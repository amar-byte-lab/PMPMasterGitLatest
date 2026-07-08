using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CabconPMP.Data;
using CabconPMP.Models;

namespace CabconPMP.UI
{
    public partial class frmMeterType : Form
    {
        private readonly MeterTypeRepository _meterTypeRepository;
        private List<MeterType> _meterTypes = new List<MeterType>();
        private MeterType _selectedMeterType;
        private readonly MeterType _initialSelectedType;

        private BindingList<ChannelConstant> _constantsList = new BindingList<ChannelConstant>();

        public frmMeterType(MeterTypeRepository repository, MeterType selectedType = null)
        {
            InitializeComponent();
            _meterTypeRepository = repository;
            _initialSelectedType = selectedType;
        }

        private void frmMeterType_Load(object sender, EventArgs e)
        {
            dgvMeterTypes.AutoGenerateColumns = false;
            dgvConstants.AutoGenerateColumns = false;
            dgvConstants.DataSource = _constantsList;

            cmbChan.SelectedIndex = 0;
            cmbMeas.SelectedIndex = 0;
            cmbUnit.SelectedIndex = 0;

            LoadMeterTypes();
            if (_initialSelectedType != null)
            {
                _selectedMeterType = _initialSelectedType;
                PopulateForm();
            }
            else
            {
                ClearForm();
            }
        }

        private async void LoadMeterTypes()
        {
            try
            {
                var list = await _meterTypeRepository.GetAllAsync();
                _meterTypes = list.ToList();
                dgvMeterTypes.DataSource = null;
                dgvMeterTypes.DataSource = _meterTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load meter types: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMeterTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMeterTypes.SelectedRows.Count > 0 && _initialSelectedType == null)
            {
                _selectedMeterType = dgvMeterTypes.SelectedRows[0].DataBoundItem as MeterType;
                PopulateForm();
            }
        }

        private void PopulateForm()
        {
            if (_selectedMeterType == null) return;
            
            txtName.Text = _selectedMeterType.Name;
            txtManufacturer.Text = _selectedMeterType.Manufacturer;
            txtApprovalNo.Text = _selectedMeterType.ApprovalNo;
            numUb.Value = (decimal)_selectedMeterType.Ub;
            numIb.Value = (decimal)_selectedMeterType.Ib;
            numImax.Value = (decimal)_selectedMeterType.Imax;
            
            cmbLineType.SelectedIndex = Math.Max(Math.Min(_selectedMeterType.LineType - 1, 2), 0);
            cmbConnectMode.SelectedIndex = Math.Max(Math.Min(_selectedMeterType.ConnectMode - 1, 3), 0);
            
            if (_selectedMeterType.Principal == 1)
                rbInduction.Checked = true;
            else
                rbElectronic.Checked = true;

            chkAccP.Checked = _selectedMeterType.AccP.HasValue;
            cmbAccP.Text = _selectedMeterType.AccP?.ToString() ?? "1.0";
            chkAccQ.Checked = _selectedMeterType.AccQ.HasValue;
            cmbAccQ.Text = _selectedMeterType.AccQ?.ToString() ?? "2.0";
            chkAccS.Checked = _selectedMeterType.AccS.HasValue;
            cmbAccS.Text = _selectedMeterType.AccS?.ToString() ?? "1.0";

            txtComment.Text = _selectedMeterType.Comment;

            // Deserialize Constants List
            _constantsList.Clear();
            if (!string.IsNullOrEmpty(_selectedMeterType.ChContent))
            {
                string[] rows = _selectedMeterType.ChContent.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var row in rows)
                {
                    string[] parts = row.Split(',');
                    if (parts.Length == 4)
                    {
                        short.TryParse(parts[0], out var chan);
                        double.TryParse(parts[2], out var val);
                        _constantsList.Add(new ChannelConstant
                        {
                            ChannelNo = chan,
                            Measurement = parts[1],
                            ConstantVal = val,
                            Unit = parts[3]
                        });
                    }
                }
            }
        }

