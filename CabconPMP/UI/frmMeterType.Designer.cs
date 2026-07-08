namespace CabconPMP.UI
{
    partial class frmMeterType
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvMeterTypes = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMtr = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.grpAccuracy = new System.Windows.Forms.GroupBox();
            this.cmbAccS = new System.Windows.Forms.ComboBox();
            this.chkAccS = new System.Windows.Forms.CheckBox();
            this.cmbAccQ = new System.Windows.Forms.ComboBox();
            this.chkAccQ = new System.Windows.Forms.CheckBox();
            this.cmbAccP = new System.Windows.Forms.ComboBox();
            this.chkAccP = new System.Windows.Forms.CheckBox();
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.rbElectronic = new System.Windows.Forms.RadioButton();
            this.rbInduction = new System.Windows.Forms.RadioButton();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtApprovalNo = new System.Windows.Forms.TextBox();
            this.lblApprovalNo = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMtrName = new System.Windows.Forms.Label();
            this.cmbConnectMode = new System.Windows.Forms.ComboBox();
            this.lblConnectMode = new System.Windows.Forms.Label();
            this.cmbLineType = new System.Windows.Forms.ComboBox();
            this.lblLineType = new System.Windows.Forms.Label();
            this.tabElectrical = new System.Windows.Forms.TabPage();
            this.grpConstants = new System.Windows.Forms.GroupBox();
            this.btnRemoveConst = new System.Windows.Forms.Button();
            this.btnAddConst = new System.Windows.Forms.Button();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtConst = new System.Windows.Forms.TextBox();
            this.lblConst = new System.Windows.Forms.Label();
            this.cmbMeas = new System.Windows.Forms.ComboBox();
            this.lblMeas = new System.Windows.Forms.Label();
            this.cmbChan = new System.Windows.Forms.ComboBox();
            this.lblChan = new System.Windows.Forms.Label();
            this.dgvConstants = new System.Windows.Forms.DataGridView();
            this.colChan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMeas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNominal = new System.Windows.Forms.GroupBox();
            this.numFreq = new System.Windows.Forms.NumericUpDown();
            this.lblFreq = new System.Windows.Forms.Label();
            this.numImax = new System.Windows.Forms.NumericUpDown();
            this.lblImax = new System.Windows.Forms.Label();
            this.numIb = new System.Windows.Forms.NumericUpDown();
            this.lblIb = new System.Windows.Forms.Label();
            this.numUb = new System.Windows.Forms.NumericUpDown();
            this.lblUb = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeterTypes)).BeginInit();
            this.tabControlMtr.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.grpAccuracy.SuspendLayout();
            this.grpPrincipal.SuspendLayout();
            this.tabElectrical.SuspendLayout();
            this.grpConstants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstants)).BeginInit();
            this.grpNominal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeterTypes
            // 
            this.dgvMeterTypes.AllowUserToAddRows = false;
            this.dgvMeterTypes.AllowUserToDeleteRows = false;
            this.dgvMeterTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // create and configure colName (avoid inline object initializer - keep as field for designer parser)
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 240;
            this.dgvMeterTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName});
            this.dgvMeterTypes.Location = new System.Drawing.Point(12, 12);
            this.dgvMeterTypes.MultiSelect = false;
            this.dgvMeterTypes.Name = "dgvMeterTypes";
            this.dgvMeterTypes.ReadOnly = true;
            this.dgvMeterTypes.RowHeadersVisible = false;
            this.dgvMeterTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeterTypes.Size = new System.Drawing.Size(260, 480);
            this.dgvMeterTypes.TabIndex = 0;
            this.dgvMeterTypes.SelectionChanged += new System.EventHandler(this.dgvMeterTypes_SelectionChanged);
            // 
            // tabControlMtr
            // 
            this.tabControlMtr.Controls.Add(this.tabGeneral);
            this.tabControlMtr.Controls.Add(this.tabElectrical);
            this.tabControlMtr.Location = new System.Drawing.Point(285, 12);
            this.tabControlMtr.Name = "tabControlMtr";
            this.tabControlMtr.SelectedIndex = 0;
            this.tabControlMtr.Size = new System.Drawing.Size(585, 440);
            this.tabControlMtr.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.grpAccuracy);
            this.tabGeneral.Controls.Add(this.grpPrincipal);
            this.tabGeneral.Controls.Add(this.txtComment);
            this.tabGeneral.Controls.Add(this.lblComment);
            this.tabGeneral.Controls.Add(this.txtApprovalNo);
            this.tabGeneral.Controls.Add(this.lblApprovalNo);
            this.tabGeneral.Controls.Add(this.txtManufacturer);
            this.tabGeneral.Controls.Add(this.lblManufacturer);
            this.tabGeneral.Controls.Add(this.txtName);
            this.tabGeneral.Controls.Add(this.lblMtrName);
            this.tabGeneral.Controls.Add(this.cmbConnectMode);
            this.tabGeneral.Controls.Add(this.lblConnectMode);
            this.tabGeneral.Controls.Add(this.cmbLineType);
            this.tabGeneral.Controls.Add(this.lblLineType);
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(577, 412);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General Feature";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // grpAccuracy
            // 
            this.grpAccuracy.Controls.Add(this.cmbAccS);
            this.grpAccuracy.Controls.Add(this.chkAccS);
            this.grpAccuracy.Controls.Add(this.cmbAccQ);
            this.grpAccuracy.Controls.Add(this.chkAccQ);
            this.grpAccuracy.Controls.Add(this.cmbAccP);
            this.grpAccuracy.Controls.Add(this.chkAccP);
            this.grpAccuracy.Location = new System.Drawing.Point(295, 75);
            this.grpAccuracy.Name = "grpAccuracy";
            this.grpAccuracy.Size = new System.Drawing.Size(260, 125);
            this.grpAccuracy.TabIndex = 13;
            this.grpAccuracy.TabStop = false;
            this.grpAccuracy.Text = "Class of accuracy";
            // 
            // cmbAccS
            // 
            this.cmbAccS.FormattingEnabled = true;
            this.cmbAccS.Items.AddRange(new object[] {
            "0.2",
            "0.5",
            "1.0",
            "2.0"});
            this.cmbAccS.Location = new System.Drawing.Point(70, 90);
            this.cmbAccS.Name = "cmbAccS";
            this.cmbAccS.Size = new System.Drawing.Size(170, 23);
            this.cmbAccS.TabIndex = 5;
            // 
            // chkAccS
            // 
            this.chkAccS.AutoSize = true;
            this.chkAccS.Location = new System.Drawing.Point(20, 92);
            this.chkAccS.Name = "chkAccS";
            this.chkAccS.Size = new System.Drawing.Size(32, 19);
            this.chkAccS.TabIndex = 4;
            this.chkAccS.Text = "S";
            this.chkAccS.UseVisualStyleBackColor = true;
            // 
            // cmbAccQ
            // 
            this.cmbAccQ.FormattingEnabled = true;
            this.cmbAccQ.Items.AddRange(new object[] {
            "0.2",
            "0.5",
            "1.0",
            "2.0"});
            this.cmbAccQ.Location = new System.Drawing.Point(70, 55);
            this.cmbAccQ.Name = "cmbAccQ";
            this.cmbAccQ.Size = new System.Drawing.Size(170, 23);
            this.cmbAccQ.TabIndex = 3;
            // 
            // chkAccQ
            // 
            this.chkAccQ.AutoSize = true;
            this.chkAccQ.Location = new System.Drawing.Point(20, 57);
            this.chkAccQ.Name = "chkAccQ";
            this.chkAccQ.Size = new System.Drawing.Size(35, 19);
            this.chkAccQ.TabIndex = 2;
            this.chkAccQ.Text = "Q";
            this.chkAccQ.UseVisualStyleBackColor = true;
            // 
            // cmbAccP
            // 
            this.cmbAccP.FormattingEnabled = true;
            this.cmbAccP.Items.AddRange(new object[] {
            "0.2",
            "0.5",
            "1.0",
            "2.0"});
            this.cmbAccP.Location = new System.Drawing.Point(70, 20);
            this.cmbAccP.Name = "cmbAccP";
            this.cmbAccP.Size = new System.Drawing.Size(170, 23);
            this.cmbAccP.TabIndex = 1;
            // 
            // chkAccP
            // 
            this.chkAccP.AutoSize = true;
            this.chkAccP.Location = new System.Drawing.Point(20, 22);
            this.chkAccP.Name = "chkAccP";
            this.chkAccP.Size = new System.Drawing.Size(33, 19);
            this.chkAccP.TabIndex = 0;
            this.chkAccP.Text = "P";
            this.chkAccP.UseVisualStyleBackColor = true;
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.Controls.Add(this.rbElectronic);
            this.grpPrincipal.Controls.Add(this.rbInduction);
            this.grpPrincipal.Location = new System.Drawing.Point(20, 75);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(260, 125);
            this.grpPrincipal.TabIndex = 12;
            this.grpPrincipal.TabStop = false;
            this.grpPrincipal.Text = "Principal";
            // 
            // rbElectronic
            // 
            this.rbElectronic.AutoSize = true;
            this.rbElectronic.Checked = true;
            this.rbElectronic.Location = new System.Drawing.Point(25, 60);
            this.rbElectronic.Name = "rbElectronic";
            this.rbElectronic.Size = new System.Drawing.Size(77, 19);
            this.rbElectronic.TabIndex = 1;
            this.rbElectronic.TabStop = true;
            this.rbElectronic.Text = "Electronic";
            this.rbElectronic.UseVisualStyleBackColor = true;
            // 
            // rbInduction
            // 
            this.rbInduction.AutoSize = true;
            this.rbInduction.Location = new System.Drawing.Point(25, 30);
            this.rbInduction.Name = "rbInduction";
            this.rbInduction.Size = new System.Drawing.Size(76, 19);
            this.rbInduction.TabIndex = 0;
            this.rbInduction.Text = "Induction";
            this.rbInduction.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(295, 230);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(260, 160);
            this.txtComment.TabIndex = 11;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(295, 212);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(64, 15);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comment:";
            // 
            // txtApprovalNo
            // 
            this.txtApprovalNo.Location = new System.Drawing.Point(20, 365);
            this.txtApprovalNo.Name = "txtApprovalNo";
            this.txtApprovalNo.Size = new System.Drawing.Size(250, 23);
            this.txtApprovalNo.TabIndex = 9;
            // 
            // lblApprovalNo
            // 
            this.lblApprovalNo.AutoSize = true;
            this.lblApprovalNo.Location = new System.Drawing.Point(20, 347);
            this.lblApprovalNo.Name = "lblApprovalNo";
            this.lblApprovalNo.Size = new System.Drawing.Size(100, 15);
            this.lblApprovalNo.TabIndex = 8;
            this.lblApprovalNo.Text = "Approval number";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(20, 310);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(250, 23);
            this.txtManufacturer.TabIndex = 7;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(20, 292);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(79, 15);
            this.lblManufacturer.TabIndex = 6;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 255);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 5;
            // 
            // lblMtrName
            // 
            this.lblMtrName.AutoSize = true;
            this.lblMtrName.Location = new System.Drawing.Point(20, 237);
            this.lblMtrName.Name = "lblMtrName";
            this.lblMtrName.Size = new System.Drawing.Size(65, 15);
            this.lblMtrName.TabIndex = 4;
            this.lblMtrName.Text = "Meter type";
            // 
            // cmbConnectMode
            // 
            this.cmbConnectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConnectMode.FormattingEnabled = true;
            this.cmbConnectMode.Items.AddRange(new object[] {
            "Direct",
            "CT",
            "PT",
            "CT/PT"});
            this.cmbConnectMode.Location = new System.Drawing.Point(295, 35);
            this.cmbConnectMode.Name = "cmbConnectMode";
            this.cmbConnectMode.Size = new System.Drawing.Size(260, 23);
            this.cmbConnectMode.TabIndex = 3;
            // 
            // lblConnectMode
            // 
            this.lblConnectMode.AutoSize = true;
            this.lblConnectMode.Location = new System.Drawing.Point(295, 17);
            this.lblConnectMode.Name = "lblConnectMode";
            this.lblConnectMode.Size = new System.Drawing.Size(102, 15);
            this.lblConnectMode.TabIndex = 2;
            this.lblConnectMode.Text = "Meter connection";
            // 
            // cmbLineType
            // 
            this.cmbLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineType.FormattingEnabled = true;
            this.cmbLineType.Items.AddRange(new object[] {
            "Single-phase",
            "3-phase 3-wire",
            "3-phase 4-wire"});
            this.cmbLineType.Location = new System.Drawing.Point(20, 35);
            this.cmbLineType.Name = "cmbLineType";
            this.cmbLineType.Size = new System.Drawing.Size(260, 23);
            this.cmbLineType.TabIndex = 1;
            // 
            // lblLineType
            // 
            this.lblLineType.AutoSize = true;
            this.lblLineType.Location = new System.Drawing.Point(20, 17);
            this.lblLineType.Name = "lblLineType";
            this.lblLineType.Size = new System.Drawing.Size(56, 15);
            this.lblLineType.TabIndex = 0;
            this.lblLineType.Text = "Line type";
            // 
            // tabElectrical
            // 
            this.tabElectrical.Controls.Add(this.grpConstants);
            this.tabElectrical.Controls.Add(this.grpNominal);
            this.tabElectrical.Location = new System.Drawing.Point(4, 24);
            this.tabElectrical.Name = "tabElectrical";
            this.tabElectrical.Padding = new System.Windows.Forms.Padding(3);
            this.tabElectrical.Size = new System.Drawing.Size(577, 412);
            this.tabElectrical.TabIndex = 1;
            this.tabElectrical.Text = "Electrical Data";
            this.tabElectrical.UseVisualStyleBackColor = true;
            // 
            // grpConstants
            // 
            this.grpConstants.Controls.Add(this.btnRemoveConst);
            this.grpConstants.Controls.Add(this.btnAddConst);
            this.grpConstants.Controls.Add(this.cmbUnit);
            this.grpConstants.Controls.Add(this.lblUnit);
            this.grpConstants.Controls.Add(this.txtConst);
            this.grpConstants.Controls.Add(this.lblConst);
            this.grpConstants.Controls.Add(this.cmbMeas);
            this.grpConstants.Controls.Add(this.lblMeas);
            this.grpConstants.Controls.Add(this.cmbChan);
            this.grpConstants.Controls.Add(this.lblChan);
            this.grpConstants.Controls.Add(this.dgvConstants);
            this.grpConstants.Location = new System.Drawing.Point(15, 120);
            this.grpConstants.Name = "grpConstants";
            this.grpConstants.Size = new System.Drawing.Size(545, 275);
            this.grpConstants.TabIndex = 1;
            this.grpConstants.TabStop = false;
            this.grpConstants.Text = "Constant of channels";
            // 
            // btnRemoveConst
            // 
            this.btnRemoveConst.Location = new System.Drawing.Point(170, 225);
            this.btnRemoveConst.Name = "btnRemoveConst";
            this.btnRemoveConst.Size = new System.Drawing.Size(80, 25);
            this.btnRemoveConst.TabIndex = 10;
            this.btnRemoveConst.Text = "Remove";
            this.btnRemoveConst.UseVisualStyleBackColor = true;
            this.btnRemoveConst.Click += new System.EventHandler(this.btnRemoveConst_Click);
            // 
            // btnAddConst
            // 
            this.btnAddConst.Location = new System.Drawing.Point(75, 225);
            this.btnAddConst.Name = "btnAddConst";
            this.btnAddConst.Size = new System.Drawing.Size(80, 25);
            this.btnAddConst.TabIndex = 9;
            this.btnAddConst.Text = "Add";
            this.btnAddConst.UseVisualStyleBackColor = true;
            this.btnAddConst.Click += new System.EventHandler(this.btnAddConst_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "imp/kWh",
            "imp/kVARh",
            "imp/kVAh",
            "Wh/imp",
            "VARh/imp",
            "VAh/imp"});
            this.cmbUnit.Location = new System.Drawing.Point(100, 175);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(150, 23);
            this.cmbUnit.TabIndex = 8;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(20, 178);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 15);
            this.lblUnit.TabIndex = 7;
            this.lblUnit.Text = "Unit";
            // 
            // txtConst
            // 
            this.txtConst.Location = new System.Drawing.Point(100, 130);
            this.txtConst.Name = "txtConst";
            this.txtConst.Size = new System.Drawing.Size(150, 23);
            this.txtConst.TabIndex = 6;
            this.txtConst.Text = "1000";
            // 
            // lblConst
            // 
            this.lblConst.AutoSize = true;
            this.lblConst.Location = new System.Drawing.Point(20, 133);
            this.lblConst.Name = "lblConst";
            this.lblConst.Size = new System.Drawing.Size(55, 15);
            this.lblConst.TabIndex = 5;
            this.lblConst.Text = "Constant";
            // 
            // cmbMeas
            // 
            this.cmbMeas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeas.FormattingEnabled = true;
            this.cmbMeas.Items.AddRange(new object[] {
            "Active (P)",
            "Reactive (Q)",
            "Apparent (S)"});
            this.cmbMeas.Location = new System.Drawing.Point(100, 85);
            this.cmbMeas.Name = "cmbMeas";
            this.cmbMeas.Size = new System.Drawing.Size(150, 23);
            this.cmbMeas.TabIndex = 4;
            // 
            // lblMeas
            // 
            this.lblMeas.AutoSize = true;
            this.lblMeas.Location = new System.Drawing.Point(20, 88);
            this.lblMeas.Name = "lblMeas";
            this.lblMeas.Size = new System.Drawing.Size(80, 15);
            this.lblMeas.TabIndex = 3;
            this.lblMeas.Text = "Measurement";
            // 
            // cmbChan
            // 
            this.cmbChan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChan.FormattingEnabled = true;
            this.cmbChan.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3"});
            this.cmbChan.Location = new System.Drawing.Point(100, 40);
            this.cmbChan.Name = "cmbChan";
            this.cmbChan.Size = new System.Drawing.Size(150, 23);
            this.cmbChan.TabIndex = 2;
            // 
            // lblChan
            // 
            this.lblChan.AutoSize = true;
            this.lblChan.Location = new System.Drawing.Point(20, 43);
            this.lblChan.Name = "lblChan";
            this.lblChan.Size = new System.Drawing.Size(51, 15);
            this.lblChan.TabIndex = 1;
            this.lblChan.Text = "Channel";
            // 
            // dgvConstants
            // 
            this.dgvConstants.AllowUserToAddRows = false;
            this.dgvConstants.AllowUserToDeleteRows = false;
            this.dgvConstants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConstants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChan,
            this.colMeas,
            this.colConst,
            this.colUnit});
            this.dgvConstants.Location = new System.Drawing.Point(270, 30);
            this.dgvConstants.Name = "dgvConstants";
            this.dgvConstants.ReadOnly = true;
            this.dgvConstants.RowHeadersVisible = false;
            this.dgvConstants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConstants.Size = new System.Drawing.Size(260, 230);
            this.dgvConstants.TabIndex = 0;
            // 
            // colChan
            // 
            this.colChan.DataPropertyName = "ChannelNo";
            this.colChan.HeaderText = "Channel";
            this.colChan.Name = "colChan";
            this.colChan.ReadOnly = true;
            this.colChan.Width = 60;
            // 
            // colMeas
            // 
            this.colMeas.DataPropertyName = "Measurement";
            this.colMeas.HeaderText = "Meas";
            this.colMeas.Name = "colMeas";
            this.colMeas.ReadOnly = true;
            this.colMeas.Width = 70;
            // 
            // colConst
            // 
            this.colConst.DataPropertyName = "ConstantVal";
            this.colConst.HeaderText = "Constant";
            this.colConst.Name = "colConst";
            this.colConst.ReadOnly = true;
            this.colConst.Width = 70;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Width = 60;
            // 
            // grpNominal
            // 
            this.grpNominal.Controls.Add(this.numFreq);
            this.grpNominal.Controls.Add(this.lblFreq);
            this.grpNominal.Controls.Add(this.numImax);
            this.grpNominal.Controls.Add(this.lblImax);
            this.grpNominal.Controls.Add(this.numIb);
            this.grpNominal.Controls.Add(this.lblIb);
            this.grpNominal.Controls.Add(this.numUb);
            this.grpNominal.Controls.Add(this.lblUb);
            this.grpNominal.Location = new System.Drawing.Point(15, 15);
            this.grpNominal.Name = "grpNominal";
            this.grpNominal.Size = new System.Drawing.Size(545, 90);
            this.grpNominal.TabIndex = 0;
            this.grpNominal.TabStop = false;
            this.grpNominal.Text = "Nominal values";
            // 
            // numFreq
            // 
            this.numFreq.Location = new System.Drawing.Point(400, 38);
            this.numFreq.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numFreq.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFreq.Name = "numFreq";
            this.numFreq.Size = new System.Drawing.Size(65, 23);
            this.numFreq.TabIndex = 7;
            this.numFreq.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(355, 41);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(43, 15);
            this.lblFreq.TabIndex = 6;
            this.lblFreq.Text = "fn [Hz]";
            // 
            // numImax
            // 
            this.numImax.DecimalPlaces = 1;
            this.numImax.Location = new System.Drawing.Point(270, 38);
            this.numImax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numImax.Name = "numImax";
            this.numImax.Size = new System.Drawing.Size(65, 23);
            this.numImax.TabIndex = 5;
            this.numImax.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblImax
            // 
            this.lblImax.AutoSize = true;
            this.lblImax.Location = new System.Drawing.Point(225, 41);
            this.lblImax.Name = "lblImax";
            this.lblImax.Size = new System.Drawing.Size(41, 15);
            this.lblImax.TabIndex = 4;
            this.lblImax.Text = "Im [A]";
            // 
            // numIb
            // 
            this.numIb.DecimalPlaces = 2;
            this.numIb.Location = new System.Drawing.Point(145, 38);
            this.numIb.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numIb.Name = "numIb";
            this.numIb.Size = new System.Drawing.Size(65, 23);
            this.numIb.TabIndex = 3;
            this.numIb.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblIb
            // 
            this.lblIb.AutoSize = true;
            this.lblIb.Location = new System.Drawing.Point(110, 41);
            this.lblIb.Name = "lblIb";
            this.lblIb.Size = new System.Drawing.Size(32, 15);
            this.lblIb.TabIndex = 2;
            this.lblIb.Text = "Ib [A]";
            // 
            // numUb
            // 
            this.numUb.DecimalPlaces = 1;
            this.numUb.Location = new System.Drawing.Point(35, 38);
            this.numUb.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUb.Name = "numUb";
            this.numUb.Size = new System.Drawing.Size(65, 23);
            this.numUb.TabIndex = 1;
            this.numUb.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
            // 
            // lblUb
            // 
            this.lblUb.AutoSize = true;
            this.lblUb.Location = new System.Drawing.Point(0, 41);
            this.lblUb.Name = "lblUb";
            this.lblUb.Size = new System.Drawing.Size(37, 15);
            this.lblUb.TabIndex = 0;
            this.lblUb.Text = "Ub [V]";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(680, 465);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(780, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMeterType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tabControlMtr);
            this.Controls.Add(this.dgvMeterTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMeterType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meter Specifications Catalog";
            this.Load += new System.EventHandler(this.frmMeterType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeterTypes)).EndInit();
            this.tabControlMtr.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.grpAccuracy.ResumeLayout(false);
            this.grpAccuracy.PerformLayout();
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            this.tabElectrical.ResumeLayout(false);
            this.grpConstants.ResumeLayout(false);
            this.grpConstants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstants)).EndInit();
            this.grpNominal.ResumeLayout(false);
            this.grpNominal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeterTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.TabControl tabControlMtr;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabElectrical;
        private System.Windows.Forms.ComboBox cmbLineType;
        private System.Windows.Forms.Label lblLineType;
        private System.Windows.Forms.ComboBox cmbConnectMode;
        private System.Windows.Forms.Label lblConnectMode;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtApprovalNo;
        private System.Windows.Forms.Label lblApprovalNo;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMtrName;
        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.RadioButton rbElectronic;
        private System.Windows.Forms.RadioButton rbInduction;
        private System.Windows.Forms.GroupBox grpAccuracy;
        private System.Windows.Forms.ComboBox cmbAccS;
        private System.Windows.Forms.CheckBox chkAccS;
        private System.Windows.Forms.ComboBox cmbAccQ;
        private System.Windows.Forms.CheckBox chkAccQ;
        private System.Windows.Forms.ComboBox cmbAccP;
        private System.Windows.Forms.CheckBox chkAccP;
        private System.Windows.Forms.GroupBox grpNominal;
        private System.Windows.Forms.NumericUpDown numUb;
        private System.Windows.Forms.Label lblUb;
        private System.Windows.Forms.NumericUpDown numIb;
        private System.Windows.Forms.Label lblIb;
        private System.Windows.Forms.NumericUpDown numImax;
        private System.Windows.Forms.Label lblImax;
        private System.Windows.Forms.NumericUpDown numFreq;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.GroupBox grpConstants;
        private System.Windows.Forms.DataGridView dgvConstants;
        private System.Windows.Forms.ComboBox cmbChan;
        private System.Windows.Forms.Label lblChan;
        private System.Windows.Forms.ComboBox cmbMeas;
        private System.Windows.Forms.Label lblMeas;
        private System.Windows.Forms.TextBox txtConst;
        private System.Windows.Forms.Label lblConst;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnRemoveConst;
        private System.Windows.Forms.Button btnAddConst;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
    }
}
