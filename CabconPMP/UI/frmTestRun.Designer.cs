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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestRun));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBenchName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblMaxRH = new System.Windows.Forms.Label();
            this.lblMinRH = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblDateRun = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblSequenceName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabDevices = new System.Windows.Forms.TabPage();
            this.grpDeviceInputs = new System.Windows.Forms.GroupBox();
            this.btnDeleteDevice = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.lblClientNo = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.lblLastApproval = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblStepOwner = new System.Windows.Forms.Label();
            this.lblOwnerNo = new System.Windows.Forms.Label();
            this.lblStepMSN = new System.Windows.Forms.Label();
            this.lblMSN = new System.Windows.Forms.Label();
            this.lblMeterType = new System.Windows.Forms.Label();
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
            this.lblLiveI = new System.Windows.Forms.Label();
            this.lblLiveU = new System.Windows.Forms.Label();
            this.lblPhaseC = new System.Windows.Forms.Label();
            this.lblPhaseB = new System.Windows.Forms.Label();
            this.lblPhaseA = new System.Windows.Forms.Label();
            this.grpEnvValues = new System.Windows.Forms.GroupBox();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.grpActualPower = new System.Windows.Forms.GroupBox();
            this.lblTotalS = new System.Windows.Forms.Label();
            this.lblTotalQ = new System.Windows.Forms.Label();
            this.lblTotalP = new System.Windows.Forms.Label();
            this.grpRangeLimits = new System.Windows.Forms.GroupBox();
            this.lblRangeLimits = new System.Windows.Forms.Label();
            this.grpBaseValues = new System.Windows.Forms.GroupBox();
            this.lblBaseIm = new System.Windows.Forms.Label();
            this.lblBaseFreq = new System.Windows.Forms.Label();
            this.lblBaseIb = new System.Windows.Forms.Label();
            this.lblBaseUb = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSingleStep = new System.Windows.Forms.Label();
            this.dgvExecuteSteps = new System.Windows.Forms.DataGridView();
            this.lblExeSteps = new System.Windows.Forms.Label();
            this.lstOverview = new System.Windows.Forms.ListBox();
            this.lblOverview = new System.Windows.Forms.Label();
            this.lblLogs = new System.Windows.Forms.Label();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.lblWhatMeter = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExportResults = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.txtComment = new CabconPMP.TransparentTextBox();
            this.txtMaxRH = new CabconPMP.TransparentTextBox();
            this.txtMinRH = new CabconPMP.TransparentTextBox();
            this.txtMaxTemp = new CabconPMP.TransparentTextBox();
            this.txtMinTemp = new CabconPMP.TransparentTextBox();
            this.txtDateRun = new CabconPMP.TransparentTextBox();
            this.txtOperator = new CabconPMP.TransparentTextBox();
            this.txtSupervisor = new CabconPMP.TransparentTextBox();
            this.txtSequenceName = new CabconPMP.TransparentTextBox();
            this.txtStatus = new CabconPMP.TransparentTextBox();
            this.cmbClientNo = new CabconPMP.TransparentComboBox();
            this.cmbClient = new CabconPMP.TransparentComboBox();
            this.cmbContractNo = new CabconPMP.TransparentComboBox();
            this.txtLastApproval = new CabconPMP.TransparentTextBox();
            this.txtYearOfManufacture = new CabconPMP.TransparentTextBox();
            this.txtStepOwnerNo = new CabconPMP.TransparentTextBox();
            this.txtOwnerNo = new CabconPMP.TransparentTextBox();
            this.txtStepMSN = new CabconPMP.TransparentTextBox();
            this.txtMSN = new CabconPMP.TransparentTextBox();
            this.cmbMeterType = new CabconPMP.TransparentComboBox();
            this.txtPositions = new CabconPMP.TransparentTextBox();
            this.txtMonPhiC = new CabconPMP.TransparentTextBox();
            this.txtMonPhiB = new CabconPMP.TransparentTextBox();
            this.txtMonPhiA = new CabconPMP.TransparentTextBox();
            this.txtMonIC = new CabconPMP.TransparentTextBox();
            this.txtMonIB = new CabconPMP.TransparentTextBox();
            this.txtMonIA = new CabconPMP.TransparentTextBox();
            this.txtMonUC = new CabconPMP.TransparentTextBox();
            this.txtMonUB = new CabconPMP.TransparentTextBox();
            this.txtMonUA = new CabconPMP.TransparentTextBox();
            this.txtEnvHumidity = new CabconPMP.TransparentTextBox();
            this.txtEnvTemp = new CabconPMP.TransparentTextBox();
            this.txtTotalS = new CabconPMP.TransparentTextBox();
            this.txtTotalQ = new CabconPMP.TransparentTextBox();
            this.txtTotalP = new CabconPMP.TransparentTextBox();
            this.txtBaseIm = new CabconPMP.TransparentTextBox();
            this.txtBaseFreq = new CabconPMP.TransparentTextBox();
            this.txtBaseIb = new CabconPMP.TransparentTextBox();
            this.txtBaseUb = new CabconPMP.TransparentTextBox();
            this.cmbStep = new CabconPMP.TransparentComboBox();
            this.txtLogs = new CabconPMP.TransparentTextBox();
            this.cmbWhatMeter = new CabconPMP.TransparentComboBox();
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
            this.lblBenchName.Location = new System.Drawing.Point(15, 12);
            this.lblBenchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenchName.Name = "lblBenchName";
            this.lblBenchName.Size = new System.Drawing.Size(185, 32);
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
            this.tabControl1.Location = new System.Drawing.Point(15, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1539, 891);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCommon
            // 
            this.tabCommon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCommon.BackgroundImage")));
            this.tabCommon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tabCommon.Location = new System.Drawing.Point(4, 29);
            this.tabCommon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCommon.Size = new System.Drawing.Size(1531, 858);
            this.tabCommon.TabIndex = 0;
            this.tabCommon.Text = "Common properties";
            this.tabCommon.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(566, 26);
            this.lblComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(97, 25);
            this.lblComment.TabIndex = 18;
            this.lblComment.Text = "Comment";
            // 
            // lblMaxRH
            // 
            this.lblMaxRH.AutoSize = true;
            this.lblMaxRH.Location = new System.Drawing.Point(424, 353);
            this.lblMaxRH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxRH.Name = "lblMaxRH";
            this.lblMaxRH.Size = new System.Drawing.Size(46, 20);
            this.lblMaxRH.TabIndex = 16;
            this.lblMaxRH.Text = "Max. ";
            // 
            // lblMinRH
            // 
            this.lblMinRH.AutoSize = true;
            this.lblMinRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinRH.Location = new System.Drawing.Point(276, 351);
            this.lblMinRH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinRH.Name = "lblMinRH";
            this.lblMinRH.Size = new System.Drawing.Size(144, 22);
            this.lblMinRH.TabIndex = 14;
            this.lblMinRH.Text = "Rel. humidity [%]";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(193, 358);
            this.lblMaxTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(42, 20);
            this.lblMaxTemp.TabIndex = 12;
            this.lblMaxTemp.Text = "Max.";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(16, 353);
            this.lblMinTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(176, 22);
            this.lblMinTemp.TabIndex = 10;
            this.lblMinTemp.Text = "Temperature [deg C]";
            // 
            // lblDateRun
            // 
            this.lblDateRun.AutoSize = true;
            this.lblDateRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRun.Location = new System.Drawing.Point(292, 213);
            this.lblDateRun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateRun.Name = "lblDateRun";
            this.lblDateRun.Size = new System.Drawing.Size(86, 22);
            this.lblDateRun.TabIndex = 8;
            this.lblDateRun.Text = "Test date";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(306, 498);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(81, 22);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "Operator";
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(20, 499);
            this.lblSupervisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(96, 22);
            this.lblSupervisor.TabIndex = 4;
            this.lblSupervisor.Text = "Supervisor";
            // 
            // lblSequenceName
            // 
            this.lblSequenceName.AutoSize = true;
            this.lblSequenceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequenceName.Location = new System.Drawing.Point(177, 60);
            this.lblSequenceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSequenceName.Name = "lblSequenceName";
            this.lblSequenceName.Size = new System.Drawing.Size(129, 22);
            this.lblSequenceName.TabIndex = 2;
            this.lblSequenceName.Text = "Test sequence";
            this.lblSequenceName.Click += new System.EventHandler(this.lblSequenceName_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(20, 214);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 22);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "State";
            // 
            // tabDevices
            // 
            this.tabDevices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDevices.BackgroundImage")));
            this.tabDevices.Controls.Add(this.grpDeviceInputs);
            this.tabDevices.Controls.Add(this.dgvMeters);
            this.tabDevices.Location = new System.Drawing.Point(4, 29);
            this.tabDevices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDevices.Size = new System.Drawing.Size(1531, 858);
            this.tabDevices.TabIndex = 1;
            this.tabDevices.Text = "Test devices";
            this.tabDevices.UseVisualStyleBackColor = true;
            // 
            // grpDeviceInputs
            // 
            this.grpDeviceInputs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpDeviceInputs.BackgroundImage")));
            this.grpDeviceInputs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.grpDeviceInputs.Location = new System.Drawing.Point(14, 6);
            this.grpDeviceInputs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeviceInputs.Name = "grpDeviceInputs";
            this.grpDeviceInputs.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeviceInputs.Size = new System.Drawing.Size(1255, 269);
            this.grpDeviceInputs.TabIndex = 0;
            this.grpDeviceInputs.TabStop = false;
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDevice.Location = new System.Drawing.Point(1032, 211);
            this.btnDeleteDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(154, 37);
            this.btnDeleteDevice.TabIndex = 23;
            this.btnDeleteDevice.Text = "Delete";
            this.btnDeleteDevice.UseVisualStyleBackColor = true;
            this.btnDeleteDevice.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.Location = new System.Drawing.Point(809, 211);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(154, 37);
            this.btnAddDevice.TabIndex = 22;
            this.btnAddDevice.Text = "Add";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // lblClientNo
            // 
            this.lblClientNo.AutoSize = true;
            this.lblClientNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNo.Location = new System.Drawing.Point(805, 159);
            this.lblClientNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientNo.Name = "lblClientNo";
            this.lblClientNo.Size = new System.Drawing.Size(98, 22);
            this.lblClientNo.TabIndex = 20;
            this.lblClientNo.Text = "Clients No.";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(805, 118);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(56, 22);
            this.lblClient.TabIndex = 18;
            this.lblClient.Text = "Client";
            // 
            // lblContractNo
            // 
            this.lblContractNo.AutoSize = true;
            this.lblContractNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractNo.Location = new System.Drawing.Point(803, 76);
            this.lblContractNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(111, 22);
            this.lblContractNo.TabIndex = 16;
            this.lblContractNo.Text = "Contract No.";
            this.lblContractNo.Click += new System.EventHandler(this.lblContractNo_Click);
            // 
            // lblLastApproval
            // 
            this.lblLastApproval.AutoSize = true;
            this.lblLastApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastApproval.Location = new System.Drawing.Point(435, 167);
            this.lblLastApproval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastApproval.Name = "lblLastApproval";
            this.lblLastApproval.Size = new System.Drawing.Size(118, 22);
            this.lblLastApproval.TabIndex = 14;
            this.lblLastApproval.Text = "Last approval";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(9, 162);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(172, 22);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year of Manufacture";
            // 
            // lblStepOwner
            // 
            this.lblStepOwner.AutoSize = true;
            this.lblStepOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepOwner.Location = new System.Drawing.Point(438, 122);
            this.lblStepOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepOwner.Name = "lblStepOwner";
            this.lblStepOwner.Size = new System.Drawing.Size(47, 22);
            this.lblStepOwner.TabIndex = 10;
            this.lblStepOwner.Text = "Step";
            // 
            // lblOwnerNo
            // 
            this.lblOwnerNo.AutoSize = true;
            this.lblOwnerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerNo.Location = new System.Drawing.Point(70, 122);
            this.lblOwnerNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerNo.Name = "lblOwnerNo";
            this.lblOwnerNo.Size = new System.Drawing.Size(105, 22);
            this.lblOwnerNo.TabIndex = 8;
            this.lblOwnerNo.Text = "Owners No.";
            // 
            // lblStepMSN
            // 
            this.lblStepMSN.AutoSize = true;
            this.lblStepMSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepMSN.Location = new System.Drawing.Point(442, 77);
            this.lblStepMSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepMSN.Name = "lblStepMSN";
            this.lblStepMSN.Size = new System.Drawing.Size(47, 22);
            this.lblStepMSN.TabIndex = 6;
            this.lblStepMSN.Text = "Step";
            // 
            // lblMSN
            // 
            this.lblMSN.AutoSize = true;
            this.lblMSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSN.Location = new System.Drawing.Point(22, 83);
            this.lblMSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSN.Name = "lblMSN";
            this.lblMSN.Size = new System.Drawing.Size(156, 22);
            this.lblMSN.TabIndex = 4;
            this.lblMSN.Text = "Manufacturing No.";
            // 
            // lblMeterType
            // 
            this.lblMeterType.AutoSize = true;
            this.lblMeterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeterType.Location = new System.Drawing.Point(440, 33);
            this.lblMeterType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeterType.Name = "lblMeterType";
            this.lblMeterType.Size = new System.Drawing.Size(94, 22);
            this.lblMeterType.TabIndex = 2;
            this.lblMeterType.Text = "Meter type";
            // 
            // lblPositions
            // 
            this.lblPositions.AutoSize = true;
            this.lblPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositions.Location = new System.Drawing.Point(66, 43);
            this.lblPositions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(107, 22);
            this.lblPositions.TabIndex = 0;
            this.lblPositions.Text = "Position No.";
            // 
            // dgvMeters
            // 
            this.dgvMeters.AllowUserToAddRows = false;
            this.dgvMeters.AllowUserToDeleteRows = false;
            this.dgvMeters.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMeters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeters.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMeters.Location = new System.Drawing.Point(14, 285);
            this.dgvMeters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMeters.Name = "dgvMeters";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeters.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMeters.RowHeadersVisible = false;
            this.dgvMeters.RowHeadersWidth = 62;
            this.dgvMeters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeters.Size = new System.Drawing.Size(1255, 458);
            this.dgvMeters.TabIndex = 1;
            // 
            // tabSequence
            // 
            this.tabSequence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSequence.BackgroundImage")));
            this.tabSequence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tabSequence.Location = new System.Drawing.Point(4, 29);
            this.tabSequence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSequence.Name = "tabSequence";
            this.tabSequence.Size = new System.Drawing.Size(1531, 858);
            this.tabSequence.TabIndex = 2;
            this.tabSequence.Text = "Sequence of test procedures";
            this.tabSequence.UseVisualStyleBackColor = true;
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(494, 108);
            this.lblReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(75, 43);
            this.lblReset.TabIndex = 53;
            this.lblReset.Text = "Reset";
            this.lblReset.UseVisualStyleBackColor = true;
            this.lblReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDisplayParaTotalSelected
            // 
            this.lblDisplayParaTotalSelected.AutoSize = true;
            this.lblDisplayParaTotalSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayParaTotalSelected.Location = new System.Drawing.Point(474, 458);
            this.lblDisplayParaTotalSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayParaTotalSelected.Name = "lblDisplayParaTotalSelected";
            this.lblDisplayParaTotalSelected.Size = new System.Drawing.Size(113, 17);
            this.lblDisplayParaTotalSelected.TabIndex = 51;
            this.lblDisplayParaTotalSelected.Text = "Total Selected";
            // 
            // btnDispAutoMoveDown
            // 
            this.btnDispAutoMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveDown.Location = new System.Drawing.Point(537, 369);
            this.btnDispAutoMoveDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoMoveDown.Name = "btnDispAutoMoveDown";
            this.btnDispAutoMoveDown.Size = new System.Drawing.Size(30, 71);
            this.btnDispAutoMoveDown.TabIndex = 50;
            this.btnDispAutoMoveDown.Text = "v";
            this.btnDispAutoMoveDown.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveDown.Click += new System.EventHandler(this.btnDispAutoMoveDown_Click);
            // 
            // btnDispAutoMoveUP
            // 
            this.btnDispAutoMoveUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveUP.Location = new System.Drawing.Point(492, 369);
            this.btnDispAutoMoveUP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoMoveUP.Name = "btnDispAutoMoveUP";
            this.btnDispAutoMoveUP.Size = new System.Drawing.Size(30, 71);
            this.btnDispAutoMoveUP.TabIndex = 49;
            this.btnDispAutoMoveUP.Text = "^";
            this.btnDispAutoMoveUP.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveUP.Click += new System.EventHandler(this.btnDispAutoMoveUP_Click);
            // 
            // btnDispAutoMove
            // 
            this.btnDispAutoMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMove.Location = new System.Drawing.Point(494, 160);
            this.btnDispAutoMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoMove.Name = "btnDispAutoMove";
            this.btnDispAutoMove.Size = new System.Drawing.Size(75, 43);
            this.btnDispAutoMove.TabIndex = 46;
            this.btnDispAutoMove.Text = ">";
            this.btnDispAutoMove.UseVisualStyleBackColor = true;
            this.btnDispAutoMove.Click += new System.EventHandler(this.btnDispAutoMove_Click);
            // 
            // btnDispAutoRemove
            // 
            this.btnDispAutoRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoRemove.Location = new System.Drawing.Point(494, 265);
            this.btnDispAutoRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoRemove.Name = "btnDispAutoRemove";
            this.btnDispAutoRemove.Size = new System.Drawing.Size(75, 43);
            this.btnDispAutoRemove.TabIndex = 47;
            this.btnDispAutoRemove.Text = "<";
            this.btnDispAutoRemove.UseVisualStyleBackColor = true;
            this.btnDispAutoRemove.Click += new System.EventHandler(this.btnDispAutoRemove_Click);
            // 
            // btnDispAutoRemoveAll
            // 
            this.btnDispAutoRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoRemoveAll.Location = new System.Drawing.Point(492, 317);
            this.btnDispAutoRemoveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoRemoveAll.Name = "btnDispAutoRemoveAll";
            this.btnDispAutoRemoveAll.Size = new System.Drawing.Size(75, 43);
            this.btnDispAutoRemoveAll.TabIndex = 48;
            this.btnDispAutoRemoveAll.Text = "<<";
            this.btnDispAutoRemoveAll.UseVisualStyleBackColor = true;
            this.btnDispAutoRemoveAll.Click += new System.EventHandler(this.btnDispAutoRemoveAll_Click);
            // 
            // btnDispAutoMoveAll
            // 
            this.btnDispAutoMoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveAll.Location = new System.Drawing.Point(494, 212);
            this.btnDispAutoMoveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoMoveAll.Name = "btnDispAutoMoveAll";
            this.btnDispAutoMoveAll.Size = new System.Drawing.Size(75, 43);
            this.btnDispAutoMoveAll.TabIndex = 45;
            this.btnDispAutoMoveAll.Text = ">>";
            this.btnDispAutoMoveAll.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveAll.Click += new System.EventHandler(this.btnDispAutoMoveAll_Click);
            // 
            // lstDisplatAutoSelected
            // 
            this.lstDisplatAutoSelected.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstDisplatAutoSelected.FormattingEnabled = true;
            this.lstDisplatAutoSelected.ItemHeight = 20;
            this.lstDisplatAutoSelected.Location = new System.Drawing.Point(637, 54);
            this.lstDisplatAutoSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDisplatAutoSelected.Name = "lstDisplatAutoSelected";
            this.lstDisplatAutoSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDisplatAutoSelected.Size = new System.Drawing.Size(436, 584);
            this.lstDisplatAutoSelected.TabIndex = 9;
            this.lstDisplatAutoSelected.SelectedIndexChanged += new System.EventHandler(this.lstDisplatAutoSelected_SelectedIndexChanged);
            // 
            // lblSelectedSteps
            // 
            this.lblSelectedSteps.AutoSize = true;
            this.lblSelectedSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSteps.Location = new System.Drawing.Point(633, 29);
            this.lblSelectedSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedSteps.Name = "lblSelectedSteps";
            this.lblSelectedSteps.Size = new System.Drawing.Size(218, 22);
            this.lblSelectedSteps.TabIndex = 2;
            this.lblSelectedSteps.Text = "Selected Test Procedures";
            // 
            // lstAvailableProcedures
            // 
            this.lstAvailableProcedures.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstAvailableProcedures.FormattingEnabled = true;
            this.lstAvailableProcedures.ItemHeight = 20;
            this.lstAvailableProcedures.Location = new System.Drawing.Point(14, 54);
            this.lstAvailableProcedures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAvailableProcedures.Name = "lstAvailableProcedures";
            this.lstAvailableProcedures.Size = new System.Drawing.Size(406, 584);
            this.lstAvailableProcedures.TabIndex = 1;
            // 
            // lblAvailableProcs
            // 
            this.lblAvailableProcs.AutoSize = true;
            this.lblAvailableProcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableProcs.Location = new System.Drawing.Point(14, 26);
            this.lblAvailableProcs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableProcs.Name = "lblAvailableProcs";
            this.lblAvailableProcs.Size = new System.Drawing.Size(221, 22);
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
            this.tabExecute.Location = new System.Drawing.Point(4, 29);
            this.tabExecute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabExecute.Name = "tabExecute";
            this.tabExecute.Size = new System.Drawing.Size(1531, 858);
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
            this.grpLiveTelemetry.Location = new System.Drawing.Point(1118, 151);
            this.grpLiveTelemetry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLiveTelemetry.Name = "grpLiveTelemetry";
            this.grpLiveTelemetry.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLiveTelemetry.Size = new System.Drawing.Size(380, 166);
            this.grpLiveTelemetry.TabIndex = 11;
            this.grpLiveTelemetry.TabStop = false;
            this.grpLiveTelemetry.Text = "Monitor";
            // 
            // lblMonFreq
            // 
            this.lblMonFreq.AutoSize = true;
            this.lblMonFreq.Location = new System.Drawing.Point(290, 31);
            this.lblMonFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonFreq.Name = "lblMonFreq";
            this.lblMonFreq.Size = new System.Drawing.Size(74, 20);
            this.lblMonFreq.TabIndex = 14;
            this.lblMonFreq.Text = " Phi [deg]";
            // 
            // lblLiveI
            // 
            this.lblLiveI.AutoSize = true;
            this.lblLiveI.Location = new System.Drawing.Point(189, 31);
            this.lblLiveI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiveI.Name = "lblLiveI";
            this.lblLiveI.Size = new System.Drawing.Size(37, 20);
            this.lblLiveI.TabIndex = 6;
            this.lblLiveI.Text = "I [A]";
            // 
            // lblLiveU
            // 
            this.lblLiveU.AutoSize = true;
            this.lblLiveU.Location = new System.Drawing.Point(58, 31);
            this.lblLiveU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiveU.Name = "lblLiveU";
            this.lblLiveU.Size = new System.Drawing.Size(44, 20);
            this.lblLiveU.TabIndex = 2;
            this.lblLiveU.Text = "U [V]";
            // 
            // lblPhaseC
            // 
            this.lblPhaseC.AutoSize = true;
            this.lblPhaseC.Location = new System.Drawing.Point(20, 131);
            this.lblPhaseC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhaseC.Name = "lblPhaseC";
            this.lblPhaseC.Size = new System.Drawing.Size(18, 20);
            this.lblPhaseC.TabIndex = 1;
            this.lblPhaseC.Text = "3";
            // 
            // lblPhaseB
            // 
            this.lblPhaseB.AutoSize = true;
            this.lblPhaseB.Location = new System.Drawing.Point(20, 97);
            this.lblPhaseB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhaseB.Name = "lblPhaseB";
            this.lblPhaseB.Size = new System.Drawing.Size(18, 20);
            this.lblPhaseB.TabIndex = 0;
            this.lblPhaseB.Text = "2";
            // 
            // lblPhaseA
            // 
            this.lblPhaseA.AutoSize = true;
            this.lblPhaseA.Location = new System.Drawing.Point(20, 65);
            this.lblPhaseA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhaseA.Name = "lblPhaseA";
            this.lblPhaseA.Size = new System.Drawing.Size(18, 20);
            this.lblPhaseA.TabIndex = 0;
            this.lblPhaseA.Text = "1";
            // 
            // grpEnvValues
            // 
            this.grpEnvValues.Controls.Add(this.txtEnvHumidity);
            this.grpEnvValues.Controls.Add(this.lblHumidity);
            this.grpEnvValues.Controls.Add(this.txtEnvTemp);
            this.grpEnvValues.Controls.Add(this.lblTemp);
            this.grpEnvValues.Location = new System.Drawing.Point(1114, 455);
            this.grpEnvValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnvValues.Name = "grpEnvValues";
            this.grpEnvValues.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEnvValues.Size = new System.Drawing.Size(380, 94);
            this.grpEnvValues.TabIndex = 14;
            this.grpEnvValues.TabStop = false;
            this.grpEnvValues.Text = "Environmental values";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(260, 23);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(79, 22);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(26, 23);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(113, 22);
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
            this.grpActualPower.Location = new System.Drawing.Point(1118, 326);
            this.grpActualPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpActualPower.Name = "grpActualPower";
            this.grpActualPower.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpActualPower.Size = new System.Drawing.Size(380, 120);
            this.grpActualPower.TabIndex = 13;
            this.grpActualPower.TabStop = false;
            this.grpActualPower.Text = "Actual power";
            // 
            // lblTotalS
            // 
            this.lblTotalS.AutoSize = true;
            this.lblTotalS.Location = new System.Drawing.Point(14, 91);
            this.lblTotalS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalS.Name = "lblTotalS";
            this.lblTotalS.Size = new System.Drawing.Size(20, 20);
            this.lblTotalS.TabIndex = 4;
            this.lblTotalS.Text = "S";
            // 
            // lblTotalQ
            // 
            this.lblTotalQ.AutoSize = true;
            this.lblTotalQ.Location = new System.Drawing.Point(14, 57);
            this.lblTotalQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQ.Name = "lblTotalQ";
            this.lblTotalQ.Size = new System.Drawing.Size(21, 20);
            this.lblTotalQ.TabIndex = 2;
            this.lblTotalQ.Text = "Q";
            // 
            // lblTotalP
            // 
            this.lblTotalP.AutoSize = true;
            this.lblTotalP.Location = new System.Drawing.Point(14, 25);
            this.lblTotalP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalP.Name = "lblTotalP";
            this.lblTotalP.Size = new System.Drawing.Size(19, 20);
            this.lblTotalP.TabIndex = 0;
            this.lblTotalP.Text = "P";
            // 
            // grpRangeLimits
            // 
            this.grpRangeLimits.Controls.Add(this.lblRangeLimits);
            this.grpRangeLimits.Location = new System.Drawing.Point(9, 11);
            this.grpRangeLimits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRangeLimits.Name = "grpRangeLimits";
            this.grpRangeLimits.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRangeLimits.Size = new System.Drawing.Size(604, 60);
            this.grpRangeLimits.TabIndex = 10;
            this.grpRangeLimits.TabStop = false;
            this.grpRangeLimits.Text = "Range of Limits";
            // 
            // lblRangeLimits
            // 
            this.lblRangeLimits.AutoSize = true;
            this.lblRangeLimits.Location = new System.Drawing.Point(20, 26);
            this.lblRangeLimits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRangeLimits.Name = "lblRangeLimits";
            this.lblRangeLimits.Size = new System.Drawing.Size(126, 20);
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
            this.grpBaseValues.Location = new System.Drawing.Point(1118, 37);
            this.grpBaseValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBaseValues.Name = "grpBaseValues";
            this.grpBaseValues.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBaseValues.Size = new System.Drawing.Size(380, 100);
            this.grpBaseValues.TabIndex = 9;
            this.grpBaseValues.TabStop = false;
            this.grpBaseValues.Text = "Base values";
            // 
            // lblBaseIm
            // 
            this.lblBaseIm.AutoSize = true;
            this.lblBaseIm.Location = new System.Drawing.Point(212, 65);
            this.lblBaseIm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseIm.Name = "lblBaseIm";
            this.lblBaseIm.Size = new System.Drawing.Size(50, 20);
            this.lblBaseIm.TabIndex = 6;
            this.lblBaseIm.Text = "Im [A]";
            // 
            // lblBaseFreq
            // 
            this.lblBaseFreq.AutoSize = true;
            this.lblBaseFreq.Location = new System.Drawing.Point(14, 65);
            this.lblBaseFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseFreq.Name = "lblBaseFreq";
            this.lblBaseFreq.Size = new System.Drawing.Size(46, 20);
            this.lblBaseFreq.TabIndex = 4;
            this.lblBaseFreq.Text = "f [Hz]";
            // 
            // lblBaseIb
            // 
            this.lblBaseIb.AutoSize = true;
            this.lblBaseIb.Location = new System.Drawing.Point(212, 28);
            this.lblBaseIb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseIb.Name = "lblBaseIb";
            this.lblBaseIb.Size = new System.Drawing.Size(46, 20);
            this.lblBaseIb.TabIndex = 2;
            this.lblBaseIb.Text = "Ib [A]";
            // 
            // lblBaseUb
            // 
            this.lblBaseUb.AutoSize = true;
            this.lblBaseUb.Location = new System.Drawing.Point(14, 28);
            this.lblBaseUb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseUb.Name = "lblBaseUb";
            this.lblBaseUb.Size = new System.Drawing.Size(53, 20);
            this.lblBaseUb.TabIndex = 0;
            this.lblBaseUb.Text = "Ub [V]";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(1018, 472);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 46);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(939, 472);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(70, 46);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(855, 472);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 46);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSingleStep
            // 
            this.lblSingleStep.AutoSize = true;
            this.lblSingleStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleStep.Location = new System.Drawing.Point(624, 455);
            this.lblSingleStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSingleStep.Name = "lblSingleStep";
            this.lblSingleStep.Size = new System.Drawing.Size(135, 22);
            this.lblSingleStep.TabIndex = 4;
            this.lblSingleStep.Text = "Execution Type";
            // 
            // dgvExecuteSteps
            // 
            this.dgvExecuteSteps.AllowUserToAddRows = false;
            this.dgvExecuteSteps.AllowUserToDeleteRows = false;
            this.dgvExecuteSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExecuteSteps.Location = new System.Drawing.Point(627, 37);
            this.dgvExecuteSteps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvExecuteSteps.MultiSelect = false;
            this.dgvExecuteSteps.Name = "dgvExecuteSteps";
            this.dgvExecuteSteps.ReadOnly = true;
            this.dgvExecuteSteps.RowHeadersVisible = false;
            this.dgvExecuteSteps.RowHeadersWidth = 62;
            this.dgvExecuteSteps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExecuteSteps.Size = new System.Drawing.Size(482, 394);
            this.dgvExecuteSteps.TabIndex = 3;
            // 
            // lblExeSteps
            // 
            this.lblExeSteps.AutoSize = true;
            this.lblExeSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExeSteps.Location = new System.Drawing.Point(622, 6);
            this.lblExeSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExeSteps.Name = "lblExeSteps";
            this.lblExeSteps.Size = new System.Drawing.Size(137, 22);
            this.lblExeSteps.TabIndex = 2;
            this.lblExeSteps.Text = "Execution steps";
            // 
            // lstOverview
            // 
            this.lstOverview.FormattingEnabled = true;
            this.lstOverview.ItemHeight = 20;
            this.lstOverview.Location = new System.Drawing.Point(4, 97);
            this.lstOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstOverview.Name = "lstOverview";
            this.lstOverview.Size = new System.Drawing.Size(608, 704);
            this.lstOverview.TabIndex = 1;
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverview.Location = new System.Drawing.Point(4, 75);
            this.lblOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(85, 22);
            this.lblOverview.TabIndex = 0;
            this.lblOverview.Text = "Overview";
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(624, 534);
            this.lblLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(44, 20);
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
            this.tabResults.Location = new System.Drawing.Point(4, 29);
            this.tabResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Name = "tabResults";
            this.tabResults.Size = new System.Drawing.Size(1531, 858);
            this.tabResults.TabIndex = 4;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // lblWhatMeter
            // 
            this.lblWhatMeter.AutoSize = true;
            this.lblWhatMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatMeter.Location = new System.Drawing.Point(14, 611);
            this.lblWhatMeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhatMeter.Name = "lblWhatMeter";
            this.lblWhatMeter.Size = new System.Drawing.Size(102, 22);
            this.lblWhatMeter.TabIndex = 3;
            this.lblWhatMeter.Text = "What Meter";
            this.lblWhatMeter.Click += new System.EventHandler(this.lblWhatMeter_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(894, 603);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(180, 37);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnExportResults
            // 
            this.btnExportResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportResults.Location = new System.Drawing.Point(700, 603);
            this.btnExportResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportResults.Name = "btnExportResults";
            this.btnExportResults.Size = new System.Drawing.Size(180, 37);
            this.btnExportResults.TabIndex = 1;
            this.btnExportResults.Text = "Export Results to Text File";
            this.btnExportResults.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(14, 20);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.Size = new System.Drawing.Size(1252, 560);
            this.dgvResults.TabIndex = 0;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.Transparent;
            this.txtComment.Location = new System.Drawing.Point(566, 54);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(901, 521);
            this.txtComment.TabIndex = 19;
            // 
            // txtMaxRH
            // 
            this.txtMaxRH.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxRH.Location = new System.Drawing.Point(405, 403);
            this.txtMaxRH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxRH.Name = "txtMaxRH";
            this.txtMaxRH.Size = new System.Drawing.Size(115, 26);
            this.txtMaxRH.TabIndex = 17;
            this.txtMaxRH.Text = "55.0";
            // 
            // txtMinRH
            // 
            this.txtMinRH.BackColor = System.Drawing.Color.Transparent;
            this.txtMinRH.Location = new System.Drawing.Point(276, 402);
            this.txtMinRH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinRH.Name = "txtMinRH";
            this.txtMinRH.Size = new System.Drawing.Size(115, 26);
            this.txtMinRH.TabIndex = 15;
            this.txtMinRH.Text = "45.0";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxTemp.Location = new System.Drawing.Point(148, 402);
            this.txtMaxTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(115, 26);
            this.txtMaxTemp.TabIndex = 13;
            this.txtMaxTemp.Text = "25.0";
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.txtMinTemp.Location = new System.Drawing.Point(20, 402);
            this.txtMinTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(115, 26);
            this.txtMinTemp.TabIndex = 11;
            this.txtMinTemp.Text = "23.0";
            // 
            // txtDateRun
            // 
            this.txtDateRun.BackColor = System.Drawing.Color.Transparent;
            this.txtDateRun.Location = new System.Drawing.Point(276, 263);
            this.txtDateRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateRun.Name = "txtDateRun";
            this.txtDateRun.ReadOnly = true;
            this.txtDateRun.Size = new System.Drawing.Size(242, 26);
            this.txtDateRun.TabIndex = 9;
            // 
            // txtOperator
            // 
            this.txtOperator.BackColor = System.Drawing.Color.Transparent;
            this.txtOperator.Location = new System.Drawing.Point(296, 547);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(242, 26);
            this.txtOperator.TabIndex = 7;
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.BackColor = System.Drawing.Color.Transparent;
            this.txtSupervisor.Location = new System.Drawing.Point(24, 548);
            this.txtSupervisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(242, 26);
            this.txtSupervisor.TabIndex = 5;
            // 
            // txtSequenceName
            // 
            this.txtSequenceName.BackColor = System.Drawing.Color.Transparent;
            this.txtSequenceName.Location = new System.Drawing.Point(20, 111);
            this.txtSequenceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSequenceName.Name = "txtSequenceName";
            this.txtSequenceName.Size = new System.Drawing.Size(500, 26);
            this.txtSequenceName.TabIndex = 3;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.Location = new System.Drawing.Point(20, 265);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(242, 26);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "New Run";
            // 
            // cmbClientNo
            // 
            this.cmbClientNo.BackColor = System.Drawing.Color.Transparent;
            this.cmbClientNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClientNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientNo.FormattingEnabled = true;
            this.cmbClientNo.Location = new System.Drawing.Point(936, 154);
            this.cmbClientNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClientNo.Name = "cmbClientNo";
            this.cmbClientNo.Size = new System.Drawing.Size(250, 27);
            this.cmbClientNo.TabIndex = 21;
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.Color.Transparent;
            this.cmbClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(936, 117);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(250, 27);
            this.cmbClient.TabIndex = 19;
            // 
            // cmbContractNo
            // 
            this.cmbContractNo.BackColor = System.Drawing.Color.Transparent;
            this.cmbContractNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbContractNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContractNo.FormattingEnabled = true;
            this.cmbContractNo.Location = new System.Drawing.Point(936, 72);
            this.cmbContractNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbContractNo.Name = "cmbContractNo";
            this.cmbContractNo.Size = new System.Drawing.Size(250, 27);
            this.cmbContractNo.TabIndex = 17;
            // 
            // txtLastApproval
            // 
            this.txtLastApproval.BackColor = System.Drawing.Color.Transparent;
            this.txtLastApproval.Location = new System.Drawing.Point(580, 163);
            this.txtLastApproval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastApproval.Name = "txtLastApproval";
            this.txtLastApproval.Size = new System.Drawing.Size(180, 26);
            this.txtLastApproval.TabIndex = 15;
            this.txtLastApproval.Text = "None";
            // 
            // txtYearOfManufacture
            // 
            this.txtYearOfManufacture.BackColor = System.Drawing.Color.Transparent;
            this.txtYearOfManufacture.Location = new System.Drawing.Point(186, 158);
            this.txtYearOfManufacture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYearOfManufacture.Name = "txtYearOfManufacture";
            this.txtYearOfManufacture.Size = new System.Drawing.Size(152, 26);
            this.txtYearOfManufacture.TabIndex = 13;
            this.txtYearOfManufacture.Text = "2026";
            // 
            // txtStepOwnerNo
            // 
            this.txtStepOwnerNo.BackColor = System.Drawing.Color.Transparent;
            this.txtStepOwnerNo.Location = new System.Drawing.Point(580, 121);
            this.txtStepOwnerNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStepOwnerNo.Name = "txtStepOwnerNo";
            this.txtStepOwnerNo.Size = new System.Drawing.Size(180, 26);
            this.txtStepOwnerNo.TabIndex = 11;
            // 
            // txtOwnerNo
            // 
            this.txtOwnerNo.BackColor = System.Drawing.Color.Transparent;
            this.txtOwnerNo.Location = new System.Drawing.Point(186, 117);
            this.txtOwnerNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOwnerNo.Name = "txtOwnerNo";
            this.txtOwnerNo.Size = new System.Drawing.Size(152, 26);
            this.txtOwnerNo.TabIndex = 9;
            // 
            // txtStepMSN
            // 
            this.txtStepMSN.BackColor = System.Drawing.Color.Transparent;
            this.txtStepMSN.Location = new System.Drawing.Point(580, 82);
            this.txtStepMSN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStepMSN.Name = "txtStepMSN";
            this.txtStepMSN.Size = new System.Drawing.Size(180, 26);
            this.txtStepMSN.TabIndex = 7;
            // 
            // txtMSN
            // 
            this.txtMSN.BackColor = System.Drawing.Color.Transparent;
            this.txtMSN.Location = new System.Drawing.Point(186, 72);
            this.txtMSN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMSN.Name = "txtMSN";
            this.txtMSN.Size = new System.Drawing.Size(152, 26);
            this.txtMSN.TabIndex = 5;
            // 
            // cmbMeterType
            // 
            this.cmbMeterType.BackColor = System.Drawing.Color.Transparent;
            this.cmbMeterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeterType.FormattingEnabled = true;
            this.cmbMeterType.Location = new System.Drawing.Point(580, 29);
            this.cmbMeterType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMeterType.Name = "cmbMeterType";
            this.cmbMeterType.Size = new System.Drawing.Size(606, 27);
            this.cmbMeterType.TabIndex = 3;
            // 
            // txtPositions
            // 
            this.txtPositions.BackColor = System.Drawing.Color.Transparent;
            this.txtPositions.Location = new System.Drawing.Point(186, 32);
            this.txtPositions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPositions.Name = "txtPositions";
            this.txtPositions.Size = new System.Drawing.Size(152, 26);
            this.txtPositions.TabIndex = 1;
            // 
            // txtMonPhiC
            // 
            this.txtMonPhiC.BackColor = System.Drawing.Color.Transparent;
            this.txtMonPhiC.Location = new System.Drawing.Point(296, 131);
            this.txtMonPhiC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonPhiC.Name = "txtMonPhiC";
            this.txtMonPhiC.ReadOnly = true;
            this.txtMonPhiC.Size = new System.Drawing.Size(70, 26);
            this.txtMonPhiC.TabIndex = 13;
            // 
            // txtMonPhiB
            // 
            this.txtMonPhiB.BackColor = System.Drawing.Color.Transparent;
            this.txtMonPhiB.Location = new System.Drawing.Point(296, 98);
            this.txtMonPhiB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonPhiB.Name = "txtMonPhiB";
            this.txtMonPhiB.ReadOnly = true;
            this.txtMonPhiB.Size = new System.Drawing.Size(70, 26);
            this.txtMonPhiB.TabIndex = 12;
            // 
            // txtMonPhiA
            // 
            this.txtMonPhiA.BackColor = System.Drawing.Color.Transparent;
            this.txtMonPhiA.Location = new System.Drawing.Point(296, 65);
            this.txtMonPhiA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonPhiA.Name = "txtMonPhiA";
            this.txtMonPhiA.ReadOnly = true;
            this.txtMonPhiA.Size = new System.Drawing.Size(70, 26);
            this.txtMonPhiA.TabIndex = 11;
            // 
            // txtMonIC
            // 
            this.txtMonIC.BackColor = System.Drawing.Color.Transparent;
            this.txtMonIC.Location = new System.Drawing.Point(172, 126);
            this.txtMonIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonIC.Name = "txtMonIC";
            this.txtMonIC.ReadOnly = true;
            this.txtMonIC.Size = new System.Drawing.Size(70, 26);
            this.txtMonIC.TabIndex = 9;
            // 
            // txtMonIB
            // 
            this.txtMonIB.BackColor = System.Drawing.Color.Transparent;
            this.txtMonIB.Location = new System.Drawing.Point(172, 94);
            this.txtMonIB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonIB.Name = "txtMonIB";
            this.txtMonIB.ReadOnly = true;
            this.txtMonIB.Size = new System.Drawing.Size(70, 26);
            this.txtMonIB.TabIndex = 8;
            // 
            // txtMonIA
            // 
            this.txtMonIA.BackColor = System.Drawing.Color.Transparent;
            this.txtMonIA.Location = new System.Drawing.Point(172, 60);
            this.txtMonIA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonIA.Name = "txtMonIA";
            this.txtMonIA.ReadOnly = true;
            this.txtMonIA.Size = new System.Drawing.Size(70, 26);
            this.txtMonIA.TabIndex = 7;
            // 
            // txtMonUC
            // 
            this.txtMonUC.BackColor = System.Drawing.Color.Transparent;
            this.txtMonUC.Location = new System.Drawing.Point(58, 126);
            this.txtMonUC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonUC.Name = "txtMonUC";
            this.txtMonUC.ReadOnly = true;
            this.txtMonUC.Size = new System.Drawing.Size(70, 26);
            this.txtMonUC.TabIndex = 5;
            // 
            // txtMonUB
            // 
            this.txtMonUB.BackColor = System.Drawing.Color.Transparent;
            this.txtMonUB.Location = new System.Drawing.Point(58, 94);
            this.txtMonUB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonUB.Name = "txtMonUB";
            this.txtMonUB.ReadOnly = true;
            this.txtMonUB.Size = new System.Drawing.Size(70, 26);
            this.txtMonUB.TabIndex = 4;
            // 
            // txtMonUA
            // 
            this.txtMonUA.BackColor = System.Drawing.Color.Transparent;
            this.txtMonUA.Location = new System.Drawing.Point(58, 60);
            this.txtMonUA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonUA.Name = "txtMonUA";
            this.txtMonUA.ReadOnly = true;
            this.txtMonUA.Size = new System.Drawing.Size(70, 26);
            this.txtMonUA.TabIndex = 3;
            // 
            // txtEnvHumidity
            // 
            this.txtEnvHumidity.BackColor = System.Drawing.Color.Transparent;
            this.txtEnvHumidity.Location = new System.Drawing.Point(264, 46);
            this.txtEnvHumidity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnvHumidity.Name = "txtEnvHumidity";
            this.txtEnvHumidity.ReadOnly = true;
            this.txtEnvHumidity.Size = new System.Drawing.Size(102, 26);
            this.txtEnvHumidity.TabIndex = 3;
            // 
            // txtEnvTemp
            // 
            this.txtEnvTemp.BackColor = System.Drawing.Color.Transparent;
            this.txtEnvTemp.Location = new System.Drawing.Point(26, 46);
            this.txtEnvTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnvTemp.Name = "txtEnvTemp";
            this.txtEnvTemp.ReadOnly = true;
            this.txtEnvTemp.Size = new System.Drawing.Size(102, 26);
            this.txtEnvTemp.TabIndex = 1;
            // 
            // txtTotalS
            // 
            this.txtTotalS.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalS.Location = new System.Drawing.Point(45, 86);
            this.txtTotalS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalS.Name = "txtTotalS";
            this.txtTotalS.ReadOnly = true;
            this.txtTotalS.Size = new System.Drawing.Size(320, 26);
            this.txtTotalS.TabIndex = 5;
            // 
            // txtTotalQ
            // 
            this.txtTotalQ.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalQ.Location = new System.Drawing.Point(45, 54);
            this.txtTotalQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalQ.Name = "txtTotalQ";
            this.txtTotalQ.ReadOnly = true;
            this.txtTotalQ.Size = new System.Drawing.Size(320, 26);
            this.txtTotalQ.TabIndex = 3;
            // 
            // txtTotalP
            // 
            this.txtTotalP.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalP.Location = new System.Drawing.Point(45, 20);
            this.txtTotalP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalP.Name = "txtTotalP";
            this.txtTotalP.ReadOnly = true;
            this.txtTotalP.Size = new System.Drawing.Size(320, 26);
            this.txtTotalP.TabIndex = 1;
            // 
            // txtBaseIm
            // 
            this.txtBaseIm.BackColor = System.Drawing.Color.Transparent;
            this.txtBaseIm.Location = new System.Drawing.Point(276, 60);
            this.txtBaseIm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaseIm.Name = "txtBaseIm";
            this.txtBaseIm.ReadOnly = true;
            this.txtBaseIm.Size = new System.Drawing.Size(90, 26);
            this.txtBaseIm.TabIndex = 7;
            // 
            // txtBaseFreq
            // 
            this.txtBaseFreq.BackColor = System.Drawing.Color.Transparent;
            this.txtBaseFreq.Location = new System.Drawing.Point(64, 60);
            this.txtBaseFreq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaseFreq.Name = "txtBaseFreq";
            this.txtBaseFreq.ReadOnly = true;
            this.txtBaseFreq.Size = new System.Drawing.Size(90, 26);
            this.txtBaseFreq.TabIndex = 5;
            // 
            // txtBaseIb
            // 
            this.txtBaseIb.BackColor = System.Drawing.Color.Transparent;
            this.txtBaseIb.Location = new System.Drawing.Point(276, 25);
            this.txtBaseIb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaseIb.Name = "txtBaseIb";
            this.txtBaseIb.ReadOnly = true;
            this.txtBaseIb.Size = new System.Drawing.Size(90, 26);
            this.txtBaseIb.TabIndex = 3;
            // 
            // txtBaseUb
            // 
            this.txtBaseUb.BackColor = System.Drawing.Color.Transparent;
            this.txtBaseUb.Location = new System.Drawing.Point(64, 25);
            this.txtBaseUb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaseUb.Name = "txtBaseUb";
            this.txtBaseUb.ReadOnly = true;
            this.txtBaseUb.Size = new System.Drawing.Size(90, 26);
            this.txtBaseUb.TabIndex = 1;
            // 
            // cmbStep
            // 
            this.cmbStep.BackColor = System.Drawing.Color.Transparent;
            this.cmbStep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Location = new System.Drawing.Point(628, 482);
            this.cmbStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(199, 27);
            this.cmbStep.TabIndex = 5;
            this.cmbStep.SelectedIndexChanged += new System.EventHandler(this.cmbStep_SelectedIndexChanged);
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.Transparent;
            this.txtLogs.Location = new System.Drawing.Point(624, 558);
            this.txtLogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(868, 242);
            this.txtLogs.TabIndex = 2;
            // 
            // cmbWhatMeter
            // 
            this.cmbWhatMeter.BackColor = System.Drawing.Color.Transparent;
            this.cmbWhatMeter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWhatMeter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWhatMeter.FormattingEnabled = true;
            this.cmbWhatMeter.Location = new System.Drawing.Point(104, 606);
            this.cmbWhatMeter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWhatMeter.Name = "cmbWhatMeter";
            this.cmbWhatMeter.Size = new System.Drawing.Size(192, 27);
            this.cmbWhatMeter.TabIndex = 4;
            // 
            // frmTestRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 959);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblBenchName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private CabconPMP.TransparentTextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private CabconPMP.TransparentTextBox txtMaxRH;
        private System.Windows.Forms.Label lblMaxRH;
        private CabconPMP.TransparentTextBox txtMinRH;
        private System.Windows.Forms.Label lblMinRH;
        private CabconPMP.TransparentTextBox txtMaxTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private CabconPMP.TransparentTextBox txtMinTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private CabconPMP.TransparentTextBox txtDateRun;
        private System.Windows.Forms.Label lblDateRun;
        private CabconPMP.TransparentTextBox txtOperator;
        private System.Windows.Forms.Label lblOperator;
        private CabconPMP.TransparentTextBox txtSupervisor;
        private System.Windows.Forms.Label lblSupervisor;
        private CabconPMP.TransparentTextBox txtSequenceName;
        private System.Windows.Forms.Label lblSequenceName;
        private CabconPMP.TransparentTextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpDeviceInputs;
        private CabconPMP.TransparentTextBox txtPositions;
        private System.Windows.Forms.Label lblPositions;
        private CabconPMP.TransparentComboBox cmbMeterType;
        private System.Windows.Forms.Label lblMeterType;
        private CabconPMP.TransparentTextBox txtStepMSN;
        private System.Windows.Forms.Label lblStepMSN;
        private CabconPMP.TransparentTextBox txtMSN;
        private System.Windows.Forms.Label lblMSN;
        private CabconPMP.TransparentTextBox txtStepOwnerNo;
        private System.Windows.Forms.Label lblStepOwner;
        private CabconPMP.TransparentTextBox txtOwnerNo;
        private System.Windows.Forms.Label lblOwnerNo;
        private CabconPMP.TransparentTextBox txtLastApproval;
        private System.Windows.Forms.Label lblLastApproval;
        private CabconPMP.TransparentTextBox txtYearOfManufacture;
        private System.Windows.Forms.Label lblYear;
        private CabconPMP.TransparentComboBox cmbClientNo;
        private System.Windows.Forms.Label lblClientNo;
        private CabconPMP.TransparentComboBox cmbClient;
        private System.Windows.Forms.Label lblClient;
        private CabconPMP.TransparentComboBox cmbContractNo;
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
        private CabconPMP.TransparentComboBox cmbStep;
        private System.Windows.Forms.Label lblSingleStep;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpBaseValues;
        private CabconPMP.TransparentTextBox txtBaseIm;
        private System.Windows.Forms.Label lblBaseIm;
        private CabconPMP.TransparentTextBox txtBaseFreq;
        private System.Windows.Forms.Label lblBaseFreq;
        private CabconPMP.TransparentTextBox txtBaseIb;
        private System.Windows.Forms.Label lblBaseIb;
        private CabconPMP.TransparentTextBox txtBaseUb;
        private System.Windows.Forms.Label lblBaseUb;
        private System.Windows.Forms.GroupBox grpRangeLimits;
        private System.Windows.Forms.Label lblRangeLimits;
        private System.Windows.Forms.GroupBox grpLiveTelemetry;
        private System.Windows.Forms.Label lblMonFreq;
        private CabconPMP.TransparentTextBox txtMonPhiC;
        private CabconPMP.TransparentTextBox txtMonPhiB;
        private CabconPMP.TransparentTextBox txtMonPhiA;
        private CabconPMP.TransparentTextBox txtMonIC;
        private CabconPMP.TransparentTextBox txtMonIB;
        private CabconPMP.TransparentTextBox txtMonIA;
        private System.Windows.Forms.Label lblLiveI;
        private CabconPMP.TransparentTextBox txtMonUC;
        private CabconPMP.TransparentTextBox txtMonUB;
        private CabconPMP.TransparentTextBox txtMonUA;
        private System.Windows.Forms.Label lblLiveU;
        private System.Windows.Forms.Label lblPhaseC;
        private System.Windows.Forms.Label lblPhaseB;
        private System.Windows.Forms.Label lblPhaseA;
        private System.Windows.Forms.GroupBox grpActualPower;
        private CabconPMP.TransparentTextBox txtTotalS;
        private System.Windows.Forms.Label lblTotalS;
        private CabconPMP.TransparentTextBox txtTotalQ;
        private System.Windows.Forms.Label lblTotalQ;
        private CabconPMP.TransparentTextBox txtTotalP;
        private System.Windows.Forms.Label lblTotalP;
        private System.Windows.Forms.GroupBox grpEnvValues;
        private CabconPMP.TransparentTextBox txtEnvHumidity;
        private System.Windows.Forms.Label lblHumidity;
        private CabconPMP.TransparentTextBox txtEnvTemp;
        private System.Windows.Forms.Label lblTemp;
        private CabconPMP.TransparentTextBox txtLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnExportResults;
        private System.Windows.Forms.Button btnReport;
        private CabconPMP.TransparentComboBox cmbWhatMeter;
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
