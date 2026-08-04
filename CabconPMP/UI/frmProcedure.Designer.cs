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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcedure));
            this.lblSelectProc = new System.Windows.Forms.Label();
            this.lblProcName = new System.Windows.Forms.Label();
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
            this.txtStepName = new CabconPMP.TransparentTextBox();
            this.lblStepName = new System.Windows.Forms.Label();
            this.grpRotation = new System.Windows.Forms.GroupBox();
            this.rbL132 = new System.Windows.Forms.RadioButton();
            this.rbL123 = new System.Windows.Forms.RadioButton();
            this.cmbFreq = new CabconPMP.TransparentComboBox();
            this.lblStepFreq = new System.Windows.Forms.Label();
            this.cmbWaveform = new CabconPMP.TransparentComboBox();
            this.lblWaveform = new System.Windows.Forms.Label();
            this.cmbPFValue = new CabconPMP.TransparentComboBox();
            this.lblPFValue = new System.Windows.Forms.Label();
            this.grpLagLead = new System.Windows.Forms.GroupBox();
            this.rbLeading = new System.Windows.Forms.RadioButton();
            this.rbLagging = new System.Windows.Forms.RadioButton();
            this.grpConsDeliv = new System.Windows.Forms.GroupBox();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbConsumption = new System.Windows.Forms.RadioButton();
            this.cmbPFType = new CabconPMP.TransparentComboBox();
            this.lblPFType = new System.Windows.Forms.Label();
            this.lblStepIC = new System.Windows.Forms.Label();
            this.cmbIC = new CabconPMP.TransparentComboBox();
            this.lblStepIB = new System.Windows.Forms.Label();
            this.cmbIB = new CabconPMP.TransparentComboBox();
            this.lblStepIA = new System.Windows.Forms.Label();
            this.cmbIA = new CabconPMP.TransparentComboBox();
            this.lblStepUC = new System.Windows.Forms.Label();
            this.cmbUC = new CabconPMP.TransparentComboBox();
            this.lblStepUB = new System.Windows.Forms.Label();
            this.cmbUB = new CabconPMP.TransparentComboBox();
            this.lblStepUA = new System.Windows.Forms.Label();
            this.cmbUA = new CabconPMP.TransparentComboBox();
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
            this.cmbChannelNo = new CabconPMP.TransparentComboBox();
            this.lblChannelNo = new System.Windows.Forms.Label();
            this.grpErrorDial = new System.Windows.Forms.GroupBox();
            this.cmbNumDecPlace = new CabconPMP.TransparentComboBox();
            this.lblNumDecPlace = new System.Windows.Forms.Label();
            this.txtNumPulsesErr = new CabconPMP.TransparentTextBox();
            this.lblNumPulsesErr = new System.Windows.Forms.Label();
            this.chkSymmetrical = new System.Windows.Forms.CheckBox();
            this.cmbLLimit = new CabconPMP.TransparentComboBox();
            this.lblLLimit = new System.Windows.Forms.Label();
            this.cmbULimit = new CabconPMP.TransparentComboBox();
            this.lblULimit = new System.Windows.Forms.Label();
            this.grpStartCreep = new System.Windows.Forms.GroupBox();
            this.cmbNumPulsesSC = new CabconPMP.TransparentComboBox();
            this.lblNumPulsesSC = new System.Windows.Forms.Label();
            this.lblMeasurement = new System.Windows.Forms.Label();
            this.lblTestType = new System.Windows.Forms.Label();
            this.cmbMeasurement = new CabconPMP.TransparentComboBox();
            this.cmbTestType = new CabconPMP.TransparentComboBox();
            this.tabDuration = new System.Windows.Forms.TabPage();
            this.grpPostAction = new System.Windows.Forms.GroupBox();
            this.rbNextTest = new System.Windows.Forms.RadioButton();
            this.rbWaitI0 = new System.Windows.Forms.RadioButton();
            this.rbWait = new System.Windows.Forms.RadioButton();
            this.grpDuration = new System.Windows.Forms.GroupBox();
            this.lblTimeoutHint = new System.Windows.Forms.Label();
            this.txtTimeout = new CabconPMP.TransparentTextBox();
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
            this.lblControlCommand = new System.Windows.Forms.Label();
            this.grpCtrlType = new System.Windows.Forms.GroupBox();
            this.rbCtrlWait = new System.Windows.Forms.RadioButton();
            this.rbCtrlProgram = new System.Windows.Forms.RadioButton();
            this.rbCtrlManual = new System.Windows.Forms.RadioButton();
            this.txtControlCommand = new CabconPMP.TransparentTextBox();
            this.txtProcedureName = new CabconPMP.TransparentTextBox();
            this.cmbProcedures = new CabconPMP.TransparentComboBox();
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
            this.lblSelectProc.Location = new System.Drawing.Point(15, 24);
            this.lblSelectProc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectProc.Name = "lblSelectProc";
            this.lblSelectProc.Size = new System.Drawing.Size(135, 20);
            this.lblSelectProc.TabIndex = 0;
            this.lblSelectProc.Text = "Select Procedure:";
            // 
            // lblProcName
            // 
            this.lblProcName.AutoSize = true;
            this.lblProcName.Location = new System.Drawing.Point(437, 24);
            this.lblProcName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcName.Name = "lblProcName";
            this.lblProcName.Size = new System.Drawing.Size(55, 20);
            this.lblProcName.TabIndex = 2;
            this.lblProcName.Text = "Name:";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(836, 24);
            this.lblRevision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(73, 20);
            this.lblRevision.TabIndex = 4;
            this.lblRevision.Text = "Revision:";
            // 
            // numRevision
            // 
            this.numRevision.Location = new System.Drawing.Point(913, 20);
            this.numRevision.Margin = new System.Windows.Forms.Padding(4);
            this.numRevision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRevision.Name = "numRevision";
            this.numRevision.Size = new System.Drawing.Size(77, 26);
            this.numRevision.TabIndex = 5;
            this.numRevision.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNewProcedure
            // 
            this.btnNewProcedure.Location = new System.Drawing.Point(1003, 17);
            this.btnNewProcedure.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewProcedure.Name = "btnNewProcedure";
            this.btnNewProcedure.Size = new System.Drawing.Size(116, 35);
            this.btnNewProcedure.TabIndex = 6;
            this.btnNewProcedure.Text = "New Proc";
            this.btnNewProcedure.UseVisualStyleBackColor = true;
            this.btnNewProcedure.Click += new System.EventHandler(this.btnNewProcedure_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1033, 707);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstSteps
            // 
            this.lstSteps.FormattingEnabled = true;
            this.lstSteps.ItemHeight = 20;
            this.lstSteps.Location = new System.Drawing.Point(15, 100);
            this.lstSteps.Margin = new System.Windows.Forms.Padding(4);
            this.lstSteps.Name = "lstSteps";
            this.lstSteps.Size = new System.Drawing.Size(301, 504);
            this.lstSteps.TabIndex = 8;
            this.lstSteps.SelectedIndexChanged += new System.EventHandler(this.lstSteps_SelectedIndexChanged);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSteps.Location = new System.Drawing.Point(15, 73);
            this.lblSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(97, 25);
            this.lblSteps.TabIndex = 9;
            this.lblSteps.Text = "Test Steps";
            // 
            // btnAddStep
            // 
            this.btnAddStep.Location = new System.Drawing.Point(13, 621);
            this.btnAddStep.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(116, 33);
            this.btnAddStep.TabIndex = 10;
            this.btnAddStep.Text = "Add Step";
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.Location = new System.Drawing.Point(190, 621);
            this.btnDeleteStep.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.Size = new System.Drawing.Size(116, 33);
            this.btnDeleteStep.TabIndex = 11;
            this.btnDeleteStep.Text = "Delete Step";
            this.btnDeleteStep.UseVisualStyleBackColor = true;
            this.btnDeleteStep.Click += new System.EventHandler(this.btnDeleteStep_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(13, 662);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(116, 33);
            this.btnMoveUp.TabIndex = 12;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(190, 666);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(116, 33);
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
            this.tabControlStepDetails.Location = new System.Drawing.Point(346, 73);
            this.tabControlStepDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlStepDetails.Name = "tabControlStepDetails";
            this.tabControlStepDetails.SelectedIndex = 0;
            this.tabControlStepDetails.Size = new System.Drawing.Size(949, 626);
            this.tabControlStepDetails.TabIndex = 14;
            // 
            // tabParameters
            // 
            this.tabParameters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabParameters.BackgroundImage")));
            this.tabParameters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tabParameters.Location = new System.Drawing.Point(4, 29);
            this.tabParameters.Margin = new System.Windows.Forms.Padding(4);
            this.tabParameters.Name = "tabParameters";
            this.tabParameters.Padding = new System.Windows.Forms.Padding(4);
            this.tabParameters.Size = new System.Drawing.Size(941, 593);
            this.tabParameters.TabIndex = 0;
            this.tabParameters.Text = "Test parameters";
            this.tabParameters.UseVisualStyleBackColor = true;
            this.tabParameters.Click += new System.EventHandler(this.tabParameters_Click);
            // 
            // txtStepName
            // 
            this.txtStepName.BackColor = System.Drawing.Color.Transparent;
            this.txtStepName.Location = new System.Drawing.Point(129, 20);
            this.txtStepName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStepName.Name = "txtStepName";
            this.txtStepName.Size = new System.Drawing.Size(773, 26);
            this.txtStepName.TabIndex = 24;
            this.txtStepName.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepName
            // 
            this.lblStepName.AutoSize = true;
            this.lblStepName.Location = new System.Drawing.Point(26, 24);
            this.lblStepName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(92, 20);
            this.lblStepName.TabIndex = 23;
            this.lblStepName.Text = "Test name :";
            // 
            // grpRotation
            // 
            this.grpRotation.Controls.Add(this.rbL132);
            this.grpRotation.Controls.Add(this.rbL123);
            this.grpRotation.Location = new System.Drawing.Point(652, 425);
            this.grpRotation.Margin = new System.Windows.Forms.Padding(4);
            this.grpRotation.Name = "grpRotation";
            this.grpRotation.Padding = new System.Windows.Forms.Padding(4);
            this.grpRotation.Size = new System.Drawing.Size(154, 107);
            this.grpRotation.TabIndex = 22;
            this.grpRotation.TabStop = false;
            this.grpRotation.Text = "Rotation field";
            // 
            // rbL132
            // 
            this.rbL132.AutoSize = true;
            this.rbL132.Location = new System.Drawing.Point(26, 64);
            this.rbL132.Margin = new System.Windows.Forms.Padding(4);
            this.rbL132.Name = "rbL132";
            this.rbL132.Size = new System.Drawing.Size(70, 24);
            this.rbL132.TabIndex = 1;
            this.rbL132.Text = "L132";
            this.rbL132.UseVisualStyleBackColor = true;
            this.rbL132.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbL123
            // 
            this.rbL123.AutoSize = true;
            this.rbL123.Checked = true;
            this.rbL123.Location = new System.Drawing.Point(26, 31);
            this.rbL123.Margin = new System.Windows.Forms.Padding(4);
            this.rbL123.Name = "rbL123";
            this.rbL123.Size = new System.Drawing.Size(70, 24);
            this.rbL123.TabIndex = 0;
            this.rbL123.TabStop = true;
            this.rbL123.Text = "L123";
            this.rbL123.UseVisualStyleBackColor = true;
            this.rbL123.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // cmbFreq
            // 
            this.cmbFreq.BackColor = System.Drawing.Color.Transparent;
            this.cmbFreq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFreq.FormattingEnabled = true;
            this.cmbFreq.Items.AddRange(new object[] {
            "50",
            "60",
            "45",
            "55"});
            this.cmbFreq.Location = new System.Drawing.Point(334, 473);
            this.cmbFreq.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFreq.Name = "cmbFreq";
            this.cmbFreq.Size = new System.Drawing.Size(156, 27);
            this.cmbFreq.TabIndex = 21;
            this.cmbFreq.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepFreq
            // 
            this.lblStepFreq.AutoSize = true;
            this.lblStepFreq.Location = new System.Drawing.Point(380, 435);
            this.lblStepFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepFreq.Name = "lblStepFreq";
            this.lblStepFreq.Size = new System.Drawing.Size(46, 20);
            this.lblStepFreq.TabIndex = 20;
            this.lblStepFreq.Text = "f [Hz]";
            // 
            // cmbWaveform
            // 
            this.cmbWaveform.BackColor = System.Drawing.Color.Transparent;
            this.cmbWaveform.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWaveform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaveform.FormattingEnabled = true;
            this.cmbWaveform.Items.AddRange(new object[] {
            "Sine wave",
            "Harmonics",
            "Triangle"});
            this.cmbWaveform.Location = new System.Drawing.Point(26, 477);
            this.cmbWaveform.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWaveform.Name = "cmbWaveform";
            this.cmbWaveform.Size = new System.Drawing.Size(204, 27);
            this.cmbWaveform.TabIndex = 19;
            this.cmbWaveform.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblWaveform
            // 
            this.lblWaveform.AutoSize = true;
            this.lblWaveform.Location = new System.Drawing.Point(68, 440);
            this.lblWaveform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaveform.Name = "lblWaveform";
            this.lblWaveform.Size = new System.Drawing.Size(85, 20);
            this.lblWaveform.TabIndex = 18;
            this.lblWaveform.Text = "Wave form";
            // 
            // cmbPFValue
            // 
            this.cmbPFValue.BackColor = System.Drawing.Color.Transparent;
            this.cmbPFValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPFValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPFValue.FormattingEnabled = true;
            this.cmbPFValue.Items.AddRange(new object[] {
            "1.0",
            "0.5L",
            "0.8C",
            "0.5C",
            "0.25L",
            "0.0"});
            this.cmbPFValue.Location = new System.Drawing.Point(652, 311);
            this.cmbPFValue.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPFValue.Name = "cmbPFValue";
            this.cmbPFValue.Size = new System.Drawing.Size(102, 27);
            this.cmbPFValue.TabIndex = 17;
            this.cmbPFValue.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblPFValue
            // 
            this.lblPFValue.AutoSize = true;
            this.lblPFValue.Location = new System.Drawing.Point(666, 274);
            this.lblPFValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFValue.Name = "lblPFValue";
            this.lblPFValue.Size = new System.Drawing.Size(74, 20);
            this.lblPFValue.TabIndex = 16;
            this.lblPFValue.Text = "PF Value";
            // 
            // grpLagLead
            // 
            this.grpLagLead.Controls.Add(this.rbLeading);
            this.grpLagLead.Controls.Add(this.rbLagging);
            this.grpLagLead.Location = new System.Drawing.Point(337, 304);
            this.grpLagLead.Margin = new System.Windows.Forms.Padding(4);
            this.grpLagLead.Name = "grpLagLead";
            this.grpLagLead.Padding = new System.Windows.Forms.Padding(4);
            this.grpLagLead.Size = new System.Drawing.Size(116, 107);
            this.grpLagLead.TabIndex = 15;
            this.grpLagLead.TabStop = false;
            // 
            // rbLeading
            // 
            this.rbLeading.AutoSize = true;
            this.rbLeading.Location = new System.Drawing.Point(13, 64);
            this.rbLeading.Margin = new System.Windows.Forms.Padding(4);
            this.rbLeading.Name = "rbLeading";
            this.rbLeading.Size = new System.Drawing.Size(85, 24);
            this.rbLeading.TabIndex = 1;
            this.rbLeading.Text = "leading";
            this.rbLeading.UseVisualStyleBackColor = true;
            this.rbLeading.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbLagging
            // 
            this.rbLagging.AutoSize = true;
            this.rbLagging.Checked = true;
            this.rbLagging.Location = new System.Drawing.Point(13, 31);
            this.rbLagging.Margin = new System.Windows.Forms.Padding(4);
            this.rbLagging.Name = "rbLagging";
            this.rbLagging.Size = new System.Drawing.Size(85, 24);
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
            this.grpConsDeliv.Location = new System.Drawing.Point(157, 324);
            this.grpConsDeliv.Margin = new System.Windows.Forms.Padding(4);
            this.grpConsDeliv.Name = "grpConsDeliv";
            this.grpConsDeliv.Padding = new System.Windows.Forms.Padding(4);
            this.grpConsDeliv.Size = new System.Drawing.Size(129, 107);
            this.grpConsDeliv.TabIndex = 14;
            this.grpConsDeliv.TabStop = false;
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(13, 64);
            this.rbDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(86, 24);
            this.rbDelivery.TabIndex = 1;
            this.rbDelivery.Text = "delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            this.rbDelivery.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbConsumption
            // 
            this.rbConsumption.AutoSize = true;
            this.rbConsumption.Checked = true;
            this.rbConsumption.Location = new System.Drawing.Point(13, 31);
            this.rbConsumption.Margin = new System.Windows.Forms.Padding(4);
            this.rbConsumption.Name = "rbConsumption";
            this.rbConsumption.Size = new System.Drawing.Size(125, 24);
            this.rbConsumption.TabIndex = 0;
            this.rbConsumption.TabStop = true;
            this.rbConsumption.Text = "consumption";
            this.rbConsumption.UseVisualStyleBackColor = true;
            this.rbConsumption.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // cmbPFType
            // 
            this.cmbPFType.BackColor = System.Drawing.Color.Transparent;
            this.cmbPFType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPFType.FormattingEnabled = true;
            this.cmbPFType.Items.AddRange(new object[] {
            "cos phi",
            "sin phi"});
            this.cmbPFType.Location = new System.Drawing.Point(26, 304);
            this.cmbPFType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPFType.Name = "cmbPFType";
            this.cmbPFType.Size = new System.Drawing.Size(127, 27);
            this.cmbPFType.TabIndex = 13;
            this.cmbPFType.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblPFType
            // 
            this.lblPFType.AutoSize = true;
            this.lblPFType.Location = new System.Drawing.Point(46, 271);
            this.lblPFType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPFType.Name = "lblPFType";
            this.lblPFType.Size = new System.Drawing.Size(67, 20);
            this.lblPFType.TabIndex = 12;
            this.lblPFType.Text = "PF Type";
            // 
            // lblStepIC
            // 
            this.lblStepIC.AutoSize = true;
            this.lblStepIC.Location = new System.Drawing.Point(686, 174);
            this.lblStepIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepIC.Name = "lblStepIC";
            this.lblStepIC.Size = new System.Drawing.Size(25, 20);
            this.lblStepIC.TabIndex = 11;
            this.lblStepIC.Text = "IC";
            // 
            // cmbIC
            // 
            this.cmbIC.BackColor = System.Drawing.Color.Transparent;
            this.cmbIC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIC.FormattingEnabled = true;
            this.cmbIC.Items.AddRange(new object[] {
            "100",
            "50",
            "20",
            "10",
            "5",
            "0"});
            this.cmbIC.Location = new System.Drawing.Point(653, 203);
            this.cmbIC.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIC.Name = "cmbIC";
            this.cmbIC.Size = new System.Drawing.Size(101, 27);
            this.cmbIC.TabIndex = 10;
            this.cmbIC.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepIB
            // 
            this.lblStepIB.AutoSize = true;
            this.lblStepIB.Location = new System.Drawing.Point(384, 173);
            this.lblStepIB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepIB.Name = "lblStepIB";
            this.lblStepIB.Size = new System.Drawing.Size(25, 20);
            this.lblStepIB.TabIndex = 9;
            this.lblStepIB.Text = "IB";
            // 
            // cmbIB
            // 
            this.cmbIB.BackColor = System.Drawing.Color.Transparent;
            this.cmbIB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIB.FormattingEnabled = true;
            this.cmbIB.Items.AddRange(new object[] {
            "100",
            "50",
            "20",
            "10",
            "5",
            "0"});
            this.cmbIB.Location = new System.Drawing.Point(353, 204);
            this.cmbIB.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIB.Name = "cmbIB";
            this.cmbIB.Size = new System.Drawing.Size(100, 27);
            this.cmbIB.TabIndex = 8;
            this.cmbIB.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepIA
            // 
            this.lblStepIA.AutoSize = true;
            this.lblStepIA.Location = new System.Drawing.Point(69, 176);
            this.lblStepIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepIA.Name = "lblStepIA";
            this.lblStepIA.Size = new System.Drawing.Size(25, 20);
            this.lblStepIA.TabIndex = 7;
            this.lblStepIA.Text = "IA";
            // 
            // cmbIA
            // 
            this.cmbIA.BackColor = System.Drawing.Color.Transparent;
            this.cmbIA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIA.FormattingEnabled = true;
            this.cmbIA.Items.AddRange(new object[] {
            "100",
            "50",
            "20",
            "10",
            "5",
            "0"});
            this.cmbIA.Location = new System.Drawing.Point(26, 207);
            this.cmbIA.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIA.Name = "cmbIA";
            this.cmbIA.Size = new System.Drawing.Size(127, 27);
            this.cmbIA.TabIndex = 6;
            this.cmbIA.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepUC
            // 
            this.lblStepUC.AutoSize = true;
            this.lblStepUC.Location = new System.Drawing.Point(682, 86);
            this.lblStepUC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepUC.Name = "lblStepUC";
            this.lblStepUC.Size = new System.Drawing.Size(32, 20);
            this.lblStepUC.TabIndex = 5;
            this.lblStepUC.Text = "UC";
            // 
            // cmbUC
            // 
            this.cmbUC.BackColor = System.Drawing.Color.Transparent;
            this.cmbUC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUC.FormattingEnabled = true;
            this.cmbUC.Items.AddRange(new object[] {
            "100",
            "0"});
            this.cmbUC.Location = new System.Drawing.Point(652, 120);
            this.cmbUC.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUC.Name = "cmbUC";
            this.cmbUC.Size = new System.Drawing.Size(102, 27);
            this.cmbUC.TabIndex = 4;
            this.cmbUC.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepUB
            // 
            this.lblStepUB.AutoSize = true;
            this.lblStepUB.Location = new System.Drawing.Point(376, 83);
            this.lblStepUB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepUB.Name = "lblStepUB";
            this.lblStepUB.Size = new System.Drawing.Size(32, 20);
            this.lblStepUB.TabIndex = 3;
            this.lblStepUB.Text = "UB";
            // 
            // cmbUB
            // 
            this.cmbUB.BackColor = System.Drawing.Color.Transparent;
            this.cmbUB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUB.FormattingEnabled = true;
            this.cmbUB.Items.AddRange(new object[] {
            "100",
            "0"});
            this.cmbUB.Location = new System.Drawing.Point(351, 115);
            this.cmbUB.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUB.Name = "cmbUB";
            this.cmbUB.Size = new System.Drawing.Size(102, 27);
            this.cmbUB.TabIndex = 2;
            this.cmbUB.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblStepUA
            // 
            this.lblStepUA.AutoSize = true;
            this.lblStepUA.Location = new System.Drawing.Point(62, 85);
            this.lblStepUA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepUA.Name = "lblStepUA";
            this.lblStepUA.Size = new System.Drawing.Size(32, 20);
            this.lblStepUA.TabIndex = 0;
            this.lblStepUA.Text = "UA";
            // 
            // cmbUA
            // 
            this.cmbUA.BackColor = System.Drawing.Color.Transparent;
            this.cmbUA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUA.FormattingEnabled = true;
            this.cmbUA.Items.AddRange(new object[] {
            "100",
            "0"});
            this.cmbUA.Location = new System.Drawing.Point(26, 115);
            this.cmbUA.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUA.Name = "cmbUA";
            this.cmbUA.Size = new System.Drawing.Size(127, 27);
            this.cmbUA.TabIndex = 1;
            this.cmbUA.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // tabType
            // 
            this.tabType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabType.BackgroundImage")));
            this.tabType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabType.Controls.Add(this.grpImpExp);
            this.tabType.Controls.Add(this.grpStoring);
            this.tabType.Controls.Add(this.grpChannel);
            this.tabType.Controls.Add(this.grpErrorDial);
            this.tabType.Controls.Add(this.grpStartCreep);
            this.tabType.Controls.Add(this.lblMeasurement);
            this.tabType.Controls.Add(this.lblTestType);
            this.tabType.Controls.Add(this.cmbMeasurement);
            this.tabType.Controls.Add(this.cmbTestType);
            this.tabType.Location = new System.Drawing.Point(4, 29);
            this.tabType.Margin = new System.Windows.Forms.Padding(4);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(4);
            this.tabType.Size = new System.Drawing.Size(941, 593);
            this.tabType.TabIndex = 1;
            this.tabType.Text = "Test type";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // grpImpExp
            // 
            this.grpImpExp.Controls.Add(this.chkImport2);
            this.grpImpExp.Controls.Add(this.chkExport);
            this.grpImpExp.Controls.Add(this.chkImport);
            this.grpImpExp.Location = new System.Drawing.Point(757, 260);
            this.grpImpExp.Margin = new System.Windows.Forms.Padding(4);
            this.grpImpExp.Name = "grpImpExp";
            this.grpImpExp.Padding = new System.Windows.Forms.Padding(4);
            this.grpImpExp.Size = new System.Drawing.Size(154, 227);
            this.grpImpExp.TabIndex = 8;
            this.grpImpExp.TabStop = false;
            this.grpImpExp.Text = "Import / Export";
            // 
            // chkImport2
            // 
            this.chkImport2.AutoSize = true;
            this.chkImport2.Location = new System.Drawing.Point(19, 127);
            this.chkImport2.Margin = new System.Windows.Forms.Padding(4);
            this.chkImport2.Name = "chkImport2";
            this.chkImport2.Size = new System.Drawing.Size(90, 24);
            this.chkImport2.TabIndex = 2;
            this.chkImport2.Text = "Import2";
            this.chkImport2.UseVisualStyleBackColor = true;
            this.chkImport2.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // chkExport
            // 
            this.chkExport.AutoSize = true;
            this.chkExport.Location = new System.Drawing.Point(19, 80);
            this.chkExport.Margin = new System.Windows.Forms.Padding(4);
            this.chkExport.Name = "chkExport";
            this.chkExport.Size = new System.Drawing.Size(81, 24);
            this.chkExport.TabIndex = 1;
            this.chkExport.Text = "Export";
            this.chkExport.UseVisualStyleBackColor = true;
            this.chkExport.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // chkImport
            // 
            this.chkImport.AutoSize = true;
            this.chkImport.Location = new System.Drawing.Point(19, 33);
            this.chkImport.Margin = new System.Windows.Forms.Padding(4);
            this.chkImport.Name = "chkImport";
            this.chkImport.Size = new System.Drawing.Size(81, 24);
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
            this.grpStoring.Location = new System.Drawing.Point(757, 26);
            this.grpStoring.Margin = new System.Windows.Forms.Padding(4);
            this.grpStoring.Name = "grpStoring";
            this.grpStoring.Padding = new System.Windows.Forms.Padding(4);
            this.grpStoring.Size = new System.Drawing.Size(154, 213);
            this.grpStoring.TabIndex = 7;
            this.grpStoring.TabStop = false;
            this.grpStoring.Text = "Storing";
            // 
            // rbMean
            // 
            this.rbMean.AutoSize = true;
            this.rbMean.Location = new System.Drawing.Point(19, 127);
            this.rbMean.Margin = new System.Windows.Forms.Padding(4);
            this.rbMean.Name = "rbMean";
            this.rbMean.Size = new System.Drawing.Size(74, 24);
            this.rbMean.TabIndex = 2;
            this.rbMean.Text = "mean";
            this.rbMean.UseVisualStyleBackColor = true;
            this.rbMean.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbLastVal
            // 
            this.rbLastVal.AutoSize = true;
            this.rbLastVal.Location = new System.Drawing.Point(19, 80);
            this.rbLastVal.Margin = new System.Windows.Forms.Padding(4);
            this.rbLastVal.Name = "rbLastVal";
            this.rbLastVal.Size = new System.Drawing.Size(100, 24);
            this.rbLastVal.TabIndex = 1;
            this.rbLastVal.Text = "last value";
            this.rbLastVal.UseVisualStyleBackColor = true;
            this.rbLastVal.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbStoreNone
            // 
            this.rbStoreNone.AutoSize = true;
            this.rbStoreNone.Checked = true;
            this.rbStoreNone.Location = new System.Drawing.Point(19, 33);
            this.rbStoreNone.Margin = new System.Windows.Forms.Padding(4);
            this.rbStoreNone.Name = "rbStoreNone";
            this.rbStoreNone.Size = new System.Drawing.Size(70, 24);
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
            this.grpChannel.Location = new System.Drawing.Point(456, 407);
            this.grpChannel.Margin = new System.Windows.Forms.Padding(4);
            this.grpChannel.Name = "grpChannel";
            this.grpChannel.Padding = new System.Windows.Forms.Padding(4);
            this.grpChannel.Size = new System.Drawing.Size(257, 107);
            this.grpChannel.TabIndex = 6;
            this.grpChannel.TabStop = false;
            this.grpChannel.Text = "Channel";
            // 
            // cmbChannelNo
            // 
            this.cmbChannelNo.BackColor = System.Drawing.Color.Transparent;
            this.cmbChannelNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChannelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChannelNo.FormattingEnabled = true;
            this.cmbChannelNo.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3"});
            this.cmbChannelNo.Location = new System.Drawing.Point(109, 40);
            this.cmbChannelNo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChannelNo.Name = "cmbChannelNo";
            this.cmbChannelNo.Size = new System.Drawing.Size(127, 27);
            this.cmbChannelNo.TabIndex = 1;
            this.cmbChannelNo.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblChannelNo
            // 
            this.lblChannelNo.AutoSize = true;
            this.lblChannelNo.Location = new System.Drawing.Point(13, 44);
            this.lblChannelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChannelNo.Name = "lblChannelNo";
            this.lblChannelNo.Size = new System.Drawing.Size(96, 20);
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
            this.grpErrorDial.Location = new System.Drawing.Point(127, 249);
            this.grpErrorDial.Margin = new System.Windows.Forms.Padding(4);
            this.grpErrorDial.Name = "grpErrorDial";
            this.grpErrorDial.Padding = new System.Windows.Forms.Padding(4);
            this.grpErrorDial.Size = new System.Drawing.Size(321, 253);
            this.grpErrorDial.TabIndex = 5;
            this.grpErrorDial.TabStop = false;
            this.grpErrorDial.Text = "Error / Dial test";
            // 
            // cmbNumDecPlace
            // 
            this.cmbNumDecPlace.BackColor = System.Drawing.Color.Transparent;
            this.cmbNumDecPlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNumDecPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumDecPlace.FormattingEnabled = true;
            this.cmbNumDecPlace.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbNumDecPlace.Location = new System.Drawing.Point(154, 200);
            this.cmbNumDecPlace.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNumDecPlace.Name = "cmbNumDecPlace";
            this.cmbNumDecPlace.Size = new System.Drawing.Size(140, 27);
            this.cmbNumDecPlace.TabIndex = 8;
            this.cmbNumDecPlace.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblNumDecPlace
            // 
            this.lblNumDecPlace.AutoSize = true;
            this.lblNumDecPlace.Location = new System.Drawing.Point(19, 204);
            this.lblNumDecPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDecPlace.Name = "lblNumDecPlace";
            this.lblNumDecPlace.Size = new System.Drawing.Size(116, 20);
            this.lblNumDecPlace.TabIndex = 7;
            this.lblNumDecPlace.Text = "Decimal places";
            // 
            // txtNumPulsesErr
            // 
            this.txtNumPulsesErr.BackColor = System.Drawing.Color.Transparent;
            this.txtNumPulsesErr.Location = new System.Drawing.Point(154, 153);
            this.txtNumPulsesErr.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumPulsesErr.Name = "txtNumPulsesErr";
            this.txtNumPulsesErr.Size = new System.Drawing.Size(140, 26);
            this.txtNumPulsesErr.TabIndex = 6;
            this.txtNumPulsesErr.Text = "10";
            this.txtNumPulsesErr.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblNumPulsesErr
            // 
            this.lblNumPulsesErr.AutoSize = true;
            this.lblNumPulsesErr.Location = new System.Drawing.Point(19, 157);
            this.lblNumPulsesErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPulsesErr.Name = "lblNumPulsesErr";
            this.lblNumPulsesErr.Size = new System.Drawing.Size(125, 20);
            this.lblNumPulsesErr.TabIndex = 5;
            this.lblNumPulsesErr.Text = "Number of pulse";
            // 
            // chkSymmetrical
            // 
            this.chkSymmetrical.AutoSize = true;
            this.chkSymmetrical.Checked = true;
            this.chkSymmetrical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSymmetrical.Location = new System.Drawing.Point(154, 120);
            this.chkSymmetrical.Margin = new System.Windows.Forms.Padding(4);
            this.chkSymmetrical.Name = "chkSymmetrical";
            this.chkSymmetrical.Size = new System.Drawing.Size(118, 24);
            this.chkSymmetrical.TabIndex = 4;
            this.chkSymmetrical.Text = "symmetrical";
            this.chkSymmetrical.UseVisualStyleBackColor = true;
            this.chkSymmetrical.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // cmbLLimit
            // 
            this.cmbLLimit.BackColor = System.Drawing.Color.Transparent;
            this.cmbLLimit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLLimit.FormattingEnabled = true;
            this.cmbLLimit.Items.AddRange(new object[] {
            "-0.5",
            "-1.0",
            "-2.0",
            "-3.0",
            "-5.0"});
            this.cmbLLimit.Location = new System.Drawing.Point(154, 73);
            this.cmbLLimit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLLimit.Name = "cmbLLimit";
            this.cmbLLimit.Size = new System.Drawing.Size(140, 27);
            this.cmbLLimit.TabIndex = 3;
            this.cmbLLimit.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblLLimit
            // 
            this.lblLLimit.AutoSize = true;
            this.lblLLimit.Location = new System.Drawing.Point(19, 77);
            this.lblLLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLLimit.Name = "lblLLimit";
            this.lblLLimit.Size = new System.Drawing.Size(83, 20);
            this.lblLLimit.TabIndex = 2;
            this.lblLLimit.Text = "Lower limit";
            // 
            // cmbULimit
            // 
            this.cmbULimit.BackColor = System.Drawing.Color.Transparent;
            this.cmbULimit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbULimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbULimit.FormattingEnabled = true;
            this.cmbULimit.Items.AddRange(new object[] {
            "0.5",
            "1.0",
            "2.0",
            "3.0",
            "5.0"});
            this.cmbULimit.Location = new System.Drawing.Point(154, 27);
            this.cmbULimit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbULimit.Name = "cmbULimit";
            this.cmbULimit.Size = new System.Drawing.Size(140, 27);
            this.cmbULimit.TabIndex = 1;
            this.cmbULimit.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblULimit
            // 
            this.lblULimit.AutoSize = true;
            this.lblULimit.Location = new System.Drawing.Point(19, 31);
            this.lblULimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblULimit.Name = "lblULimit";
            this.lblULimit.Size = new System.Drawing.Size(84, 20);
            this.lblULimit.TabIndex = 0;
            this.lblULimit.Text = "Upper limit";
            // 
            // grpStartCreep
            // 
            this.grpStartCreep.Controls.Add(this.cmbNumPulsesSC);
            this.grpStartCreep.Controls.Add(this.lblNumPulsesSC);
            this.grpStartCreep.Location = new System.Drawing.Point(129, 105);
            this.grpStartCreep.Margin = new System.Windows.Forms.Padding(4);
            this.grpStartCreep.Name = "grpStartCreep";
            this.grpStartCreep.Padding = new System.Windows.Forms.Padding(4);
            this.grpStartCreep.Size = new System.Drawing.Size(321, 107);
            this.grpStartCreep.TabIndex = 4;
            this.grpStartCreep.TabStop = false;
            this.grpStartCreep.Text = "Start / Creep test";
            // 
            // cmbNumPulsesSC
            // 
            this.cmbNumPulsesSC.BackColor = System.Drawing.Color.Transparent;
            this.cmbNumPulsesSC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNumPulsesSC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumPulsesSC.FormattingEnabled = true;
            this.cmbNumPulsesSC.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.cmbNumPulsesSC.Location = new System.Drawing.Point(154, 40);
            this.cmbNumPulsesSC.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNumPulsesSC.Name = "cmbNumPulsesSC";
            this.cmbNumPulsesSC.Size = new System.Drawing.Size(140, 27);
            this.cmbNumPulsesSC.TabIndex = 1;
            this.cmbNumPulsesSC.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // lblNumPulsesSC
            // 
            this.lblNumPulsesSC.AutoSize = true;
            this.lblNumPulsesSC.Location = new System.Drawing.Point(19, 44);
            this.lblNumPulsesSC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPulsesSC.Name = "lblNumPulsesSC";
            this.lblNumPulsesSC.Size = new System.Drawing.Size(101, 20);
            this.lblNumPulsesSC.TabIndex = 0;
            this.lblNumPulsesSC.Text = "No. of pulses";
            // 
            // lblMeasurement
            // 
            this.lblMeasurement.AutoSize = true;
            this.lblMeasurement.Location = new System.Drawing.Point(380, 24);
            this.lblMeasurement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeasurement.Name = "lblMeasurement";
            this.lblMeasurement.Size = new System.Drawing.Size(107, 20);
            this.lblMeasurement.TabIndex = 2;
            this.lblMeasurement.Text = "Measurement";
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Location = new System.Drawing.Point(26, 24);
            this.lblTestType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(74, 20);
            this.lblTestType.TabIndex = 0;
            this.lblTestType.Text = "Test type";
            // 
            // cmbMeasurement
            // 
            this.cmbMeasurement.BackColor = System.Drawing.Color.Transparent;
            this.cmbMeasurement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasurement.FormattingEnabled = true;
            this.cmbMeasurement.Items.AddRange(new object[] {
            "Active (P)",
            "Reactive (Q)",
            "Apparent (S)"});
            this.cmbMeasurement.Location = new System.Drawing.Point(490, 20);
            this.cmbMeasurement.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMeasurement.Name = "cmbMeasurement";
            this.cmbMeasurement.Size = new System.Drawing.Size(202, 27);
            this.cmbMeasurement.TabIndex = 3;
            this.cmbMeasurement.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // cmbTestType
            // 
            this.cmbTestType.BackColor = System.Drawing.Color.Transparent;
            this.cmbTestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestType.FormattingEnabled = true;
            this.cmbTestType.Items.AddRange(new object[] {
            "No Test",
            "Creep",
            "Start",
            "Error"});
            this.cmbTestType.Location = new System.Drawing.Point(129, 20);
            this.cmbTestType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTestType.Name = "cmbTestType";
            this.cmbTestType.Size = new System.Drawing.Size(217, 27);
            this.cmbTestType.TabIndex = 1;
            this.cmbTestType.SelectedIndexChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // tabDuration
            // 
            this.tabDuration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDuration.BackgroundImage")));
            this.tabDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDuration.Controls.Add(this.grpPostAction);
            this.tabDuration.Controls.Add(this.grpDuration);
            this.tabDuration.Location = new System.Drawing.Point(4, 29);
            this.tabDuration.Margin = new System.Windows.Forms.Padding(4);
            this.tabDuration.Name = "tabDuration";
            this.tabDuration.Size = new System.Drawing.Size(941, 593);
            this.tabDuration.TabIndex = 2;
            this.tabDuration.Text = "Test duration";
            this.tabDuration.UseVisualStyleBackColor = true;
            // 
            // grpPostAction
            // 
            this.grpPostAction.Controls.Add(this.rbNextTest);
            this.grpPostAction.Controls.Add(this.rbWaitI0);
            this.grpPostAction.Controls.Add(this.rbWait);
            this.grpPostAction.Location = new System.Drawing.Point(437, 20);
            this.grpPostAction.Margin = new System.Windows.Forms.Padding(4);
            this.grpPostAction.Name = "grpPostAction";
            this.grpPostAction.Padding = new System.Windows.Forms.Padding(4);
            this.grpPostAction.Size = new System.Drawing.Size(354, 187);
            this.grpPostAction.TabIndex = 1;
            this.grpPostAction.TabStop = false;
            this.grpPostAction.Text = "Action after test";
            // 
            // rbNextTest
            // 
            this.rbNextTest.AutoSize = true;
            this.rbNextTest.Checked = true;
            this.rbNextTest.Location = new System.Drawing.Point(26, 107);
            this.rbNextTest.Margin = new System.Windows.Forms.Padding(4);
            this.rbNextTest.Name = "rbNextTest";
            this.rbNextTest.Size = new System.Drawing.Size(97, 24);
            this.rbNextTest.TabIndex = 2;
            this.rbNextTest.TabStop = true;
            this.rbNextTest.Text = "Next test";
            this.rbNextTest.UseVisualStyleBackColor = true;
            this.rbNextTest.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbWaitI0
            // 
            this.rbWaitI0.AutoSize = true;
            this.rbWaitI0.Location = new System.Drawing.Point(26, 69);
            this.rbWaitI0.Margin = new System.Windows.Forms.Padding(4);
            this.rbWaitI0.Name = "rbWaitI0";
            this.rbWaitI0.Size = new System.Drawing.Size(93, 24);
            this.rbWaitI0.TabIndex = 1;
            this.rbWaitI0.Text = "Wait I=0";
            this.rbWaitI0.UseVisualStyleBackColor = true;
            this.rbWaitI0.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbWait
            // 
            this.rbWait.AutoSize = true;
            this.rbWait.Location = new System.Drawing.Point(26, 33);
            this.rbWait.Margin = new System.Windows.Forms.Padding(4);
            this.rbWait.Name = "rbWait";
            this.rbWait.Size = new System.Drawing.Size(66, 24);
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
            this.grpDuration.Location = new System.Drawing.Point(19, 20);
            this.grpDuration.Margin = new System.Windows.Forms.Padding(4);
            this.grpDuration.Name = "grpDuration";
            this.grpDuration.Padding = new System.Windows.Forms.Padding(4);
            this.grpDuration.Size = new System.Drawing.Size(399, 187);
            this.grpDuration.TabIndex = 0;
            this.grpDuration.TabStop = false;
            this.grpDuration.Text = "Test duration";
            // 
            // lblTimeoutHint
            // 
            this.lblTimeoutHint.AutoSize = true;
            this.lblTimeoutHint.Location = new System.Drawing.Point(244, 41);
            this.lblTimeoutHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeoutHint.Name = "lblTimeoutHint";
            this.lblTimeoutHint.Size = new System.Drawing.Size(77, 20);
            this.lblTimeoutHint.TabIndex = 2;
            this.lblTimeoutHint.Text = "hh:mm:ss";
            // 
            // txtTimeout
            // 
            this.txtTimeout.BackColor = System.Drawing.Color.Transparent;
            this.txtTimeout.Location = new System.Drawing.Point(116, 37);
            this.txtTimeout.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(115, 26);
            this.txtTimeout.TabIndex = 1;
            this.txtTimeout.Text = "00:01:00";
            this.txtTimeout.TextChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbTimeDuration
            // 
            this.rbTimeDuration.AutoSize = true;
            this.rbTimeDuration.Checked = true;
            this.rbTimeDuration.Location = new System.Drawing.Point(26, 40);
            this.rbTimeDuration.Margin = new System.Windows.Forms.Padding(4);
            this.rbTimeDuration.Name = "rbTimeDuration";
            this.rbTimeDuration.Size = new System.Drawing.Size(68, 24);
            this.rbTimeDuration.TabIndex = 0;
            this.rbTimeDuration.TabStop = true;
            this.rbTimeDuration.Text = "Time";
            this.rbTimeDuration.UseVisualStyleBackColor = true;
            // 
            // tabControls
            // 
            this.tabControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControls.BackgroundImage")));
            this.tabControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tabControls.Controls.Add(this.lblControlCommand);
            this.tabControls.Controls.Add(this.grpCtrlType);
            this.tabControls.Controls.Add(this.txtControlCommand);
            this.tabControls.Location = new System.Drawing.Point(4, 29);
            this.tabControls.Margin = new System.Windows.Forms.Padding(4);
            this.tabControls.Name = "tabControls";
            this.tabControls.Size = new System.Drawing.Size(941, 593);
            this.tabControls.TabIndex = 3;
            this.tabControls.Text = "Control functions";
            this.tabControls.UseVisualStyleBackColor = true;
            // 
            // chkWithAmp
            // 
            this.chkWithAmp.AutoSize = true;
            this.chkWithAmp.Location = new System.Drawing.Point(301, 464);
            this.chkWithAmp.Margin = new System.Windows.Forms.Padding(4);
            this.chkWithAmp.Name = "chkWithAmp";
            this.chkWithAmp.Size = new System.Drawing.Size(61, 24);
            this.chkWithAmp.TabIndex = 16;
            this.chkWithAmp.Text = "w/A";
            this.chkWithAmp.UseVisualStyleBackColor = true;
            this.chkWithAmp.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // btnDelAfter
            // 
            this.btnDelAfter.Location = new System.Drawing.Point(309, 400);
            this.btnDelAfter.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelAfter.Name = "btnDelAfter";
            this.btnDelAfter.Size = new System.Drawing.Size(45, 31);
            this.btnDelAfter.TabIndex = 15;
            this.btnDelAfter.Text = "<<";
            this.btnDelAfter.UseVisualStyleBackColor = true;
            this.btnDelAfter.Click += new System.EventHandler(this.btnDelAfter_Click);
            // 
            // btnAddAfter
            // 
            this.btnAddAfter.Location = new System.Drawing.Point(309, 360);
            this.btnAddAfter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAfter.Name = "btnAddAfter";
            this.btnAddAfter.Size = new System.Drawing.Size(45, 31);
            this.btnAddAfter.TabIndex = 14;
            this.btnAddAfter.Text = ">>";
            this.btnAddAfter.UseVisualStyleBackColor = true;
            this.btnAddAfter.Click += new System.EventHandler(this.btnAddAfter_Click);
            // 
            // btnDelDuring
            // 
            this.btnDelDuring.Location = new System.Drawing.Point(309, 240);
            this.btnDelDuring.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelDuring.Name = "btnDelDuring";
            this.btnDelDuring.Size = new System.Drawing.Size(45, 31);
            this.btnDelDuring.TabIndex = 13;
            this.btnDelDuring.Text = "<<";
            this.btnDelDuring.UseVisualStyleBackColor = true;
            this.btnDelDuring.Click += new System.EventHandler(this.btnDelDuring_Click);
            // 
            // btnAddDuring
            // 
            this.btnAddDuring.Location = new System.Drawing.Point(309, 200);
            this.btnAddDuring.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDuring.Name = "btnAddDuring";
            this.btnAddDuring.Size = new System.Drawing.Size(45, 31);
            this.btnAddDuring.TabIndex = 12;
            this.btnAddDuring.Text = ">>";
            this.btnAddDuring.UseVisualStyleBackColor = true;
            this.btnAddDuring.Click += new System.EventHandler(this.btnAddDuring_Click);
            // 
            // btnDelBefore
            // 
            this.btnDelBefore.Location = new System.Drawing.Point(309, 73);
            this.btnDelBefore.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelBefore.Name = "btnDelBefore";
            this.btnDelBefore.Size = new System.Drawing.Size(45, 31);
            this.btnDelBefore.TabIndex = 11;
            this.btnDelBefore.Text = "<<";
            this.btnDelBefore.UseVisualStyleBackColor = true;
            this.btnDelBefore.Click += new System.EventHandler(this.btnDelBefore_Click);
            // 
            // btnAddBefore
            // 
            this.btnAddBefore.Location = new System.Drawing.Point(309, 33);
            this.btnAddBefore.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBefore.Name = "btnAddBefore";
            this.btnAddBefore.Size = new System.Drawing.Size(45, 31);
            this.btnAddBefore.TabIndex = 10;
            this.btnAddBefore.Text = ">>";
            this.btnAddBefore.UseVisualStyleBackColor = true;
            this.btnAddBefore.Click += new System.EventHandler(this.btnAddBefore_Click);
            // 
            // lstAfterCmds
            // 
            this.lstAfterCmds.FormattingEnabled = true;
            this.lstAfterCmds.ItemHeight = 20;
            this.lstAfterCmds.Location = new System.Drawing.Point(373, 387);
            this.lstAfterCmds.Margin = new System.Windows.Forms.Padding(4);
            this.lstAfterCmds.Name = "lstAfterCmds";
            this.lstAfterCmds.Size = new System.Drawing.Size(549, 164);
            this.lstAfterCmds.TabIndex = 9;
            // 
            // lblAfterCmds
            // 
            this.lblAfterCmds.AutoSize = true;
            this.lblAfterCmds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterCmds.Location = new System.Drawing.Point(373, 354);
            this.lblAfterCmds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfterCmds.Name = "lblAfterCmds";
            this.lblAfterCmds.Size = new System.Drawing.Size(82, 22);
            this.lblAfterCmds.TabIndex = 8;
            this.lblAfterCmds.Text = "After test";
            this.lblAfterCmds.Click += new System.EventHandler(this.lblAfterCmds_Click);
            // 
            // lstDuringCmds
            // 
            this.lstDuringCmds.FormattingEnabled = true;
            this.lstDuringCmds.ItemHeight = 20;
            this.lstDuringCmds.Location = new System.Drawing.Point(373, 207);
            this.lstDuringCmds.Margin = new System.Windows.Forms.Padding(4);
            this.lstDuringCmds.Name = "lstDuringCmds";
            this.lstDuringCmds.Size = new System.Drawing.Size(549, 144);
            this.lstDuringCmds.TabIndex = 7;
            // 
            // lblDuringCmds
            // 
            this.lblDuringCmds.AutoSize = true;
            this.lblDuringCmds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuringCmds.Location = new System.Drawing.Point(373, 177);
            this.lblDuringCmds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuringCmds.Name = "lblDuringCmds";
            this.lblDuringCmds.Size = new System.Drawing.Size(97, 22);
            this.lblDuringCmds.TabIndex = 6;
            this.lblDuringCmds.Text = "During test";
            // 
            // lstBeforeCmds
            // 
            this.lstBeforeCmds.FormattingEnabled = true;
            this.lstBeforeCmds.ItemHeight = 20;
            this.lstBeforeCmds.Location = new System.Drawing.Point(373, 27);
            this.lstBeforeCmds.Margin = new System.Windows.Forms.Padding(4);
            this.lstBeforeCmds.Name = "lstBeforeCmds";
            this.lstBeforeCmds.Size = new System.Drawing.Size(549, 144);
            this.lstBeforeCmds.TabIndex = 5;
            // 
            // lblBeforeCmds
            // 
            this.lblBeforeCmds.AutoSize = true;
            this.lblBeforeCmds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeforeCmds.Location = new System.Drawing.Point(373, 4);
            this.lblBeforeCmds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeforeCmds.Name = "lblBeforeCmds";
            this.lblBeforeCmds.Size = new System.Drawing.Size(97, 22);
            this.lblBeforeCmds.TabIndex = 4;
            this.lblBeforeCmds.Text = "Before test";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(19, 500);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(270, 52);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblControlCommand
            // 
            this.lblControlCommand.AutoSize = true;
            this.lblControlCommand.Location = new System.Drawing.Point(19, 160);
            this.lblControlCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlCommand.Name = "lblControlCommand";
            this.lblControlCommand.Size = new System.Drawing.Size(226, 20);
            this.lblControlCommand.TabIndex = 1;
            this.lblControlCommand.Text = "Message Text / Program Name";
            // 
            // grpCtrlType
            // 
            this.grpCtrlType.Controls.Add(this.rbCtrlWait);
            this.grpCtrlType.Controls.Add(this.rbCtrlProgram);
            this.grpCtrlType.Controls.Add(this.rbCtrlManual);
            this.grpCtrlType.Location = new System.Drawing.Point(19, 20);
            this.grpCtrlType.Margin = new System.Windows.Forms.Padding(4);
            this.grpCtrlType.Name = "grpCtrlType";
            this.grpCtrlType.Padding = new System.Windows.Forms.Padding(4);
            this.grpCtrlType.Size = new System.Drawing.Size(270, 127);
            this.grpCtrlType.TabIndex = 0;
            this.grpCtrlType.TabStop = false;
            this.grpCtrlType.Text = "Control function";
            // 
            // rbCtrlWait
            // 
            this.rbCtrlWait.AutoSize = true;
            this.rbCtrlWait.Location = new System.Drawing.Point(26, 91);
            this.rbCtrlWait.Margin = new System.Windows.Forms.Padding(4);
            this.rbCtrlWait.Name = "rbCtrlWait";
            this.rbCtrlWait.Size = new System.Drawing.Size(66, 24);
            this.rbCtrlWait.TabIndex = 2;
            this.rbCtrlWait.Text = "Wait";
            this.rbCtrlWait.UseVisualStyleBackColor = true;
            this.rbCtrlWait.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbCtrlProgram
            // 
            this.rbCtrlProgram.AutoSize = true;
            this.rbCtrlProgram.Location = new System.Drawing.Point(26, 57);
            this.rbCtrlProgram.Margin = new System.Windows.Forms.Padding(4);
            this.rbCtrlProgram.Name = "rbCtrlProgram";
            this.rbCtrlProgram.Size = new System.Drawing.Size(94, 24);
            this.rbCtrlProgram.TabIndex = 1;
            this.rbCtrlProgram.Text = "Program";
            this.rbCtrlProgram.UseVisualStyleBackColor = true;
            this.rbCtrlProgram.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // rbCtrlManual
            // 
            this.rbCtrlManual.AutoSize = true;
            this.rbCtrlManual.Checked = true;
            this.rbCtrlManual.Location = new System.Drawing.Point(26, 27);
            this.rbCtrlManual.Margin = new System.Windows.Forms.Padding(4);
            this.rbCtrlManual.Name = "rbCtrlManual";
            this.rbCtrlManual.Size = new System.Drawing.Size(86, 24);
            this.rbCtrlManual.TabIndex = 0;
            this.rbCtrlManual.TabStop = true;
            this.rbCtrlManual.Text = "Manual";
            this.rbCtrlManual.UseVisualStyleBackColor = true;
            this.rbCtrlManual.CheckedChanged += new System.EventHandler(this.DetailControl_Changed);
            // 
            // txtControlCommand
            // 
            this.txtControlCommand.BackColor = System.Drawing.Color.Transparent;
            this.txtControlCommand.Location = new System.Drawing.Point(19, 187);
            this.txtControlCommand.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlCommand.Multiline = true;
            this.txtControlCommand.Name = "txtControlCommand";
            this.txtControlCommand.Size = new System.Drawing.Size(269, 305);
            this.txtControlCommand.TabIndex = 2;
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.BackColor = System.Drawing.Color.Transparent;
            this.txtProcedureName.Location = new System.Drawing.Point(495, 20);
            this.txtProcedureName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(320, 26);
            this.txtProcedureName.TabIndex = 3;
            // 
            // cmbProcedures
            // 
            this.cmbProcedures.BackColor = System.Drawing.Color.Transparent;
            this.cmbProcedures.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProcedures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcedures.FormattingEnabled = true;
            this.cmbProcedures.Location = new System.Drawing.Point(154, 20);
            this.cmbProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProcedures.Name = "cmbProcedures";
            this.cmbProcedures.Size = new System.Drawing.Size(256, 27);
            this.cmbProcedures.TabIndex = 1;
            this.cmbProcedures.SelectedIndexChanged += new System.EventHandler(this.cmbProcedures_SelectedIndexChanged);
            // 
            // frmProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1348, 794);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private CabconPMP.TransparentComboBox cmbProcedures;
        private System.Windows.Forms.Label lblProcName;
        private CabconPMP.TransparentTextBox txtProcedureName;
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
        private CabconPMP.TransparentComboBox cmbUA;
        private System.Windows.Forms.Label lblStepUC;
        private CabconPMP.TransparentComboBox cmbUC;
        private System.Windows.Forms.Label lblStepUB;
        private CabconPMP.TransparentComboBox cmbUB;
        private System.Windows.Forms.Label lblStepIC;
        private CabconPMP.TransparentComboBox cmbIC;
        private System.Windows.Forms.Label lblStepIB;
        private CabconPMP.TransparentComboBox cmbIB;
        private System.Windows.Forms.Label lblStepIA;
        private CabconPMP.TransparentComboBox cmbIA;
        private CabconPMP.TransparentComboBox cmbPFType;
        private System.Windows.Forms.Label lblPFType;
        private System.Windows.Forms.GroupBox grpLagLead;
        private System.Windows.Forms.RadioButton rbLeading;
        private System.Windows.Forms.RadioButton rbLagging;
        private System.Windows.Forms.GroupBox grpConsDeliv;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbConsumption;
        private CabconPMP.TransparentComboBox cmbPFValue;
        private System.Windows.Forms.Label lblPFValue;
        private CabconPMP.TransparentComboBox cmbWaveform;
        private System.Windows.Forms.Label lblWaveform;
        private CabconPMP.TransparentComboBox cmbFreq;
        private System.Windows.Forms.Label lblStepFreq;
        private System.Windows.Forms.GroupBox grpRotation;
        private System.Windows.Forms.RadioButton rbL132;
        private System.Windows.Forms.RadioButton rbL123;
        private CabconPMP.TransparentTextBox txtStepName;
        private System.Windows.Forms.Label lblStepName;
        private CabconPMP.TransparentComboBox cmbTestType;
        private System.Windows.Forms.Label lblTestType;
        private CabconPMP.TransparentComboBox cmbMeasurement;
        private System.Windows.Forms.Label lblMeasurement;
        private System.Windows.Forms.GroupBox grpStartCreep;
        private CabconPMP.TransparentComboBox cmbNumPulsesSC;
        private System.Windows.Forms.Label lblNumPulsesSC;
        private System.Windows.Forms.GroupBox grpErrorDial;
        private CabconPMP.TransparentComboBox cmbLLimit;
        private System.Windows.Forms.Label lblLLimit;
        private CabconPMP.TransparentComboBox cmbULimit;
        private System.Windows.Forms.Label lblULimit;
        private System.Windows.Forms.CheckBox chkSymmetrical;
        private CabconPMP.TransparentTextBox txtNumPulsesErr;
        private System.Windows.Forms.Label lblNumPulsesErr;
        private CabconPMP.TransparentComboBox cmbNumDecPlace;
        private System.Windows.Forms.Label lblNumDecPlace;
        private System.Windows.Forms.GroupBox grpChannel;
        private CabconPMP.TransparentComboBox cmbChannelNo;
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
        private CabconPMP.TransparentTextBox txtTimeout;
        private System.Windows.Forms.RadioButton rbTimeDuration;
        private System.Windows.Forms.GroupBox grpPostAction;
        private System.Windows.Forms.RadioButton rbNextTest;
        private System.Windows.Forms.RadioButton rbWaitI0;
        private System.Windows.Forms.RadioButton rbWait;
        private System.Windows.Forms.GroupBox grpCtrlType;
        private System.Windows.Forms.RadioButton rbCtrlWait;
        private System.Windows.Forms.RadioButton rbCtrlProgram;
        private System.Windows.Forms.RadioButton rbCtrlManual;
        private CabconPMP.TransparentTextBox txtControlCommand;
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
