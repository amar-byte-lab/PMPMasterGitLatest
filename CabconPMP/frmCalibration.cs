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

        private BindingList<invokedProcedure> _procedureGrid =
new BindingList<invokedProcedure>();

        private readonly ManualResetEventSlim _pauseEvent =
    new ManualResetEventSlim(true);

        Dictionary<ProcedureInfo, Func<Task<positionResponse>>> procedures =
           new Dictionary<ProcedureInfo, Func<Task<positionResponse>>>();

        private CancellationTokenSource _cts;


        FakeData fd = new FakeData();
        public frmCalibration()
        {
            InitializeComponent();
            _pauseEvent = new ManualResetEventSlim(true);
            procedures = fd.procedureNames
                .ToDictionary(
                    name => new ProcedureInfo
                    {
                        Index = name.Index,
                        Name = name.Name
                    },
                    name =>
                    {
                        MethodInfo method =
                            typeof(FakeData).GetMethod(name.Name);

                        return new Func<Task<positionResponse>>(async () =>
                        {
                            return await (Task<positionResponse>)method.Invoke(fd, null);
                        });
                    });
        }

        private void frmCalibration_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _positionResultGrid;
            dataGridView2.DataSource = _procedureGrid;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {

            await ExecuteAllStepsAsync(procedures);
            //await ExecuteSingleStepAsync(procedures.ElementAt(0));
        }
        private async Task<List<ProcedureResult>> ExecuteProcedureAsync(
    KeyValuePair<ProcedureInfo, Func<Task<positionResponse>>> procedure,
    CancellationToken token)
        {
            List<Task<ProcedureResult>> tasks = new List<Task<ProcedureResult>>();

            foreach (PortInfo port in fd.portList)
            {
                tasks.Add(Task.Run(async () =>
                {
                    token.ThrowIfCancellationRequested();

                    _pauseEvent.Wait(token);

                    positionResponse result = await procedure.Value();

                    await UpdatePositionGrid(new positionResponse { Position = port.Position, Result = result.Result, Status = result.Status });

                    return new ProcedureResult
                    {
                        Position = port.Position,
                        ProcedureName = procedure.Key.Name,
                        Response = result.Result,
                        Status = result.Status
                    };
                }, token));
            }

            return (await Task.WhenAll(tasks)).ToList();
        }

        public async Task ExecuteAllStepsAsync(Dictionary<ProcedureInfo, Func<Task<positionResponse>>> procedures)
        {
            _cts = new CancellationTokenSource();

            foreach (var procedure in procedures)
            {
                await Task.Run(async () => await UpdateProcedureGrid(new invokedProcedure { SlNo = procedure.Key.Index, ProcedureName = procedure.Key.Name }));

                _pauseEvent.Wait(_cts.Token);

                var results = await ExecuteProcedureAsync(procedure, _cts.Token);
            }
        }

        public async Task ExecuteSingleStepAsync(KeyValuePair<ProcedureInfo, Func<Task<positionResponse>>> procedure)
        {
            _cts = new CancellationTokenSource();

            await Task.Run(async () => await UpdateProcedureGrid(new invokedProcedure { SlNo = procedure.Key.Index, ProcedureName = procedure.Key.Name }));
            _pauseEvent.Wait(_cts.Token);

            var results =
                await ExecuteProcedureAsync(
                    procedure,
                    _cts.Token);

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _pauseEvent.Reset(); //Pause
            _pauseEvent.Set(); //Resume
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }

        private Task UpdatePositionGrid(positionResponse result)
        {
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
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateProcedureGrid(procedure)));
                return Task.CompletedTask;
            }

            _procedureGrid.Add(procedure);

            dataGridView2.DataSource = _procedureGrid;

            int lastRowIndex = dataGridView2.Rows.Count - 1;

            if (lastRowIndex >= 0)
            {
                dataGridView2.CurrentCell =
                    dataGridView2.Rows[lastRowIndex -1].Cells[0];

                dataGridView2.Rows[lastRowIndex].Selected = true;
            }

            return Task.CompletedTask;
        }
    }
}
