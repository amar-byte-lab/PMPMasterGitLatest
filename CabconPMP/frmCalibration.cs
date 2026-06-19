using CabconPMP.datalayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static SmartCalibration.Constants.GlobalConstants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        Dictionary<string, Func<positionResponse>> procedures =
           new Dictionary<string, Func<positionResponse>>();

        private CancellationTokenSource _cts;


        FakeData fd = new FakeData();
        public frmCalibration()
        {
            InitializeComponent();
            procedures = fd.procedureNames
                .ToDictionary(
                    name => name,
                    name =>
                    {
                        MethodInfo method =
                            typeof(FakeData).GetMethod(name);

                        return new Func<positionResponse>(
                            () => (positionResponse)method.Invoke(fd, null));
                    });
        }

        private void frmCalibration_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _positionResultGrid;
            dataGridView2.DataSource = _procedureGrid;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            
            await ExecuteAllStepsAsync();
        }
        private async Task<List<ProcedureResult>> ExecuteProcedureAsync(
    KeyValuePair<string, Func<positionResponse>> procedure,
    CancellationToken token)
        {
            List<Task<ProcedureResult>> tasks = new List<Task<ProcedureResult>>();

            foreach (PortInfo port in fd.portList)
            {
                tasks.Add(Task.Run(() => 
                {
                    token.ThrowIfCancellationRequested();

                    _pauseEvent.Wait(token);

                    positionResponse result = procedure.Value();
                    UpdatePositionGrid(result);

                    return new ProcedureResult
                    {
                        Position = port.Position,
                        ProcedureName = procedure.Key,
                        Response = result.Result,
                        Status = result.Status
                    };
                }, token));
            }

            return (await Task.WhenAll(tasks)).ToList();
        }

        public async Task ExecuteAllStepsAsync()
        {
            _cts = new CancellationTokenSource();
            int slNo = 1;
            foreach (var procedure in procedures)
            {
                UpdateProcedureGrid(new invokedProcedure { SlNo = slNo++, ProcedureName = procedure.Key });
                _pauseEvent.Wait(_cts.Token);

                var results = await ExecuteProcedureAsync(procedure, _cts.Token);


                bool anyFail = results.Any(x => x.Status == "Fail");
            }
        }
        //Single Step Mode
        private int _currentProcedureIndex = 0;

        public async Task ExecuteSingleStepAsync()
        {
            if (_currentProcedureIndex >= procedures.Count)
                return;

            var procedure =
                procedures.ElementAt(_currentProcedureIndex);

            //UpdateProcedureGrid(new invokedProcedure { SlNo = slNo++, ProcedureName = procedure.Key });
            _pauseEvent.Wait(_cts.Token);

            var results =
                await ExecuteProcedureAsync(
                    procedure,
                    _cts.Token);

            _currentProcedureIndex++;
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

        private void UpdatePositionGrid(positionResponse result)
        {
            _positionResultGrid.Add(new positionResponse
            {
                Result = result.Result,
                Status = result.Status
            });

            //dataGridView1.DataSource = _positionResultGrid;
        }
        private void UpdateProcedureGrid(invokedProcedure procedure)
        {
            _procedureGrid.Add(new invokedProcedure
            {
                SlNo = procedure.SlNo,
                ProcedureName = procedure.ProcedureName
            });

            dataGridView2.DataSource = _procedureGrid;
        }
    }
}
