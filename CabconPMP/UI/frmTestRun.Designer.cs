namespace CabconPMP.UI
{
    partial class frmTestRun
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
            this.lblBenchName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtMaxRH = new System.Windows.Forms.TextBox();
            this.lblMaxRH = new System.Windows.Forms.Label();
            this.txtMinRH = new System.Windows.Forms.TextBox();
            this.lblMinRH = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.txtDateRun = new System.Windows.Forms.TextBox();
            this.lblDateRun = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.txtSequenceName = new System.Windows.Forms.TextBox();
            this.lblSequenceName = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabDevices = new System.Windows.Forms.TabPage();
            this.grpDeviceInputs = new System.Windows.Forms.GroupBox();
            this.btnDeleteDevice = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.cmbClientNo = new System.Windows.Forms.ComboBox();
            this.lblClientNo = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbContractNo = new System.Windows.Forms.ComboBox();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.txtLastApproval = new System.Windows.Forms.TextBox();
            this.lblLastApproval = new System.Windows.Forms.Label();
            this.txtYearOfManufacture = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtStepOwnerNo = new System.Windows.Forms.TextBox();
            this.lblStepOwner = new System.Windows.Forms.Label();
            this.txtOwnerNo = new System.Windows.Forms.TextBox();
            this.lblOwnerNo = new System.Windows.Forms.Label();
            this.txtStepMSN = new System.Windows.Forms.TextBox();
            this.lblStepMSN = new System.Windows.Forms.Label();
            this.txtMSN = new System.Windows.Forms.TextBox();
            this.lblMSN = new System.Windows.Forms.Label();
            this.cmbMeterType = new System.Windows.Forms.ComboBox();
            this.lblMeterType = new System.Windows.Forms.Label();
            this.txtPositions = new System.Windows.Forms.TextBox();
            this.lblPositions = new System.Windows.Forms.Label();
            this.dgvMeters = new System.Windows.Forms.DataGridView();
            this.tabSequence = new System.Windows.Forms.TabPage();
            this.lblReset = new System.Windows.Forms.Button();
            this.lblDisplayParaTotalSelected = new System.Windows.Forms.Label();
            this.btnDispAutoMoveDown = new System.Windows.Forms.Button();
            this.btnDispAutoMoveUP = new System.Windows.Forms.Button();
            this.btnDispAutoMove = new System.Windows.Forms.Button();
            this.btnDispAutoRemove = new System.Windows.Forms.Button();
            this.btnDispAutoRemoveAll = new System.Windows.Forms.Button();
            this.btnDispAutoMoveAll = new System.Windows.Forms.Button();
            this.lstDisplatAutoSelected = new System.Windows.Forms.ListBox();
            this.lblSelectedSteps = new System.Windows.Forms.Label();
            this.lstAvailableProcedures = new System.Windows.Forms.ListBox();
            this.lblAvailableProcs = new System.Windows.Forms.Label();
            this.tabExecute = new System.Windows.Forms.TabPage();
            this.grpLiveTelemetry = new System.Windows.Forms.GroupBox();
            this.lblMonFreq = new System.Windows.Forms.Label();
            this.txtMonPhiC = new System.Windows.Forms.TextBox();
            this.txtMonPhiB = new System.Windows.Forms.TextBox();
            this.txtMonPhiA = new System.Windows.Forms.TextBox();
            this.txtMonIC = new System.Windows.Forms.TextBox();
            this.txtMonIB = new System.Windows.Forms.TextBox();
            this.txtMonIA = new System.Windows.Forms.TextBox();
            this.lblLiveI = new System.Windows.Forms.Label();
            this.txtMonUC = new System.Windows.Forms.TextBox();
            this.txtMonUB = new System.Windows.Forms.TextBox();
            this.txtMonUA = new System.Windows.Forms.TextBox();
            this.lblLiveU = new System.Windows.Forms.Label();
            this.lblPhaseC = new System.Windows.Forms.Label();
            this.lblPhaseB = new System.Windows.Forms.Label();
            this.lblPhaseA = new System.Windows.Forms.Label();
            this.grpEnvValues = new System.Windows.Forms.GroupBox();
            this.txtEnvHumidity = new System.Windows.Forms.TextBox();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.txtEnvTemp = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.grpActualPower = new System.Windows.Forms.GroupBox();
            this.txtTotalS = new System.Windows.Forms.TextBox();
            this.lblTotalS = new System.Windows.Forms.Label();
            this.txtTotalQ = new System.Windows.Forms.TextBox();
            this.lblTotalQ = new System.Windows.Forms.Label();
            this.txtTotalP = new System.Windows.Forms.TextBox();
            this.lblTotalP = new System.Windows.Forms.Label();
            this.grpRangeLimits = new System.Windows.Forms.GroupBox();
            this.lblRangeLimits = new System.Windows.Forms.Label();
            this.grpBaseValues = new System.Windows.Forms.GroupBox();
            this.txtBaseIm = new System.Windows.Forms.TextBox();
            this.lblBaseIm = new System.Windows.Forms.Label();
            this.txtBaseFreq = new System.Windows.Forms.TextBox();
            this.lblBaseFreq = new System.Windows.Forms.Label();
            this.txtBaseIb = new System.Windows.Forms.TextBox();
            this.lblBaseIb = new System.Windows.Forms.Label();
            this.txtBaseUb = new System.Windows.Forms.TextBox();
            this.lblBaseUb = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.lblSingleStep = new System.Windows.Forms.Label();
            this.dgvExecuteSteps = new System.Windows.Forms.DataGridView();
            this.lblExeSteps = new System.Windows.Forms.Label();
            this.lstOverview = new System.Windows.Forms.ListBox();
            this.lblOverview = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.lblLogs = new System.Windows.Forms.Label();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.cmbWhatMeter = new System.Windows.Forms.ComboBox();
            this.lblWhatMeter = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExportResults = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tabDevices.SuspendLayout();
            this.grpDeviceInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeters)).BeginInit();
            this.tabSequence.SuspendLayout();
            this.tabExecute.SuspendLayout();
            this.grpLiveTelemetry.SuspendLayout();
            this.grpEnvValues.SuspendLayout();
            this.grpActualPower.SuspendLayout();
            this.grpRangeLimits.SuspendLayout();
            this.grpBaseValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecuteSteps)).BeginInit();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBenchName
            // 
            this.lblBenchName.AutoSize = true;
            this.lblBenchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBenchName.Location = new System.Drawing.Point(10, 8);
            this.lblBenchName.Name = "lblBenchName";
            this.lblBenchName.Size = new System.Drawing.Size(123, 21);
            this.lblBenchName.TabIndex = 0;
            this.lblBenchName.Text = "Bench Name ...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCommon);
            this.tabControl1.Controls.Add(this.tabDevices);
            this.tabControl1.Controls.Add(this.tabSequence);
            this.tabControl1.Controls.Add(this.tabExecute);
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Location = new System.Drawing.Point(10, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 451);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCommon
            // 
            this.tabCommon.Controls.Add(this.txtComment);
            this.tabCommon.Controls.Add(this.lblComment);
            this.tabCommon.Controls.Add(this.txtMaxRH);
            this.tabCommon.Controls.Add(this.lblMaxRH);
            this.tabCommon.Controls.Add(this.txtMinRH);
            this.tabCommon.Controls.Add(this.lblMinRH);
            this.tabCommon.Controls.Add(this.txtMaxTemp);
            this.tabCommon.Controls.Add(this.lblMaxTemp);
            this.tabCommon.Controls.Add(this.txtMinTemp);
            this.tabCommon.Controls.Add(this.lblMinTemp);
            this.tabCommon.Controls.Add(this.txtDateRun);
            this.tabCommon.Controls.Add(this.lblDateRun);
            this.tabCommon.Controls.Add(this.txtOperator);
            this.tabCommon.Controls.Add(this.lblOperator);
            this.tabCommon.Controls.Add(this.txtSupervisor);
            this.tabCommon.Controls.Add(this.lblSupervisor);
            this.tabCommon.Controls.Add(this.txtSequenceName);
            this.tabCommon.Controls.Add(this.lblSequenceName);
            this.tabCommon.Controls.Add(this.txtStatus);
            this.tabCommon.Controls.Add(this.lblStatus);
            this.tabCommon.Location = new System.Drawing.Point(4, 22);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(729, 425);
            this.tabCommon.TabIndex = 0;
            this.tabCommon.Text = "Common properties";
            this.tabCommon.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(377, 35);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(335, 209);
            this.txtComment.TabIndex = 19;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(377, 17);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 18;
            this.lblComment.Text = "Comment";
            // 
            // txtMaxRH
            // 
            this.txtMaxRH.Location = new System.Drawing.Point(270, 152);
            this.txtMaxRH.Name = "txtMaxRH";
            this.txtMaxRH.Size = new System.Drawing.Size(78, 20);
            this.txtMaxRH.TabIndex = 17;
            this.txtMaxRH.Text = "55.0";
            // 
            // lblMaxRH
            // 
            this.lblMaxRH.AutoSize = true;
            this.lblMaxRH.Location = new System.Drawing.Point(270, 134);
            this.lblMaxRH.Name = "lblMaxRH";
            this.lblMaxRH.Size = new System.Drawing.Size(33, 13);
            this.lblMaxRH.TabIndex = 16;
            this.lblMaxRH.Text = "Max. ";
            // 
            // txtMinRH
            // 
            this.txtMinRH.Location = new System.Drawing.Point(184, 152);
            this.txtMinRH.Name = "txtMinRH";
            this.txtMinRH.Size = new System.Drawing.Size(78, 20);
            this.txtMinRH.TabIndex = 15;
            this.txtMinRH.Text = "45.0";
            // 
            // lblMinRH
            // 
            this.lblMinRH.AutoSize = true;
            this.lblMinRH.Location = new System.Drawing.Point(184, 134);
            this.lblMinRH.Name = "lblMinRH";
            this.lblMinRH.Size = new System.Drawing.Size(84, 13);
            this.lblMinRH.TabIndex = 14;
            this.lblMinRH.Text = "Rel. humidity [%]";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(99, 152);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(78, 20);
            this.txtMaxTemp.TabIndex = 13;
            this.txtMaxTemp.Text = "25.0";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(99, 134);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(30, 13);
            this.lblMaxTemp.TabIndex = 12;
            this.lblMaxTemp.Text = "Max.";
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(13, 152);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(78, 20);
            this.txtMinTemp.TabIndex = 11;
            this.txtMinTemp.Text = "23.0";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(13, 134);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(104, 13);
            this.lblMinTemp.TabIndex = 10;
            this.lblMinTemp.Text = "Temperature [deg C]";
            // 
            // txtDateRun
            // 
            this.txtDateRun.Location = new System.Drawing.Point(184, 95);
            this.txtDateRun.Name = "txtDateRun";
            this.txtDateRun.ReadOnly = true;
            this.txtDateRun.Size = new System.Drawing.Size(163, 20);
            this.txtDateRun.TabIndex = 9;
            // 
            // lblDateRun
            // 
            this.lblDateRun.AutoSize = true;
            this.lblDateRun.Location = new System.Drawing.Point(184, 78);
            this.lblDateRun.Name = "lblDateRun";
            this.lblDateRun.Size = new System.Drawing.Size(52, 13);
            this.lblDateRun.TabIndex = 8;
            this.lblDateRun.Text = "Test date";
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(184, 208);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(163, 20);
            this.txtOperator.TabIndex = 7;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(184, 191);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(48, 13);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "Operator";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(13, 208);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(163, 20);
            this.txtSupervisor.TabIndex = 5;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(13, 191);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(57, 13);
            this.lblSupervisor.TabIndex = 4;
            this.lblSupervisor.Text = "Supervisor";
            // 
            // txtSequenceName
            // 
            this.txtSequenceName.Location = new System.Drawing.Point(13, 35);
            this.txtSequenceName.Name = "txtSequenceName";
            this.txtSequenceName.Size = new System.Drawing.Size(335, 20);
            this.txtSequenceName.TabIndex = 3;
            // 
            // lblSequenceName
            // 
            this.lblSequenceName.AutoSize = true;
            this.lblSequenceName.Location = new System.Drawing.Point(13, 17);
            this.lblSequenceName.Name = "lblSequenceName";
            this.lblSequenceName.Size = new System.Drawing.Size(78, 13);
            this.lblSequenceName.TabIndex = 2;
            this.lblSequenceName.Text = "Test sequence";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(13, 95);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(163, 20);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "New Run";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 78);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "State";
            // 
            // tabDevices
            // 
            this.tabDevices.Controls.Add(this.grpDeviceInputs);
            this.tabDevices.Controls.Add(this.dgvMeters);
            this.tabDevices.Location = new System.Drawing.Point(4, 22);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevices.Size = new System.Drawing.Size(729, 425);
            this.tabDevices.TabIndex = 1;
            this.tabDevices.Text = "Test devices";
            this.tabDevices.UseVisualStyleBackColor = true;
            // 
            // grpDeviceInputs
            // 
            this.grpDeviceInputs.Controls.Add(this.btnDeleteDevice);
            this.grpDeviceInputs.Controls.Add(this.btnAddDevice);
            this.grpDeviceInputs.Controls.Add(this.cmbClientNo);
            this.grpDeviceInputs.Controls.Add(this.lblClientNo);
            this.grpDeviceInputs.Controls.Add(this.cmbClient);
            this.grpDeviceInputs.Controls.Add(this.lblClient);
            this.grpDeviceInputs.Controls.Add(this.cmbContractNo);
            this.grpDeviceInputs.Controls.Add(this.lblContractNo);
            this.grpDeviceInputs.Controls.Add(this.txtLastApproval);
            this.grpDeviceInputs.Controls.Add(this.lblLastApproval);
            this.grpDeviceInputs.Controls.Add(this.txtYearOfManufacture);
            this.grpDeviceInputs.Controls.Add(this.lblYear);
            this.grpDeviceInputs.Controls.Add(this.txtStepOwnerNo);
            this.grpDeviceInputs.Controls.Add(this.lblStepOwner);
            this.grpDeviceInputs.Controls.Add(this.txtOwnerNo);
            this.grpDeviceInputs.Controls.Add(this.lblOwnerNo);
            this.grpDeviceInputs.Controls.Add(this.txtStepMSN);
            this.grpDeviceInputs.Controls.Add(this.lblStepMSN);
            this.grpDeviceInputs.Controls.Add(this.txtMSN);
            this.grpDeviceInputs.Controls.Add(this.lblMSN);
            this.grpDeviceInputs.Controls.Add(this.cmbMeterType);
            this.grpDeviceInputs.Controls.Add(this.lblMeterType);
            this.grpDeviceInputs.Controls.Add(this.txtPositions);
            this.grpDeviceInputs.Controls.Add(this.lblPositions);
            this.grpDeviceInputs.Location = new System.Drawing.Point(9, 4);
            this.grpDeviceInputs.Name = "grpDeviceInputs";
            this.grpDeviceInputs.Size = new System.Drawing.Size(711, 175);
            this.grpDeviceInputs.TabIndex = 0;
            this.grpDeviceInputs.TabStop = false;
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.Location = new System.Drawing.Point(594, 143);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(103, 24);
            this.btnDeleteDevice.TabIndex = 23;
            this.btnDeleteDevice.Text = "Delete";
            this.btnDeleteDevice.UseVisualStyleBackColor = true;
            this.btnDeleteDevice.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(473, 143);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(103, 24);
            this.btnAddDevice.TabIndex = 22;
            this.btnAddDevice.Text = "Add";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // cmbClientNo
            // 
            this.cmbClientNo.FormattingEnabled = true;
            this.cmbClientNo.Location = new System.Drawing.Point(529, 103);
            this.cmbClientNo.Name = "cmbClientNo";
            this.cmbClientNo.Size = new System.Drawing.Size(168, 21);
            this.cmbClientNo.TabIndex = 21;
            // 
            // lblClientNo
            // 
            this.lblClientNo.AutoSize = true;
            this.lblClientNo.Location = new System.Drawing.Point(457, 110);
            this.lblClientNo.Name = "lblClientNo";
            this.lblClientNo.Size = new System.Drawing.Size(58, 13);
            this.lblClientNo.TabIndex = 20;
            this.lblClientNo.Text = "Clients No.";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(529, 76);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(168, 21);
            this.cmbClient.TabIndex = 19;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(482, 79);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 18;
            this.lblClient.Text = "Client";
            // 
            // cmbContractNo
            // 
            this.cmbContractNo.FormattingEnabled = true;
            this.cmbContractNo.Location = new System.Drawing.Point(529, 46);
            this.cmbContractNo.Name = "cmbContractNo";
            this.cmbContractNo.Size = new System.Drawing.Size(168, 21);
            this.cmbContractNo.TabIndex = 17;
            // 
            // lblContractNo
            // 
            this.lblContractNo.AutoSize = true;
            this.lblContractNo.Location = new System.Drawing.Point(448, 50);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(67, 13);
            this.lblContractNo.TabIndex = 16;
            this.lblContractNo.Text = "Contract No.";
            // 
            // txtLastApproval
            // 
            this.txtLastApproval.Location = new System.Drawing.Point(315, 103);
            this.txtLastApproval.Name = "txtLastApproval";
            this.txtLastApproval.Size = new System.Drawing.Size(121, 20);
            this.txtLastApproval.TabIndex = 15;
            this.txtLastApproval.Text = "None";
            // 
            // lblLastApproval
            // 
            this.lblLastApproval.AutoSize = true;
            this.lblLastApproval.Location = new System.Drawing.Point(238, 106);
            this.lblLastApproval.Name = "lblLastApproval";
            this.lblLastApproval.Size = new System.Drawing.Size(71, 13);
            this.lblLastApproval.TabIndex = 14;
            this.lblLastApproval.Text = "Last approval";
            // 
            // txtYearOfManufacture
            // 
            this.txtYearOfManufacture.Location = new System.Drawing.Point(114, 103);
            this.txtYearOfManufacture.Name = "txtYearOfManufacture";
            this.txtYearOfManufacture.Size = new System.Drawing.Size(103, 20);
            this.txtYearOfManufacture.TabIndex = 13;
            this.txtYearOfManufacture.Text = "2026";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 105);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(104, 13);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year of Manufacture";
            // 
            // txtStepOwnerNo
            // 
            this.txtStepOwnerNo.Location = new System.Drawing.Point(315, 76);
            this.txtStepOwnerNo.Name = "txtStepOwnerNo";
            this.txtStepOwnerNo.Size = new System.Drawing.Size(43, 20);
            this.txtStepOwnerNo.TabIndex = 11;
            // 
            // lblStepOwner
            // 
            this.lblStepOwner.AutoSize = true;
            this.lblStepOwner.Location = new System.Drawing.Point(280, 79);
            this.lblStepOwner.Name = "lblStepOwner";
            this.lblStepOwner.Size = new System.Drawing.Size(29, 13);
            this.lblStepOwner.TabIndex = 10;
            this.lblStepOwner.Text = "Step";
            // 
            // txtOwnerNo
            // 
            this.txtOwnerNo.Location = new System.Drawing.Point(114, 76);
            this.txtOwnerNo.Name = "txtOwnerNo";
            this.txtOwnerNo.Size = new System.Drawing.Size(103, 20);
            this.txtOwnerNo.TabIndex = 9;
            // 
            // lblOwnerNo
            // 
            this.lblOwnerNo.AutoSize = true;
            this.lblOwnerNo.Location = new System.Drawing.Point(47, 79);
            this.lblOwnerNo.Name = "lblOwnerNo";
            this.lblOwnerNo.Size = new System.Drawing.Size(63, 13);
            this.lblOwnerNo.TabIndex = 8;
            this.lblOwnerNo.Text = "Owners No.";
            // 
            // txtStepMSN
            // 
            this.txtStepMSN.Location = new System.Drawing.Point(315, 47);
            this.txtStepMSN.Name = "txtStepMSN";
            this.txtStepMSN.Size = new System.Drawing.Size(43, 20);
            this.txtStepMSN.TabIndex = 7;
            // 
            // lblStepMSN
            // 
            this.lblStepMSN.AutoSize = true;
            this.lblStepMSN.Location = new System.Drawing.Point(280, 50);
            this.lblStepMSN.Name = "lblStepMSN";
            this.lblStepMSN.Size = new System.Drawing.Size(29, 13);
            this.lblStepMSN.TabIndex = 6;
            this.lblStepMSN.Text = "Step";
            // 
            // txtMSN
            // 
            this.txtMSN.Location = new System.Drawing.Point(114, 47);
            this.txtMSN.Name = "txtMSN";
            this.txtMSN.Size = new System.Drawing.Size(103, 20);
            this.txtMSN.TabIndex = 5;
            // 
            // lblMSN
            // 
            this.lblMSN.AutoSize = true;
            this.lblMSN.Location = new System.Drawing.Point(15, 54);
            this.lblMSN.Name = "lblMSN";
            this.lblMSN.Size = new System.Drawing.Size(95, 13);
            this.lblMSN.TabIndex = 4;
            this.lblMSN.Text = "Manufacturing No.";
            // 
            // cmbMeterType
            // 
            this.cmbMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeterType.FormattingEnabled = true;
            this.cmbMeterType.Location = new System.Drawing.Point(315, 16);
            this.cmbMeterType.Name = "cmbMeterType";
            this.cmbMeterType.Size = new System.Drawing.Size(382, 21);
            this.cmbMeterType.TabIndex = 3;
            // 
            // lblMeterType
            // 
            this.lblMeterType.AutoSize = true;
            this.lblMeterType.Location = new System.Drawing.Point(252, 24);
            this.lblMeterType.Name = "lblMeterType";
            this.lblMeterType.Size = new System.Drawing.Size(57, 13);
            this.lblMeterType.TabIndex = 2;
            this.lblMeterType.Text = "Meter type";
            // 
            // txtPositions
            // 
            this.txtPositions.Location = new System.Drawing.Point(114, 21);
            this.txtPositions.Name = "txtPositions";
            this.txtPositions.Size = new System.Drawing.Size(103, 20);
            this.txtPositions.TabIndex = 1;
            // 
            // lblPositions
            // 
            this.lblPositions.AutoSize = true;
            this.lblPositions.Location = new System.Drawing.Point(44, 28);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(64, 13);
            this.lblPositions.TabIndex = 0;
            this.lblPositions.Text = "Position No.";
            // 
            // dgvMeters
            // 
            this.dgvMeters.AllowUserToAddRows = false;
            this.dgvMeters.AllowUserToDeleteRows = false;
            this.dgvMeters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeters.Location = new System.Drawing.Point(9, 185);
            this.dgvMeters.Name = "dgvMeters";
            this.dgvMeters.RowHeadersVisible = false;
            this.dgvMeters.Size = new System.Drawing.Size(711, 236);
            this.dgvMeters.TabIndex = 1;
            // 
            // tabSequence
            // 
            this.tabSequence.Controls.Add(this.lblReset);
            this.tabSequence.Controls.Add(this.lblDisplayParaTotalSelected);
            this.tabSequence.Controls.Add(this.btnDispAutoMoveDown);
            this.tabSequence.Controls.Add(this.btnDispAutoMoveUP);
            this.tabSequence.Controls.Add(this.btnDispAutoMove);
            this.tabSequence.Controls.Add(this.btnDispAutoRemove);
            this.tabSequence.Controls.Add(this.btnDispAutoRemoveAll);
            this.tabSequence.Controls.Add(this.btnDispAutoMoveAll);
            this.tabSequence.Controls.Add(this.lstDisplatAutoSelected);
            this.tabSequence.Controls.Add(this.lblSelectedSteps);
            this.tabSequence.Controls.Add(this.lstAvailableProcedures);
            this.tabSequence.Controls.Add(this.lblAvailableProcs);
            this.tabSequence.Location = new System.Drawing.Point(4, 22);
            this.tabSequence.Name = "tabSequence";
            this.tabSequence.Size = new System.Drawing.Size(729, 425);
            this.tabSequence.TabIndex = 2;
            this.tabSequence.Text = "Sequence of test procedures";
            this.tabSequence.UseVisualStyleBackColor = true;
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(329, 70);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(50, 28);
            this.lblReset.TabIndex = 53;
            this.lblReset.Text = "Reset";
            this.lblReset.UseVisualStyleBackColor = true;
            this.lblReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDisplayParaTotalSelected
            // 
            this.lblDisplayParaTotalSelected.AutoSize = true;
            this.lblDisplayParaTotalSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayParaTotalSelected.Location = new System.Drawing.Point(316, 298);
            this.lblDisplayParaTotalSelected.Name = "lblDisplayParaTotalSelected";
            this.lblDisplayParaTotalSelected.Size = new System.Drawing.Size(77, 12);
            this.lblDisplayParaTotalSelected.TabIndex = 51;
            this.lblDisplayParaTotalSelected.Text = "Total Selected";
            // 
            // btnDispAutoMoveDown
            // 
            this.btnDispAutoMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveDown.Location = new System.Drawing.Point(358, 240);
            this.btnDispAutoMoveDown.Name = "btnDispAutoMoveDown";
            this.btnDispAutoMoveDown.Size = new System.Drawing.Size(20, 46);
            this.btnDispAutoMoveDown.TabIndex = 50;
            this.btnDispAutoMoveDown.Text = "v";
            this.btnDispAutoMoveDown.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveDown.Click += new System.EventHandler(this.btnDispAutoMoveDown_Click);
            // 
            // btnDispAutoMoveUP
            // 
            this.btnDispAutoMoveUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveUP.Location = new System.Drawing.Point(328, 240);
            this.btnDispAutoMoveUP.Name = "btnDispAutoMoveUP";
            this.btnDispAutoMoveUP.Size = new System.Drawing.Size(20, 46);
            this.btnDispAutoMoveUP.TabIndex = 49;
            this.btnDispAutoMoveUP.Text = "^";
            this.btnDispAutoMoveUP.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveUP.Click += new System.EventHandler(this.btnDispAutoMoveUP_Click);
            // 
            // btnDispAutoMove
            // 
            this.btnDispAutoMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMove.Location = new System.Drawing.Point(329, 104);
            this.btnDispAutoMove.Name = "btnDispAutoMove";
            this.btnDispAutoMove.Size = new System.Drawing.Size(50, 28);
            this.btnDispAutoMove.TabIndex = 46;
            this.btnDispAutoMove.Text = ">";
            this.btnDispAutoMove.UseVisualStyleBackColor = true;
            this.btnDispAutoMove.Click += new System.EventHandler(this.btnDispAutoMove_Click);
            // 
            // btnDispAutoRemove
            // 
            this.btnDispAutoRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoRemove.Location = new System.Drawing.Point(329, 172);
            this.btnDispAutoRemove.Name = "btnDispAutoRemove";
            this.btnDispAutoRemove.Size = new System.Drawing.Size(50, 28);
            this.btnDispAutoRemove.TabIndex = 47;
            this.btnDispAutoRemove.Text = "<";
            this.btnDispAutoRemove.UseVisualStyleBackColor = true;
            this.btnDispAutoRemove.Click += new System.EventHandler(this.btnDispAutoRemove_Click);
            // 
            // btnDispAutoRemoveAll
            // 
            this.btnDispAutoRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoRemoveAll.Location = new System.Drawing.Point(328, 206);
            this.btnDispAutoRemoveAll.Name = "btnDispAutoRemoveAll";
            this.btnDispAutoRemoveAll.Size = new System.Drawing.Size(50, 28);
            this.btnDispAutoRemoveAll.TabIndex = 48;
            this.btnDispAutoRemoveAll.Text = "<<";
            this.btnDispAutoRemoveAll.UseVisualStyleBackColor = true;
            this.btnDispAutoRemoveAll.Click += new System.EventHandler(this.btnDispAutoRemoveAll_Click);
            // 
            // btnDispAutoMoveAll
            // 
            this.btnDispAutoMoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveAll.Location = new System.Drawing.Point(329, 138);
            this.btnDispAutoMoveAll.Name = "btnDispAutoMoveAll";
            this.btnDispAutoMoveAll.Size = new System.Drawing.Size(50, 28);
            this.btnDispAutoMoveAll.TabIndex = 45;
            this.btnDispAutoMoveAll.Text = ">>";
            this.btnDispAutoMoveAll.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveAll.Click += new System.EventHandler(this.btnDispAutoMoveAll_Click);
            // 
            // lstDisplatAutoSelected
            // 
            this.lstDisplatAutoSelected.FormattingEnabled = true;
            this.lstDisplatAutoSelected.Location = new System.Drawing.Point(425, 35);
            this.lstDisplatAutoSelected.Name = "lstDisplatAutoSelected";
            this.lstDisplatAutoSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDisplatAutoSelected.Size = new System.Drawing.Size(292, 381);
            this.lstDisplatAutoSelected.TabIndex = 9;
            // 
            // lblSelectedSteps
            // 
            this.lblSelectedSteps.AutoSize = true;
            this.lblSelectedSteps.Location = new System.Drawing.Point(422, 19);
            this.lblSelectedSteps.Name = "lblSelectedSteps";
            this.lblSelectedSteps.Size = new System.Drawing.Size(130, 13);
            this.lblSelectedSteps.TabIndex = 2;
            this.lblSelectedSteps.Text = "Selected Test Procedures";
            // 
            // lstAvailableProcedures
            // 
            this.lstAvailableProcedures.FormattingEnabled = true;
            this.lstAvailableProcedures.Location = new System.Drawing.Point(9, 35);
            this.lstAvailableProcedures.Name = "lstAvailableProcedures";
            this.lstAvailableProcedures.Size = new System.Drawing.Size(272, 381);
            this.lstAvailableProcedures.TabIndex = 1;
            // 
            // lblAvailableProcs
            // 
            this.lblAvailableProcs.AutoSize = true;
            this.lblAvailableProcs.Location = new System.Drawing.Point(9, 17);
            this.lblAvailableProcs.Name = "lblAvailableProcs";
            this.lblAvailableProcs.Size = new System.Drawing.Size(131, 13);
            this.lblAvailableProcs.TabIndex = 0;
            this.lblAvailableProcs.Text = "Available Test Procedures";
            // 
            // tabExecute
            // 
            this.tabExecute.Controls.Add(this.grpLiveTelemetry);
            this.tabExecute.Controls.Add(this.grpEnvValues);
            this.tabExecute.Controls.Add(this.grpActualPower);
            this.tabExecute.Controls.Add(this.grpRangeLimits);
            this.tabExecute.Controls.Add(this.grpBaseValues);
            this.tabExecute.Controls.Add(this.btnStop);
            this.tabExecute.Controls.Add(this.btnPause);
            this.tabExecute.Controls.Add(this.btnStart);
            this.tabExecute.Controls.Add(this.cmbStep);
            this.tabExecute.Controls.Add(this.lblSingleStep);
            this.tabExecute.Controls.Add(this.dgvExecuteSteps);
            this.tabExecute.Controls.Add(this.lblExeSteps);
            this.tabExecute.Controls.Add(this.lstOverview);
            this.tabExecute.Controls.Add(this.lblOverview);
            this.tabExecute.Controls.Add(this.txtLogs);
            this.tabExecute.Controls.Add(this.lblLogs);
            this.tabExecute.Location = new System.Drawing.Point(4, 22);
            this.tabExecute.Name = "tabExecute";
            this.tabExecute.Size = new System.Drawing.Size(729, 425);
            this.tabExecute.TabIndex = 3;
            this.tabExecute.Text = "Execute";
            this.tabExecute.UseVisualStyleBackColor = true;
            // 
            // grpLiveTelemetry
            // 
            this.grpLiveTelemetry.Controls.Add(this.lblMonFreq);
            this.grpLiveTelemetry.Controls.Add(this.txtMonPhiC);
            this.grpLiveTelemetry.Controls.Add(this.txtMonPhiB);
            this.grpLiveTelemetry.Controls.Add(this.txtMonPhiA);
            this.grpLiveTelemetry.Controls.Add(this.txtMonIC);
            this.grpLiveTelemetry.Controls.Add(this.txtMonIB);
            this.grpLiveTelemetry.Controls.Add(this.txtMonIA);
            this.grpLiveTelemetry.Controls.Add(this.lblLiveI);
            this.grpLiveTelemetry.Controls.Add(this.txtMonUC);
            this.grpLiveTelemetry.Controls.Add(this.txtMonUB);
            this.grpLiveTelemetry.Controls.Add(this.txtMonUA);
            this.grpLiveTelemetry.Controls.Add(this.lblLiveU);
            this.grpLiveTelemetry.Controls.Add(this.lblPhaseC);
            this.grpLiveTelemetry.Controls.Add(this.lblPhaseB);
            this.grpLiveTelemetry.Controls.Add(this.lblPhaseA);
            this.grpLiveTelemetry.Location = new System.Drawing.Point(467, 69);
            this.grpLiveTelemetry.Name = "grpLiveTelemetry";
            this.grpLiveTelemetry.Size = new System.Drawing.Size(253, 108);
            this.grpLiveTelemetry.TabIndex = 11;
            this.grpLiveTelemetry.TabStop = false;
            this.grpLiveTelemetry.Text = "Monitor";
            // 
            // lblMonFreq
            // 
            this.lblMonFreq.AutoSize = true;
            this.lblMonFreq.Location = new System.Drawing.Point(193, 20);
            this.lblMonFreq.Name = "lblMonFreq";
            this.lblMonFreq.Size = new System.Drawing.Size(52, 13);
            this.lblMonFreq.TabIndex = 14;
            this.lblMonFreq.Text = " Phi [deg]";
            // 
            // txtMonPhiC
            // 
            this.txtMonPhiC.Location = new System.Drawing.Point(197, 85);
            this.txtMonPhiC.Name = "txtMonPhiC";
            this.txtMonPhiC.ReadOnly = true;
            this.txtMonPhiC.Size = new System.Drawing.Size(48, 20);
            this.txtMonPhiC.TabIndex = 13;
            // 
            // txtMonPhiB
            // 
            this.txtMonPhiB.Location = new System.Drawing.Point(197, 64);
            this.txtMonPhiB.Name = "txtMonPhiB";
            this.txtMonPhiB.ReadOnly = true;
            this.txtMonPhiB.Size = new System.Drawing.Size(48, 20);
            this.txtMonPhiB.TabIndex = 12;
            // 
            // txtMonPhiA
            // 
            this.txtMonPhiA.Location = new System.Drawing.Point(197, 42);
            this.txtMonPhiA.Name = "txtMonPhiA";
            this.txtMonPhiA.ReadOnly = true;
            this.txtMonPhiA.Size = new System.Drawing.Size(48, 20);
            this.txtMonPhiA.TabIndex = 11;
            // 
            // txtMonIC
            // 
            this.txtMonIC.Location = new System.Drawing.Point(115, 82);
            this.txtMonIC.Name = "txtMonIC";
            this.txtMonIC.ReadOnly = true;
            this.txtMonIC.Size = new System.Drawing.Size(48, 20);
            this.txtMonIC.TabIndex = 9;
            // 
            // txtMonIB
            // 
            this.txtMonIB.Location = new System.Drawing.Point(115, 61);
            this.txtMonIB.Name = "txtMonIB";
            this.txtMonIB.ReadOnly = true;
            this.txtMonIB.Size = new System.Drawing.Size(48, 20);
            this.txtMonIB.TabIndex = 8;
            // 
            // txtMonIA
            // 
            this.txtMonIA.Location = new System.Drawing.Point(115, 39);
            this.txtMonIA.Name = "txtMonIA";
            this.txtMonIA.ReadOnly = true;
            this.txtMonIA.Size = new System.Drawing.Size(48, 20);
            this.txtMonIA.TabIndex = 7;
            // 
            // lblLiveI
            // 
            this.lblLiveI.AutoSize = true;
            this.lblLiveI.Location = new System.Drawing.Point(126, 20);
            this.lblLiveI.Name = "lblLiveI";
            this.lblLiveI.Size = new System.Drawing.Size(26, 13);
            this.lblLiveI.TabIndex = 6;
            this.lblLiveI.Text = "I [A]";
            // 
            // txtMonUC
            // 
            this.txtMonUC.Location = new System.Drawing.Point(39, 82);
            this.txtMonUC.Name = "txtMonUC";
            this.txtMonUC.ReadOnly = true;
            this.txtMonUC.Size = new System.Drawing.Size(48, 20);
            this.txtMonUC.TabIndex = 5;
            // 
            // txtMonUB
            // 
            this.txtMonUB.Location = new System.Drawing.Point(39, 61);
            this.txtMonUB.Name = "txtMonUB";
            this.txtMonUB.ReadOnly = true;
            this.txtMonUB.Size = new System.Drawing.Size(48, 20);
            this.txtMonUB.TabIndex = 4;
            // 
            // txtMonUA
            // 
            this.txtMonUA.Location = new System.Drawing.Point(39, 39);
            this.txtMonUA.Name = "txtMonUA";
            this.txtMonUA.ReadOnly = true;
            this.txtMonUA.Size = new System.Drawing.Size(48, 20);
            this.txtMonUA.TabIndex = 3;
            // 
            // lblLiveU
            // 
            this.lblLiveU.AutoSize = true;
            this.lblLiveU.Location = new System.Drawing.Point(39, 20);
            this.lblLiveU.Name = "lblLiveU";
            this.lblLiveU.Size = new System.Drawing.Size(31, 13);
            this.lblLiveU.TabIndex = 2;
            this.lblLiveU.Text = "U [V]";
            // 
            // lblPhaseC
            // 
            this.lblPhaseC.AutoSize = true;
            this.lblPhaseC.Location = new System.Drawing.Point(13, 85);
            this.lblPhaseC.Name = "lblPhaseC";
            this.lblPhaseC.Size = new System.Drawing.Size(13, 13);
            this.lblPhaseC.TabIndex = 1;
            this.lblPhaseC.Text = "3";
            // 
            // lblPhaseB
            // 
            this.lblPhaseB.AutoSize = true;
            this.lblPhaseB.Location = new System.Drawing.Point(13, 63);
            this.lblPhaseB.Name = "lblPhaseB";
            this.lblPhaseB.Size = new System.Drawing.Size(13, 13);
            this.lblPhaseB.TabIndex = 0;
            this.lblPhaseB.Text = "2";
            // 
            // lblPhaseA
            // 
            this.lblPhaseA.AutoSize = true;
            this.lblPhaseA.Location = new System.Drawing.Point(13, 42);
            this.lblPhaseA.Name = "lblPhaseA";
            this.lblPhaseA.Size = new System.Drawing.Size(13, 13);
            this.lblPhaseA.TabIndex = 0;
            this.lblPhaseA.Text = "1";
            // 
            // grpEnvValues
            // 
            this.grpEnvValues.Controls.Add(this.txtEnvHumidity);
            this.grpEnvValues.Controls.Add(this.lblHumidity);
            this.grpEnvValues.Controls.Add(this.txtEnvTemp);
            this.grpEnvValues.Controls.Add(this.lblTemp);
            this.grpEnvValues.Location = new System.Drawing.Point(467, 264);
            this.grpEnvValues.Name = "grpEnvValues";
            this.grpEnvValues.Size = new System.Drawing.Size(253, 61);
            this.grpEnvValues.TabIndex = 14;
            this.grpEnvValues.TabStop = false;
            this.grpEnvValues.Text = "Environmental values";
            // 
            // txtEnvHumidity
            // 
            this.txtEnvHumidity.Location = new System.Drawing.Point(176, 30);
            this.txtEnvHumidity.Name = "txtEnvHumidity";
            this.txtEnvHumidity.ReadOnly = true;
            this.txtEnvHumidity.Size = new System.Drawing.Size(69, 20);
            this.txtEnvHumidity.TabIndex = 3;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(173, 15);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(47, 13);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity";
            // 
            // txtEnvTemp
            // 
            this.txtEnvTemp.Location = new System.Drawing.Point(17, 30);
            this.txtEnvTemp.Name = "txtEnvTemp";
            this.txtEnvTemp.ReadOnly = true;
            this.txtEnvTemp.Size = new System.Drawing.Size(69, 20);
            this.txtEnvTemp.TabIndex = 1;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(17, 15);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 13);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temperature";
            // 
            // grpActualPower
            // 
            this.grpActualPower.Controls.Add(this.txtTotalS);
            this.grpActualPower.Controls.Add(this.lblTotalS);
            this.grpActualPower.Controls.Add(this.txtTotalQ);
            this.grpActualPower.Controls.Add(this.lblTotalQ);
            this.grpActualPower.Controls.Add(this.txtTotalP);
            this.grpActualPower.Controls.Add(this.lblTotalP);
            this.grpActualPower.Location = new System.Drawing.Point(467, 182);
            this.grpActualPower.Name = "grpActualPower";
            this.grpActualPower.Size = new System.Drawing.Size(253, 78);
            this.grpActualPower.TabIndex = 13;
            this.grpActualPower.TabStop = false;
            this.grpActualPower.Text = "Actual power";
            // 
            // txtTotalS
            // 
            this.txtTotalS.Location = new System.Drawing.Point(30, 56);
            this.txtTotalS.Name = "txtTotalS";
            this.txtTotalS.ReadOnly = true;
            this.txtTotalS.Size = new System.Drawing.Size(215, 20);
            this.txtTotalS.TabIndex = 5;
            // 
            // lblTotalS
            // 
            this.lblTotalS.AutoSize = true;
            this.lblTotalS.Location = new System.Drawing.Point(9, 59);
            this.lblTotalS.Name = "lblTotalS";
            this.lblTotalS.Size = new System.Drawing.Size(14, 13);
            this.lblTotalS.TabIndex = 4;
            this.lblTotalS.Text = "S";
            // 
            // txtTotalQ
            // 
            this.txtTotalQ.Location = new System.Drawing.Point(30, 35);
            this.txtTotalQ.Name = "txtTotalQ";
            this.txtTotalQ.ReadOnly = true;
            this.txtTotalQ.Size = new System.Drawing.Size(215, 20);
            this.txtTotalQ.TabIndex = 3;
            // 
            // lblTotalQ
            // 
            this.lblTotalQ.AutoSize = true;
            this.lblTotalQ.Location = new System.Drawing.Point(9, 37);
            this.lblTotalQ.Name = "lblTotalQ";
            this.lblTotalQ.Size = new System.Drawing.Size(15, 13);
            this.lblTotalQ.TabIndex = 2;
            this.lblTotalQ.Text = "Q";
            // 
            // txtTotalP
            // 
            this.txtTotalP.Location = new System.Drawing.Point(30, 13);
            this.txtTotalP.Name = "txtTotalP";
            this.txtTotalP.ReadOnly = true;
            this.txtTotalP.Size = new System.Drawing.Size(215, 20);
            this.txtTotalP.TabIndex = 1;
            // 
            // lblTotalP
            // 
            this.lblTotalP.AutoSize = true;
            this.lblTotalP.Location = new System.Drawing.Point(9, 16);
            this.lblTotalP.Name = "lblTotalP";
            this.lblTotalP.Size = new System.Drawing.Size(14, 13);
            this.lblTotalP.TabIndex = 0;
            this.lblTotalP.Text = "P";
            // 
            // grpRangeLimits
            // 
            this.grpRangeLimits.Controls.Add(this.lblRangeLimits);
            this.grpRangeLimits.Location = new System.Drawing.Point(133, 286);
            this.grpRangeLimits.Name = "grpRangeLimits";
            this.grpRangeLimits.Size = new System.Drawing.Size(163, 39);
            this.grpRangeLimits.TabIndex = 10;
            this.grpRangeLimits.TabStop = false;
            this.grpRangeLimits.Text = "Range of Limits";
            // 
            // lblRangeLimits
            // 
            this.lblRangeLimits.AutoSize = true;
            this.lblRangeLimits.Location = new System.Drawing.Point(13, 17);
            this.lblRangeLimits.Name = "lblRangeLimits";
            this.lblRangeLimits.Size = new System.Drawing.Size(83, 13);
            this.lblRangeLimits.TabIndex = 0;
            this.lblRangeLimits.Text = "-0.50% to 0.50%";
            // 
            // grpBaseValues
            // 
            this.grpBaseValues.Controls.Add(this.txtBaseIm);
            this.grpBaseValues.Controls.Add(this.lblBaseIm);
            this.grpBaseValues.Controls.Add(this.txtBaseFreq);
            this.grpBaseValues.Controls.Add(this.lblBaseFreq);
            this.grpBaseValues.Controls.Add(this.txtBaseIb);
            this.grpBaseValues.Controls.Add(this.lblBaseIb);
            this.grpBaseValues.Controls.Add(this.txtBaseUb);
            this.grpBaseValues.Controls.Add(this.lblBaseUb);
            this.grpBaseValues.Location = new System.Drawing.Point(467, 4);
            this.grpBaseValues.Name = "grpBaseValues";
            this.grpBaseValues.Size = new System.Drawing.Size(253, 65);
            this.grpBaseValues.TabIndex = 9;
            this.grpBaseValues.TabStop = false;
            this.grpBaseValues.Text = "Base values";
            // 
            // txtBaseIm
            // 
            this.txtBaseIm.Location = new System.Drawing.Point(184, 39);
            this.txtBaseIm.Name = "txtBaseIm";
            this.txtBaseIm.ReadOnly = true;
            this.txtBaseIm.Size = new System.Drawing.Size(61, 20);
            this.txtBaseIm.TabIndex = 7;
            // 
            // lblBaseIm
            // 
            this.lblBaseIm.AutoSize = true;
            this.lblBaseIm.Location = new System.Drawing.Point(141, 42);
            this.lblBaseIm.Name = "lblBaseIm";
            this.lblBaseIm.Size = new System.Drawing.Size(34, 13);
            this.lblBaseIm.TabIndex = 6;
            this.lblBaseIm.Text = "Im [A]";
            // 
            // txtBaseFreq
            // 
            this.txtBaseFreq.Location = new System.Drawing.Point(43, 39);
            this.txtBaseFreq.Name = "txtBaseFreq";
            this.txtBaseFreq.ReadOnly = true;
            this.txtBaseFreq.Size = new System.Drawing.Size(61, 20);
            this.txtBaseFreq.TabIndex = 5;
            // 
            // lblBaseFreq
            // 
            this.lblBaseFreq.AutoSize = true;
            this.lblBaseFreq.Location = new System.Drawing.Point(9, 42);
            this.lblBaseFreq.Name = "lblBaseFreq";
            this.lblBaseFreq.Size = new System.Drawing.Size(32, 13);
            this.lblBaseFreq.TabIndex = 4;
            this.lblBaseFreq.Text = "f [Hz]";
            // 
            // txtBaseIb
            // 
            this.txtBaseIb.Location = new System.Drawing.Point(184, 16);
            this.txtBaseIb.Name = "txtBaseIb";
            this.txtBaseIb.ReadOnly = true;
            this.txtBaseIb.Size = new System.Drawing.Size(61, 20);
            this.txtBaseIb.TabIndex = 3;
            // 
            // lblBaseIb
            // 
            this.lblBaseIb.AutoSize = true;
            this.lblBaseIb.Location = new System.Drawing.Point(141, 18);
            this.lblBaseIb.Name = "lblBaseIb";
            this.lblBaseIb.Size = new System.Drawing.Size(32, 13);
            this.lblBaseIb.TabIndex = 2;
            this.lblBaseIb.Text = "Ib [A]";
            // 
            // txtBaseUb
            // 
            this.txtBaseUb.Location = new System.Drawing.Point(43, 16);
            this.txtBaseUb.Name = "txtBaseUb";
            this.txtBaseUb.ReadOnly = true;
            this.txtBaseUb.Size = new System.Drawing.Size(61, 20);
            this.txtBaseUb.TabIndex = 1;
            // 
            // lblBaseUb
            // 
            this.lblBaseUb.AutoSize = true;
            this.lblBaseUb.Location = new System.Drawing.Point(9, 18);
            this.lblBaseUb.Name = "lblBaseUb";
            this.lblBaseUb.Size = new System.Drawing.Size(37, 13);
            this.lblBaseUb.TabIndex = 0;
            this.lblBaseUb.Text = "Ub [V]";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(240, 381);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(47, 30);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(189, 381);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(47, 30);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(137, 381);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(47, 30);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbStep
            // 
            this.cmbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(137, 347);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(159, 21);
            this.cmbStep.TabIndex = 5;
            // 
            // lblSingleStep
            // 
            this.lblSingleStep.AutoSize = true;
            this.lblSingleStep.Location = new System.Drawing.Point(137, 331);
            this.lblSingleStep.Name = "lblSingleStep";
            this.lblSingleStep.Size = new System.Drawing.Size(29, 13);
            this.lblSingleStep.TabIndex = 4;
            this.lblSingleStep.Text = "Step";
            // 
            // dgvExecuteSteps
            // 
            this.dgvExecuteSteps.AllowUserToAddRows = false;
            this.dgvExecuteSteps.AllowUserToDeleteRows = false;
            this.dgvExecuteSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExecuteSteps.Location = new System.Drawing.Point(137, 22);
            this.dgvExecuteSteps.Name = "dgvExecuteSteps";
            this.dgvExecuteSteps.ReadOnly = true;
            this.dgvExecuteSteps.RowHeadersVisible = false;
            this.dgvExecuteSteps.Size = new System.Drawing.Size(321, 260);
            this.dgvExecuteSteps.TabIndex = 3;
            // 
            // lblExeSteps
            // 
            this.lblExeSteps.AutoSize = true;
            this.lblExeSteps.Location = new System.Drawing.Point(137, 4);
            this.lblExeSteps.Name = "lblExeSteps";
            this.lblExeSteps.Size = new System.Drawing.Size(82, 13);
            this.lblExeSteps.TabIndex = 2;
            this.lblExeSteps.Text = "Execution steps";
            // 
            // lstOverview
            // 
            this.lstOverview.FormattingEnabled = true;
            this.lstOverview.Location = new System.Drawing.Point(9, 22);
            this.lstOverview.Name = "lstOverview";
            this.lstOverview.Size = new System.Drawing.Size(121, 394);
            this.lstOverview.TabIndex = 1;
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Location = new System.Drawing.Point(9, 4);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(52, 13);
            this.lblOverview.TabIndex = 0;
            this.lblOverview.Text = "Overview";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(309, 347);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(412, 70);
            this.txtLogs.TabIndex = 2;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(309, 331);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(30, 13);
            this.lblLogs.TabIndex = 1;
            this.lblLogs.Text = "Logs";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.cmbWhatMeter);
            this.tabResults.Controls.Add(this.lblWhatMeter);
            this.tabResults.Controls.Add(this.btnReport);
            this.tabResults.Controls.Add(this.btnExportResults);
            this.tabResults.Controls.Add(this.dgvResults);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Size = new System.Drawing.Size(729, 425);
            this.tabResults.TabIndex = 4;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // cmbWhatMeter
            // 
            this.cmbWhatMeter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWhatMeter.FormattingEnabled = true;
            this.cmbWhatMeter.Location = new System.Drawing.Point(69, 394);
            this.cmbWhatMeter.Name = "cmbWhatMeter";
            this.cmbWhatMeter.Size = new System.Drawing.Size(129, 21);
            this.cmbWhatMeter.TabIndex = 4;
            // 
            // lblWhatMeter
            // 
            this.lblWhatMeter.AutoSize = true;
            this.lblWhatMeter.Location = new System.Drawing.Point(9, 397);
            this.lblWhatMeter.Name = "lblWhatMeter";
            this.lblWhatMeter.Size = new System.Drawing.Size(63, 13);
            this.lblWhatMeter.TabIndex = 3;
            this.lblWhatMeter.Text = "What Meter";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(596, 392);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 24);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnExportResults
            // 
            this.btnExportResults.Location = new System.Drawing.Point(467, 392);
            this.btnExportResults.Name = "btnExportResults";
            this.btnExportResults.Size = new System.Drawing.Size(120, 24);
            this.btnExportResults.TabIndex = 1;
            this.btnExportResults.Text = "Export Results to Text File";
            this.btnExportResults.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(9, 13);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(711, 364);
            this.dgvResults.TabIndex = 0;
            // 
            // frmTestRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblBenchName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTestRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AemCal: Live Calibration Run";
            this.Load += new System.EventHandler(this.frmTestRun_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.tabCommon.PerformLayout();
            this.tabDevices.ResumeLayout(false);
            this.grpDeviceInputs.ResumeLayout(false);
            this.grpDeviceInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeters)).EndInit();
            this.tabSequence.ResumeLayout(false);
            this.tabSequence.PerformLayout();
            this.tabExecute.ResumeLayout(false);
            this.tabExecute.PerformLayout();
            this.grpLiveTelemetry.ResumeLayout(false);
            this.grpLiveTelemetry.PerformLayout();
            this.grpEnvValues.ResumeLayout(false);
            this.grpEnvValues.PerformLayout();
            this.grpActualPower.ResumeLayout(false);
            this.grpActualPower.PerformLayout();
            this.grpRangeLimits.ResumeLayout(false);
            this.grpRangeLimits.PerformLayout();
            this.grpBaseValues.ResumeLayout(false);
            this.grpBaseValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecuteSteps)).EndInit();
            this.tabResults.ResumeLayout(false);
            this.tabResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBenchName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.TabPage tabDevices;
        private System.Windows.Forms.TabPage tabSequence;
        private System.Windows.Forms.TabPage tabExecute;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtMaxRH;
        private System.Windows.Forms.Label lblMaxRH;
        private System.Windows.Forms.TextBox txtMinRH;
        private System.Windows.Forms.Label lblMinRH;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.TextBox txtDateRun;
        private System.Windows.Forms.Label lblDateRun;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.TextBox txtSequenceName;
        private System.Windows.Forms.Label lblSequenceName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpDeviceInputs;
        private System.Windows.Forms.TextBox txtPositions;
        private System.Windows.Forms.Label lblPositions;
        private System.Windows.Forms.ComboBox cmbMeterType;
        private System.Windows.Forms.Label lblMeterType;
        private System.Windows.Forms.TextBox txtStepMSN;
        private System.Windows.Forms.Label lblStepMSN;
        private System.Windows.Forms.TextBox txtMSN;
        private System.Windows.Forms.Label lblMSN;
        private System.Windows.Forms.TextBox txtStepOwnerNo;
        private System.Windows.Forms.Label lblStepOwner;
        private System.Windows.Forms.TextBox txtOwnerNo;
        private System.Windows.Forms.Label lblOwnerNo;
        private System.Windows.Forms.TextBox txtLastApproval;
        private System.Windows.Forms.Label lblLastApproval;
        private System.Windows.Forms.TextBox txtYearOfManufacture;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbClientNo;
        private System.Windows.Forms.Label lblClientNo;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbContractNo;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.Button btnDeleteDevice;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.DataGridView dgvMeters;
        private System.Windows.Forms.Label lblSelectedSteps;
        private System.Windows.Forms.ListBox lstAvailableProcedures;
        private System.Windows.Forms.Label lblAvailableProcs;
        private System.Windows.Forms.ListBox lstOverview;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.DataGridView dgvExecuteSteps;
        private System.Windows.Forms.Label lblExeSteps;
        private System.Windows.Forms.ComboBox cmbStep;
        private System.Windows.Forms.Label lblSingleStep;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpBaseValues;
        private System.Windows.Forms.TextBox txtBaseIm;
        private System.Windows.Forms.Label lblBaseIm;
        private System.Windows.Forms.TextBox txtBaseFreq;
        private System.Windows.Forms.Label lblBaseFreq;
        private System.Windows.Forms.TextBox txtBaseIb;
        private System.Windows.Forms.Label lblBaseIb;
        private System.Windows.Forms.TextBox txtBaseUb;
        private System.Windows.Forms.Label lblBaseUb;
        private System.Windows.Forms.GroupBox grpRangeLimits;
        private System.Windows.Forms.Label lblRangeLimits;
        private System.Windows.Forms.GroupBox grpLiveTelemetry;
        private System.Windows.Forms.Label lblMonFreq;
        private System.Windows.Forms.TextBox txtMonPhiC;
        private System.Windows.Forms.TextBox txtMonPhiB;
        private System.Windows.Forms.TextBox txtMonPhiA;
        private System.Windows.Forms.TextBox txtMonIC;
        private System.Windows.Forms.TextBox txtMonIB;
        private System.Windows.Forms.TextBox txtMonIA;
        private System.Windows.Forms.Label lblLiveI;
        private System.Windows.Forms.TextBox txtMonUC;
        private System.Windows.Forms.TextBox txtMonUB;
        private System.Windows.Forms.TextBox txtMonUA;
        private System.Windows.Forms.Label lblLiveU;
        private System.Windows.Forms.Label lblPhaseC;
        private System.Windows.Forms.Label lblPhaseB;
        private System.Windows.Forms.Label lblPhaseA;
        private System.Windows.Forms.GroupBox grpActualPower;
        private System.Windows.Forms.TextBox txtTotalS;
        private System.Windows.Forms.Label lblTotalS;
        private System.Windows.Forms.TextBox txtTotalQ;
        private System.Windows.Forms.Label lblTotalQ;
        private System.Windows.Forms.TextBox txtTotalP;
        private System.Windows.Forms.Label lblTotalP;
        private System.Windows.Forms.GroupBox grpEnvValues;
        private System.Windows.Forms.TextBox txtEnvHumidity;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.TextBox txtEnvTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnExportResults;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cmbWhatMeter;
        private System.Windows.Forms.Label lblWhatMeter;
        private System.Windows.Forms.ListBox lstDisplatAutoSelected;
        private System.Windows.Forms.Label lblDisplayParaTotalSelected;
        private System.Windows.Forms.Button btnDispAutoMoveDown;
        private System.Windows.Forms.Button btnDispAutoMoveUP;
        private System.Windows.Forms.Button btnDispAutoMove;
        private System.Windows.Forms.Button btnDispAutoRemove;
        private System.Windows.Forms.Button btnDispAutoRemoveAll;
        private System.Windows.Forms.Button btnDispAutoMoveAll;
        private System.Windows.Forms.Button lblReset;
    }
}
