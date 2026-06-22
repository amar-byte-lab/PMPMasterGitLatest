using CabconPMP.datalayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CabconPMP
{
    public partial class frmCalibration : Form
    {
        public List<KeyValuePair<int, string>> _selectedItems { get; set; }

        private BindingList<positionResponse> _positionResultGrid =
    new BindingList<positionResponse>();

        // keep ManualResetEventSlim mutable (initialize once here)
        private readonly ManualResetEventSlim _pauseEvent =
    new ManualResetEventSlim(true);

        // now procedures accept a CancellationToken so we can propagate cancellation
        Dictionary<KeyValuePair<int, string>, Func<CancellationToken, Task<positionResponse>>> procedures =
           new Dictionary<KeyValuePair<int, string>, Func<CancellationToken, Task<positionResponse>>>();

        private CancellationTokenSource _cts;


        FakeData fd = new FakeData();
        public frmCalibration(List<KeyValuePair<int, string>> selectedItems)
        {
            InitializeComponent();

            //Populate Procedures name in dataGridView2
            _selectedItems = selectedItems;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _selectedItems;

            //Combobox initialisation
            comboBox1.DataSource = Enum.GetValues(typeof(ExecutionMode));
            comboBox1.SelectedItem = ExecutionMode.SingleStep;
            dataGridView2.Rows[0].Selected = true;

            _cts = new CancellationTokenSource();

            DefaultPageState();
        }

        private void DefaultPageState()
        {
            //Set Default State of the page
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            btnPauseResume.Text = "Pause";
            btnPauseResume.Enabled = false;

            //Ensure any paused threads are released so they observe cancellation quickly
            _pauseEvent.Set();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
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

                   // ExecuteProcedureAsync(
                        //procedures.First(), CancellationToken.None).Wait();

                    if (mode == ExecutionMode.AllSteps)
                    {
                        // Run all items one by one
                        foreach (var item in _selectedItems)
                        {
                            await RunStep(item, _cts.Token);
                        }
                    }
                    else
                    {
                        if (dataGridView2.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Please select a row.");
                            return;
                        }

                        // Run only one selected item
                        await RunStep(_selectedItems[Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value)], _cts.Token);
                    }

                    
                }
                catch (OperationCanceledException)
                {
                    // expected when user clicks Stop
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

        private async Task<List<ProcedureResult>> RunStep(KeyValuePair<int, string> stepName, CancellationToken token)
        {
            // Find the corresponding procedure for the selected step
            List<Task<ProcedureResult>> tasks = new List<Task<ProcedureResult>>();

            // Update procedure grid on UI without blocking main flow
            if (!IsDisposed && IsHandleCreated)
            {
                BeginInvoke(new Action(async () => await UpdateProcedureGrid(new invokedProcedure { SlNo = stepName.Key, ProcedureName = stepName.Value })));
            }

            dataGridView1.Rows.Clear();

            foreach (PortInfo port in fd.portList)
            {
                tasks.Add(Task.Run(async () =>
                {
                    token.ThrowIfCancellationRequested();

                    // Wait here if paused, but still observe cancellation
                    _pauseEvent.Wait(token);

                    // Start the procedure, passing the cancellation token to the real method
                    try
                    {
                        switch (stepName.Value)
                        {
                            case "READ PCBA ID":
                                procedures[stepName] = async (ct) => await fd.Procedure1(ct);
                                break;
                            case "CALIBRATE":
                                procedures[stepName] = async (ct) => await fd.Procedure2(ct);
                                break;
                            default:
                                throw new InvalidOperationException($"No procedure defined for step {stepName.Value}");
                        }

                        var response = await procedures[stepName](token);

                        // update UI asynchronously (do not block worker)
                        if (!IsDisposed && IsHandleCreated)
                        {
                            _ = Task.Run(async () =>
                            {
                                await UpdatePositionGrid(new positionResponse
                                {
                                    Position = port.Position,
                                    Result = response.Result,
                                    Status = response.Status
                                });
                            });
                        }

                        return new ProcedureResult
                        {
                            Position = port.Position,
                            ProcedureName = stepName.Value,
                            Response = response.Result,
                            Status = response.Status
                        };
                    }
                    catch (OperationCanceledException)
                    {
                        // propagate cancellation to caller
                        throw;
                    }
                    catch (Exception)
                    {
                        // If underlying operation fails, return a failed ProcedureResult
                        string resp = null;
                        try
                        {
                            //if (operationTask != null && operationTask.IsCompleted)
                            //{
                            //    resp = operationTask.Result?.Result;
                            //}
                        }
                        catch { /* ignore */ }

                        return new ProcedureResult
                        {
                            Position = port.Position,
                            ProcedureName = stepName.Value,
                            Response = resp,
                            Status = "Error"
                        };
                    }
                }, token));
            }
            return (await Task.WhenAll(tasks)).ToList();
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
        }

        private Task UpdatePositionGrid(positionResponse result)
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
                dataGridView2.Enabled = false;
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
    }
}
