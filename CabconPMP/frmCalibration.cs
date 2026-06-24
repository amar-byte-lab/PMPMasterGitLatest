using ApplicationInterface;
using CabconPMP.datalayer;
using COMMONENTITY;
using SerialCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CabconPMP
{
    public partial class frmCalibration : Form
    {
        public List<KeyValuePair<int, string>> _selectedItems { get; set; }

        // now store position responses with a string payload (matches FakeData)
        private BindingList<positionResponse<string>> _positionResultGrid =
            new BindingList<positionResponse<string>>();

        // keep ManualResetEventSlim mutable (initialize once here)
        private readonly ManualResetEventSlim _pauseEvent =
            new ManualResetEventSlim(true);

        // generic-compat procedures map:
        // key: procedure name, value: Func<object input, CancellationToken, Task<object response>>
        // we use object here so we can register arbitrary typed procedures and invoke them from generic callers
        private readonly Dictionary<string, Func<object, CancellationToken, LayerInterface, CommonCommandMethods, Task<object>>> _procedures =
            new Dictionary<string, Func<object, CancellationToken, LayerInterface, CommonCommandMethods, Task<object>>>();

        // The communication stack below frmCalibration is stateful and uses shared globals.
        // Serialize meter sessions so one port cannot overwrite another port's active COM settings.
        private readonly SemaphoreSlim _meterSessionGate = new SemaphoreSlim(1, 1);

        private CancellationTokenSource _cts;

        FakeData fd = new FakeData();

        List<string> portList = new List<string>();
        List<PortInfo> ports = new List<PortInfo>();


        public frmCalibration(List<KeyValuePair<int, string>> selectedItems)
        {
            InitializeComponent();

            // Populate Procedures name in dataGridView2
            _selectedItems = selectedItems;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _selectedItems;

            // Combobox initialisation
            comboBox1.DataSource = Enum.GetValues(typeof(ExecutionMode));
            comboBox1.SelectedItem = ExecutionMode.SingleStep;
            dataGridView2.Rows[0].Selected = true;




            _cts = new CancellationTokenSource();

            BuildPortList();

            RegisterProcedures();

            DefaultPageState();
        }

        private void BuildPortList()
        {
            // Build actual port list from SerialPortSettings Default CSV (e.g. "COM5,COM4,COM3")
            try
            {
                // Get Associated PortList
                ports = new List<PortInfo>();
                portList = new LayerInterface().GetAssociatedPortList();
                for (int i = 0; i < portList.Count; i++)
                {
                    ports.Add(new PortInfo { Position = i + 1, PortName = portList[i], PCBAId = string.Empty });
                }
            }
            catch
            {
                // fallback to FakeData portList if parsing fails
            }
        }

        private void RegisterProcedures()
        {
            // Register procedure adapters here.
            // Each registration adapts a strongly-typed method to the object-based delegate used by the runtime.
            // For current FakeData methods the concrete return type is positionResponse<string>
            _procedures["READ PCBA ID"] = async (input, ct, layer, objComMethod) =>
            {
                var resp = await fd.ReadPCBAId(ct, layer, objComMethod).ConfigureAwait(false);
                return (object)resp;
            };

            _procedures["READ Meter RTC"] = async (input, ct, layer, objComMethod) =>
            {
                var resp = await fd.ReadMeterRtc(ct, layer, objComMethod).ConfigureAwait(false);
                return (object)resp;
            };

            _procedures["CALIBRATE"] = async (input, ct, layer, objComMethod) =>
            {
                var resp = await fd.Calibrate(ct, layer, objComMethod).ConfigureAwait(false);
                return (object)resp;
            };

            _procedures["Read Energy"] = async (input, ct, layer, objComMethod) =>
            {
                var resp = await fd.ReadEnergy(ct, layer, objComMethod).ConfigureAwait(false);
                return (object)resp;
            };

            _procedures["Meter Reset"] = async (input, ct, layer, objComMethod) =>
            {
                var resp = await fd.MeterReset(ct, layer, objComMethod).ConfigureAwait(false);
                return (object)resp;
            };

        }

        private void DefaultPageState()
        {
            // Set Default State of the page
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            btnPauseResume.Text = "Pause";
            btnPauseResume.Enabled = false;

            // Ensure any paused threads are released so they observe cancellation quickly
            _pauseEvent.Set();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_cts != null)
            {
                _cts.Dispose();
            }
            _cts = new CancellationTokenSource();

            // update UI immediately
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnPauseResume.Enabled = true;
            btnPauseResume.Text = "Pause";

            dataGridView1.Rows.Clear();

            // ensure not paused when starting
            _pauseEvent.Set();

            // run full execution off the UI thread so waits/pauses don't block the UI
            Task.Run(async () =>
            {
                try
                {
                    var mode = (ExecutionMode)Invoke(new Func<ExecutionMode>(() => (ExecutionMode)comboBox1.SelectedItem));

                    if (mode == ExecutionMode.AllSteps)
                    {
                        // Run all items one by one
                        foreach (var item in _selectedItems)
                        {
                            // current FakeData procedures ignore input; pass null
                            await RunStep<object, positionResponse<string>>(item, null, _cts.Token).ConfigureAwait(false);
                        }
                    }
                    else
                    {
                        if (dataGridView2.SelectedRows.Count == 0)
                        {
                            if (!IsDisposed && IsHandleCreated)
                            {
                                BeginInvoke(new Action(() =>
                                {
                                    MessageBox.Show("Please select a row.");
                                }));
                            }
                            return;
                        }

                        var selectedIndex = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                        await RunStep<object, positionResponse<string>>(_selectedItems[selectedIndex], null, _cts.Token).ConfigureAwait(false);
                    }
                }
                catch (Exception ex)
                {
                    // marshal message to UI thread safely
                    if (!IsDisposed && IsHandleCreated)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            MessageBox.Show($"Error during execution: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                    }
                }
                finally
                {
                    if (!IsDisposed && IsHandleCreated)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            btnStart.Enabled = true;
                            btnStop.Enabled = false;
                            btnPauseResume.Text = "Pause";
                            btnPauseResume.Enabled = false;
                        }));
                    }

                    // ensure paused workers are released
                    _pauseEvent.Set();
                }
            });
        }

        // Generic ProcedureResult so callers can get strongly-typed responses
        private class ProcedureResult<TResponse>
        {
            public int Position { get; set; }
            public string ProcedureName { get; set; }
            public TResponse Response { get; set; }
            public string Status { get; set; }
        }

        // Helper: asynchronous-friendly wait while paused
        private async Task WaitWhilePausedAsync(CancellationToken token)
        {
            // ManualResetEventSlim is synchronous; avoid blocking a thread pool thread.
            // Polling with a short delay gives an async non-blocking wait and still respects cancellation.
            while (!_pauseEvent.IsSet)
            {
                token.ThrowIfCancellationRequested();
                await Task.Delay(50, token).ConfigureAwait(false);
            }
        }

        // RunStep is generic over input and response types.
        // Creates a LayerInterface per-serial-port (from SerialPortSettings.Default.SerialPort CSV),
        // connects, runs the registered procedure, then disconnects.
        // Concurrency controlled with SemaphoreSlim. Respects pause/cancellation and updates UI.
        private async Task<List<ProcedureResult<TResponse>>> RunStep<TInput, TResponse>(KeyValuePair<int, string> stepName, TInput input, CancellationToken token)
        {
            var tasks = new List<Task<ProcedureResult<TResponse>>>();

            // Update procedure grid on UI without blocking main flow
            if (!IsDisposed && IsHandleCreated)
            {
                // fire-and-forget UI update (UpdateProcedureGrid handles InvokeRequired)
                BeginInvoke(new Action(async () => await UpdateProcedureGrid(new invokedProcedure { SlNo = stepName.Key, ProcedureName = stepName.Value }).ConfigureAwait(false)));
            }

            // Choose a sensible concurrency level for IO-bound meter communications.
            int maxConcurrency = Math.Min(ports.Count, Math.Max(1, Environment.ProcessorCount * 2));
            var semaphore = new SemaphoreSlim(maxConcurrency, maxConcurrency);

            foreach (PortInfo port in ports)
            {
                // Create an async task per-port that acquires the semaphore to control concurrency.
                Task<ProcedureResult<TResponse>> portTask = Task.Run(async () =>
                {
                    LayerInterface layer = null;
                    CommonCommandMethods ccm = null;
                    bool semaphoreTaken = false;
                    bool sessionTaken = false;
                    try
                    {
                        await semaphore.WaitAsync(token).ConfigureAwait(false);
                        semaphoreTaken = true;

                        await _meterSessionGate.WaitAsync(token).ConfigureAwait(false);
                        sessionTaken = true;

                        token.ThrowIfCancellationRequested();

                        // Await asynchronously while paused so we don't block thread pool threads.
                        await WaitWhilePausedAsync(token).ConfigureAwait(false);
                        token.ThrowIfCancellationRequested();

                        // Create and connect LayerInterface for this specific COM port.
                        layer = new LayerInterface();
                        ccm = new CommonCommandMethods();

                        bool connected = false;
                        try
                        {
                            // LayerInterface.ConnectToMeter(serialPortName) is synchronous.
                            // It sets SerialPortSettings.Default.SerialPort and performs physical/HDLC/association.
                            connected = layer.ConnectToMeter(port.PortName);
                        }
                        catch (Exception connEx)
                        {
                            connected = false;
                            if (!IsDisposed && IsHandleCreated)
                            {
                                BeginInvoke(new Action(() =>
                                {
                                    MessageBox.Show($"Connection error on {port.PortName}: {connEx.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }));
                            }
                        }

                        if (!connected)
                        {
                            var connectResult = new ProcedureResult<TResponse>
                            {
                                Position = port.Position,
                                ProcedureName = stepName.Value,
                                Response = default(TResponse),
                                Status = "ConnectFailed"
                            };
                            await UpdatePositionGrid(BuildGridRow(connectResult, $"Connection failed on {port.PortName}")).ConfigureAwait(false);
                            return connectResult;
                        }

                        // Resolve registered procedure adapter
                        if (!_procedures.TryGetValue(stepName.Value, out var adapter))
                        {
                            throw new InvalidOperationException($"No procedure defined for step {stepName.Value}");
                        }

                        // Call adapter (returns Task<object>) and await its completion.
                        object rawResponse = await adapter((object)input, token, layer, ccm).ConfigureAwait(false);

                        // Attempt to convert response to expected type TResponse
                        TResponse typedResponse;
                        try
                        {
                            if (rawResponse == null)
                            {
                                typedResponse = default(TResponse);
                            }
                            else if (rawResponse is TResponse tr)
                            {
                                typedResponse = tr;
                            }
                            else
                            {
                                typedResponse = (TResponse)Convert.ChangeType(rawResponse, typeof(TResponse));
                            }
                        }
                        catch (Exception castEx)
                        {
                            typedResponse = default(TResponse);
                            if (!IsDisposed && IsHandleCreated)
                            {
                                BeginInvoke(new Action(() =>
                                {
                                    MessageBox.Show($"Procedure '{stepName.Value}' returned an unexpected response type: {castEx.Message}", "Type Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }));
                            }
                        }

                        object responseObj = typedResponse;
                        var responseText = responseObj?.ToString();

                        var responseResult = new ProcedureResult<TResponse>
                        {
                            Position = port.Position,
                            ProcedureName = stepName.Value,
                            Response = typedResponse,
                            Status = ExtractStatusFromResponse(rawResponse) ?? "OK"
                        };

                        var gridRow = TryExtractPositionResponse(rawResponse);
                        if (gridRow == null)
                        {
                            gridRow = BuildGridRow(responseResult, responseText);
                        }
                        else
                        {
                            gridRow.Position = port.Position;
                            gridRow.Status = responseResult.Status;
                            if (string.IsNullOrWhiteSpace(gridRow.Payload))
                            {
                                gridRow.Payload = responseText;
                            }
                        }

                        await UpdatePositionGrid(gridRow).ConfigureAwait(false);
                        return responseResult;
                    }
                    catch (OperationCanceledException)
                    {
                        var cancelResult = new ProcedureResult<TResponse>
                        {
                            Position = port.Position,
                            ProcedureName = stepName.Value,
                            Response = default(TResponse),
                            Status = "Cancelled"
                        };
                        await UpdatePositionGrid(BuildGridRow(cancelResult, "Cancelled")).ConfigureAwait(false);
                        return cancelResult;
                    }
                    catch (Exception ex)
                    {
                        if (!IsDisposed && IsHandleCreated)
                        {
                            BeginInvoke(new Action(() =>
                            {
                                MessageBox.Show($"Error in procedure '{stepName.Value}' for port {port.PortName}: {ex.Message}", "Procedure Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                        }

                        var errorResult = new ProcedureResult<TResponse>
                        {
                            Position = port.Position,
                            ProcedureName = stepName.Value,
                            Response = default(TResponse),
                            Status = "Error"
                        };

                        await UpdatePositionGrid(BuildGridRow(errorResult, ex.Message)).ConfigureAwait(false);
                        return errorResult;
                    }
                    finally
                    {
                        // Always try to disconnect this port's LayerInterface instance
                        try
                        {
                            if (layer != null)
                            {
                                // AssociationDisconnect will call PhysicalLayerDisconnect in finally
                                layer.AssociationDisconnect();
                            }
                        }
                        catch
                        {
                            // ignore disconnect errors
                        }

                        if (semaphoreTaken)
                        {
                            semaphore.Release();
                        }

                        if (sessionTaken)
                        {
                            _meterSessionGate.Release();
                        }
                    }
                });

                tasks.Add(portTask);
            }

            try
            {
                var completed = await Task.WhenAll(tasks).ConfigureAwait(false);
                return completed.ToList();
            }
            finally
            {
                // Clean up semaphore
                semaphore.Dispose();
            }
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if (IsDisposed) return;

            if (btnPauseResume.Text == "Pause")
            {
                _pauseEvent.Reset();
                btnPauseResume.Text = "Resume";
            }
            else
            {
                _pauseEvent.Set();
                btnPauseResume.Text = "Pause";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts.Cancel();
            }
            DefaultPageState();
            _pauseEvent.Set();
        }

        private Task UpdatePositionGrid(positionResponse<string> result)
        {
            // If control/form is closing or not created, drop update
            if (IsDisposed || !IsHandleCreated)
                return Task.CompletedTask;

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdatePositionGrid(result)));
                return Task.CompletedTask;
            }

            _positionResultGrid.Add(result);

            dataGridView1.DataSource = _positionResultGrid;
            return Task.CompletedTask;
        }

        private positionResponse<string> BuildGridRow<TResponse>(ProcedureResult<TResponse> result, string payload)
        {
            return new positionResponse<string>
            {
                Position = result.Position,
                Status = result.Status,
                Payload = payload ?? string.Empty
            };
        }
        private Task UpdateProcedureGrid(invokedProcedure procedure)
        {
            if (IsDisposed || !IsHandleCreated)
                return Task.CompletedTask;

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateProcedureGrid(procedure)));
                return Task.CompletedTask;
            }

            int lastRowIndex = dataGridView2.Rows.Count - 1;
            if (lastRowIndex >= 0)
            {
                if (lastRowIndex - 1 >= 0)
                    dataGridView2.CurrentCell = dataGridView2.Rows[procedure.SlNo].Cells[0];

                dataGridView2.Rows[procedure.SlNo].Selected = true;
            }

            return Task.CompletedTask;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mode = (ExecutionMode)comboBox1.SelectedItem;

            if (mode == ExecutionMode.AllSteps)
            {
                dataGridView2.ClearSelection();
                dataGridView2.Enabled = false;
            }
            else
            {
                dataGridView2.Rows[0].Selected = true;
                dataGridView2.Enabled = true;
            }
        }

        #region Helpers to extract UI fields from arbitrary response objects

        // Tries to build a positionResponse<string> from an arbitrary response object by:
        // 1) direct cast to positionResponse<string>
        // 2) if type is positionResponse<T>, extract Payload and Status and convert payload to string
        // 3) reflection: reading "Result" and "Status" properties (legacy)
        private positionResponse<string> TryExtractPositionResponse(object resp)
        {
            if (resp == null) return null;

            // direct strong-typed
            if (resp is positionResponse<string> direct)
            {
                return direct;
            }

            var type = resp.GetType();

            // if it's a positionResponse<T>, get Payload and Status by reflection
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(positionResponse<>))
            {
                var payloadProp = type.GetProperty("Payload", BindingFlags.Public | BindingFlags.Instance);
                var statusProp = type.GetProperty("Status", BindingFlags.Public | BindingFlags.Instance);
                var positionProp = type.GetProperty("Position", BindingFlags.Public | BindingFlags.Instance);

                var payloadVal = payloadProp?.GetValue(resp);
                var statusVal = statusProp?.GetValue(resp);
                var posVal = positionProp?.GetValue(resp);

                return new positionResponse<string>
                {
                    Position = posVal is int p ? p : 0,
                    Payload = payloadVal?.ToString(),
                    Status = statusVal?.ToString()
                };
            }

            // legacy shape support: look for Result + Status properties
            var resultProp = type.GetProperty("Result", BindingFlags.Public | BindingFlags.Instance);
            var statusPropLegacy = type.GetProperty("Status", BindingFlags.Public | BindingFlags.Instance);
            var positionPropLegacy = type.GetProperty("Position", BindingFlags.Public | BindingFlags.Instance);

            if (resultProp != null && statusPropLegacy != null)
            {
                var resultVal = resultProp.GetValue(resp);
                var statusVal = statusPropLegacy.GetValue(resp);
                var posVal = positionPropLegacy?.GetValue(resp);

                return new positionResponse<string>
                {
                    Position = posVal is int p ? p : 0,
                    Payload = resultVal?.ToString(),
                    Status = statusVal?.ToString()
                };
            }

            return null;
        }

        // Attempts to extract a status string from a response object
        private string ExtractStatusFromResponse(object resp)
        {
            if (resp == null) return null;

            var type = resp.GetType();

            var statusProp = type.GetProperty("Status", BindingFlags.Public | BindingFlags.Instance);
            if (statusProp != null)
            {
                var statusVal = statusProp.GetValue(resp);
                return statusVal?.ToString();
            }

            // if payload-based positionResponse
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(positionResponse<>))
            {
                var statusProp2 = type.GetProperty("Status", BindingFlags.Public | BindingFlags.Instance);
                if (statusProp2 != null)
                {
                    var statusVal2 = statusProp2.GetValue(resp);
                    return statusVal2?.ToString();
                }
            }

            return null;
        }

        #endregion
    }
}
