using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CabconPMP.Data;
using CabconPMP.Models;
using static CabconPMP.Data.MeterTypeRepository;

namespace CabconPMP.UI
{
    public partial class frmProcedure : Form
    {
        private readonly ProcedureRepository _procedureRepository;
        private List<TestProcedure> _procedures = new List<TestProcedure>();
        private TestProcedure _selectedProcedure;
        private PStep _selectedStep;
        private bool _isBinding = false;

        private readonly TestProcedure _initialProcedure;

        public frmProcedure(ProcedureRepository repository, TestProcedure initialProcedure = null)
        {
            InitializeComponent();
            ApplyModernTabs();
            ModernizeUI(this);
            _procedureRepository = repository;
            _initialProcedure = initialProcedure;
        }

        private void ApplyModernTabs()
        {
            tabControlStepDetails.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlStepDetails.ItemSize = new System.Drawing.Size(120, 35);
            tabControlStepDetails.SizeMode = TabSizeMode.Fixed;
            tabControlStepDetails.DrawItem += TabControl1_DrawItem;
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabCtrl = (TabControl)sender;
            System.Drawing.Graphics g = e.Graphics;
            System.Drawing.Rectangle r = tabCtrl.GetTabRect(e.Index);
            bool isSelected = (e.State == DrawItemState.Selected);
            
            // Draw background
            using (System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(isSelected ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(240, 240, 240)))
            {
                g.FillRectangle(b, r);
            }
            
            // Draw accent line for selected tab
            if (isSelected)
            {
                using (System.Drawing.SolidBrush accent = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 122, 204)))
                {
                    g.FillRectangle(accent, r.Left, r.Top, r.Width, 3);
                }
            }
            
