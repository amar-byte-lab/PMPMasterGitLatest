namespace CabconPMP.UI
{
    partial class frmProcedure
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
            this.lblSelectProc = new System.Windows.Forms.Label();
            this.cmbProcedures = new System.Windows.Forms.ComboBox();
            this.lblProcName = new System.Windows.Forms.Label();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.lblRevision = new System.Windows.Forms.Label();
            this.numRevision = new System.Windows.Forms.NumericUpDown();
            this.btnNewProcedure = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstSteps = new System.Windows.Forms.ListBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.btnDeleteStep = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.tabControlStepDetails = new System.Windows.Forms.TabControl();
            this.tabParameters = new System.Windows.Forms.TabPage();
            this.txtStepName = new System.Windows.Forms.TextBox();
            this.lblStepName = new System.Windows.Forms.Label();
            this.grpRotation = new System.Windows.Forms.GroupBox();
            this.rbL132 = new System.Windows.Forms.RadioButton();
            this.rbL123 = new System.Windows.Forms.RadioButton();
            this.cmbFreq = new System.Windows.Forms.ComboBox();
            this.lblStepFreq = new System.Windows.Forms.Label();
            this.cmbWaveform = new System.Windows.Forms.ComboBox();
            this.lblWaveform = new System.Windows.Forms.Label();
            this.cmbPFValue = new System.Windows.Forms.ComboBox();
            this.lblPFValue = new System.Windows.Forms.Label();
            this.grpLagLead = new System.Windows.Forms.GroupBox();
            this.rbLeading = new System.Windows.Forms.RadioButton();
            this.rbLagging = new System.Windows.Forms.RadioButton();
            this.grpConsDeliv = new System.Windows.Forms.GroupBox();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbConsumption = new System.Windows.Forms.RadioButton();
            this.cmbPFType = new System.Windows.Forms.ComboBox();
            this.lblPFType = new System.Windows.Forms.Label();
            this.lblStepIC = new System.Windows.Forms.Label();
            this.cmbIC = new System.Windows.Forms.ComboBox();
            this.lblStepIB = new System.Windows.Forms.Label();
            this.cmbIB = new System.Windows.Forms.ComboBox();
            this.lblStepIA = new System.Windows.Forms.Label();
            this.cmbIA = new System.Windows.Forms.ComboBox();
            this.lblStepUC = new System.Windows.Forms.Label();
            this.cmbUC = new System.Windows.Forms.ComboBox();
            this.lblStepUB = new System.Windows.Forms.Label();
            this.cmbUB = new System.Windows.Forms.ComboBox();
            this.lblStepUA = new System.Windows.Forms.Label();
            this.cmbUA = new System.Windows.Forms.ComboBox();
            this.tabType = new System.Windows.Forms.TabPage();
            this.grpImpExp = new System.Windows.Forms.GroupBox();
            this.chkImport2 = new System.Windows.Forms.CheckBox();
            this.chkExport = new System.Windows.Forms.CheckBox();
            this.chkImport = new System.Windows.Forms.CheckBox();
            this.grpStoring = new System.Windows.Forms.GroupBox();
            this.rbMean = new System.Windows.Forms.RadioButton();
            this.rbLastVal = new System.Windows.Forms.RadioButton();
            this.rbStoreNone = new System.Windows.Forms.RadioButton();
            this.grpChannel = new System.Windows.Forms.GroupBox();
            this.cmbChannelNo = new System.Windows.Forms.ComboBox();
            this.lblChannelNo = new System.Windows.Forms.Label();
            this.grpErrorDial = new System.Windows.Forms.GroupBox();
            this.cmbNumDecPlace = new System.Windows.Forms.ComboBox();
            this.lblNumDecPlace = new System.Windows.Forms.Label();
            this.txtNumPulsesErr = new System.Windows.Forms.TextBox();
            this.lblNumPulsesErr = new System.Windows.Forms.Label();
            this.chkSymmetrical = new System.Windows.Forms.CheckBox();
            this.cmbLLimit = new System.Windows.Forms.ComboBox();
            this.lblLLimit = new System.Windows.Forms.Label();
            this.cmbULimit = new System.Windows.Forms.ComboBox();
            this.lblULimit = new System.Windows.Forms.Label();
            this.grpStartCreep = new System.Windows.Forms.GroupBox();
            this.cmbNumPulsesSC = new System.Windows.Forms.ComboBox();
            this.lblNumPulsesSC = new System.Windows.Forms.Label();
            this.cmbMeasurement = new System.Windows.Forms.ComboBox();
            this.lblMeasurement = new System.Windows.Forms.Label();
            this.cmbTestType = new System.Windows.Forms.ComboBox();
            this.lblTestType = new System.Windows.Forms.Label();
            this.tabDuration = new System.Windows.Forms.TabPage();
            this.grpPostAction = new System.Windows.Forms.GroupBox();
            this.rbNextTest = new System.Windows.Forms.RadioButton();
            this.rbWaitI0 = new System.Windows.Forms.RadioButton();
            this.rbWait = new System.Windows.Forms.RadioButton();
            this.grpDuration = new System.Windows.Forms.GroupBox();
            this.lblTimeoutHint = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.rbTimeDuration = new System.Windows.Forms.RadioButton();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.chkWithAmp = new System.Windows.Forms.CheckBox();
            this.btnDelAfter = new System.Windows.Forms.Button();
            this.btnAddAfter = new System.Windows.Forms.Button();
            this.btnDelDuring = new System.Windows.Forms.Button();
            this.btnAddDuring = new System.Windows.Forms.Button();
            this.btnDelBefore = new System.Windows.Forms.Button();
            this.btnAddBefore = new System.Windows.Forms.Button();
            this.lstAfterCmds = new System.Windows.Forms.ListBox();
            this.lblAfterCmds = new System.Windows.Forms.Label();
            this.lstDuringCmds = new System.Windows.Forms.ListBox();
            this.lblDuringCmds = new System.Windows.Forms.Label();
            this.lstBeforeCmds = new System.Windows.Forms.ListBox();
            this.lblBeforeCmds = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtControlCommand = new System.Windows.Forms.TextBox();
            this.lblControlCommand = new System.Windows.Forms.Label();
            this.grpCtrlType = new System.Windows.Forms.GroupBox();
            this.rbCtrlWait = new System.Windows.Forms.RadioButton();
            this.rbCtrlProgram = new System.Windows.Forms.RadioButton();
            this.rbCtrlManual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numRevision)).BeginInit();
            this.tabControlStepDetails.SuspendLayout();
            this.tabParameters.SuspendLayout();
            this.grpRotation.SuspendLayout();
            this.grpLagLead.SuspendLayout();
            this.grpConsDeliv.SuspendLayout();
            this.tabType.SuspendLayout();
            this.grpImpExp.SuspendLayout();
            this.grpStoring.SuspendLayout();
            this.grpChannel.SuspendLayout();
            this.grpErrorDial.SuspendLayout();
            this.grpStartCreep.SuspendLayout();
            this.tabDuration.SuspendLayout();
            this.grpPostAction.SuspendLayout();
            this.grpDuration.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.grpCtrlType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectProc
            // 
            this.lblSelectProc.AutoSize = true;
            this.lblSelectProc.Location = new System.Drawing.Point(12, 18);
            this.lblSelectProc.Name = "lblSelectProc";
            this.lblSelectProc.Size = new System.Drawing.Size(97, 15);
            this.lblSelectProc.TabIndex = 0;
            this.lblSelectProc.Text = "Select Procedure:";
            // 
            // cmbProcedures
            // 
            this.cmbProcedures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcedures.FormattingEnabled = true;
            this.cmbProcedures.Location = new System.Drawing.Point(120, 15);
            this.cmbProcedures.Name = "cmbProcedures";
            this.cmbProcedures.Size = new System.Drawing.Size(200, 23);
            this.cmbProcedures.TabIndex = 1;
            this.cmbProcedures.SelectedIndexChanged += new System.EventHandler(this.cmbProcedures_SelectedIndexChanged);
            // 
            // lblProcName
            // 
            this.lblProcName.AutoSize = true;
            this.lblProcName.Location = new System.Drawing.Point(340, 18);
            this.lblProcName.Name = "lblProcName";
            this.lblProcName.Size = new System.Drawing.Size(42, 15);
            this.lblProcName.TabIndex = 2;
            this.lblProcName.Text = "Name:";
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.Location = new System.Drawing.Point(385, 15);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(250, 23);
            this.txtProcedureName.TabIndex = 3;
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(650, 18);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(54, 15);
            this.lblRevision.TabIndex = 4;
            this.lblRevision.Text = "Revision:";
            // 
            // numRevision
            // 
            this.numRevision.Location = new System.Drawing.Point(710, 15);
            this.numRevision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRevision.Name = "numRevision";
            this.numRevision.Size = new System.Drawing.Size(60, 23);
            this.numRevision.TabIndex = 5;
            this.numRevision.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNewProcedure
            // 
            this.btnNewProcedure.Location = new System.Drawing.Point(780, 13);
            this.btnNewProcedure.Name = "btnNewProcedure";
            this.btnNewProcedure.Size = new System.Drawing.Size(90, 26);
            this.btnNewProcedure.TabIndex = 6;
            this.btnNewProcedure.Text = "New Proc";
            this.btnNewProcedure.UseVisualStyleBackColor = true;
            this.btnNewProcedure.Click += new System.EventHandler(this.btnNewProcedure_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(780, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstSteps
            // 
            this.lstSteps.FormattingEnabled = true;
            this.lstSteps.ItemHeight = 15;
            this.lstSteps.Location = new System.Drawing.Point(12, 75);
            this.lstSteps.Name = "lstSteps";
            this.lstSteps.Size = new System.Drawing.Size(200, 319);
            this.lstSteps.TabIndex = 8;
            this.lstSteps.SelectedIndexChanged += new System.EventHandler(this.lstSteps_SelectedIndexChanged);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSteps.Location = new System.Drawing.Point(12, 55);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(64, 15);
            this.lblSteps.TabIndex = 9;
            this.lblSteps.Text = "Test Steps";
            // 
            // btnAddStep
            // 
            this.btnAddStep.Location = new System.Drawing.Point(12, 405);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(90, 25);
            this.btnAddStep.TabIndex = 10;
            this.btnAddStep.Text = "Add Step";
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.Location = new System.Drawing.Point(122, 405);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.Size = new System.Drawing.Size(90, 25);
            this.btnDeleteStep.TabIndex = 11;
            this.btnDeleteStep.Text = "Delete Step";
            this.btnDeleteStep.UseVisualStyleBackColor = true;
            this.btnDeleteStep.Click += new System.EventHandler(this.btnDeleteStep_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(12, 436);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(90, 25);
            this.btnMoveUp.TabIndex = 12;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(122, 436);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(90, 25);
            this.btnMoveDown.TabIndex = 13;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // tabControlStepDetails
            // 
            this.tabControlStepDetails.Controls.Add(this.tabParameters);
            this.tabControlStepDetails.Controls.Add(this.tabType);
            this.tabControlStepDetails.Controls.Add(this.tabDuration);
            this.tabControlStepDetails.Controls.Add(this.tabControls);
            this.tabControlStepDetails.Location = new System.Drawing.Point(230, 55);
            this.tabControlStepDetails.Name = "tabControlStepDetails";
            this.tabControlStepDetails.SelectedIndex = 0;
            this.tabControlStepDetails.Size = new System.Drawing.Size(640, 400);
            this.tabControlStepDetails.TabIndex = 14;
            // 
            // tabParameters
            // 
            this.tabParameters.Controls.Add(this.txtStepName);
            this.tabParameters.Controls.Add(this.lblStepName);
            this.tabParameters.Controls.Add(this.grpRotation);
            this.tabParameters.Controls.Add(this.cmbFreq);
            this.tabParameters.Controls.Add(this.lblStepFreq);
            this.tabParameters.Controls.Add(this.cmbWaveform);
            this.tabParameters.Controls.Add(this.lblWaveform);
            this.tabParameters.Controls.Add(this.cmbPFValue);
            this.tabParameters.Controls.Add(this.lblPFValue);
            this.tabParameters.Controls.Add(this.grpLagLead);
            this.tabParameters.Controls.Add(this.grpConsDeliv);
            this.tabParameters.Controls.Add(this.cmbPFType);
            this.tabParameters.Controls.Add(this.lblPFType);
            this.tabParameters.Controls.Add(this.lblStepIC);
            this.tabParameters.Controls.Add(this.cmbIC);
            this.tabParameters.Controls.Add(this.lblStepIB);
            this.tabParameters.Controls.Add(this.cmbIB);
            this.tabParameters.Controls.Add(this.lblStepIA);
            this.tabParameters.Controls.Add(this.cmbIA);
            this.tabParameters.Controls.Add(this.lblStepUC);
            this.tabParameters.Controls.Add(this.cmbUC);
            this.tabParameters.Controls.Add(this.lblStepUB);
            this.tabParameters.Controls.Add(this.cmbUB);
            this.tabParameters.Controls.Add(this.lblStepUA);
            this.tabParameters.Controls.Add(this.cmbUA);
            this.tabParameters.Location = new System.Drawing.Point(4, 24);
            this.tabParameters.Name = "tabParameters";
            this.tabParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tabParameters.Size = new System.Drawing.Size(632, 372);
            this.tabParameters.TabIndex = 0;
            this.tabParameters.Text = "Test parameters";
            this.tabParameters.UseVisualStyleBackColor = true;
            // 
            // txtStepName
            // 
            this.txtStepName.Location = new System.Drawing.Point(100, 15);
            this.txtStepName.Name = "txtStepName";
            this.txtStepName.Size = new System.Drawing.Size(510, 23);
            this.txtStepName.TabIndex = 24;
            this.txtStepName.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepName
            // 
            this.lblStepName.AutoSize = true;
            this.lblStepName.Location = new System.Drawing.Point(20, 18);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(64, 15);
            this.lblStepName.TabIndex = 23;
            this.lblStepName.Text = "Test name :";
            // 
            // grpRotation
            // 
            this.grpRotation.Controls.Add(this.rbL132);
            this.grpRotation.Controls.Add(this.rbL123);
            this.grpRotation.Location = new System.Drawing.Point(375, 275);
            this.grpRotation.Name = "grpRotation";
            this.grpRotation.Size = new System.Drawing.Size(120, 80);
            this.grpRotation.TabIndex = 22;
            this.grpRotation.TabStop = false;
            this.grpRotation.Text = "Rotation field";
            // 
            // rbL132
            // 
            this.rbL132.AutoSize = true;
            this.rbL132.Location = new System.Drawing.Point(20, 48);
            this.rbL132.Name = "rbL132";
            this.rbL132.Size = new System.Drawing.Size(51, 19);
            this.rbL132.TabIndex = 1;
            this.rbL132.Text = "L132";
            this.rbL132.UseVisualStyleBackColor = true;
            this.rbL132.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbL123
            // 
            this.rbL123.AutoSize = true;
            this.rbL123.Checked = true;
            this.rbL123.Location = new System.Drawing.Point(20, 23);
            this.rbL123.Name = "rbL123";
            this.rbL123.Size = new System.Drawing.Size(51, 19);
            this.rbL123.TabIndex = 0;
            this.rbL123.TabStop = true;
            this.rbL123.Text = "L123";
            this.rbL123.UseVisualStyleBackColor = true;
            this.rbL123.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // cmbFreq
            // 
            this.cmbFreq.FormattingEnabled = true;
            this.cmbFreq.Items.AddRange(new object[] {
            "50",
            "60",
            "45",
            "55"});
            this.cmbFreq.Location = new System.Drawing.Point(240, 300);
            this.cmbFreq.Name = "cmbFreq";
            this.cmbFreq.Size = new System.Drawing.Size(100, 23);
            this.cmbFreq.TabIndex = 21;
            this.cmbFreq.Text = "50";
            this.cmbFreq.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepFreq
            // 
            this.lblStepFreq.AutoSize = true;
            this.lblStepFreq.Location = new System.Drawing.Point(200, 303);
            this.lblStepFreq.Name = "lblStepFreq";
            this.lblStepFreq.Size = new System.Drawing.Size(37, 15);
            this.lblStepFreq.TabIndex = 20;
            this.lblStepFreq.Text = "f [Hz]";
            // 
            // cmbWaveform
            // 
            this.cmbWaveform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaveform.FormattingEnabled = true;
            this.cmbWaveform.Items.AddRange(new object[] {
            "Sine wave",
            "Harmonics",
            "Triangle"});
            this.cmbWaveform.Location = new System.Drawing.Point(40, 300);
            this.cmbWaveform.Name = "cmbWaveform";
            this.cmbWaveform.Size = new System.Drawing.Size(140, 23);
            this.cmbWaveform.TabIndex = 19;
            this.cmbWaveform.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblWaveform
            // 
            this.lblWaveform.AutoSize = true;
            this.lblWaveform.Location = new System.Drawing.Point(40, 275);
            this.lblWaveform.Name = "lblWaveform";
            this.lblWaveform.Size = new System.Drawing.Size(66, 15);
            this.lblWaveform.TabIndex = 18;
            this.lblWaveform.Text = "Wave form";
            // 
            // cmbPFValue
            // 
            this.cmbPFValue.FormattingEnabled = true;
            this.cmbPFValue.Items.AddRange(new object[] {
            "1.0",
            "0.5L",
            "0.8C",
            "0.5C",
            "0.25L",
            "0.0"});
            this.cmbPFValue.Location = new System.Drawing.Point(340, 215);
            this.cmbPFValue.Name = "cmbPFValue";
            this.cmbPFValue.Size = new System.Drawing.Size(110, 23);
            this.cmbPFValue.TabIndex = 17;
            this.cmbPFValue.Text = "1.0";
            this.cmbPFValue.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblPFValue
            // 
            this.lblPFValue.AutoSize = true;
            this.lblPFValue.Location = new System.Drawing.Point(340, 197);
            this.lblPFValue.Name = "lblPFValue";
            this.lblPFValue.Size = new System.Drawing.Size(51, 15);
            this.lblPFValue.TabIndex = 16;
            this.lblPFValue.Text = "PF Value";
            // 
            // grpLagLead
            // 
            this.grpLagLead.Controls.Add(this.rbLeading);
            this.grpLagLead.Controls.Add(this.rbLagging);
            this.grpLagLead.Location = new System.Drawing.Point(240, 180);
            this.grpLagLead.Name = "grpLagLead";
            this.grpLagLead.Size = new System.Drawing.Size(90, 80);
            this.grpLagLead.TabIndex = 15;
            this.grpLagLead.TabStop = false;
            // 
            // rbLeading
            // 
            this.rbLeading.AutoSize = true;
            this.rbLeading.Location = new System.Drawing.Point(10, 48);
            this.rbLeading.Name = "rbLeading";
            this.rbLeading.Size = new System.Drawing.Size(68, 19);
            this.rbLeading.TabIndex = 1;
            this.rbLeading.Text = "leading";
            this.rbLeading.UseVisualStyleBackColor = true;
            this.rbLeading.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbLagging
            // 
            this.rbLagging.AutoSize = true;
            this.rbLagging.Checked = true;
            this.rbLagging.Location = new System.Drawing.Point(10, 23);
            this.rbLagging.Name = "rbLagging";
            this.rbLagging.Size = new System.Drawing.Size(67, 19);
            this.rbLagging.TabIndex = 0;
            this.rbLagging.TabStop = true;
            this.rbLagging.Text = "lagging";
            this.rbLagging.UseVisualStyleBackColor = true;
            this.rbLagging.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // grpConsDeliv
            // 
            this.grpConsDeliv.Controls.Add(this.rbDelivery);
            this.grpConsDeliv.Controls.Add(this.rbConsumption);
            this.grpConsDeliv.Location = new System.Drawing.Point(130, 180);
            this.grpConsDeliv.Name = "grpConsDeliv";
            this.grpConsDeliv.Size = new System.Drawing.Size(100, 80);
            this.grpConsDeliv.TabIndex = 14;
            this.grpConsDeliv.TabStop = false;
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(10, 48);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(67, 19);
            this.rbDelivery.TabIndex = 1;
            this.rbDelivery.Text = "delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            this.rbDelivery.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbConsumption
            // 
            this.rbConsumption.AutoSize = true;
            this.rbConsumption.Checked = true;
            this.rbConsumption.Location = new System.Drawing.Point(10, 23);
            this.rbConsumption.Name = "rbConsumption";
            this.rbConsumption.Size = new System.Drawing.Size(95, 19);
            this.rbConsumption.TabIndex = 0;
            this.rbConsumption.TabStop = true;
            this.rbConsumption.Text = "consumption";
            this.rbConsumption.UseVisualStyleBackColor = true;
            this.rbConsumption.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // cmbPFType
            // 
            this.cmbPFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPFType.FormattingEnabled = true;
            this.cmbPFType.Items.AddRange(new object[] {
            "cos phi",
            "sin phi"});
            this.cmbPFType.Location = new System.Drawing.Point(20, 215);
            this.cmbPFType.Name = "cmbPFType";
            this.cmbPFType.Size = new System.Drawing.Size(100, 23);
            this.cmbPFType.TabIndex = 13;
            this.cmbPFType.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblPFType
            // 
            this.lblPFType.AutoSize = true;
            this.lblPFType.Location = new System.Drawing.Point(20, 197);
            this.lblPFType.Name = "lblPFType";
            this.lblPFType.Size = new System.Drawing.Size(48, 15);
            this.lblPFType.TabIndex = 12;
            this.lblPFType.Text = "PF Type";
            // 
            // lblStepIC
            // 
            this.lblStepIC.AutoSize = true;
            this.lblStepIC.Location = new System.Drawing.Point(420, 123);
            this.lblStepIC.Name = "lblStepIC";
            this.lblStepIC.Size = new System.Drawing.Size(18, 15);
            this.lblStepIC.TabIndex = 11;
            this.lblStepIC.Text = "IC";
            // 
            // cmbIC
            // 
            this.cmbIC.FormattingEnabled = true;
            this.cmbIC.Items.AddRange(new object[] {
            "100",
            "50",
            "20",
            "10",
            "5",
            "0"});
            this.cmbIC.Location = new System.Drawing.Point(420, 140);
            this.cmbIC.Name = "cmbIC";
            this.cmbIC.Size = new System.Drawing.Size(80, 23);
            this.cmbIC.TabIndex = 10;
            this.cmbIC.Text = "100";
            this.cmbIC.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepIB
            // 
            this.lblStepIB.AutoSize = true;
            this.lblStepIB.Location = new System.Drawing.Point(220, 123);
            this.lblStepIB.Name = "lblStepIB";
            this.lblStepIB.Size = new System.Drawing.Size(17, 15);
            this.lblStepIB.TabIndex = 9;
            this.lblStepIB.Text = "IB";
            // 
            // cmbIB
            // 
            this.cmbIB.FormattingEnabled = true;
            this.cmbIB.Items.AddRange(new object[] {
            "100",
            "50",
            "20",
            "10",
            "5",
            "0"});
            this.cmbIB.Location = new System.Drawing.Point(220, 140);
            this.cmbIB.Name = "cmbIB";
            this.cmbIB.Size = new System.Drawing.Size(80, 23);
            this.cmbIB.TabIndex = 8;
            this.cmbIB.Text = "100";
            this.cmbIB.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepIA
            // 
            this.lblStepIA.AutoSize = true;
            this.lblStepIA.Location = new System.Drawing.Point(20, 123);
            this.lblStepIA.Name = "lblStepIA";
            this.lblStepIA.Size = new System.Drawing.Size(18, 15);
            this.lblStepIA.TabIndex = 7;
            this.lblStepIA.Text = "IA";
            // 
            // cmbIA
            // 
            this.cmbIA.FormattingEnabled = true;
            this.cmbIA.Items.AddRange(new object[] {
            "100",
            "50",
            "20",
            "10",
            "5",
            "0"});
            this.cmbIA.Location = new System.Drawing.Point(20, 140);
            this.cmbIA.Name = "cmbIA";
            this.cmbIA.Size = new System.Drawing.Size(80, 23);
            this.cmbIA.TabIndex = 6;
            this.cmbIA.Text = "100";
            this.cmbIA.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepUC
            // 
            this.lblStepUC.AutoSize = true;
            this.lblStepUC.Location = new System.Drawing.Point(420, 58);
            this.lblStepUC.Name = "lblStepUC";
            this.lblStepUC.Size = new System.Drawing.Size(23, 15);
            this.lblStepUC.TabIndex = 5;
            this.lblStepUC.Text = "UC";
            // 
            // cmbUC
            // 
            this.cmbUC.FormattingEnabled = true;
            this.cmbUC.Items.AddRange(new object[] {
            "100",
            "0"});
            this.cmbUC.Location = new System.Drawing.Point(420, 75);
            this.cmbUC.Name = "cmbUC";
            this.cmbUC.Size = new System.Drawing.Size(80, 23);
            this.cmbUC.TabIndex = 4;
            this.cmbUC.Text = "100";
            this.cmbUC.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepUB
            // 
            this.lblStepUB.AutoSize = true;
            this.lblStepUB.Location = new System.Drawing.Point(220, 58);
            this.lblStepUB.Name = "lblStepUB";
            this.lblStepUB.Size = new System.Drawing.Size(22, 15);
            this.lblStepUB.TabIndex = 3;
            this.lblStepUB.Text = "UB";
            // 
            // cmbUB
            // 
            this.cmbUB.FormattingEnabled = true;
            this.cmbUB.Items.AddRange(new object[] {
            "100",
            "0"});
            this.cmbUB.Location = new System.Drawing.Point(220, 75);
            this.cmbUB.Name = "cmbUB";
            this.cmbUB.Size = new System.Drawing.Size(80, 23);
            this.cmbUB.TabIndex = 2;
            this.cmbUB.Text = "100";
            this.cmbUB.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepUA
            // 
            this.lblStepUA.AutoSize = true;
            this.lblStepUA.Location = new System.Drawing.Point(20, 58);
            this.lblStepUA.Name = "lblStepUA";
            this.lblStepUA.Size = new System.Drawing.Size(23, 15);
            this.lblStepUA.TabIndex = 0;
            this.lblStepUA.Text = "UA";
            // 
            // cmbUA
            // 
            this.cmbUA.FormattingEnabled = true;
            this.cmbUA.Items.AddRange(new object[] {
            "100",
            "0"});
            this.cmbUA.Location = new System.Drawing.Point(20, 75);
            this.cmbUA.Name = "cmbUA";
            this.cmbUA.Size = new System.Drawing.Size(80, 23);
            this.cmbUA.TabIndex = 1;
            this.cmbUA.Text = "100";
            this.cmbUA.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.grpImpExp);
            this.tabType.Controls.Add(this.grpStoring);
            this.tabType.Controls.Add(this.grpChannel);
            this.tabType.Controls.Add(this.grpErrorDial);
            this.tabType.Controls.Add(this.grpStartCreep);
            this.tabType.Controls.Add(this.cmbMeasurement);
            this.tabType.Controls.Add(this.lblMeasurement);
            this.tabType.Controls.Add(this.cmbTestType);
            this.tabType.Controls.Add(this.lblTestType);
            this.tabType.Location = new System.Drawing.Point(4, 24);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(632, 372);
            this.tabType.TabIndex = 1;
            this.tabType.Text = "Test type";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // grpImpExp
            // 
            this.grpImpExp.Controls.Add(this.chkImport2);
            this.grpImpExp.Controls.Add(this.chkExport);
            this.grpImpExp.Controls.Add(this.chkImport);
            this.grpImpExp.Location = new System.Drawing.Point(490, 185);
            this.grpImpExp.Name = "grpImpExp";
            this.grpImpExp.Size = new System.Drawing.Size(120, 170);
            this.grpImpExp.TabIndex = 8;
            this.grpImpExp.TabStop = false;
            this.grpImpExp.Text = "Import / Export";
            // 
            // chkImport2
            // 
            this.chkImport2.AutoSize = true;
            this.chkImport2.Location = new System.Drawing.Point(15, 95);
            this.chkImport2.Name = "chkImport2";
            this.chkImport2.Size = new System.Drawing.Size(68, 19);
            this.chkImport2.TabIndex = 2;
            this.chkImport2.Text = "Import2";
            this.chkImport2.UseVisualStyleBackColor = true;
            this.chkImport2.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // chkExport
            // 
            this.chkExport.AutoSize = true;
            this.chkExport.Location = new System.Drawing.Point(15, 60);
            this.chkExport.Name = "chkExport";
            this.chkExport.Size = new System.Drawing.Size(60, 19);
            this.chkExport.TabIndex = 1;
            this.chkExport.Text = "Export";
            this.chkExport.UseVisualStyleBackColor = true;
            this.chkExport.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // chkImport
            // 
            this.chkImport.AutoSize = true;
            this.chkImport.Location = new System.Drawing.Point(15, 25);
            this.chkImport.Name = "chkImport";
            this.chkImport.Size = new System.Drawing.Size(62, 19);
            this.chkImport.TabIndex = 0;
            this.chkImport.Text = "Import";
            this.chkImport.UseVisualStyleBackColor = true;
            this.chkImport.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // grpStoring
            // 
            this.grpStoring.Controls.Add(this.rbMean);
            this.grpStoring.Controls.Add(this.rbLastVal);
            this.grpStoring.Controls.Add(this.rbStoreNone);
            this.grpStoring.Location = new System.Drawing.Point(490, 15);
            this.grpStoring.Name = "grpStoring";
            this.grpStoring.Size = new System.Drawing.Size(120, 160);
            this.grpStoring.TabIndex = 7;
            this.grpStoring.TabStop = false;
            this.grpStoring.Text = "Storing";
            // 
            // rbMean
            // 
            this.rbMean.AutoSize = true;
            this.rbMean.Location = new System.Drawing.Point(15, 95);
            this.rbMean.Name = "rbMean";
            this.rbMean.Size = new System.Drawing.Size(55, 19);
            this.rbMean.TabIndex = 2;
            this.rbMean.Text = "mean";
            this.rbMean.UseVisualStyleBackColor = true;
            this.rbMean.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbLastVal
            // 
            this.rbLastVal.AutoSize = true;
            this.rbLastVal.Location = new System.Drawing.Point(15, 60);
            this.rbLastVal.Name = "rbLastVal";
            this.rbLastVal.Size = new System.Drawing.Size(74, 19);
            this.rbLastVal.TabIndex = 1;
            this.rbLastVal.Text = "last value";
            this.rbLastVal.UseVisualStyleBackColor = true;
            this.rbLastVal.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbStoreNone
            // 
            this.rbStoreNone.AutoSize = true;
            this.rbStoreNone.Checked = true;
            this.rbStoreNone.Location = new System.Drawing.Point(15, 25);
            this.rbStoreNone.Name = "rbStoreNone";
            this.rbStoreNone.Size = new System.Drawing.Size(52, 19);
            this.rbStoreNone.TabIndex = 0;
            this.rbStoreNone.TabStop = true;
            this.rbStoreNone.Text = "none";
            this.rbStoreNone.UseVisualStyleBackColor = true;
            this.rbStoreNone.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // grpChannel
            // 
            this.grpChannel.Controls.Add(this.cmbChannelNo);
            this.grpChannel.Controls.Add(this.lblChannelNo);
            this.grpChannel.Location = new System.Drawing.Point(280, 275);
            this.grpChannel.Name = "grpChannel";
            this.grpChannel.Size = new System.Drawing.Size(200, 80);
            this.grpChannel.TabIndex = 6;
            this.grpChannel.TabStop = false;
            this.grpChannel.Text = "Channel";
            // 
            // cmbChannelNo
            // 
            this.cmbChannelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChannelNo.FormattingEnabled = true;
            this.cmbChannelNo.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3"});
            this.cmbChannelNo.Location = new System.Drawing.Point(85, 30);
            this.cmbChannelNo.Name = "cmbChannelNo";
            this.cmbChannelNo.Size = new System.Drawing.Size(100, 23);
            this.cmbChannelNo.TabIndex = 1;
            this.cmbChannelNo.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblChannelNo
            // 
            this.lblChannelNo.AutoSize = true;
            this.lblChannelNo.Location = new System.Drawing.Point(10, 33);
            this.lblChannelNo.Name = "lblChannelNo";
            this.lblChannelNo.Size = new System.Drawing.Size(73, 15);
            this.lblChannelNo.TabIndex = 0;
            this.lblChannelNo.Text = "Channel No.";
            // 
            // grpErrorDial
            // 
            this.grpErrorDial.Controls.Add(this.cmbNumDecPlace);
            this.grpErrorDial.Controls.Add(this.lblNumDecPlace);
            this.grpErrorDial.Controls.Add(this.txtNumPulsesErr);
            this.grpErrorDial.Controls.Add(this.lblNumPulsesErr);
            this.grpErrorDial.Controls.Add(this.chkSymmetrical);
            this.grpErrorDial.Controls.Add(this.cmbLLimit);
            this.grpErrorDial.Controls.Add(this.lblLLimit);
            this.grpErrorDial.Controls.Add(this.cmbULimit);
            this.grpErrorDial.Controls.Add(this.lblULimit);
            this.grpErrorDial.Location = new System.Drawing.Point(20, 165);
            this.grpErrorDial.Name = "grpErrorDial";
            this.grpErrorDial.Size = new System.Drawing.Size(250, 190);
            this.grpErrorDial.TabIndex = 5;
            this.grpErrorDial.TabStop = false;
            this.grpErrorDial.Text = "Error / Dial test";
            // 
            // cmbNumDecPlace
            // 
            this.cmbNumDecPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumDecPlace.FormattingEnabled = true;
            this.cmbNumDecPlace.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbNumDecPlace.Location = new System.Drawing.Point(120, 150);
            this.cmbNumDecPlace.Name = "cmbNumDecPlace";
            this.cmbNumDecPlace.Size = new System.Drawing.Size(110, 23);
            this.cmbNumDecPlace.TabIndex = 8;
            this.cmbNumDecPlace.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblNumDecPlace
            // 
            this.lblNumDecPlace.AutoSize = true;
            this.lblNumDecPlace.Location = new System.Drawing.Point(15, 153);
            this.lblNumDecPlace.Name = "lblNumDecPlace";
            this.lblNumDecPlace.Size = new System.Drawing.Size(87, 15);
            this.lblNumDecPlace.TabIndex = 7;
            this.lblNumDecPlace.Text = "Decimal places";
            // 
            // txtNumPulsesErr
            // 
            this.txtNumPulsesErr.Location = new System.Drawing.Point(120, 115);
            this.txtNumPulsesErr.Name = "txtNumPulsesErr";
            this.txtNumPulsesErr.Size = new System.Drawing.Size(110, 23);
            this.txtNumPulsesErr.TabIndex = 6;
            this.txtNumPulsesErr.Text = "10";
            this.txtNumPulsesErr.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblNumPulsesErr
            // 
            this.lblNumPulsesErr.AutoSize = true;
            this.lblNumPulsesErr.Location = new System.Drawing.Point(15, 118);
            this.lblNumPulsesErr.Name = "lblNumPulsesErr";
            this.lblNumPulsesErr.Size = new System.Drawing.Size(95, 15);
            this.lblNumPulsesErr.TabIndex = 5;
            this.lblNumPulsesErr.Text = "Number of pulse";
            // 
            // chkSymmetrical
            // 
            this.chkSymmetrical.AutoSize = true;
            this.chkSymmetrical.Checked = true;
            this.chkSymmetrical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSymmetrical.Location = new System.Drawing.Point(120, 90);
            this.chkSymmetrical.Name = "chkSymmetrical";
            this.chkSymmetrical.Size = new System.Drawing.Size(91, 19);
            this.chkSymmetrical.TabIndex = 4;
            this.chkSymmetrical.Text = "symmetrical";
            this.chkSymmetrical.UseVisualStyleBackColor = true;
            this.chkSymmetrical.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // cmbLLimit
            // 
            this.cmbLLimit.FormattingEnabled = true;
            this.cmbLLimit.Items.AddRange(new object[] {
            "-0.5",
            "-1.0",
            "-2.0",
            "-3.0",
            "-5.0"});
            this.cmbLLimit.Location = new System.Drawing.Point(120, 55);
            this.cmbLLimit.Name = "cmbLLimit";
            this.cmbLLimit.Size = new System.Drawing.Size(110, 23);
            this.cmbLLimit.TabIndex = 3;
            this.cmbLLimit.Text = "-0.5";
            this.cmbLLimit.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblLLimit
            // 
            this.lblLLimit.AutoSize = true;
            this.lblLLimit.Location = new System.Drawing.Point(15, 58);
            this.lblLLimit.Name = "lblLLimit";
            this.lblLLimit.Size = new System.Drawing.Size(65, 15);
            this.lblLLimit.TabIndex = 2;
            this.lblLLimit.Text = "Lower limit";
            // 
            // cmbULimit
            // 
            this.cmbULimit.FormattingEnabled = true;
            this.cmbULimit.Items.AddRange(new object[] {
            "0.5",
            "1.0",
            "2.0",
            "3.0",
            "5.0"});
            this.cmbULimit.Location = new System.Drawing.Point(120, 20);
            this.cmbULimit.Name = "cmbULimit";
            this.cmbULimit.Size = new System.Drawing.Size(110, 23);
            this.cmbULimit.TabIndex = 1;
            this.cmbULimit.Text = "0.5";
            this.cmbULimit.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblULimit
            // 
            this.lblULimit.AutoSize = true;
            this.lblULimit.Location = new System.Drawing.Point(15, 23);
            this.lblULimit.Name = "lblULimit";
            this.lblULimit.Size = new System.Drawing.Size(65, 15);
            this.lblULimit.TabIndex = 0;
            this.lblULimit.Text = "Upper limit";
            // 
            // grpStartCreep
            // 
            this.grpStartCreep.Controls.Add(this.cmbNumPulsesSC);
            this.grpStartCreep.Controls.Add(this.lblNumPulsesSC);
            this.grpStartCreep.Location = new System.Drawing.Point(20, 65);
            this.grpStartCreep.Name = "grpStartCreep";
            this.grpStartCreep.Size = new System.Drawing.Size(250, 80);
            this.grpStartCreep.TabIndex = 4;
            this.grpStartCreep.TabStop = false;
            this.grpStartCreep.Text = "Start / Creep test";
            // 
            // cmbNumPulsesSC
            // 
            this.cmbNumPulsesSC.FormattingEnabled = true;
            this.cmbNumPulsesSC.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.cmbNumPulsesSC.Location = new System.Drawing.Point(120, 30);
            this.cmbNumPulsesSC.Name = "cmbNumPulsesSC";
            this.cmbNumPulsesSC.Size = new System.Drawing.Size(110, 23);
            this.cmbNumPulsesSC.TabIndex = 1;
            this.cmbNumPulsesSC.Text = "1";
            this.cmbNumPulsesSC.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblNumPulsesSC
            // 
            this.lblNumPulsesSC.AutoSize = true;
            this.lblNumPulsesSC.Location = new System.Drawing.Point(15, 33);
            this.lblNumPulsesSC.Name = "lblNumPulsesSC";
            this.lblNumPulsesSC.Size = new System.Drawing.Size(78, 15);
            this.lblNumPulsesSC.TabIndex = 0;
            this.lblNumPulsesSC.Text = "No. of pulses";
            // 
            // cmbMeasurement
            // 
            this.cmbMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasurement.FormattingEnabled = true;
            this.cmbMeasurement.Items.AddRange(new object[] {
            "Active (P)",
            "Reactive (Q)",
            "Apparent (S)"});
            this.cmbMeasurement.Location = new System.Drawing.Point(365, 15);
            this.cmbMeasurement.Name = "cmbMeasurement";
            this.cmbMeasurement.Size = new System.Drawing.Size(110, 23);
            this.cmbMeasurement.TabIndex = 3;
            this.cmbMeasurement.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblMeasurement
            // 
            this.lblMeasurement.AutoSize = true;
            this.lblMeasurement.Location = new System.Drawing.Point(280, 18);
            this.lblMeasurement.Name = "lblMeasurement";
            this.lblMeasurement.Size = new System.Drawing.Size(80, 15);
            this.lblMeasurement.TabIndex = 2;
            this.lblMeasurement.Text = "Measurement";
            // 
            // cmbTestType
            // 
            this.cmbTestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestType.FormattingEnabled = true;
            this.cmbTestType.Items.AddRange(new object[] {
            "No Test",
            "Creep",
            "Start",
            "Error"});
            this.cmbTestType.Location = new System.Drawing.Point(100, 15);
            this.cmbTestType.Name = "cmbTestType";
            this.cmbTestType.Size = new System.Drawing.Size(170, 23);
            this.cmbTestType.TabIndex = 1;
            this.cmbTestType.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Location = new System.Drawing.Point(20, 18);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(55, 15);
            this.lblTestType.TabIndex = 0;
            this.lblTestType.Text = "Test type";
            // 
            // tabDuration
            // 
            this.tabDuration.Controls.Add(this.grpPostAction);
            this.tabDuration.Controls.Add(this.grpDuration);
            this.tabDuration.Location = new System.Drawing.Point(4, 24);
            this.tabDuration.Name = "tabDuration";
            this.tabDuration.Size = new System.Drawing.Size(632, 372);
            this.tabDuration.TabIndex = 2;
            this.tabDuration.Text = "Test duration";
            this.tabDuration.UseVisualStyleBackColor = true;
            // 
            // grpPostAction
            // 
            this.grpPostAction.Controls.Add(this.rbNextTest);
            this.grpPostAction.Controls.Add(this.rbWaitI0);
            this.grpPostAction.Controls.Add(this.rbWait);
            this.grpPostAction.Location = new System.Drawing.Point(340, 15);
            this.grpPostAction.Name = "grpPostAction";
            this.grpPostAction.Size = new System.Drawing.Size(275, 140);
            this.grpPostAction.TabIndex = 1;
            this.grpPostAction.TabStop = false;
            this.grpPostAction.Text = "Action after test";
            // 
            // rbNextTest
            // 
            this.rbNextTest.AutoSize = true;
            this.rbNextTest.Checked = true;
            this.rbNextTest.Location = new System.Drawing.Point(20, 80);
            this.rbNextTest.Name = "rbNextTest";
            this.rbNextTest.Size = new System.Drawing.Size(71, 19);
            this.rbNextTest.TabIndex = 2;
            this.rbNextTest.TabStop = true;
            this.rbNextTest.Text = "Next test";
            this.rbNextTest.UseVisualStyleBackColor = true;
            this.rbNextTest.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbWaitI0
            // 
            this.rbWaitI0.AutoSize = true;
            this.rbWaitI0.Location = new System.Drawing.Point(20, 52);
            this.rbWaitI0.Name = "rbWaitI0";
            this.rbWaitI0.Size = new System.Drawing.Size(70, 19);
            this.rbWaitI0.TabIndex = 1;
            this.rbWaitI0.Text = "Wait I=0";
            this.rbWaitI0.UseVisualStyleBackColor = true;
            this.rbWaitI0.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbWait
            // 
            this.rbWait.AutoSize = true;
            this.rbWait.Location = new System.Drawing.Point(20, 25);
            this.rbWait.Name = "rbWait";
            this.rbWait.Size = new System.Drawing.Size(49, 19);
            this.rbWait.TabIndex = 0;
            this.rbWait.Text = "Wait";
            this.rbWait.UseVisualStyleBackColor = true;
            this.rbWait.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // grpDuration
            // 
            this.grpDuration.Controls.Add(this.lblTimeoutHint);
            this.grpDuration.Controls.Add(this.txtTimeout);
            this.grpDuration.Controls.Add(this.rbTimeDuration);
            this.grpDuration.Location = new System.Drawing.Point(15, 15);
            this.grpDuration.Name = "grpDuration";
            this.grpDuration.Size = new System.Drawing.Size(310, 140);
            this.grpDuration.TabIndex = 0;
            this.grpDuration.TabStop = false;
            this.grpDuration.Text = "Test duration";
            // 
            // lblTimeoutHint
            // 
            this.lblTimeoutHint.AutoSize = true;
            this.lblTimeoutHint.Location = new System.Drawing.Point(190, 31);
            this.lblTimeoutHint.Name = "lblTimeoutHint";
            this.lblTimeoutHint.Size = new System.Drawing.Size(59, 15);
            this.lblTimeoutHint.TabIndex = 2;
            this.lblTimeoutHint.Text = "hh:mm:ss";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(90, 28);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(90, 23);
            this.txtTimeout.TabIndex = 1;
            this.txtTimeout.Text = "00:01:00";
            this.txtTimeout.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbTimeDuration
            // 
            this.rbTimeDuration.AutoSize = true;
            this.rbTimeDuration.Checked = true;
            this.rbTimeDuration.Location = new System.Drawing.Point(20, 30);
            this.rbTimeDuration.Name = "rbTimeDuration";
            this.rbTimeDuration.Size = new System.Drawing.Size(52, 19);
            this.rbTimeDuration.TabIndex = 0;
            this.rbTimeDuration.TabStop = true;
            this.rbTimeDuration.Text = "Time";
            this.rbTimeDuration.UseVisualStyleBackColor = true;
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.chkWithAmp);
            this.tabControls.Controls.Add(this.btnDelAfter);
            this.tabControls.Controls.Add(this.btnAddAfter);
            this.tabControls.Controls.Add(this.btnDelDuring);
            this.tabControls.Controls.Add(this.btnAddDuring);
            this.tabControls.Controls.Add(this.btnDelBefore);
            this.tabControls.Controls.Add(this.btnAddBefore);
            this.tabControls.Controls.Add(this.lstAfterCmds);
            this.tabControls.Controls.Add(this.lblAfterCmds);
            this.tabControls.Controls.Add(this.lstDuringCmds);
            this.tabControls.Controls.Add(this.lblDuringCmds);
            this.tabControls.Controls.Add(this.lstBeforeCmds);
            this.tabControls.Controls.Add(this.lblBeforeCmds);
            this.tabControls.Controls.Add(this.btnBrowse);
            this.tabControls.Controls.Add(this.txtControlCommand);
            this.tabControls.Controls.Add(this.lblControlCommand);
            this.tabControls.Controls.Add(this.grpCtrlType);
            this.tabControls.Location = new System.Drawing.Point(4, 24);
            this.tabControls.Name = "tabControls";
            this.tabControls.Size = new System.Drawing.Size(632, 372);
            this.tabControls.TabIndex = 3;
            this.tabControls.Text = "Control functions";
            this.tabControls.UseVisualStyleBackColor = true;
            // 
            // chkWithAmp
            // 
            this.chkWithAmp.AutoSize = true;
            this.chkWithAmp.Location = new System.Drawing.Point(240, 340);
            this.chkWithAmp.Name = "chkWithAmp";
            this.chkWithAmp.Size = new System.Drawing.Size(49, 19);
            this.chkWithAmp.TabIndex = 16;
            this.chkWithAmp.Text = "w/A";
            this.chkWithAmp.UseVisualStyleBackColor = true;
            this.chkWithAmp.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // btnDelAfter
            // 
            this.btnDelAfter.Location = new System.Drawing.Point(240, 300);
            this.btnDelAfter.Name = "btnDelAfter";
            this.btnDelAfter.Size = new System.Drawing.Size(35, 23);
            this.btnDelAfter.TabIndex = 15;
            this.btnDelAfter.Text = "<<";
            this.btnDelAfter.UseVisualStyleBackColor = true;
            this.btnDelAfter.Click += new System.EventHandler(this.btnDelAfter_Click);
            // 
            // btnAddAfter
            // 
            this.btnAddAfter.Location = new System.Drawing.Point(240, 270);
            this.btnAddAfter.Name = "btnAddAfter";
            this.btnAddAfter.Size = new System.Drawing.Size(35, 23);
            this.btnAddAfter.TabIndex = 14;
            this.btnAddAfter.Text = ">>";
            this.btnAddAfter.UseVisualStyleBackColor = true;
            this.btnAddAfter.Click += new System.EventHandler(this.btnAddAfter_Click);
            // 
            // btnDelDuring
            // 
            this.btnDelDuring.Location = new System.Drawing.Point(240, 180);
            this.btnDelDuring.Name = "btnDelDuring";
            this.btnDelDuring.Size = new System.Drawing.Size(35, 23);
            this.btnDelDuring.TabIndex = 13;
            this.btnDelDuring.Text = "<<";
            this.btnDelDuring.UseVisualStyleBackColor = true;
            this.btnDelDuring.Click += new System.EventHandler(this.btnDelDuring_Click);
            // 
            // btnAddDuring
            // 
            this.btnAddDuring.Location = new System.Drawing.Point(240, 150);
            this.btnAddDuring.Name = "btnAddDuring";
            this.btnAddDuring.Size = new System.Drawing.Size(35, 23);
            this.btnAddDuring.TabIndex = 12;
            this.btnAddDuring.Text = ">>";
            this.btnAddDuring.UseVisualStyleBackColor = true;
            this.btnAddDuring.Click += new System.EventHandler(this.btnAddDuring_Click);
            // 
            // btnDelBefore
            // 
            this.btnDelBefore.Location = new System.Drawing.Point(240, 55);
            this.btnDelBefore.Name = "btnDelBefore";
            this.btnDelBefore.Size = new System.Drawing.Size(35, 23);
            this.btnDelBefore.TabIndex = 11;
            this.btnDelBefore.Text = "<<";
            this.btnDelBefore.UseVisualStyleBackColor = true;
            this.btnDelBefore.Click += new System.EventHandler(this.btnDelBefore_Click);
            // 
            // btnAddBefore
            // 
            this.btnAddBefore.Location = new System.Drawing.Point(240, 25);
            this.btnAddBefore.Name = "btnAddBefore";
            this.btnAddBefore.Size = new System.Drawing.Size(35, 23);
            this.btnAddBefore.TabIndex = 10;
            this.btnAddBefore.Text = ">>";
            this.btnAddBefore.UseVisualStyleBackColor = true;
            this.btnAddBefore.Click += new System.EventHandler(this.btnAddBefore_Click);
            // 
            // lstAfterCmds
            // 
            this.lstAfterCmds.FormattingEnabled = true;
            this.lstAfterCmds.ItemHeight = 15;
            this.lstAfterCmds.Location = new System.Drawing.Point(290, 260);
            this.lstAfterCmds.Name = "lstAfterCmds";
            this.lstAfterCmds.Size = new System.Drawing.Size(325, 94);
            this.lstAfterCmds.TabIndex = 9;
            // 
            // lblAfterCmds
            // 
            this.lblAfterCmds.AutoSize = true;
            this.lblAfterCmds.Location = new System.Drawing.Point(290, 242);
            this.lblAfterCmds.Name = "lblAfterCmds";
            this.lblAfterCmds.Size = new System.Drawing.Size(59, 15);
            this.lblAfterCmds.TabIndex = 8;
            this.lblAfterCmds.Text = "After test";
            // 
            // lstDuringCmds
            // 
            this.lstDuringCmds.FormattingEnabled = true;
            this.lstDuringCmds.ItemHeight = 15;
            this.lstDuringCmds.Location = new System.Drawing.Point(290, 140);
            this.lstDuringCmds.Name = "lstDuringCmds";
            this.lstDuringCmds.Size = new System.Drawing.Size(325, 94);
            this.lstDuringCmds.TabIndex = 7;
            // 
            // lblDuringCmds
            // 
            this.lblDuringCmds.AutoSize = true;
            this.lblDuringCmds.Location = new System.Drawing.Point(290, 122);
            this.lblDuringCmds.Name = "lblDuringCmds";
            this.lblDuringCmds.Size = new System.Drawing.Size(68, 15);
            this.lblDuringCmds.TabIndex = 6;
            this.lblDuringCmds.Text = "During test";
            // 
            // lstBeforeCmds
            // 
            this.lstBeforeCmds.FormattingEnabled = true;
            this.lstBeforeCmds.ItemHeight = 15;
            this.lstBeforeCmds.Location = new System.Drawing.Point(290, 20);
            this.lstBeforeCmds.Name = "lstBeforeCmds";
            this.lstBeforeCmds.Size = new System.Drawing.Size(325, 94);
            this.lstBeforeCmds.TabIndex = 5;
            // 
            // lblBeforeCmds
            // 
            this.lblBeforeCmds.AutoSize = true;
            this.lblBeforeCmds.Location = new System.Drawing.Point(290, 3);
            this.lblBeforeCmds.Name = "lblBeforeCmds";
            this.lblBeforeCmds.Size = new System.Drawing.Size(69, 15);
            this.lblBeforeCmds.TabIndex = 4;
            this.lblBeforeCmds.Text = "Before test";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(15, 335);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(210, 25);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtControlCommand
            // 
            this.txtControlCommand.Location = new System.Drawing.Point(15, 140);
            this.txtControlCommand.Multiline = true;
            this.txtControlCommand.Name = "txtControlCommand";
            this.txtControlCommand.Size = new System.Drawing.Size(210, 185);
            this.txtControlCommand.TabIndex = 2;
            // 
            // lblControlCommand
            // 
            this.lblControlCommand.AutoSize = true;
            this.lblControlCommand.Location = new System.Drawing.Point(15, 120);
            this.lblControlCommand.Name = "lblControlCommand";
            this.lblControlCommand.Size = new System.Drawing.Size(184, 15);
            this.lblControlCommand.TabIndex = 1;
            this.lblControlCommand.Text = "Message Text / Program Name";
            // 
            // grpCtrlType
            // 
            this.grpCtrlType.Controls.Add(this.rbCtrlWait);
            this.grpCtrlType.Controls.Add(this.rbCtrlProgram);
            this.grpCtrlType.Controls.Add(this.rbCtrlManual);
            this.grpCtrlType.Location = new System.Drawing.Point(15, 15);
            this.grpCtrlType.Name = "grpCtrlType";
            this.grpCtrlType.Size = new System.Drawing.Size(210, 95);
            this.grpCtrlType.TabIndex = 0;
            this.grpCtrlType.TabStop = false;
            this.grpCtrlType.Text = "Control function";
            // 
            // rbCtrlWait
            // 
            this.rbCtrlWait.AutoSize = true;
            this.rbCtrlWait.Location = new System.Drawing.Point(20, 68);
            this.rbCtrlWait.Name = "rbCtrlWait";
            this.rbCtrlWait.Size = new System.Drawing.Size(49, 19);
            this.rbCtrlWait.TabIndex = 2;
            this.rbCtrlWait.Text = "Wait";
            this.rbCtrlWait.UseVisualStyleBackColor = true;
            this.rbCtrlWait.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbCtrlProgram
            // 
            this.rbCtrlProgram.AutoSize = true;
            this.rbCtrlProgram.Location = new System.Drawing.Point(20, 43);
            this.rbCtrlProgram.Name = "rbCtrlProgram";
            this.rbCtrlProgram.Size = new System.Drawing.Size(71, 19);
            this.rbCtrlProgram.TabIndex = 1;
            this.rbCtrlProgram.Text = "Program";
            this.rbCtrlProgram.UseVisualStyleBackColor = true;
            this.rbCtrlProgram.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbCtrlManual
            // 
            this.rbCtrlManual.AutoSize = true;
            this.rbCtrlManual.Checked = true;
            this.rbCtrlManual.Location = new System.Drawing.Point(20, 20);
            this.rbCtrlManual.Name = "rbCtrlManual";
            this.rbCtrlManual.Size = new System.Drawing.Size(65, 19);
            this.rbCtrlManual.TabIndex = 0;
            this.rbCtrlManual.TabStop = true;
            this.rbCtrlManual.Text = "Manual";
            this.rbCtrlManual.UseVisualStyleBackColor = true;
            this.rbCtrlManual.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // frmProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.tabControlStepDetails);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnDeleteStep);
            this.Controls.Add(this.btnAddStep);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lstSteps);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewProcedure);
            this.Controls.Add(this.numRevision);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.txtProcedureName);
            this.Controls.Add(this.lblProcName);
            this.Controls.Add(this.cmbProcedures);
            this.Controls.Add(this.lblSelectProc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProcedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Procedure Planner";
            this.Load += new System.EventHandler(this.frmProcedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRevision)).EndInit();
            this.tabControlStepDetails.ResumeLayout(false);
            this.tabParameters.ResumeLayout(false);
            this.tabParameters.PerformLayout();
            this.grpRotation.ResumeLayout(false);
            this.grpRotation.PerformLayout();
            this.grpLagLead.ResumeLayout(false);
            this.grpLagLead.PerformLayout();
            this.grpConsDeliv.ResumeLayout(false);
            this.grpConsDeliv.PerformLayout();
            this.tabType.ResumeLayout(false);
            this.tabType.PerformLayout();
            this.grpImpExp.ResumeLayout(false);
            this.grpImpExp.PerformLayout();
            this.grpStoring.ResumeLayout(false);
            this.grpStoring.PerformLayout();
            this.grpChannel.ResumeLayout(false);
            this.grpChannel.PerformLayout();
            this.grpErrorDial.ResumeLayout(false);
            this.grpErrorDial.PerformLayout();
            this.grpStartCreep.ResumeLayout(false);
            this.grpStartCreep.PerformLayout();
            this.tabDuration.ResumeLayout(false);
            this.grpPostAction.ResumeLayout(false);
            this.grpPostAction.PerformLayout();
            this.grpDuration.ResumeLayout(false);
            this.grpDuration.PerformLayout();
            this.tabControls.ResumeLayout(false);
            this.tabControls.PerformLayout();
            this.grpCtrlType.ResumeLayout(false);
            this.grpCtrlType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectProc;
        private System.Windows.Forms.ComboBox cmbProcedures;
        private System.Windows.Forms.Label lblProcName;
        private System.Windows.Forms.TextBox txtProcedureName;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.NumericUpDown numRevision;
        private System.Windows.Forms.Button btnNewProcedure;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstSteps;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnAddStep;
        private System.Windows.Forms.Button btnDeleteStep;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.TabControl tabControlStepDetails;
        private System.Windows.Forms.TabPage tabParameters;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.TabPage tabDuration;
        private System.Windows.Forms.TabPage tabControls;
        private System.Windows.Forms.Label lblStepUA;
        private System.Windows.Forms.ComboBox cmbUA;
        private System.Windows.Forms.Label lblStepUC;
        private System.Windows.Forms.ComboBox cmbUC;
        private System.Windows.Forms.Label lblStepUB;
        private System.Windows.Forms.ComboBox cmbUB;
        private System.Windows.Forms.Label lblStepIC;
        private System.Windows.Forms.ComboBox cmbIC;
        private System.Windows.Forms.Label lblStepIB;
        private System.Windows.Forms.ComboBox cmbIB;
        private System.Windows.Forms.Label lblStepIA;
        private System.Windows.Forms.ComboBox cmbIA;
        private System.Windows.Forms.ComboBox cmbPFType;
        private System.Windows.Forms.Label lblPFType;
        private System.Windows.Forms.GroupBox grpLagLead;
        private System.Windows.Forms.RadioButton rbLeading;
        private System.Windows.Forms.RadioButton rbLagging;
        private System.Windows.Forms.GroupBox grpConsDeliv;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbConsumption;
        private System.Windows.Forms.ComboBox cmbPFValue;
        private System.Windows.Forms.Label lblPFValue;
        private System.Windows.Forms.ComboBox cmbWaveform;
        private System.Windows.Forms.Label lblWaveform;
        private System.Windows.Forms.ComboBox cmbFreq;
        private System.Windows.Forms.Label lblStepFreq;
        private System.Windows.Forms.GroupBox grpRotation;
        private System.Windows.Forms.RadioButton rbL132;
        private System.Windows.Forms.RadioButton rbL123;
        private System.Windows.Forms.TextBox txtStepName;
        private System.Windows.Forms.Label lblStepName;
        private System.Windows.Forms.ComboBox cmbTestType;
        private System.Windows.Forms.Label lblTestType;
        private System.Windows.Forms.ComboBox cmbMeasurement;
        private System.Windows.Forms.Label lblMeasurement;
        private System.Windows.Forms.GroupBox grpStartCreep;
        private System.Windows.Forms.ComboBox cmbNumPulsesSC;
        private System.Windows.Forms.Label lblNumPulsesSC;
        private System.Windows.Forms.GroupBox grpErrorDial;
        private System.Windows.Forms.ComboBox cmbLLimit;
        private System.Windows.Forms.Label lblLLimit;
        private System.Windows.Forms.ComboBox cmbULimit;
        private System.Windows.Forms.Label lblULimit;
        private System.Windows.Forms.CheckBox chkSymmetrical;
        private System.Windows.Forms.TextBox txtNumPulsesErr;
        private System.Windows.Forms.Label lblNumPulsesErr;
        private System.Windows.Forms.ComboBox cmbNumDecPlace;
        private System.Windows.Forms.Label lblNumDecPlace;
        private System.Windows.Forms.GroupBox grpChannel;
        private System.Windows.Forms.ComboBox cmbChannelNo;
        private System.Windows.Forms.Label lblChannelNo;
        private System.Windows.Forms.GroupBox grpStoring;
        private System.Windows.Forms.RadioButton rbMean;
        private System.Windows.Forms.RadioButton rbLastVal;
        private System.Windows.Forms.RadioButton rbStoreNone;
        private System.Windows.Forms.GroupBox grpImpExp;
        private System.Windows.Forms.CheckBox chkImport2;
        private System.Windows.Forms.CheckBox chkExport;
        private System.Windows.Forms.CheckBox chkImport;
        private System.Windows.Forms.GroupBox grpDuration;
        private System.Windows.Forms.Label lblTimeoutHint;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.RadioButton rbTimeDuration;
        private System.Windows.Forms.GroupBox grpPostAction;
        private System.Windows.Forms.RadioButton rbNextTest;
        private System.Windows.Forms.RadioButton rbWaitI0;
        private System.Windows.Forms.RadioButton rbWait;
        private System.Windows.Forms.GroupBox grpCtrlType;
        private System.Windows.Forms.RadioButton rbCtrlWait;
        private System.Windows.Forms.RadioButton rbCtrlProgram;
        private System.Windows.Forms.RadioButton rbCtrlManual;
        private System.Windows.Forms.TextBox txtControlCommand;
        private System.Windows.Forms.Label lblControlCommand;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstAfterCmds;
        private System.Windows.Forms.Label lblAfterCmds;
        private System.Windows.Forms.ListBox lstDuringCmds;
        private System.Windows.Forms.Label lblDuringCmds;
        private System.Windows.Forms.ListBox lstBeforeCmds;
        private System.Windows.Forms.Label lblBeforeCmds;
        private System.Windows.Forms.Button btnDelAfter;
        private System.Windows.Forms.Button btnAddAfter;
        private System.Windows.Forms.Button btnDelDuring;
        private System.Windows.Forms.Button btnAddDuring;
        private System.Windows.Forms.Button btnDelBefore;
        private System.Windows.Forms.Button btnAddBefore;
        private System.Windows.Forms.CheckBox chkWithAmp;
    }
}
