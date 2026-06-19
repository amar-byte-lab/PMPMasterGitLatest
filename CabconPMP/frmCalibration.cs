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

        private BindingList<positionResponse> _positionResultGrid =
    new BindingList<positionResponse>();

        private BindingList<ProcedureInfo> _procedureGrid =
new BindingList<ProcedureInfo>();

        // keep ManualResetEventSlim mutable (initialize once here)
        private readonly ManualResetEventSlim _pauseEvent =
    new ManualResetEventSlim(true);

        // now procedures accept a CancellationToken so we can propagate cancellation
        Dictionary<ProcedureInfo, Func<CancellationToken, Task<positionResponse>>> procedures =
           new Dictionary<ProcedureInfo, Func<CancellationToken, Task<positionResponse>>>();

        private CancellationTokenSource _cts;


        FakeData fd = new FakeData();
        public frmCalibration()
        {
            InitializeComponent();
            procedures = fd.procedureNames
    .ToDictionary(
        name => new ProcedureInfo
        {
            Index = name.Index,
            Name = name.Name
        },
        name =>
        {
            // locate method taking a CancellationToken
            MethodInfo method =
                typeof(FakeData).GetMethod(name.Name, new[] { typeof(CancellationToken) });

            if (method == null)
            {
                throw new InvalidOperationException($"Method '{name.Name}(CancellationToken)' not found on FakeData.");
            }

            // return a function that invokes the method and returns Task<positionResponse>
            return new Func<CancellationToken, Task<positionResponse>>(token =>
            {
                return (Task<positionResponse>)method.Invoke(fd, new object[] { token });
            });
        });
            Reset();
        }

        private void Reset()
        {
            // Default state: only Start enabled
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            btnPauseResume.Text = "Pause";
            btnPauseResume.Enabled = false;

            //dataGridView1.DataSource = _positionResultGrid;

            _procedureGrid = new BindingList<ProcedureInfo>(procedures.Keys.OrderBy(p => p.Index).ToList());

            dataGridView2.DataSource = _procedureGrid;


            comboBox1.DataSource = Enum.GetValues(typeof(ExecutionMode));
            comboBox1.SelectedItem = ExecutionMode.AllSteps;



            // Ensure any paused threads are released so they observe cancellation quickly
            _pauseEvent.Set();
        }

        private void frmCalibration_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // update UI immediately
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnPauseResume.Enabled = true;
            btnPauseResume.Text = "Pause";

            // ensure not paused when starting
            _pauseEvent.Set();

            // run full execution off the UI thread so waits/pauses don't block the UI
            Task.Run(async () =>
            {
                try
                {

                    var mode = (ExecutionMode)comboBox1.SelectedItem;

                    if (mode == ExecutionMode.AllSteps)
                    {
                        // Execute all procedures
                        await ExecuteAllStepsAsync(procedures);
                    }
                    else
                    {
                        if (_selectedProcedure == null)
                        {
                            MessageBox.Show("Please select a row.");
                            return;
                        }

                        var selectedProcedure = procedures.FirstOrDefault(p => p.Key.Name == _selectedProcedure.Name);

                        // Execute only selected procedure
                        await ExecuteSingleStepAsync(selectedProcedure);
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
        private async Task<List<ProcedureResult>> ExecuteProcedureAsync(
    KeyValuePair<ProcedureInfo, Func<CancellationToken, Task<positionResponse>>> procedure,
    CancellationToken token)
        {
            List<Task<ProcedureResult>> tasks = new List<Task<ProcedureResult>>();

            foreach (PortInfo port in fd.portList)
            {
                tasks.Add(Task.Run(async () =>
                {
                    token.ThrowIfCancellationRequested();

                    // Wait here if paused, but still observe cancellation
                    _pauseEvent.Wait(token);

                    // Start the procedure, passing the cancellation token to the real method
                    Task<positionResponse> operationTask = null;
                    try
                    {
                        operationTask = procedure.Value(token);

                        // Await the operation (it will observe the token and throw if cancelled)
                        positionResponse result = await operationTask.ConfigureAwait(false);

                        // update UI asynchronously (do not block worker)
                        if (!IsDisposed && IsHandleCreated)
                        {
                            _ = Task.Run(async () =>
                            {
                                await UpdatePositionGrid(new positionResponse
                                {
                                    Position = port.Position,
                                    Result = result.Result,
                                    Status = result.Status
                                });
                            });
                        }

                        return new ProcedureResult
                        {
                            Position = port.Position,
                            ProcedureName = procedure.Key.Name,
                            Response = result.Result,
                            Status = result.Status
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
                            if (operationTask != null && operationTask.IsCompleted)
                            {
                                resp = operationTask.Result?.Result;
                            }
                        }
                        catch { /* ignore */ }

                        return new ProcedureResult
                        {
                            Position = port.Position,
                            ProcedureName = procedure.Key.Name,
                            Response = resp,
                            Status = "Error"
                        };
                    }
                }, token));
            }

            return (await Task.WhenAll(tasks)).ToList();
        }

        public async Task ExecuteAllStepsAsync(Dictionary<ProcedureInfo, Func<CancellationToken, Task<positionResponse>>> procedures)
        {
            _cts = new CancellationTokenSource();

            try
            {
                foreach (var procedure in procedures)
                {
                    // honor pause / cancellation before starting procedure
                    _pauseEvent.Wait(_cts.Token);

                    // Update procedure grid on UI without blocking main flow
                    if (!IsDisposed && IsHandleCreated)
                    {
                        BeginInvoke(new Action(async () => await UpdateProcedureGrid(new invokedProcedure { SlNo = procedure.Key.Index, ProcedureName = procedure.Key.Name })));
                    }

                    var results = await ExecuteProcedureAsync(procedure, _cts.Token);
                }
            }
            finally
            {
                // nothing to dispose here; final cleanup in caller
            }
        }

        public async Task ExecuteSingleStepAsync(KeyValuePair<ProcedureInfo, Func<CancellationToken, Task<positionResponse>>> procedure)
        {
            _cts = new CancellationTokenSource();

            if (!IsDisposed && IsHandleCreated)
            {
                BeginInvoke(new Action(async () => await UpdateProcedureGrid(new invokedProcedure { SlNo = procedure.Key.Index, ProcedureName = procedure.Key.Name })));
            }

            _pauseEvent.Wait(_cts.Token);

            var results =
                await ExecuteProcedureAsync(
                    procedure,
                    _cts.Token);

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

            Reset();
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
                    dataGridView2.CurrentCell = dataGridView2.Rows[procedure.SlNo - 1].Cells[0];

                dataGridView2.Rows[procedure.SlNo - 1].Selected = true;
                dataGridView2.Enabled = false;
            }

            return Task.CompletedTask;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mode = (ExecutionMode)comboBox1.SelectedItem;

            if (mode == ExecutionMode.AllSteps)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Enabled = false;
            }
            else
            {
                dataGridView1.Enabled = true;
            }
        }

        private ProcedureInfo _selectedProcedure;

        private void dataGridView2_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if ((ExecutionMode)comboBox1.SelectedItem
                != ExecutionMode.SingleStep)
                return;

            _selectedProcedure =
                (ProcedureInfo)dataGridView1.Rows[e.RowIndex].DataBoundItem;
        }
    }
}