            // Draw text
            string tabText = tabCtrl.TabPages[e.Index].Text;
            System.Drawing.StringFormat sf = new System.Drawing.StringFormat();
            sf.Alignment = System.Drawing.StringAlignment.Center;
            sf.LineAlignment = System.Drawing.StringAlignment.Center;
            using (System.Drawing.Font f = new System.Drawing.Font(tabCtrl.Font, isSelected ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular))
            {
                using (System.Drawing.SolidBrush textBrush = new System.Drawing.SolidBrush(isSelected ? System.Drawing.Color.FromArgb(0, 122, 204) : System.Drawing.Color.FromArgb(100, 100, 100)))
                {
                    g.DrawString(tabText, f, textBrush, r, sf);
                }
            }
        }

        private void ModernizeUI(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is System.Windows.Forms.Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = System.Drawing.Color.FromArgb(30, 40, 60);
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.Font = new System.Drawing.Font(btn.Font, System.Drawing.FontStyle.Bold);
                }
                else if (c is System.Windows.Forms.DataGridView dgv)
                {
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 250);
                    dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
                    dgv.BackgroundColor = System.Drawing.Color.White;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 40, 60);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgv.Font, System.Drawing.FontStyle.Bold);
                }
                else if (c is System.Windows.Forms.GroupBox gb)
                {
                    gb.FlatStyle = FlatStyle.Flat;
                }
                else if (c is System.Windows.Forms.Label lbl)
                {
                    lbl.BackColor = System.Drawing.Color.Transparent;
                }
                else if (c is System.Windows.Forms.TabPage tp)
                {
                    tp.BackColor = System.Drawing.Color.Transparent;
                }

                if (c.HasChildren)
                {
                    ModernizeUI(c);
                }
            }
        }

        private void frmProcedure_Load(object sender, EventArgs e)
        {
            // Set defaults for comboboxes
            cmbUA.SelectedIndex = 0;
            cmbUB.SelectedIndex = 0;
            cmbUC.SelectedIndex = 0;
            cmbIA.SelectedIndex = 0;
            cmbIB.SelectedIndex = 0;
            cmbIC.SelectedIndex = 0;

            cmbPFType.SelectedIndex = 0;
            cmbWaveform.SelectedIndex = 0;
            cmbFreq.SelectedIndex = 0;

            cmbTestType.SelectedIndex = 0;
            cmbMeasurement.SelectedIndex = 0;
            cmbNumPulsesSC.SelectedIndex = 0;
            cmbNumDecPlace.SelectedIndex = 1;
            cmbChannelNo.SelectedIndex = 0;

            LoadProcedures();
        }

        private async void LoadProcedures()
        {
            try
            {
                var list = await _procedureRepository.GetAllAsync();
                _procedures = list.ToList();
                
                _isBinding = true;
                cmbProcedures.DataSource = null;
                cmbProcedures.DataSource = _procedures;
                cmbProcedures.DisplayMember = "Name";
                cmbProcedures.ValueMember = "ProcedureID";
                _isBinding = false;

                if (_initialProcedure != null)
                {
                    cmbProcedures.SelectedValue = _initialProcedure.ProcedureID;
                }
                else if (_procedures.Count > 0)
                {
                    cmbProcedures.SelectedIndex = 0;
                }
                else
                {
                    ClearProcedureForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load procedures: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cmbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding) return;

            if (cmbProcedures.SelectedValue is int procId && procId > 0)
            {
                try
                {
                    _selectedProcedure = await _procedureRepository.GetByIdAsync(procId);
                    if (_selectedProcedure != null)
                    {
                        txtProcedureName.Text = _selectedProcedure.Name;
                        numRevision.Value = _selectedProcedure.Revision;
                        RefreshStepList();
                        if (_selectedProcedure.Steps.Count > 0)
                        {
                            lstSteps.SelectedIndex = 0;
                        }
                        else
                        {
                            ClearStepForm();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load procedure steps: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshStepList()
        {
            if (_selectedProcedure == null) return;
            
            _isBinding = true;
            lstSteps.DataSource = null;
            lstSteps.DataSource = _selectedProcedure.Steps;
            lstSteps.DisplayMember = "Name";
            _isBinding = false;
        }

        private void lstSteps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isBinding) return;

            if (lstSteps.SelectedItem is PStep step)
            {
                _selectedStep = step;
                PopulateStepForm();
            }
        }

        private void PopulateStepForm()
        {
            if (_selectedStep == null) return;

            _isBinding = true;

            // Tab 1: Parameters
            txtStepName.Text = _selectedStep.Name;
            cmbUA.Text = _selectedStep.UA;
            cmbUB.Text = _selectedStep.UB;
            cmbUC.Text = _selectedStep.UC;
            
            cmbIA.Text = _selectedStep.IA;
            cmbIB.Text = _selectedStep.IB;
            cmbIC.Text = _selectedStep.IC;

            // Parse PHI to UI
            string phiText = DegreeToText(_selectedStep.PHI);
            ParsePhiTextToUI(phiText);

            cmbWaveform.SelectedIndex = Math.Max(Math.Min(_selectedStep.Waveform - 1, 2), 0);
            cmbFreq.Text = _selectedStep.FREQ;

            if (_selectedStep.PhaseSeq == 1)
                rbL123.Checked = true;
            else
                rbL132.Checked = true;

            // Tab 2: Test Type
            cmbTestType.SelectedIndex = Math.Max(Math.Min(_selectedStep.TestTypeID - 1, 3), 0);
            cmbMeasurement.SelectedIndex = Math.Max(Math.Min(_selectedStep.Measurement - 1, 2), 0);
            
            cmbNumPulsesSC.Text = _selectedStep.NumPulses;
            txtNumPulsesErr.Text = _selectedStep.NumPulses;

            cmbULimit.Text = _selectedStep.ULIMIT;
            cmbLLimit.Text = _selectedStep.LLIMIT;
            chkSymmetrical.Checked = _selectedStep.ULIMIT == _selectedStep.LLIMIT.Replace("-", "");

            cmbNumDecPlace.Text = _selectedStep.Storing.ToString();
            cmbChannelNo.SelectedIndex = Math.Max(Math.Min(_selectedStep.ChannelNo - 1, 2), 0);

            // Storing
            if (_selectedStep.Storing == 0)
                rbStoreNone.Checked = true;
            else if (_selectedStep.Storing == 1)
                rbLastVal.Checked = true;
            else
                rbMean.Checked = true;

            // FileIE checks
            chkImport.Checked = (_selectedStep.FileIE & 1) != 0;
            chkExport.Checked = (_selectedStep.FileIE & 2) != 0;
            chkImport2.Checked = (_selectedStep.FileIE & 4) != 0;

            // Tab 3: Duration
            rbTimeDuration.Checked = true;
            txtTimeout.Text = _selectedStep.Timeout;

            if (_selectedStep.Finally == 1)
                rbWait.Checked = true;
            else if (_selectedStep.Finally == 2)
                rbWaitI0.Checked = true;
            else
                rbNextTest.Checked = true;

            // Tab 4: Controls
            // Wait / Program / Manual radios
            if (_selectedStep.Duration == 0)
                rbCtrlManual.Checked = true;
            else if (_selectedStep.Duration == 1)
                rbCtrlProgram.Checked = true;
            else
                rbCtrlWait.Checked = true;

            // Commands list populating
            PopulateCommandsList(lstBeforeCmds, _selectedStep.ACMDS);
            PopulateCommandsList(lstDuringCmds, _selectedStep.BCMDS);
            PopulateCommandsList(lstAfterCmds, _selectedStep.CCMDS);

            chkWithAmp.Checked = _selectedStep.WithAmp != 0;

            _isBinding = false;
        }

        private void ParsePhiTextToUI(string phiText)
        {
            try
            {
                var parts = phiText.Split('=');
                if (parts.Length < 2) return;

                cmbPFType.SelectedIndex = parts[0].Contains("cos") ? 0 : 1;

                var subparts = parts[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (subparts.Length >= 3)
                {
                    cmbPFValue.Text = subparts[0];
                    if (subparts[1].Contains("consumption"))
                        rbConsumption.Checked = true;
                    else
                        rbDelivery.Checked = true;

                    if (subparts[2].Contains("lagging"))
                        rbLagging.Checked = true;
                    else
                        rbLeading.Checked = true;
                }
            }
            catch { }
        }

        private void PopulateCommandsList(ListBox listBox, string cmdsStr)
        {
            listBox.Items.Clear();
            if (!string.IsNullOrEmpty(cmdsStr))
            {
                string[] cmds = cmdsStr.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var cmd in cmds)
                {
                    listBox.Items.Add(cmd);
                }
            }
        }

        private string GetCommandsString(ListBox listBox)
        {
            List<string> items = new List<string>();
            foreach (var item in listBox.Items)
            {
                items.Add(item.ToString());
            }
            return string.Join("|", items);
        }

        private void ClearProcedureForm()
        {
            _selectedProcedure = null;
            txtProcedureName.Text = string.Empty;
            numRevision.Value = 1;
            lstSteps.DataSource = null;
            ClearStepForm();
        }

        private void ClearStepForm()
        {
            _selectedStep = null;
            txtStepName.Text = string.Empty;
            cmbUA.SelectedIndex = 0;
            cmbUB.SelectedIndex = 0;
            cmbUC.SelectedIndex = 0;
            cmbIA.SelectedIndex = 0;
            cmbIB.SelectedIndex = 0;
            cmbIC.SelectedIndex = 0;
            cmbPFValue.Text = "1.0";
            cmbPFType.SelectedIndex = 0;
            rbConsumption.Checked = true;
            rbLagging.Checked = true;
            cmbWaveform.SelectedIndex = 0;
            cmbFreq.Text = "50";
            rbL123.Checked = true;

            cmbTestType.SelectedIndex = 0;
            cmbMeasurement.SelectedIndex = 0;
            cmbNumPulsesSC.SelectedIndex = 0;
            txtNumPulsesErr.Text = "10";
            cmbULimit.Text = "0.5";
            cmbLLimit.Text = "-0.5";
            chkSymmetrical.Checked = true;
            cmbNumDecPlace.SelectedIndex = 1;
            cmbChannelNo.SelectedIndex = 0;
            rbStoreNone.Checked = true;
            chkImport.Checked = false;
            chkExport.Checked = false;
            chkImport2.Checked = false;

            txtTimeout.Text = "00:01:00";
            rbNextTest.Checked = true;

            rbCtrlManual.Checked = true;
            txtControlCommand.Text = string.Empty;
            lstBeforeCmds.Items.Clear();
            lstDuringCmds.Items.Clear();
            lstAfterCmds.Items.Clear();
            chkWithAmp.Checked = false;
        }

        private void DetailControl_Changed(object sender, EventArgs e)
        {
            if (_isBinding || _selectedStep == null) return;

            // Save details back to selected step memory
            _selectedStep.Name = txtStepName.Text.Trim();
            _selectedStep.UA = cmbUA.Text;
            _selectedStep.UB = cmbUB.Text;
            _selectedStep.UC = cmbUC.Text;
            
            _selectedStep.IA = cmbIA.Text;
            _selectedStep.IB = cmbIB.Text;
            _selectedStep.IC = cmbIC.Text;

            _selectedStep.IsImax = (short)(_selectedStep.IA == "Imax" || _selectedStep.IB == "Imax" || _selectedStep.IC == "Imax" ? 1 : 0);

            // Rebuild PHI string
            string pfTypeText = cmbPFType.SelectedIndex == 0 ? "cos(phi)" : "sin(phi)";
            string consDeliv = rbConsumption.Checked ? "consumption" : "delivery";
            string lagLead = rbLagging.Checked ? "lagging" : "leading";
            string phiText = $"{pfTypeText}={cmbPFValue.Text} {consDeliv} {lagLead}";
            _selectedStep.PHI = TextToDegree(phiText);

            _selectedStep.Waveform = (short)(cmbWaveform.SelectedIndex + 1);
            _selectedStep.FREQ = cmbFreq.Text;
            _selectedStep.PhaseSeq = (short)(rbL123.Checked ? 1 : 2);

            _selectedStep.TestTypeID = (short)(cmbTestType.SelectedIndex + 1);
            _selectedStep.Measurement = (short)(cmbMeasurement.SelectedIndex + 1);

            if (_selectedStep.TestTypeID == 4) // Error test
            {
                _selectedStep.NumPulses = txtNumPulsesErr.Text;
            }
            else
            {
                _selectedStep.NumPulses = cmbNumPulsesSC.Text;
            }

            _selectedStep.ULIMIT = cmbULimit.Text;
            if (chkSymmetrical.Checked)
            {
                _selectedStep.LLIMIT = "-" + cmbULimit.Text.Replace("-", "");
                _isBinding = true;
                cmbLLimit.Text = _selectedStep.LLIMIT;
                _isBinding = false;
            }
            else
            {
                _selectedStep.LLIMIT = cmbLLimit.Text;
            }

            short.TryParse(cmbNumDecPlace.Text, out var decPl);
            _selectedStep.Storing = decPl;

            _selectedStep.ChannelNo = (short)(cmbChannelNo.SelectedIndex + 1);
            
            _selectedStep.Storing = (short)(rbStoreNone.Checked ? 0 : (rbLastVal.Checked ? 1 : 2));

            _selectedStep.FileIE = (short)((chkImport.Checked ? 1 : 0) + (chkExport.Checked ? 2 : 0) + (chkImport2.Checked ? 4 : 0));

            _selectedStep.Timeout = txtTimeout.Text;
            _selectedStep.Finally = (short)(rbWait.Checked ? 1 : (rbWaitI0.Checked ? 2 : 3));

            _selectedStep.Duration = (short)(rbCtrlManual.Checked ? 0 : (rbCtrlProgram.Checked ? 1 : 2));

            _selectedStep.ACMDS = GetCommandsString(lstBeforeCmds);
            _selectedStep.BCMDS = GetCommandsString(lstDuringCmds);
            _selectedStep.CCMDS = GetCommandsString(lstAfterCmds);

            _selectedStep.WithAmp = (short)(chkWithAmp.Checked ? 1 : 0);

            // Update ListBox display member if step name changed
            _isBinding = true;
            int idx = lstSteps.SelectedIndex;
            lstSteps.DataSource = null;
            lstSteps.DataSource = _selectedProcedure.Steps;
            lstSteps.DisplayMember = "Name";
            lstSteps.SelectedIndex = idx;
            _isBinding = false;
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            if (_selectedProcedure == null)
            {
                MessageBox.Show("Please select or create a procedure first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            short nextNo = (short)(_selectedProcedure.Steps.Count + 1);
            var step = new PStep
            {
                ProcedureID = _selectedProcedure.ProcedureID,
                PStepNo = nextNo,
                Name = $"Step {nextNo}",
                UA = "100", UB = "100", UC = "100",
                IA = "100", IB = "100", IC = "100",
                PHI = "c0.00",
                FREQ = "50",
                Waveform = 1,
                PhaseSeq = 1,
                TestTypeID = 4, // Error test default
                Measurement = 1, // Active P
                NumPulses = "10",
                ULIMIT = "0.5",
                LLIMIT = "-0.5",
                ChannelNo = 1,
                Storing = 0,
                FileIE = 0,
                Duration = 0,
                Timeout = "00:01:00",
                Finally = 3, // Next test
                WithAmp = 0
            };

            _selectedProcedure.Steps.Add(step);
            RefreshStepList();
            lstSteps.SelectedItem = step;
        }

        private void btnDeleteStep_Click(object sender, EventArgs e)
        {
            if (_selectedProcedure == null || _selectedStep == null) return;

            _selectedProcedure.Steps.Remove(_selectedStep);
            
            // Re-index step numbers
            for (short i = 0; i < _selectedProcedure.Steps.Count; i++)
            {
                _selectedProcedure.Steps[i].PStepNo = (short)(i + 1);
            }

            RefreshStepList();
            if (_selectedProcedure.Steps.Count > 0)
            {
                lstSteps.SelectedIndex = 0;
            }
            else
            {
                ClearStepForm();
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (_selectedProcedure == null || _selectedStep == null) return;

            int idx = _selectedProcedure.Steps.IndexOf(_selectedStep);
            if (idx > 0)
            {
                _selectedProcedure.Steps.RemoveAt(idx);
                _selectedProcedure.Steps.Insert(idx - 1, _selectedStep);
                
                // Re-index step numbers
                for (short i = 0; i < _selectedProcedure.Steps.Count; i++)
                {
                    _selectedProcedure.Steps[i].PStepNo = (short)(i + 1);
                }

                RefreshStepList();
                lstSteps.SelectedItem = _selectedStep;
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (_selectedProcedure == null || _selectedStep == null) return;

            int idx = _selectedProcedure.Steps.IndexOf(_selectedStep);
            if (idx >= 0 && idx < _selectedProcedure.Steps.Count - 1)
            {
                _selectedProcedure.Steps.RemoveAt(idx);
                _selectedProcedure.Steps.Insert(idx + 1, _selectedStep);
                
                // Re-index step numbers
                for (short i = 0; i < _selectedProcedure.Steps.Count; i++)
                {
                    _selectedProcedure.Steps[i].PStepNo = (short)(i + 1);
                }

                RefreshStepList();
                lstSteps.SelectedItem = _selectedStep;
            }
        }

        private void btnNewProcedure_Click(object sender, EventArgs e)
        {
            ClearProcedureForm();
            var proc = new TestProcedure
            {
                Name = "New Test Procedure",
                Revision = 1,
                Steps = new List<PStep>()
            };
            _selectedProcedure = proc;
            txtProcedureName.Text = proc.Name;
            numRevision.Value = proc.Revision;
            RefreshStepList();
            txtProcedureName.Focus();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedProcedure == null) return;

            if (string.IsNullOrEmpty(txtProcedureName.Text))
            {
                MessageBox.Show("Procedure name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedProcedure.Name = txtProcedureName.Text.Trim();
            _selectedProcedure.Revision = (short)numRevision.Value;

            try
            {
                int procId = await _procedureRepository.SaveAsync(_selectedProcedure);
                _selectedProcedure.ProcedureID = procId;
                MessageBox.Show("Test Procedure saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProcedures();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save procedure: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable files (*.exe)|*.exe|Command scripts (*.bat;*.cmd)|*.bat;*.cmd|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtControlCommand.Text = ofd.FileName;
                }
            }
        }

        private void btnAddBefore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtControlCommand.Text))
            {
                lstBeforeCmds.Items.Add(txtControlCommand.Text.Trim());
                DetailControl_Changed(this, EventArgs.Empty);
            }
        }

        private void btnDelBefore_Click(object sender, EventArgs e)
        {
            if (lstBeforeCmds.SelectedIndex >= 0)
            {
                lstBeforeCmds.Items.RemoveAt(lstBeforeCmds.SelectedIndex);
                DetailControl_Changed(this, EventArgs.Empty);
            }
        }

        private void btnAddDuring_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtControlCommand.Text))
            {
                lstDuringCmds.Items.Add(txtControlCommand.Text.Trim());
                DetailControl_Changed(this, EventArgs.Empty);
            }
        }

        private void btnDelDuring_Click(object sender, EventArgs e)
        {
            if (lstDuringCmds.SelectedIndex >= 0)
            {
                lstDuringCmds.Items.RemoveAt(lstDuringCmds.SelectedIndex);
                DetailControl_Changed(this, EventArgs.Empty);
            }
        }

        private void btnAddAfter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtControlCommand.Text))
            {
                lstAfterCmds.Items.Add(txtControlCommand.Text.Trim());
                DetailControl_Changed(this, EventArgs.Empty);
            }
        }

        private void btnDelAfter_Click(object sender, EventArgs e)
        {
            if (lstAfterCmds.SelectedIndex >= 0)
            {
                lstAfterCmds.Items.RemoveAt(lstAfterCmds.SelectedIndex);
                DetailControl_Changed(this, EventArgs.Empty);
            }
        }

        // PHI parsing helpers matching MFC FuncPhi logic
        private string DegreeToText(string degreeStr)
        {
            if (string.IsNullOrEmpty(degreeStr) || degreeStr.Length < 2) return "cos(phi)=1.00 consumption lagging";
            char ch = degreeStr[0];
            if (!double.TryParse(degreeStr.Substring(1), out var angle)) return "cos(phi)=1.00 consumption lagging";
            
            double v = 0;
            string c = "consumption";
            string l = "lagging";
            string y = "cos(phi)";
            double pi = Math.PI;

            if (ch == 'c')
            {
                y = "cos(phi)";
                v = Math.Abs(Math.Cos(angle * pi / 180.0));
                if ((angle >= 0.0 && angle <= 90.0) || (angle >= 270.0 && angle <= 360.0))
                {
                    c = "consumption";
                    l = (angle <= 90.0) ? "lagging" : "leading";
                }
                else
                {
                    c = "delivery";
                    l = (angle >= 180.0) ? "lagging" : "leading";
                }
            }
            else if (ch == 's')
            {
                y = "sin(phi)";
                v = Math.Abs(Math.Sin(angle * pi / 180.0));
                if (angle >= 0.0 && angle <= 180.0)
                {
                    c = "consumption";
                    l = (angle <= 90.0) ? "lagging" : "leading";
                }
                else
                {
                    c = "delivery";
                    l = (angle <= 270.0) ? "lagging" : "leading";
                }
            }
            return $"{y}={v:F2} {c} {l}";
        }

        private string TextToDegree(string text)
        {
            try
            {
                var parts = text.Split('=');
                if (parts.Length < 2) return "c0.00";
                
                char ch = 'c';
                int y = parts[0].Contains("cos") ? 1 : 2;
                
                var subparts = parts[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (subparts.Length < 3) return "c0.00";
                
                double v = double.Parse(subparts[0]);
                int c = subparts[1].Contains("consumption") ? 1 : 2;
                int l = subparts[2].Contains("lagging") ? 1 : 2;
                
                double angle = 0;
                double angleR = 0;
                double pi = Math.PI;

                if (y == 1) // cos
                {
                    angle = Math.Acos(v) * 180.0 / pi;
                    if (c == 1 && l == 1) angleR = 0.0;
                    else if (c == 1 && l == 2) angleR = 360.0;
                    else angleR = 180.0;
                    angle = angleR + (l == 1 ? 1 : -1) * angle;
                    ch = 'c';
                }
                else // sin
                {
                    angle = Math.Asin(v) * 180.0 / pi;
                    if (c == 1 && l == 1) angle = 0.0 + angle;
                    else if (c == 2 && l == 1) angle = 180.0 + angle;
                    else if (c == 1 && l == 2) angle = 180.0 - angle;
                    else angle = 360.0 - angle;
                    ch = 's';
                }
                
                // Normalise to 0-360 range
                angle = (angle + 360.0) % 360.0;
                
                return $"{ch}{angle:F2}";
            }
            catch
            {
                return "c0.00";
            }
        }

        private void lblAfterCmds_Click(object sender, EventArgs e)
        {

        }
    }
}