        private void ClearForm()
        {
            _selectedMeterType = null;
            txtName.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtApprovalNo.Text = string.Empty;
            numUb.Value = 220;
            numIb.Value = 5;
            numImax.Value = 60;
            cmbLineType.SelectedIndex = 2; // 3-phase 4-wire default
            cmbConnectMode.SelectedIndex = 0; // Direct default
            rbElectronic.Checked = true;
            chkAccP.Checked = true;
            cmbAccP.Text = "1.0";
            chkAccQ.Checked = false;
            cmbAccQ.Text = "2.0";
            chkAccS.Checked = false;
            cmbAccS.Text = "1.0";
            txtComment.Text = string.Empty;
            _constantsList.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtName.Focus();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Meter name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isNew = _selectedMeterType == null;
            var mt = _selectedMeterType ?? new MeterType();

            mt.Name = txtName.Text.Trim();
            mt.Manufacturer = txtManufacturer.Text.Trim();
            mt.ApprovalNo = txtApprovalNo.Text.Trim();
            mt.Ub = (double)numUb.Value;
            mt.Ib = (double)numIb.Value;
            mt.Imax = (double)numImax.Value;
            mt.LineType = (short)(cmbLineType.SelectedIndex + 1);
            mt.ConnectMode = (short)(cmbConnectMode.SelectedIndex + 1);
            mt.Principal = (short)(rbInduction.Checked ? 1 : 2);

            mt.AccP = chkAccP.Checked && double.TryParse(cmbAccP.Text, out var ap) ? ap : (double?)null;
            mt.AccQ = chkAccQ.Checked && double.TryParse(cmbAccQ.Text, out var aq) ? aq : (double?)null;
            mt.AccS = chkAccS.Checked && double.TryParse(cmbAccS.Text, out var asVal) ? asVal : (double?)null;

            mt.Comment = txtComment.Text.Trim();

            // Serialize Constants List
            List<string> rows = new List<string>();
            foreach (var item in _constantsList)
            {
                rows.Add($"{item.ChannelNo},{item.Measurement},{item.ConstantVal},{item.Unit}");
            }
            mt.ChContent = string.Join("|", rows);

            try
            {
                if (isNew)
                {
                    await _meterTypeRepository.InsertAsync(mt);
                }
                else
                {
                    await _meterTypeRepository.UpdateAsync(mt);
                }
                MessageBox.Show("Meter Type saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMeterTypes();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddConst_Click(object sender, EventArgs e)
        {
            short chan = (short)(cmbChan.SelectedIndex + 1);
            string meas = cmbMeas.Text;
            if (!double.TryParse(txtConst.Text, out var constantVal))
            {
                MessageBox.Show("Constant value must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string unit = cmbUnit.Text;

            // Check if combination already exists, if so update it
            var existing = _constantsList.FirstOrDefault(c => c.ChannelNo == chan && c.Measurement == meas);
            if (existing != null)
            {
                existing.ConstantVal = constantVal;
                existing.Unit = unit;
                dgvConstants.Refresh();
            }
            else
            {
                _constantsList.Add(new ChannelConstant
                {
                    ChannelNo = chan,
                    Measurement = meas,
                    ConstantVal = constantVal,
                    Unit = unit
                });
            }
        }

        private void btnRemoveConst_Click(object sender, EventArgs e)
        {
            if (dgvConstants.SelectedRows.Count > 0)
            {
                var row = dgvConstants.SelectedRows[0];
                var item = row.DataBoundItem as ChannelConstant;
                if (item != null)
                {
                    _constantsList.Remove(item);
                }
            }
        }
    }

    public class ChannelConstant
    {
        public short ChannelNo { get; set; }
        public string Measurement { get; set; } = string.Empty;
        public double ConstantVal { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}
