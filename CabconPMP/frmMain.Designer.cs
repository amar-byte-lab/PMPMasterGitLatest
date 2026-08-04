namespace CabconPMP
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_configuration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Association = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_userManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ServerSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.verificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_report = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_executionReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_parametersWiseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_missingMeterReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_productionStageReport = new System.Windows.Forms.ToolStripMenuItem();
            this.routineTestReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDataReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_rejectlist = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DLMSStas = new System.Windows.Forms.StatusStrip();
            this.stsReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlmsCommStatusmsh = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblversion = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlmsCommStatusmsh2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_ico_report = new System.Windows.Forms.ToolStripLabel();
            this.tss_Report = new System.Windows.Forms.ToolStripSeparator();
            this.ts_ico_Association = new System.Windows.Forms.ToolStripLabel();
            this.ts_Help = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Exit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRetry = new System.Windows.Forms.ToolStripLabel();
            this.cms_Open = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_openProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_OpenProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_New = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_RunProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_CreateProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_CreateProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainScreenMsg = new System.Windows.Forms.Label();
            this.pcbBackgroundImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.DLMSStas.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.cms_Open.SuspendLayout();
            this.cms_New.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibrationToolStripMenuItem,
            this.ts_configuration,
            this.verificationToolStripMenuItem,
            this.ts_report,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1678, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // calibrationToolStripMenuItem
            // 
            this.calibrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.calibrateToolStripMenuItem,
            this.addProceduresToolStripMenuItem,
            this.meterTypeToolStripMenuItem});
            this.calibrationToolStripMenuItem.Name = "calibrationToolStripMenuItem";
            this.calibrationToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.calibrationToolStripMenuItem.Text = "Calibration";
            this.calibrationToolStripMenuItem.Click += new System.EventHandler(this.calibrationToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Enabled = false;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Visible = false;
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.selectProceduresToolStripMenuItem_Click);
            // 
            // calibrateToolStripMenuItem
            // 
            this.calibrateToolStripMenuItem.Name = "calibrateToolStripMenuItem";
            this.calibrateToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.calibrateToolStripMenuItem.Text = "Calibrate";
            this.calibrateToolStripMenuItem.Click += new System.EventHandler(this.calibrateToolStripMenuItem_Click);
            // 
            // addProceduresToolStripMenuItem
            // 
            this.addProceduresToolStripMenuItem.Name = "addProceduresToolStripMenuItem";
            this.addProceduresToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.addProceduresToolStripMenuItem.Text = "Add Procedures";
            this.addProceduresToolStripMenuItem.Click += new System.EventHandler(this.addProceduresToolStripMenuItem_Click);
            // 
            // meterTypeToolStripMenuItem
            // 
            this.meterTypeToolStripMenuItem.Name = "meterTypeToolStripMenuItem";
            this.meterTypeToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.meterTypeToolStripMenuItem.Text = "Meter Type";
            this.meterTypeToolStripMenuItem.Click += new System.EventHandler(this.meterTypeToolStripMenuItem_Click);
            // 
            // ts_configuration
            // 
            this.ts_configuration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Association,
            this.tsm_userManagement,
            this.tsm_changePassword,
            this.tsm_ServerSettings});
            this.ts_configuration.Name = "ts_configuration";
            this.ts_configuration.Size = new System.Drawing.Size(92, 29);
            this.ts_configuration.Text = "Settings";
            // 
            // tsm_Association
            // 
            this.tsm_Association.Name = "tsm_Association";
            this.tsm_Association.Size = new System.Drawing.Size(259, 34);
            this.tsm_Association.Text = "Association";
            this.tsm_Association.Click += new System.EventHandler(this.tsm_Association_Click);
            // 
            // tsm_userManagement
            // 
            this.tsm_userManagement.Enabled = false;
            this.tsm_userManagement.Name = "tsm_userManagement";
            this.tsm_userManagement.Size = new System.Drawing.Size(259, 34);
            this.tsm_userManagement.Text = "User Management";
            this.tsm_userManagement.Visible = false;
            this.tsm_userManagement.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // tsm_changePassword
            // 
            this.tsm_changePassword.Enabled = false;
            this.tsm_changePassword.Name = "tsm_changePassword";
            this.tsm_changePassword.Size = new System.Drawing.Size(259, 34);
            this.tsm_changePassword.Text = "Change Password";
            this.tsm_changePassword.Visible = false;
            this.tsm_changePassword.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // tsm_ServerSettings
            // 
            this.tsm_ServerSettings.Name = "tsm_ServerSettings";
            this.tsm_ServerSettings.Size = new System.Drawing.Size(259, 34);
            this.tsm_ServerSettings.Text = "Server Settings";
            this.tsm_ServerSettings.Click += new System.EventHandler(this.tsm_ServerSettings_Click);
            // 
            // verificationToolStripMenuItem
            // 
            this.verificationToolStripMenuItem.Name = "verificationToolStripMenuItem";
            this.verificationToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.verificationToolStripMenuItem.Text = "Verification";
            // 
            // ts_report
            // 
            this.ts_report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_executionReports,
            this.tsm_parametersWiseReport,
            this.tsm_missingMeterReport,
            this.tsm_productionStageReport,
            this.routineTestReportToolStripMenuItem,
            this.backupDataReportToolStripMenuItem,
            this.tsm_rejectlist});
            this.ts_report.Name = "ts_report";
            this.ts_report.Size = new System.Drawing.Size(89, 29);
            this.ts_report.Text = "Reports";
            // 
            // tsm_executionReports
            // 
            this.tsm_executionReports.Name = "tsm_executionReports";
            this.tsm_executionReports.Size = new System.Drawing.Size(391, 34);
            this.tsm_executionReports.Text = "Detailed Report";
            this.tsm_executionReports.Click += new System.EventHandler(this.tsm_executionReports_Click);
            // 
            // tsm_parametersWiseReport
            // 
            this.tsm_parametersWiseReport.Enabled = false;
            this.tsm_parametersWiseReport.Name = "tsm_parametersWiseReport";
            this.tsm_parametersWiseReport.Size = new System.Drawing.Size(391, 34);
            this.tsm_parametersWiseReport.Text = "Parameters Wise Report";
            this.tsm_parametersWiseReport.Visible = false;
            this.tsm_parametersWiseReport.Click += new System.EventHandler(this.tsm_parametersWiseReport_Click);
            // 
            // tsm_missingMeterReport
            // 
            this.tsm_missingMeterReport.Enabled = false;
            this.tsm_missingMeterReport.Name = "tsm_missingMeterReport";
            this.tsm_missingMeterReport.Size = new System.Drawing.Size(391, 34);
            this.tsm_missingMeterReport.Text = "Serialization Missing Meters Report";
            this.tsm_missingMeterReport.Visible = false;
            this.tsm_missingMeterReport.Click += new System.EventHandler(this.tsm_missingMeterReport_Click);
            // 
            // tsm_productionStageReport
            // 
            this.tsm_productionStageReport.Name = "tsm_productionStageReport";
            this.tsm_productionStageReport.Size = new System.Drawing.Size(391, 34);
            this.tsm_productionStageReport.Text = "Production Stage Report";
            this.tsm_productionStageReport.Click += new System.EventHandler(this.tsm_productionStageReport_Click);
            // 
            // routineTestReportToolStripMenuItem
            // 
            this.routineTestReportToolStripMenuItem.Name = "routineTestReportToolStripMenuItem";
            this.routineTestReportToolStripMenuItem.Size = new System.Drawing.Size(391, 34);
            this.routineTestReportToolStripMenuItem.Text = "Calibration Routine Test Report";
            this.routineTestReportToolStripMenuItem.Click += new System.EventHandler(this.routineTestReportToolStripMenuItem_Click);
            // 
            // backupDataReportToolStripMenuItem
            // 
            this.backupDataReportToolStripMenuItem.Name = "backupDataReportToolStripMenuItem";
            this.backupDataReportToolStripMenuItem.Size = new System.Drawing.Size(391, 34);
            this.backupDataReportToolStripMenuItem.Text = "Backup Data Report";
            this.backupDataReportToolStripMenuItem.Click += new System.EventHandler(this.backupDataReportToolStripMenuItem_Click);
            // 
            // tsm_rejectlist
            // 
            this.tsm_rejectlist.Enabled = false;
            this.tsm_rejectlist.Name = "tsm_rejectlist";
            this.tsm_rejectlist.Size = new System.Drawing.Size(391, 34);
            this.tsm_rejectlist.Text = "Rejection List Report";
            this.tsm_rejectlist.Visible = false;
            this.tsm_rejectlist.Click += new System.EventHandler(this.tsm_rejectlist_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contentsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.contentsToolStripMenuItem.Text = "Contents";
            this.contentsToolStripMenuItem.Visible = false;
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DLMSStas
            // 
            this.DLMSStas.AutoSize = false;
            this.DLMSStas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DLMSStas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsReady,
            this.dlmsCommStatusmsh,
            this.lblversion,
            this.dlmsCommStatusmsh2,
            this.lblLoginInfo});
            this.DLMSStas.Location = new System.Drawing.Point(0, 972);
            this.DLMSStas.Name = "DLMSStas";
            this.DLMSStas.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.DLMSStas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DLMSStas.Size = new System.Drawing.Size(1678, 34);
            this.DLMSStas.TabIndex = 1;
            this.DLMSStas.Text = "statusStrip1";
            // 
            // stsReady
            // 
            this.stsReady.Name = "stsReady";
            this.stsReady.Size = new System.Drawing.Size(60, 27);
            this.stsReady.Text = "Ready";
            // 
            // dlmsCommStatusmsh
            // 
            this.dlmsCommStatusmsh.AutoSize = false;
            this.dlmsCommStatusmsh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlmsCommStatusmsh.ForeColor = System.Drawing.Color.Green;
            this.dlmsCommStatusmsh.Name = "dlmsCommStatusmsh";
            this.dlmsCommStatusmsh.Size = new System.Drawing.Size(38, 27);
            this.dlmsCommStatusmsh.Text = "Space";
            // 
            // lblversion
            // 
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(137, 27);
            this.lblversion.Text = "Product Version";
            // 
            // dlmsCommStatusmsh2
            // 
            this.dlmsCommStatusmsh2.AutoSize = false;
            this.dlmsCommStatusmsh2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlmsCommStatusmsh2.ForeColor = System.Drawing.Color.Green;
            this.dlmsCommStatusmsh2.Name = "dlmsCommStatusmsh2";
            this.dlmsCommStatusmsh2.Size = new System.Drawing.Size(38, 27);
            this.dlmsCommStatusmsh2.Text = "Space";
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(88, 27);
            this.lblLoginInfo.Text = "LoginInfo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_ico_report,
            this.tss_Report,
            this.ts_ico_Association,
            this.ts_Help,
            this.toolStripSeparator4,
            this.ts_Exit,
            this.toolStripSeparator3,
            this.toolRetry});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1678, 60);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // ts_ico_report
            // 
            this.ts_ico_report.Image = ((System.Drawing.Image)(resources.GetObject("ts_ico_report.Image")));
            this.ts_ico_report.Name = "ts_ico_report";
            this.ts_ico_report.Size = new System.Drawing.Size(105, 55);
            this.ts_ico_report.Text = "    Report    ";
            this.ts_ico_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_ico_report.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // tss_Report
            // 
            this.tss_Report.Name = "tss_Report";
            this.tss_Report.Size = new System.Drawing.Size(6, 60);
            // 
            // ts_ico_Association
            // 
            this.ts_ico_Association.Image = global::CabconPMP.Properties.Resources.alliance;
            this.ts_ico_Association.Name = "ts_ico_Association";
            this.ts_ico_Association.Size = new System.Drawing.Size(103, 55);
            this.ts_ico_Association.Text = "Association";
            this.ts_ico_Association.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_ico_Association.Click += new System.EventHandler(this.ts_Association_Click);
            // 
            // ts_Help
            // 
            this.ts_Help.Image = ((System.Drawing.Image)(resources.GetObject("ts_Help.Image")));
            this.ts_Help.Name = "ts_Help";
            this.ts_Help.Size = new System.Drawing.Size(114, 55);
            this.ts_Help.Text = "       Help      ";
            this.ts_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Help.Visible = false;
            this.ts_Help.Click += new System.EventHandler(this.ts_Help_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 60);
            // 
            // ts_Exit
            // 
            this.ts_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ts_Exit.Image")));
            this.ts_Exit.Name = "ts_Exit";
            this.ts_Exit.Size = new System.Drawing.Size(99, 55);
            this.ts_Exit.Text = "      Exit      ";
            this.ts_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Exit.Click += new System.EventHandler(this.ts_Exit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // toolRetry
            // 
            this.toolRetry.Image = ((System.Drawing.Image)(resources.GetObject("toolRetry.Image")));
            this.toolRetry.Name = "toolRetry";
            this.toolRetry.Size = new System.Drawing.Size(106, 55);
            this.toolRetry.Text = "     Calibrate";
            this.toolRetry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolRetry.Click += new System.EventHandler(this.toolRetry_Click);
            // 
            // cms_Open
            // 
            this.cms_Open.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cms_Open.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_openProcedure,
            this.cms_OpenProgram});
            this.cms_Open.Name = "cms_Open";
            this.cms_Open.Size = new System.Drawing.Size(165, 68);
            this.cms_Open.Text = "Open";
            // 
            // cms_openProcedure
            // 
            this.cms_openProcedure.Name = "cms_openProcedure";
            this.cms_openProcedure.Size = new System.Drawing.Size(164, 32);
            this.cms_openProcedure.Text = "Procedure";
            this.cms_openProcedure.Click += new System.EventHandler(this.cms_openProcedure_Click);
            // 
            // cms_OpenProgram
            // 
            this.cms_OpenProgram.Name = "cms_OpenProgram";
            this.cms_OpenProgram.Size = new System.Drawing.Size(164, 32);
            this.cms_OpenProgram.Text = "Program";
            this.cms_OpenProgram.Click += new System.EventHandler(this.cms_OpenProgram_Click);
            // 
            // cms_New
            // 
            this.cms_New.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cms_New.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_RunProcedure,
            this.cms_CreateProcedure,
            this.cms_CreateProgram});
            this.cms_New.Name = "cms_Open";
            this.cms_New.Size = new System.Drawing.Size(220, 100);
            this.cms_New.Text = "Open";
            // 
            // cms_RunProcedure
            // 
            this.cms_RunProcedure.Name = "cms_RunProcedure";
            this.cms_RunProcedure.Size = new System.Drawing.Size(219, 32);
            this.cms_RunProcedure.Text = "Run Procedure";
            this.cms_RunProcedure.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cms_CreateProcedure
            // 
            this.cms_CreateProcedure.Name = "cms_CreateProcedure";
            this.cms_CreateProcedure.Size = new System.Drawing.Size(219, 32);
            this.cms_CreateProcedure.Text = "Create Procedure";
            this.cms_CreateProcedure.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cms_CreateProgram
            // 
            this.cms_CreateProgram.Name = "cms_CreateProgram";
            this.cms_CreateProgram.Size = new System.Drawing.Size(219, 32);
            this.cms_CreateProgram.Text = "Create Program";
            this.cms_CreateProgram.Click += new System.EventHandler(this.createProgramToolStripMenuItem_Click);
            // 
            // lblMainScreenMsg
            // 
            this.lblMainScreenMsg.AutoSize = true;
            this.lblMainScreenMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMainScreenMsg.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainScreenMsg.Location = new System.Drawing.Point(645, 625);
            this.lblMainScreenMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainScreenMsg.Name = "lblMainScreenMsg";
            this.lblMainScreenMsg.Size = new System.Drawing.Size(0, 33);
            this.lblMainScreenMsg.TabIndex = 20;
            // 
            // pcbBackgroundImage
            // 
            this.pcbBackgroundImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbBackgroundImage.BackgroundImage")));
            this.pcbBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbBackgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbBackgroundImage.Location = new System.Drawing.Point(0, 36);
            this.pcbBackgroundImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbBackgroundImage.Name = "pcbBackgroundImage";
            this.pcbBackgroundImage.Size = new System.Drawing.Size(1678, 936);
            this.pcbBackgroundImage.TabIndex = 19;
            this.pcbBackgroundImage.TabStop = false;
            this.pcbBackgroundImage.Click += new System.EventHandler(this.pcbBackgroundImage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1006);
            this.Controls.Add(this.lblMainScreenMsg);
            this.Controls.Add(this.pcbBackgroundImage);
            this.Controls.Add(this.DLMSStas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cabcon Calibration Software";
            this.Activated += new System.EventHandler(this.SM110frmMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.SM110frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DLMSStas.ResumeLayout(false);
            this.DLMSStas.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cms_Open.ResumeLayout(false);
            this.cms_New.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_configuration;
        private System.Windows.Forms.ToolStripMenuItem ts_report;
        private System.Windows.Forms.StatusStrip DLMSStas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ts_ico_Association;
        private System.Windows.Forms.ToolStripLabel ts_Help;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel ts_Exit;
        private System.Windows.Forms.ToolStripMenuItem tsm_Association;
        private System.Windows.Forms.ToolStripStatusLabel stsReady;
        private System.Windows.Forms.ToolStripStatusLabel lblversion;
        private System.Windows.Forms.ToolStripStatusLabel dlmsCommStatusmsh;
        private System.Windows.Forms.ToolStripMenuItem tsm_executionReports;
        private System.Windows.Forms.ToolStripLabel ts_ico_report;
        private System.Windows.Forms.ToolStripSeparator tss_Report;
        private System.Windows.Forms.ContextMenuStrip cms_Open;
        private System.Windows.Forms.ToolStripMenuItem cms_openProcedure;
        private System.Windows.Forms.ToolStripMenuItem cms_OpenProgram;
        private System.Windows.Forms.ContextMenuStrip cms_New;
        private System.Windows.Forms.ToolStripMenuItem cms_RunProcedure;
        private System.Windows.Forms.ToolStripMenuItem cms_CreateProcedure;
        private System.Windows.Forms.ToolStripMenuItem cms_CreateProgram;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcbBackgroundImage;
        private System.Windows.Forms.ToolStripMenuItem tsm_userManagement;
        private System.Windows.Forms.ToolStripMenuItem tsm_changePassword;
        private System.Windows.Forms.ToolStripMenuItem tsm_ServerSettings;
        private System.Windows.Forms.Label lblMainScreenMsg;
        private System.Windows.Forms.ToolStripMenuItem tsm_productionStageReport;
        private System.Windows.Forms.ToolStripMenuItem routineTestReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_missingMeterReport;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginInfo;
        private System.Windows.Forms.ToolStripStatusLabel dlmsCommStatusmsh2;
        private System.Windows.Forms.ToolStripMenuItem tsm_parametersWiseReport;
        private System.Windows.Forms.ToolStripMenuItem backupDataReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsm_rejectlist;
        private System.Windows.Forms.ToolStripLabel toolRetry;
        private System.Windows.Forms.ToolStripMenuItem calibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterTypeToolStripMenuItem;
    }
}

