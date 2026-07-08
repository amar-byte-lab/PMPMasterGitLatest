using CabconPMP.Data;
//using CabconPMP.Hardware;
using CabconPMP.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

//using CabconPMP.Sequencer;
using static CabconPMP.Data.MeterTypeRepository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CabconPMP.UI
{
    public partial class frmTestRun : Form
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        private readonly RunRepository _runRepository;
        private readonly ProcedureRepository _procedureRepository;
        private readonly MeterTypeRepository _meterTypeRepository;
        private readonly BenchRepository _benchRepository;
        private readonly Person _currentUser;
        private readonly Run _initialSelectedRun;

        private Bench _bench;
        private List<MeterType> _meterTypes = new List<MeterType>();

        private BindingList<TestProcedure> _availableProcedures;
        private BindingList<TestProcedure> _selectedProcedures;
        private List<TestProcedure> _originalProcedures;

        private BindingList<MeterAllocationRow> _metersList = new BindingList<MeterAllocationRow>();
        private BindingList<RStepRow> _sequenceList = new BindingList<RStepRow>();

        // Sequencer variables
        private CancellationTokenSource _cts;
        private ManualResetEventSlim _pauseEvent = new ManualResetEventSlim(true);
        private bool _isRunning = false;
        private bool _isPaused = false;

        public frmTestRun(
            IDbConnectionFactory dbConnectionFactory,
            RunRepository runRepository,
            ProcedureRepository procedureRepository,
            MeterTypeRepository meterTypeRepository,
            BenchRepository benchRepository,
            Person currentUser,
            Run selectedRun = null)
        {
            InitializeComponent();
            _dbConnectionFactory = dbConnectionFactory;
            _runRepository = runRepository;
            _procedureRepository = procedureRepository;
            _meterTypeRepository = meterTypeRepository;
            _benchRepository = benchRepository;
            _currentUser = currentUser;
            _initialSelectedRun = selectedRun;
        }

        private async void frmTestRun_Load(object sender, EventArgs e)
        {
            _bench = await _benchRepository.GetBenchAsync();
            lblBenchName.Text = _bench?.BenchName ?? "Default Bench";

            dgvMeters.AutoGenerateColumns = false;
            SetupMetersGridColumns();

            dgvExecuteSteps.AutoGenerateColumns = false;
            SetupExecuteStepsGridColumns();

            InitializeOverviewList();

            // Subscribe to tab change so selected procedures are loaded only when Execute tab is shown.
            tabControl1.SelectedIndexChanged -= TabControl1_SelectedIndexChanged;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            if (_initialSelectedRun != null)
            {
                // Display completed run mode
                txtSupervisor.Text = _initialSelectedRun.SupervisorID?.ToString() ?? "Admin";
                txtOperator.Text = _initialSelectedRun.OperatorID?.ToString() ?? "Operator";
                txtDateRun.Text = _initialSelectedRun.TimeRun.ToString("yyyy-MM-dd HH:mm");
                txtMinTemp.Text = _initialSelectedRun.MinTemp?.ToString("F1") ?? "23.0";
                txtMaxTemp.Text = _initialSelectedRun.MaxTemp?.ToString("F1") ?? "25.0";
                txtMinRH.Text = _initialSelectedRun.MinRH?.ToString("F1") ?? "45.0";
                txtMaxRH.Text = _initialSelectedRun.MaxRH?.ToString("F1") ?? "55.0";
                txtComment.Text = _initialSelectedRun.Comment;

                // Make UI read-only
                txtMinTemp.ReadOnly = true;
                txtMaxTemp.ReadOnly = true;
                txtMinRH.ReadOnly = true;
                txtMaxRH.ReadOnly = true;
                txtComment.ReadOnly = true;

                btnStart.Enabled = false;
                btnPause.Enabled = false;
                btnStop.Enabled = false;
                grpDeviceInputs.Enabled = false;
                //btnSeqAdd.Enabled = false;
                //btnSeqDel.Enabled = false;

                // Load allocated meters
                var runMeters = await _runRepository.GetMetersForRunAsync(_initialSelectedRun.RunID);
                _metersList.Clear();
                foreach (var m in runMeters)
                {
                    _metersList.Add(new MeterAllocationRow
                    {
                        PositionNo = m.PositionNo,
                        Status = m.Status == 1,
                        MSN = m.MSN,
                        MeterType = m.MeterName ?? "",
                        OwnerNo = m.OwnerNo ?? "",
                        YearOfManufacture = m.YearOfManufacture?.ToString() ?? "",
                        LastApproval = m.LastApproval ?? "",
                        ContractNo = m.ContractNo ?? "",
                        ClientName = m.ClientName ?? "",
                        ClientNo = m.ClientNo ?? ""
                    });
                }
                dgvMeters.DataSource = _metersList;
                dgvMeters.ReadOnly = true;

                // Load steps
                var runSteps = await _runRepository.GetStepsForRunAsync(_initialSelectedRun.RunID);
                _sequenceList.Clear();
                foreach (var s in runSteps)
                {
                    _sequenceList.Add(new RStepRow
                    {
                        Select = true,
                        StepNo = s.StepNo,
                        Name = s.Name,
                        UA = s.UA.ToString("F1"),
                        IA = s.IA.ToString("F2"),
                        PHI = s.PHI.ToString("F1"),
                        FREQ = s.FREQ.ToString("F2"),
                        Timeout = s.Timeout.ToString(),
                        ACMDS = s.ACMDS,
                        BCMDS = s.BCMDS,
                        CCMDS = s.CCMDS
                    });
                }
                dgvExecuteSteps.DataSource = _sequenceList;

                // Load results
                var runResults = await _runRepository.GetResultsForRunAsync(_initialSelectedRun.RunID);

                // Initialize results columns
                dgvResults.Columns.Clear();
                dgvResults.Columns.Add("colPos", "Pos");
                dgvResults.Columns.Add("colMSN", "Meter MSN");
                foreach (var step in runSteps)
                {
                    string colName = $"colStep_{step.StepNo}";
                    dgvResults.Columns.Add(colName, step.Name);
                }

                // Load results rows
                foreach (var mtr in runMeters)
                {
                    int rowIndex = dgvResults.Rows.Add();
                    var row = dgvResults.Rows[rowIndex];
                    row.Cells[0].Value = mtr.PositionNo;
                    row.Cells[1].Value = mtr.MSN;

                    for (int col = 2; col < dgvResults.Columns.Count; col++)
                    {
                        short stepNo = short.Parse(dgvResults.Columns[col].Name.Split('_')[1]);
                        var resVal = runResults.FirstOrDefault(r => r.PositionNo == mtr.PositionNo && r.StepNo == stepNo)?.RValue ?? "-";
                        row.Cells[col].Value = resVal;
                    }
                }
                dgvResults.ReadOnly = true;

                // Select results tab
                tabControl1.SelectedIndex = 4;
            }
            else
            {
                // Setup for fresh Run
                txtSupervisor.Text = _currentUser?.Name ?? "Admin";
                txtOperator.Text = _currentUser?.Name ?? "Operator";
                txtDateRun.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                LoadMetadata();
                InitializeMetersGrid();
            }
        }

        private void SetupMetersGridColumns()
        {
            //dgvMeters.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Enabled", HeaderText = "Active", Width = 50 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PositionNo", HeaderText = "Pos", ReadOnly = true, Width = 40 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status", ReadOnly = true, Width = 40 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MeterType", HeaderText = "Meter Type", Width = 100 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MSN", HeaderText = "MSN", Width = 90 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OwnerNo", HeaderText = "Owner No", Width = 90 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "YearOfManufacture", HeaderText = "Year", Width = 60 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastApproval", HeaderText = "Last Approval", Width = 90 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ContractNo", HeaderText = "Contract No", Width = 90 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClientName", HeaderText = "Client Name", Width = 110 });
            dgvMeters.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ClientNo", HeaderText = "Client No", Width = 90 });
        }

        private void SetupExecuteStepsGridColumns()
        {
            dgvExecuteSteps.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StepNo", HeaderText = "Step No.", ReadOnly = true, Width = 45 });
            dgvExecuteSteps.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Step Name", ReadOnly = true, Width = 180 });
            dgvExecuteSteps.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Timeout", HeaderText = "Time Limit", ReadOnly = true, Width = 80 });
        }

        private void InitializeOverviewList()
        {
            lstOverview.Items.Clear();
            int positions = _bench?.NumPosition ?? 48;
            for (int i = 1; i <= positions; i++)
            {
                lstOverview.Items.Add($"{i:D2}:  -");
            }
        }

        private async void LoadMetadata()
        {
            try
            {
                var mt = await _meterTypeRepository.GetAllAsync();
                _meterTypes = mt.ToList();
                cmbMeterType.DataSource = _meterTypes;
                cmbMeterType.DisplayMember = "Name";
                cmbMeterType.ValueMember = "MeterTypeID";

                var pr = await _procedureRepository.GetAllAsync();

                _originalProcedures = pr.ToList();

                _availableProcedures = new BindingList<TestProcedure>(pr.ToList());
                _selectedProcedures = new BindingList<TestProcedure>();

                lstAvailableProcedures.DataSource = _availableProcedures;
                lstAvailableProcedures.DisplayMember = "Name";
                lstAvailableProcedures.ValueMember = "ProcedureID";

                lstDisplatAutoSelected.DataSource = _selectedProcedures;
                lstDisplatAutoSelected.DisplayMember = "Name";
                lstDisplatAutoSelected.ValueMember = "ProcedureID";



                // Setup combo options for devices
                cmbContractNo.Items.AddRange(new object[] { "CON-2026-01", "CON-2026-02", "CON-EX-09" });
                cmbClient.Items.AddRange(new object[] { "State Grid Corp", "North Utilities", "Cabcon Industrial" });
                cmbClientNo.Items.AddRange(new object[] { "CLI-901", "CLI-902", "CLI-788" });
                cmbContractNo.SelectedIndex = 0;
                cmbClient.SelectedIndex = 0;
                cmbClientNo.SelectedIndex = 0;

                // Combobox Stepl initialisation
                cmbStep.DataSource = Enum.GetValues(typeof(ExecutionMode));
                cmbStep.SelectedItem = ExecutionMode.SingleStep;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading metadata: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeMetersGrid()
        {
            int positions = _bench?.NumPosition ?? 48;
            _metersList.Clear();
            // do not pre-populate; rows will be added when user clicks Add
            dgvMeters.DataSource = _metersList;
        }

        // MSN & Owner Auto-Generation methods matching C++ Numberise
        private bool Numberise(string text, out string prefix, out ulong suffixVal)
        {
            prefix = text;
            suffixVal = 0;
            if (string.IsNullOrEmpty(text)) return false;

            var match = Regex.Match(text, @"\d+$");
            if (match.Success)
            {
                string suffixStr = match.Value;
                prefix = text.Substring(0, text.Length - suffixStr.Length);
                ulong.TryParse(suffixStr, out suffixVal);
                return true;
            }
            return false;
        }

        private string FormatIncremented(string prefix, ulong val, int totalLength)
        {
            string numStr = val.ToString();
            int padLen = totalLength - prefix.Length;
            if (padLen > numStr.Length)
            {
                numStr = numStr.PadLeft(padLen, '0');
            }
            return prefix + numStr;
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            int maxPositions = _bench?.NumPosition ?? 48;
            int from = 1, to = 1;

            string posStr = txtPositions.Text.Trim();
            if (posStr.Contains(".."))
            {
                var parts = posStr.Split(new[] { ".." }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2 && int.TryParse(parts[0], out var f) && int.TryParse(parts[1], out var t))
                {
                    from = Math.Max(f, 1);
                    from = Math.Min(from, maxPositions);
                    to = Math.Max(t, 1);
                    to = Math.Min(to, maxPositions);
                }
            }
            else if (int.TryParse(posStr, out var p))
            {
                from = Math.Max(p, 1);
                from = Math.Min(p, maxPositions);
                to = from;
            }
            else
            {
                MessageBox.Show("Please enter positions range (e.g. '1..48' or '12').", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (from > to)
            {
                int tmp = from;
                from = to;
                to = tmp;
            }

            // MSN setup
            string rawMsn = txtMSN.Text.Trim();
            bool hasMsn = Numberise(rawMsn, out string msnPrefix, out ulong msnVal);
            int.TryParse(txtStepMSN.Text, out var stepMsn);
            if (stepMsn <= 0) stepMsn = 1;

            // Owner Setup
            string rawOwner = txtOwnerNo.Text.Trim();
            bool hasOwner = Numberise(rawOwner, out string ownerPrefix, out ulong ownerVal);
            int.TryParse(txtStepOwnerNo.Text, out var stepOwner);
            if (stepOwner <= 0) stepOwner = 1;

            string mtrType = cmbMeterType.Text;
            string year = txtYearOfManufacture.Text.Trim();
            string approval = txtLastApproval.Text.Trim();
            string contract = cmbContractNo.Text;
            string client = cmbClient.Text;
            string clientNo = cmbClientNo.Text;

            var duplicatePositions = new List<int>();

            for (int k = from; k <= to; k++)
            {
                var existing = _metersList.FirstOrDefault(r => r.PositionNo == k);
                bool isOccupied = false;

                if (existing != null)
                {
                    // Consider a row occupied if it already has identifying data
                    if (!string.IsNullOrWhiteSpace(existing.MSN) ||
                        !string.IsNullOrWhiteSpace(existing.MeterType) ||
                        !string.IsNullOrWhiteSpace(existing.OwnerNo) ||
                        !string.IsNullOrWhiteSpace(existing.ContractNo) ||
                        !string.IsNullOrWhiteSpace(existing.ClientName) ||
                        !string.IsNullOrWhiteSpace(existing.ClientNo))
                    {
                        isOccupied = true;
                    }
                }

                if (isOccupied)
                {
                    duplicatePositions.Add(k);
                    continue;
                }

                MeterAllocationRow row;
                if (existing != null)
                {
                    // reuse and populate existing (it was empty)
                    row = existing;
                }
                else
                {
                    row = new MeterAllocationRow
                    {
                        PositionNo = (short)k,
                        Status = true
                    };
                    _metersList.Add(row);
                }

                row.MeterType = mtrType;
                row.YearOfManufacture = year;
                row.LastApproval = approval;
                row.ContractNo = contract;
                row.ClientName = client;
                row.ClientNo = clientNo;

                if (hasMsn)
                {
                    row.MSN = FormatIncremented(msnPrefix, msnVal, rawMsn.Length);
                    msnVal += (ulong)stepMsn;
                }
                else
                {
                    row.MSN = rawMsn;
                }

                if (hasOwner)
                {
                    row.OwnerNo = FormatIncremented(ownerPrefix, ownerVal, rawOwner.Length);
                    ownerVal += (ulong)stepOwner;
                }
                else
                {
                    row.OwnerNo = rawOwner;
                }
            }

            if (duplicatePositions.Any())
            {
                MessageBox.Show($"The following positions are already occupied and were skipped: {string.Join(", ", duplicatePositions)}", "Duplicate Positions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // ensure UI updates
            dgvMeters.Refresh();
            dgvMeters.DataSource = null;
            dgvMeters.DataSource = _metersList;
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            if (dgvMeters.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var toRemove = new List<MeterAllocationRow>();

            foreach (DataGridViewRow row in dgvMeters.SelectedRows)
            {
                if (row.DataBoundItem is MeterAllocationRow mtr)
                {
                    toRemove.Add(mtr);
                }
            }

            if (toRemove.Count == 0)
            {
                MessageBox.Show("No removable rows selected.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var item in toRemove)
            {
                _metersList.Remove(item);
            }

            // refresh grid
            dgvMeters.Refresh();
            dgvMeters.DataSource = null;
            dgvMeters.DataSource = _metersList;
        }

        //--------------------

        // '>' : Move selected items from All -> Selected (transfer)
        private void btnDispAutoMove_Click(object sender, EventArgs e)
        {
            MoveItem();
        }

        // '>>' : Move all items from All -> Selected (transfer)
        private void btnDispAutoMoveAll_Click(object sender, EventArgs e)
        {
            MoveAll();
        }

        // '<' : Move selected items from Selected -> All (transfer back)
        private void btnDispAutoRemove_Click(object sender, EventArgs e)
        {
            MoveBack();
        }

        // '<<' : Move all items from Selected -> All
        private void btnDispAutoRemoveAll_Click(object sender, EventArgs e)
        {
            MoveBackAll();
        }

        // '^' : Move selected items up within Selected list
        private void btnDispAutoMoveUP_Click(object sender, EventArgs e)
        {
            MoveSelectedUp();
            // no change in count
        }

        // 'v' : Move selected items down within Selected list
        private void btnDispAutoMoveDown_Click(object sender, EventArgs e)
        {
            MoveSelectedDown();
        }


        // Transfer all items from source -> destination (destination appended, then source cleared)
        private void MoveAll()
        {
            var items = _availableProcedures.ToList();

            foreach (var item in items)
            {
                _selectedProcedures.Add(item);
                _availableProcedures.Remove(item);
            }

            lblDisplayParaTotalSelected.Text =
                $"Total Selected:\n          {_selectedProcedures.Count}";
        }

        // Move selected items from source -> destination (preserve order)
        private void MoveItem()
        {
            if (lstAvailableProcedures.SelectedItems.Count == 0)
                return;

            var items = lstAvailableProcedures.SelectedItems
                            .Cast<TestProcedure>()
                            .ToList();

            foreach (var item in items)
            {
                _selectedProcedures.Add(item);
                _availableProcedures.Remove(item);
            }

            lblDisplayParaTotalSelected.Text =
                $"Total Selected:\n          {_selectedProcedures.Count}";
        }

        private void MoveBack()
        {
            if (lstDisplatAutoSelected.SelectedItems.Count == 0)
                return;

            var items = lstDisplatAutoSelected.SelectedItems
                            .Cast<TestProcedure>()
                            .ToList();

            foreach (var item in items)
            {
                _availableProcedures.Add(item);
                _selectedProcedures.Remove(item);
            }

            lblDisplayParaTotalSelected.Text =
                $"Total Selected:\n          {_selectedProcedures.Count}";
        }

        private void MoveBackAll()
        {
            var items = _selectedProcedures.ToList();

            foreach (var item in items)
            {
                _availableProcedures.Add(item);
                _selectedProcedures.Remove(item);
            }

            lblDisplayParaTotalSelected.Text =
                $"Total Selected:\n          {_selectedProcedures.Count}";
        }


        // Move selected items up one position within the same list
        private void MoveSelectedUp()
        {
            var list = (BindingList<TestProcedure>)lstDisplatAutoSelected.DataSource;
            if (list == null || lstDisplatAutoSelected.SelectedIndices.Count == 0)
                return;

            var indices = lstDisplatAutoSelected.SelectedIndices
                                                .Cast<int>()
                                                .OrderBy(i => i)
                                                .ToList();

            // Already at top
            if (indices.First() == 0)
                return;

            foreach (int index in indices)
            {
                var item = list[index];
                list.RemoveAt(index);
                list.Insert(index - 1, item);
            }

            lstDisplatAutoSelected.ClearSelected();

            foreach (int index in indices)
            {
                lstDisplatAutoSelected.SetSelected(index - 1, true);
            }
        }

        // Move selected items down one position within the same list
        private void MoveSelectedDown()
        {
            var list = (BindingList<TestProcedure>)lstDisplatAutoSelected.DataSource;
            if (list == null || lstDisplatAutoSelected.SelectedIndices.Count == 0)
                return;

            var indices = lstDisplatAutoSelected.SelectedIndices
                                                .Cast<int>()
                                                .OrderByDescending(i => i)
                                                .ToList();

            // Already at bottom
            if (indices.First() == list.Count - 1)
                return;

            foreach (int index in indices)
            {
                var item = list[index];
                list.RemoveAt(index);
                list.Insert(index + 1, item);
            }

            lstDisplatAutoSelected.ClearSelected();

            foreach (int index in indices)
            {
                lstDisplatAutoSelected.SetSelected(index + 1, true);
            }
        }


        private void ResetProcedures()
        {
            _availableProcedures.Clear();
            _selectedProcedures.Clear();

            foreach (var procedure in _originalProcedures)
            {
                _availableProcedures.Add(procedure);
            }

            lstAvailableProcedures.ClearSelected();
            lstDisplatAutoSelected.ClearSelected();

            lblDisplayParaTotalSelected.Text =
                $"Total Selected:\n          {_selectedProcedures.Count}";
        }


        // Thread-safe dispatch logging and monitoring helpers
        private void Log(string message)
        {
            if (txtLogs.InvokeRequired)
            {
                txtLogs.Invoke(new Action(() => Log(message)));
            }
            else
            {
                txtLogs.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\r\n");
            }
        }

        private void UpdateOverviewError(int positionNo, string errorText)
        {
            if (lstOverview.InvokeRequired)
            {
                lstOverview.Invoke(new Action(() => UpdateOverviewError(positionNo, errorText)));
            }
            else
            {
                if (positionNo >= 1 && positionNo <= lstOverview.Items.Count)
                {
                    lstOverview.Items[positionNo - 1] = $"{positionNo:D2}:  {errorText}%";
                }
            }
        }

        private void UpdateBaseValues(double ub, double ib, double freq, double imax)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateBaseValues(ub, ib, freq, imax)));
            }
            else
            {
                txtBaseUb.Text = ub.ToString("F1");
                txtBaseIb.Text = ib.ToString("F2");
                txtBaseFreq.Text = freq.ToString("F2");
                txtBaseIm.Text = imax.ToString("F1");
            }
        }

        private void UpdateRangeLimits(string limitStr)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateRangeLimits(limitStr)));
            }
            else
            {
                lblRangeLimits.Text = limitStr;
            }
        }

        private void HighlightActiveStep(short stepNo)
        {
            if (dgvExecuteSteps.InvokeRequired)
            {
                dgvExecuteSteps.Invoke(new Action(() => HighlightActiveStep(stepNo)));
            }
            else
            {
                foreach (DataGridViewRow row in dgvExecuteSteps.Rows)
                {
                    if (row.DataBoundItem is RStepRow step && step.StepNo == stepNo)
                    {
                        row.Selected = true;
                        dgvExecuteSteps.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        // Actions: Start, Pause, Stop
        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                if (_isPaused)
                {
                    _isPaused = false;
                    _pauseEvent.Set();
                    btnStart.Enabled = false;
                    btnPause.Enabled = true;
                    Log("Execution resumed.");
                }
                return;
            }

            var stepsToRun = new List<RStepRow>();
            var executionType = (ExecutionMode)cmbStep.SelectedItem;

            switch (executionType)
            {
                case ExecutionMode.AllSteps:
                    stepsToRun = _sequenceList.Where(s => s.Select).ToList();
                    break;
                case ExecutionMode.SingleStep:
                    stepsToRun = dgvExecuteSteps.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(r => r.DataBoundItem as RStepRow)
                        .Where(s => s != null)
                        .ToList();
                    break;
                default:
                    MessageBox.Show("Unknown execution mode selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }


            if (stepsToRun.Count == 0)
            {
                MessageBox.Show("Please Add at least one step in the sequence list to execute.", "No Steps Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (executionType == ExecutionMode.SingleStep && dgvExecuteSteps.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one step in the sequence list to execute.", "No Steps Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isRunning = true;
            _isPaused = false;
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            _pauseEvent.Set();

            _cts = new CancellationTokenSource();
            Log("Starting calibration sequence...");

            // Run calibration sequence in background thread
            await Task.Run(() => RunCalibrationProcedure(stepsToRun, _cts.Token));
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_isRunning && !_isPaused)
            {
                _isPaused = true;
                _pauseEvent.Reset();
                btnStart.Enabled = true;
                btnPause.Enabled = false;
                Log("Execution paused. Click Start to resume.");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _cts?.Cancel();
                _pauseEvent.Set(); // Resume thread if paused so it exits immediately
                Log("Stop requested. Cleaning up...");
            }
        }

        private void RunCalibrationProcedure(List<RStepRow> steps, CancellationToken token)
        {
            try
            {
                // Connect to board controller and serial port standard meter
                //int sioPort = _bench?.SioPortNo ?? 1;
                //string sioFmt = _bench?.SioFormat ?? "19200,n,8,2";

                //using var board = new YcBoardController(sioPort, sioFmt);
                //var serial = new SerialPortService();

                //// SZ-03A-K6 Reference Standard Meter parser
                //var refStd = new CSZ_03A_K6(serial) { Port = sioPort };

                //Log("Initializing board connection...");
                //// Open standard boards (BoxType = 1 matches MFC app)
                //bool boxOk = board.OpenBoxAsync(1).GetAwaiter().GetResult();
                //if (!boxOk)
                //{
                //    Log("Warning: Board OpenBox returned error status. Simulating outputs...");
                //}

                // Initialise base values (nominal Ub, Ib from the first allocated meter)
                double nominalUb = 220.0;
                double nominalIb = 5.0;
                double nominalIm = 60.0;
                var firstMtr = _metersList.FirstOrDefault(m => m.Status && !string.IsNullOrEmpty(m.MeterType));
                if (firstMtr != null)
                {
                    var mtrSpec = _meterTypes.FirstOrDefault(m => m.Name == firstMtr.MeterType);
                    if (mtrSpec != null)
                    {
                        nominalUb = mtrSpec.Ub;
                        nominalIb = mtrSpec.Ib;
                        nominalIm = mtrSpec.Imax;
                    }
                }

                foreach (var step in steps)
                {

                    token.ThrowIfCancellationRequested();
                    _pauseEvent.Wait(token);

                    Log($"Executing: {step.Name}");

                    //Not working
                    HighlightActiveStep(step.StepNo);

                    // Parse voltage percentages and active power frequency
                    double.TryParse(step.UA, out var uaPct);
                    double.TryParse(step.IA, out var iaPct);
                    double.TryParse(step.FREQ, out var freq);
                    if (freq <= 0) freq = 50.0;

                    double targetUb = nominalUb * (uaPct / 100.0);
                    double targetIb = nominalIb * (iaPct / 100.0);

                    UpdateBaseValues(targetUb, targetIb, freq, nominalIm);

                    // Send output commands to the source board via COM integration
                    // (Translating C++ VoltageOut and CurrentOut calls)
                    Log($"Setting Voltage Out = {targetUb} V, Current Out = {targetIb} A");

                    // Simulate error monitoring loop
                    int timeLimitSeconds = 30;
                    if (int.TryParse(step.Timeout, out var tLimit)) timeLimitSeconds = tLimit;

                    // Parse limit indicators
                    string limitDisplay = "-0.50% to 0.50%";
                    UpdateRangeLimits(limitDisplay);


                    //Change are to be done here

                    for (int elapsed = 0; elapsed < timeLimitSeconds; elapsed++)
                    {
                        token.ThrowIfCancellationRequested();
                        _pauseEvent.Wait(token);

                        // Read telemetry values from the reference standard meter
                        //var act = refStd.GetActuals();
                        //if (!act.IsValid)
                        //{
                        //    // Telemetry simulation values if physical standard is not connected
                        //    act.IsValid = true;
                        //    act.UA = targetUb; act.UB = targetUb; act.UC = targetUb;
                        //    act.IA = targetIb; act.IB = targetIb; act.IC = targetIb;
                        //    act.Freq = freq;
                        //    act.TotalP = targetUb * targetIb * 3.0;
                        //    act.TotalQ = 0;
                        //    act.TotalS = act.TotalP;
                        //}
                        //UpdateLiveTelemetry(act);

                        // Random error generation simulation for positions

                        // _metersList iterate with respect to position, then execute RunCalibrationProcedure in the multithreading. Number of threadpools should be equal to _metersList
                        // Show the current running step at every available position in lstOverview.
                        for (int pos = 1; pos <= _metersList.Count; pos++)
                        {
                            var mtr = _metersList[pos - 1];
                            if (mtr.Status && !string.IsNullOrEmpty(mtr.MeterType))
                            {
                                double simErr = (new Random().NextDouble() * 0.4) - 0.2; // -0.20% to +0.20%
                                UpdateOverviewError(pos, simErr.ToString("F2"));
                            }
                        }

                        Thread.Sleep(1000);
                    }
                }

                Log("Calibration completed successfully!");
                SaveRunAndResults();
            }
            catch (OperationCanceledException)
            {
                Log("Calibration sequence canceled.");
            }
            catch (Exception ex)
            {
                Log($"Execution Error: {ex.Message}");
            }
            finally
            {
                _isRunning = false;
                _isPaused = false;
                Invoke(new Action(() =>
                {
                    btnStart.Enabled = true;
                    btnPause.Enabled = false;
                    btnStop.Enabled = false;
                }));
            }
        }



        private void SaveRunAndResults()
        {
            // Build Run object from UI fields
            var run = new Run
            {
                Name = txtSupervisor.Text.Trim(),
                TestSequence = txtSequenceName.Text.Trim(),
                TimeRun = DateTime.TryParse(txtDateRun.Text, out var dt) ? dt : DateTime.Now,
                SupervisorID = int.TryParse(txtSupervisor.Text, out var sup) ? sup : (int?)null,
                OperatorID = int.TryParse(txtOperator.Text, out var op) ? op : (int?)null,
                MinTemp = float.TryParse(txtMinTemp.Text, out var minT) ? (float?)minT : (float?)null,
                MaxTemp = float.TryParse(txtMaxTemp.Text, out var maxT) ? (float?)maxT : (float?)null,
                MinRH = float.TryParse(txtMinRH.Text, out var minRH) ? (float?)minRH : (float?)null,
                MaxRH = float.TryParse(txtMaxRH.Text, out var maxRH) ? (float?)maxRH : (float?)null,
                Status = 1,
                Comment = txtComment.Text.Trim()
            };

            // Convert UI steps to domain RStep objects
            var steps = _sequenceList.Select(s => new RStep
            {
                StepNo = (short)s.StepNo,
                Name = s.Name,
                UA = double.TryParse(s.UA, out var ua) ? ua : 0,
                IA = double.TryParse(s.IA, out var ia) ? ia : 0,
                PHI = double.TryParse(s.PHI, out var phi) ? phi : 0,
                FREQ = double.TryParse(s.FREQ, out var freq) ? freq : 0,
                Timeout = int.TryParse(s.Timeout, out var to) ? to : 0,
                ACMDS = s.ACMDS,
                BCMDS = s.BCMDS,
                CCMDS = s.CCMDS
            }).ToList();

            // Convert allocated meters to RMeter objects
            var meters = _metersList.Select(m => new RMeter
            {
                PositionNo = (short)m.PositionNo,
                Status = (short)(m.Status ? 1 : 0),
                MeterName = m.MeterType,
                OwnerNo = m.OwnerNo,
                MSN = m.MSN,
                YearOfManufacture = short.TryParse(m.YearOfManufacture, out var yr) ? (short?)yr : (short?)null,
                LastApproval = m.LastApproval,
                ContractNo = m.ContractNo,
                ClientName = m.ClientName,
                ClientNo = m.ClientNo
            }).ToList();

            // No detailed meter data collected yet – empty list
            var meterData = new List<RMeterData>();

            // Insert run and retrieve RunID
            var runId = _runRepository.InsertRunAsync(run, steps, meters, meterData).GetAwaiter().GetResult();

            // Gather results from results grid if any
            var results = new List<RResult>();
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                if (row.Cells[0].Value == null) continue;
                int pos = Convert.ToInt32(row.Cells[0].Value);
                short posShort = (short)pos;
                for (int col = 2; col < dgvResults.Columns.Count; col++)
                {
                    var colParts = dgvResults.Columns[col].Name.Split('_');
                    if (colParts.Length < 2) continue;
                    if (!short.TryParse(colParts[1], out var stepNo)) continue;
                    var val = row.Cells[col].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(val) && val != "-")
                    {
                        results.Add(new RResult
                        {
                            RunID = runId,
                            StepNo = stepNo,
                            PositionNo = posShort,
                            RValue = val
                        });
                    }
                }
            }

            if (results.Any())
            {
                _runRepository.SaveResultsAsync(runId, results).GetAwaiter().GetResult();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetProcedures();
        }

        // Populate sequence grid when Execute tab is selected.
        private async void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabExecute)
                {
                    await PopulateExecuteSequenceFromSelectedProceduresAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to populate execute sequence: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Build _sequenceList from _selectedProcedures and bind to dgvExecuteSteps.
        private async Task PopulateExecuteSequenceFromSelectedProceduresAsync()
        {
            _sequenceList.Clear();

            if (_selectedProcedures == null || _selectedProcedures.Count == 0)
            {
                dgvExecuteSteps.DataSource = null;
                dgvExecuteSteps.DataSource = _sequenceList;
                return;
            }

            short nextStepNo = 1;

            foreach (var proc in _selectedProcedures)
            {
                TestProcedure fullProc = proc;
                try
                {
                    // Try to get full procedure (with steps) from repository, fall back to item in list
                    var fetched = await _procedureRepository.GetByIdAsync(proc.ProcedureID);
                    if (fetched != null) fullProc = fetched;
                }
                catch
                {
                    // ignore fetch errors, use proc (it may already contain steps)
                }

                if (fullProc?.Steps == null || fullProc.Steps.Count == 0)
                    continue;

                foreach (var step in fullProc.Steps)
                {
                    _sequenceList.Add(new RStepRow
                    {
                        Select = true,
                        StepNo = nextStepNo++,
                        Name = $"{proc.Name} - {step.Name}",
                        UA = step.UA,
                        IA = step.IA,
                        PHI = step.PHI,
                        FREQ = step.FREQ,
                        Timeout = step.Timeout,
                        ACMDS = step.ACMDS,
                        BCMDS = step.BCMDS,
                        CCMDS = step.CCMDS
                    });
                }
            }

            // Rebind grid
            dgvExecuteSteps.DataSource = null;
            dgvExecuteSteps.DataSource = _sequenceList;
        }

        private void cmbStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mode = (ExecutionMode)cmbStep.SelectedItem;

            if (dgvExecuteSteps.SelectedRows.Count == 0)
                return;

            if (mode == ExecutionMode.AllSteps)
            {
                dgvExecuteSteps.ClearSelection();
                dgvExecuteSteps.Enabled = false;
            }
            else
            {
                dgvExecuteSteps.Rows[0].Selected = true;
                dgvExecuteSteps.Enabled = true;
            }
        }
    }

    public class MeterAllocationRow
    {
        public short PositionNo { get; set; }
        public bool Status { get; set; } = true;
        public string MeterType { get; set; } = string.Empty;
        public string MSN { get; set; } = string.Empty;
        public string OwnerNo { get; set; } = string.Empty;
        public string YearOfManufacture { get; set; } = string.Empty;
        public string LastApproval { get; set; } = string.Empty;
        public string ContractNo { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public string ClientNo { get; set; } = string.Empty;
    }

    public class RStepRow
    {
        public bool Select { get; set; } = true;
        public short StepNo { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UA { get; set; } = string.Empty;
        public string IA { get; set; } = string.Empty;
        public string PHI { get; set; } = string.Empty;
        public string FREQ { get; set; } = string.Empty;
        public string Timeout { get; set; } = string.Empty;
        public string ACMDS { get; set; } = string.Empty;
        public string BCMDS { get; set; } = string.Empty;
        public string CCMDS { get; set; } = string.Empty;
    }
}