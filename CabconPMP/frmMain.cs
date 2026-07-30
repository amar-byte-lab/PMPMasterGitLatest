using CabconPMP.UI;
using ApplicationInterface;
using BALLAYER;
using CabconPMP.Data;
using CabconPMP.Models;
using CabconPMPREJECTIONTOOL;
using CabconPMPSYNCSERVICE;
using COMMONENTITY;
using Dapper;
using DataLayer;
using SmartCalibration.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SystemSecurityLibrary;
using Utilities;
using static CabconPMP.Data.MeterTypeRepository;
namespace CabconPMP
{
    public partial class frmMain : Form
    {
        GlobalMethods objsv = new GlobalMethods();
        AppSettings objappSettings = new AppSettings();
        MyCrypro objcrypt = new MyCrypro();
        XMLExportImport obgxml = new XMLExportImport();
        EntityUserManagement objetyusermgt = new EntityUserManagement();
        string logedUserID = string.Empty;
        string logedUserType = string.Empty;
        int getUserIndex = 0;
        private Person _currentUser;

        private readonly IDbConnectionFactory _dbConnectionFactory;
        private readonly PersonRepository _personRepository;
        private readonly MeterTypeRepository _meterTypeRepository;
        private readonly ProcedureRepository _procedureRepository;
        private readonly RunRepository _runRepository;
        private readonly BenchRepository _benchRepository;

        public frmMain(EntityUserManagement objetyum, IDbConnectionFactory dbFactory, PersonRepository personRepo, MeterTypeRepository meterTypeRepo, ProcedureRepository procedureRepo, RunRepository runRepo, BenchRepository benchRepo)
        {
            InitializeComponent(); COMMONENTITY.FormStyleHelper.Apply(this);
            objetyusermgt.LoginuserID = objetyum.LoginuserID;
            objetyusermgt = objetyum;
            logedUserType = objetyum.LogType;
            _dbConnectionFactory = dbFactory;
            _personRepository = personRepo;
            _meterTypeRepository = meterTypeRepo;
            _procedureRepository = procedureRepo;
            _runRepository = runRepo;
            _benchRepository = benchRepo;

            // Auto-initialize local database schema if needed
            InitializeLocalDatabase();

            // Show logon dialog on load
            ShowLogon();
        }

        private void ShowLogon()
        {
            using (var login = new frmLoginMain(_personRepository))
            if (login.ShowDialog() == DialogResult.OK)
            {
                _currentUser = login.LoggedInUser;
                //lblStatusUser.Text = $"Active User: {_currentUser?.Name} ({(String.Equals(_currentUser?.Status.ToString(), "1") ? "Admin" : "Operator")})";
                //EnableMenuCommands(true);
            }
            else
            {
                Application.Exit();
            }
        }

        private void InitializeLocalDatabase()
        {
            try
            {
                using (var localCn = (SqlConnection)_dbConnectionFactory.CreateConnection())
                {
                    // Check if tables already exist, if not, create them
                    var tableExists = localCn.ExecuteScalar<int>(
                        "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Bench'"
                    );

                    if (tableExists > 0)
                    {
                        localCn.Execute(@"
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'MeterType' AND COLUMN_NAME = 'AccP')
                    BEGIN
                        ALTER TABLE MeterType ADD AccP FLOAT NULL;
                        ALTER TABLE MeterType ADD AccQ FLOAT NULL;
                        ALTER TABLE MeterType ADD AccS FLOAT NULL;
                        ALTER TABLE MeterType ADD ChContent NVARCHAR(MAX) NULL;
                    END");
                        return; // Schema already created
                    }

                    string ddl = @"
                CREATE TABLE Bench (
                    BenchName NVARCHAR(64) PRIMARY KEY,
                    Owner NVARCHAR(64) NULL,
                    NumPhase SMALLINT NOT NULL DEFAULT 3,
                    NumPosition SMALLINT NOT NULL DEFAULT 48,
                    SioPortNo SMALLINT NOT NULL DEFAULT 1,
                    SioFormat NVARCHAR(64) NULL,
                    RefStdName NVARCHAR(64) NULL,
                    Comment NVARCHAR(255) NULL,
                    DBRevision SMALLINT NOT NULL DEFAULT 2
                );

                CREATE TABLE Person (
                    PersonID INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(64) NOT NULL,
                    Status SMALLINT NOT NULL DEFAULT 0,
                    Password NVARCHAR(64) NULL,
                    TimeModified DATETIME NULL,
                    Comment NVARCHAR(255) NULL
                );

                CREATE TABLE MeterType (
                    MeterTypeID INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(64) NOT NULL,
                    Manufacturer NVARCHAR(64) NULL,
                    ApprovalNo NVARCHAR(64) NULL,
                    LineType SMALLINT NOT NULL DEFAULT 1,
                    ConnectMode SMALLINT NOT NULL DEFAULT 1,
                    Principal SMALLINT NOT NULL DEFAULT 1,
                    Ub FLOAT NOT NULL DEFAULT 220.0,
                    Ib FLOAT NOT NULL DEFAULT 5.0,
                    Imax FLOAT NOT NULL DEFAULT 60.0,
                    AccP FLOAT NULL,
                    AccQ FLOAT NULL,
                    AccS FLOAT NULL,
                    ChContent NVARCHAR(MAX) NULL,
                    TimeModified DATETIME NULL,
                    Comment NVARCHAR(255) NULL
                );

                CREATE TABLE TestProcedure (
                    ProcedureID INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(64) NOT NULL,
                    TimeModified DATETIME NULL,
                    Revision SMALLINT NOT NULL DEFAULT 1
                );

                CREATE TABLE PStep (
                    ProcedureID INT NOT NULL,
                    PStepNo SMALLINT NOT NULL,
                    Name NVARCHAR(64) NULL,
                    UA NVARCHAR(10) NULL,
                    UB NVARCHAR(10) NULL,
                    UC KEY_FIELD_OPTIONAL NVARCHAR(10) NULL, -- compatibility mapping
                    UA_MAPPED NVARCHAR(10) NULL,
                    UB_MAPPED NVARCHAR(10) NULL,
                    UC_MAPPED NVARCHAR(10) NULL,
                    UA_RAW NVARCHAR(10) NULL,
                    UB_RAW NVARCHAR(10) NULL,
                    UC_RAW NVARCHAR(10) NULL,
                    IA NVARCHAR(10) NULL,
                    IB NVARCHAR(10) NULL,
                    IC NVARCHAR(10) NULL,
                    IsImax SMALLINT NOT NULL DEFAULT 0,
                    PHI NVARCHAR(10) NULL,
                    FREQ NVARCHAR(10) NULL,
                    Waveform SMALLINT NOT NULL DEFAULT 1,
                    PhaseSeq SMALLINT NOT NULL DEFAULT 1,
                    TestTypeID SMALLINT NOT NULL DEFAULT 1,
                    Measurement SMALLINT NOT NULL DEFAULT 1,
                    NumPulses NVARCHAR(10) NULL,
                    ULIMIT NVARCHAR(10) NULL,
                    LLIMIT NVARCHAR(10) NULL,
                    ChannelNo SMALLINT NOT NULL DEFAULT 1,
                    Storing SMALLINT NOT NULL DEFAULT 0,
                    FileIE SMALLINT NOT NULL DEFAULT 0,
                    Duration SMALLINT NOT NULL DEFAULT 0,
                    Timeout NVARCHAR(10) NULL,
                    Finally SMALLINT NOT NULL DEFAULT 0,
                    ACMDS NVARCHAR(MAX) NULL,
                    BCMDS NVARCHAR(MAX) NULL,
                    CCMDS NVARCHAR(MAX) NULL,
                    WithAmp SMALLINT NOT NULL DEFAULT 0,
                    PRIMARY KEY (ProcedureID, PStepNo),
                    FOREIGN KEY (ProcedureID) REFERENCES TestProcedure(ProcedureID) ON DELETE CASCADE
                );

                -- Fix schema mapping to match check constraints
                ALTER TABLE PStep DROP COLUMN UC_MAPPED, UB_MAPPED, UA_MAPPED, UC_RAW, UB_RAW, UA_RAW, KEY_FIELD_OPTIONAL;

                CREATE TABLE Run (
                    RunID INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(64) NOT NULL,
                    TimeRun DATETIME NOT NULL DEFAULT GETDATE(),
                    SupervisorID INT NULL,
                    OperatorID INT NULL,
                    MinTemp REAL NULL,
                    MaxTemp REAL NULL,
                    MinRH REAL NULL,
                    MaxRH REAL NULL,
                    Status SMALLINT NOT NULL DEFAULT 0,
                    Comment NVARCHAR(255) NULL,
                    FOREIGN KEY (SupervisorID) REFERENCES Person(PersonID),
                    FOREIGN KEY (OperatorID) REFERENCES Person(PersonID)
                );

                CREATE TABLE RStep (
                    RunID INT NOT NULL,
                    StepNo SMALLINT NOT NULL,
                    Name NVARCHAR(64) NULL,
                    UA FLOAT NOT NULL DEFAULT 0.0,
                    UB FLOAT NOT NULL DEFAULT 0.0,
                    UC FLOAT NOT NULL DEFAULT 0.0,
                    IA FLOAT NOT NULL DEFAULT 0.0,
                    IB FLOAT NOT NULL DEFAULT 0.0,
                    IC FLOAT NOT NULL DEFAULT 0.0,
                    IsImax SMALLINT NOT NULL DEFAULT 0,
                    PHI FLOAT NOT NULL DEFAULT 0.0,
                    FREQ FLOAT NOT NULL DEFAULT 50.0,
                    Waveform SMALLINT NOT NULL DEFAULT 1,
                    PhaseSeq SMALLINT NOT NULL DEFAULT 1,
                    TestTypeID SMALLINT NOT NULL DEFAULT 1,
                    Measurement SMALLINT NOT NULL DEFAULT 1,
                    NumPulses INT NOT NULL DEFAULT 0,
                    ULIMIT FLOAT NOT NULL DEFAULT 0.0,
                    LLIMIT FLOAT NOT NULL DEFAULT 0.0,
                    ChannelNo SMALLINT NOT NULL DEFAULT 1,
                    Storing SMALLINT NOT NULL DEFAULT 0,
                    FileIE SMALLINT NOT NULL DEFAULT 0,
                    Duration SMALLINT NOT NULL DEFAULT 0,
                    Timeout INT NOT NULL DEFAULT 0,
                    Finally SMALLINT NOT NULL DEFAULT 0,
                    Belonged NVARCHAR(64) NULL,
                    ACMDS NVARCHAR(MAX) NULL,
                    BCMDS NVARCHAR(MAX) NULL,
                    CCMDS NVARCHAR(MAX) NULL,
                    WithAmp SMALLINT NOT NULL DEFAULT 0,
                    BelongedRevision SMALLINT NOT NULL DEFAULT 1,
                    PRIMARY KEY (RunID, StepNo),
                    FOREIGN KEY (RunID) REFERENCES Run(RunID) ON DELETE CASCADE
                );

                CREATE TABLE RMeter (
                    RunID INT NOT NULL,
                    PositionNo SMALLINT NOT NULL,
                    Status SMALLINT NOT NULL DEFAULT 0,
                    MeterName NVARCHAR(64) NULL,
                    OwnerNo NVARCHAR(64) NULL,
                    MSN NVARCHAR(64) NULL,
                    YearOfManufacture SMALLINT NULL,
                    LastApproval NVARCHAR(64) NULL,
                    ContractNo NVARCHAR(64) NULL,
                    ClientName NVARCHAR(64) NULL,
                    ClientNo NVARCHAR(64) NULL,
                    PRIMARY KEY (RunID, PositionNo),
                    FOREIGN KEY (RunID) REFERENCES Run(RunID) ON DELETE CASCADE
                );

                CREATE TABLE RMeterData (
                    RunID INT NOT NULL,
                    MeterName NVARCHAR(64) NOT NULL,
                    LineType SMALLINT NOT NULL DEFAULT 1,
                    ConnectMode SMALLINT NOT NULL DEFAULT 1,
                    Principal SMALLINT NOT NULL DEFAULT 1,
                    Ub FLOAT NOT NULL DEFAULT 220.0,
                    Ib FLOAT NOT NULL DEFAULT 5.0,
                    Imax FLOAT NOT NULL DEFAULT 60.0,
                    ChContent NVARCHAR(255) NULL,
                    PRIMARY KEY (RunID, MeterName),
                    FOREIGN KEY (RunID) REFERENCES Run(RunID) ON DELETE CASCADE
                );

                CREATE TABLE RResult (
                    RunID INT NOT NULL,
                    StepNo SMALLINT NOT NULL,
                    PositionNo SMALLINT NOT NULL,
                    RValue NVARCHAR(64) NULL,
                    PRIMARY KEY (RunID, StepNo, PositionNo),
                    FOREIGN KEY (RunID, StepNo) REFERENCES RStep(RunID, StepNo) ON DELETE CASCADE,
                    FOREIGN KEY (RunID, PositionNo) REFERENCES RMeter(RunID, PositionNo)
                );

                INSERT INTO Bench (BenchName, Owner, NumPhase, NumPosition, SioPortNo, SioFormat, RefStdName, DBRevision)
                VALUES ('Calibration Bench 1', 'Owner', 3, 48, 1, '19200,n,8,2', 'SZ_03A_K6', 2);

                INSERT INTO Person (Name, Status, Password, TimeModified, Comment)
                VALUES ('admin', 1, 'admin', GETDATE(), 'Administrator account');";

                    localCn.Execute(ddl);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MainForm_UpdateMsg(object sender, UpdateEventArgs e)
        {
            if (e.isError) dlmsCommStatusmsh.ForeColor = Color.Red;
            else dlmsCommStatusmsh.ForeColor = Color.Green;
            dlmsCommStatusmsh.Text = e.msg;
            Application.DoEvents();

        }
        private void tsm_Association_Click(object sender, EventArgs e)
        {
            Association frmasso = new Association();
            frmasso.ShowDialog();
        }


        private void SM110frmMain_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            // getUserIndex = StaticVariables.ApplicationUserType.IndexOf(objetyusermgt.LogType);
            // objetyusermgt.LoginTypeIndex = (byte)getUserIndex;
            // DisplayMainStatus();
            // SetUserPermission();
            //SetUserPermissionRejectionList();
        }
        public void DisplayMainStatus()
        {
            try
            {
                dlmsCommStatusmsh.Text = "";
                dlmsCommStatusmsh.Width = (DLMSStas.Width / 6);
                dlmsCommStatusmsh2.Text = "";
                dlmsCommStatusmsh2.Width = (DLMSStas.Width / 7);
                //------------------------------DLMS Mode Settings----------------------
                string ClientSAP = Convert.ToInt32(objappSettings.GetClientSAP(), 10).ToString("X");
                string SerialPort = objappSettings.GetPortName() + ", " + objappSettings.GetDatabits() + ", " + objappSettings.GetParity() + ", " + objappSettings.GetStopBits();
                string dlmscommmode = "";

                if (ClientSAP == "10") dlmscommmode += " PC ";
                //else if (ClientSAP == "20") dlmscommmode += " MR ";
                //else if (ClientSAP == "30") dlmscommmode += " US ";
                else if (ClientSAP == "40") dlmscommmode += " FS ";

                dlmscommmode += "| " + SerialPort;
                //--------------------------------------------------------------------


                string Communication = string.Empty;
                string Company_Profile = string.Empty;
                string filename = AppDomain.CurrentDomain.BaseDirectory + @"\CabconPMP.exe";
                string strbuilton = "Built On: " + File.GetCreationTime(filename).Day.ToString("00") + "/" + File.GetCreationTime(filename).Month.ToString("00") + "/" + File.GetCreationTime(filename).Year.ToString("00");

                string strtemp = "";
                string connectionString = strtemp = obgxml.GetConnectionString();

                if (connectionString.IndexOf("INDELNB") >= 0) connectionString = "Location : Local System";
                //else if (connectionString.IndexOf("INDEL") >= 0) connectionString = "Location : GDC Noida";
                //else if (connectionString.IndexOf("INBDI") >= 0) connectionString = "Location : Baddi Factory";
                //else if (connectionString.IndexOf("INCCU") >= 0) connectionString = "Location : Joka Factory";
                else connectionString = "Location : Others Factory";

                connectionString += " ( " + strtemp.Substring(strtemp.IndexOf('=') + 1, strtemp.IndexOf(';') - strtemp.IndexOf('=') - 1) + " )";

                bool Flg_ComSetting = true;
                if (Flg_ComSetting)
                {
                    Communication = dlmscommmode;

                }
                string Prduct_Version = SystemInfo.ProductVersion();
                string strpath = AppDomain.CurrentDomain.BaseDirectory + "CabconPMP.exe";
                Company_Profile = SystemInfo.CopyRightsDetail();
                lblMainScreenMsg.Text = "Cabcon  Product Management Program Ver. " + Prduct_Version + "\n" + "            " + connectionString;
                Prduct_Version = Application.ProductName.ToString() + " Ver. " + Prduct_Version;
                stsReady.Text = "Association : " + dlmscommmode;
                lblversion.Text = Prduct_Version + " | " + strbuilton;
                lblversion.Text = lblversion.Text;
                lblLoginInfo.Text = "Login Mode : " + objetyusermgt.LogType.ToUpper() + " | " + connectionString;

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Setting Main Form Status Failed !" + "\r\n" + "\r\n" + Ex.ToString(), "Cabcon PMP", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void SetUserPermissionRejectionList()
        {
            try
            {
                ToolStripItem[] ts = new ToolStripItem[] { tsm_rejectlist };
                List<int> permissionGivenIdx = new List<int>();

                switch (getUserIndex)
                {
                    case (int)COMMONENTITY.StaticVariables.userCategory.UserRework:
                    case (int)COMMONENTITY.StaticVariables.userCategory.Useradministrator:
                    case (int)COMMONENTITY.StaticVariables.userCategory.Usersupervisor:
                    case (int)COMMONENTITY.StaticVariables.userCategory.UserPoweradministrator:
                        break;
                    case (int)COMMONENTITY.StaticVariables.userCategory.Uservendor:
                    case (int)COMMONENTITY.StaticVariables.userCategory.Useroperator:
                    case (int)COMMONENTITY.StaticVariables.userCategory.UserValidation:
                    case (int)COMMONENTITY.StaticVariables.userCategory.Userreader:
                        permissionGivenIdx.Add(0);
                        permissionGivenIdx.Add(1);
                        permissionGivenIdx.Add(2);
                        permissionGivenIdx.Add(3);
                        permissionGivenIdx.Add(4);
                        break;
                }
                int displayIdx = 0;
                while (displayIdx < permissionGivenIdx.Count)
                {
                    ts[permissionGivenIdx[displayIdx]].Visible = false;
                    displayIdx++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Setting Main Form Status Failed !" + "\r\n" + "\r\n" + ex.ToString(), "Cabcon PMP", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void SetUserPermission()
        {
            try
            {

                ToolStripMenuItem[] ts = new ToolStripMenuItem[] { tsm_Association, tsm_userManagement, tsm_changePassword, tsm_executionReports, tsm_ServerSettings };
                List<int> permissionGivenIdx = new List<int>();

                switch (getUserIndex)
                {

                    case (int)COMMONENTITY.StaticVariables.userCategory.Uservendor:
                    case (int)COMMONENTITY.StaticVariables.userCategory.Useroperator:
                    case (int)COMMONENTITY.StaticVariables.userCategory.UserRework:
                        permissionGivenIdx.Add(1);
                        permissionGivenIdx.Add(2);
                        permissionGivenIdx.Add(3);
                        permissionGivenIdx.Add(5);
                        permissionGivenIdx.Add(6);
                        permissionGivenIdx.Add(4);
                        permissionGivenIdx.Add(8);
                        permissionGivenIdx.Add(11);
                        break;
                    case (int)COMMONENTITY.StaticVariables.userCategory.Usersupervisor:

                        permissionGivenIdx.Add(1);
                        permissionGivenIdx.Add(2);
                        permissionGivenIdx.Add(8);
                        permissionGivenIdx.Add(11);
                        break;
                    case (int)COMMONENTITY.StaticVariables.userCategory.Userreader:
                        permissionGivenIdx.Add(0);
                        permissionGivenIdx.Add(1);
                        permissionGivenIdx.Add(2);
                        permissionGivenIdx.Add(3);
                        permissionGivenIdx.Add(4);
                        permissionGivenIdx.Add(5);
                        permissionGivenIdx.Add(6);
                        permissionGivenIdx.Add(7);
                        permissionGivenIdx.Add(8);
                        permissionGivenIdx.Add(9);
                        permissionGivenIdx.Add(10);
                        permissionGivenIdx.Add(11);
                        permissionGivenIdx.Add(12);
                        break;
                    case (int)COMMONENTITY.StaticVariables.userCategory.Useradministrator:
                    case (int)COMMONENTITY.StaticVariables.userCategory.UserValidation:
                        permissionGivenIdx.Add(8);
                        //permissionGivenIdx.Add(11);//Server setting
                        break;
                    case (int)COMMONENTITY.StaticVariables.userCategory.UserPoweradministrator:
                        break;
                }
                int displayIdx = 0;
                while (displayIdx < permissionGivenIdx.Count)
                {
                    ts[permissionGivenIdx[displayIdx]].Visible = false;
                    switch (permissionGivenIdx[displayIdx])
                    {
                        case 0:
                            cms_RunProcedure.Visible = false;
                            break;
                        case 1:
                            cms_CreateProcedure.Visible = false;
                            break;
                        case 2:
                            cms_CreateProgram.Visible = false;
                            break;
                        case 3:
                            cms_openProcedure.Visible = false;
                            break;
                        case 4:
                            cms_OpenProgram.Visible = false;
                            break;
                        case 8:
                            ts_ico_Association.Visible = false;
                            break;
                        case 11:
                            ts_ico_report.Visible = false;
                            tss_Report.Visible = false;
                            break;
                        case 12:
                            tsm_ServerSettings.Visible = false;
                            break;

                    }
                    displayIdx++;
                }
            }
            catch (Exception)
            {
            }

        }
        private void ts_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SM110frmMain_Activated(object sender, EventArgs e)
        {
            // DisplayMainStatus();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                string[] formNames = { "frmChooseSaveColumns", "frmRecordHistory", "frmUpdateEntry", "frmHardError" };
                if (formNames.Any(c => frm.Name.Contains(c)))
                    frm.BringToFront();
            }
        }

        private void tsm_createProcedure_Click(object sender, EventArgs e)
        {

            frmProcedure1 objprcreat = new frmProcedure1("", objetyusermgt);
            objprcreat.UpdateMsg += new frmProcedure1.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objprcreat.ShowDialog();
        }

        private void tsm_procedureopen_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Open", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }

        private void runProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Run", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }

        private void tsm_programList_Click(object sender, EventArgs e)
        {
            frmProgramLists objprlist = new frmProgramLists("", objetyusermgt);
            objprlist.ShowDialog();
        }

        private void programListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgramListOpen objprlistop = new frmProgramListOpen(objetyusermgt);
            objprlistop.ShowDialog();
        }


        private void tsm_executionReports_Click(object sender, EventArgs e)
        {
            frmResultsReport objrr = new frmResultsReport();
            objrr.ShowDialog();
        }


        private void toolStripLabel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cms_New.Show(PointToScreen(e.Location));
            }
        }

        private void cms_openProcedure_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Open", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }

        private void cms_OpenProgram_Click(object sender, EventArgs e)
        {
            frmProgramListOpen objprlistop = new frmProgramListOpen(objetyusermgt);
            objprlistop.ShowDialog();
        }

        private void toolStripLabel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cms_Open.Show(PointToScreen(e.Location));
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Run", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProcedure1 objprcreat = new frmProcedure1("", objetyusermgt);
            objprcreat.UpdateMsg += new frmProcedure1.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objprcreat.ShowDialog();
        }

        private void createProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgramLists objprlist = new frmProgramLists("", objetyusermgt);
            objprlist.ShowDialog();
        }

        private void ts_FunctionalTest_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Run", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }


        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

            frmResultsReport objrr = new frmResultsReport();
            objrr.ShowDialog();
        }

        private void ts_Association_Click(object sender, EventArgs e)
        {
            Association frmasso = new Association();
            frmasso.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void RemoveInstances()
        {
            try
            {
                List<string> currPrsName = objsv.ProgramNameList.ToList();
                Process currentappProcess = Process.GetCurrentProcess();
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();
                /*-------------------Dependency process Kill---------------------*/
                foreach (System.Diagnostics.Process proces in prs)
                {
                    if (currPrsName.Contains(proces.ProcessName.ToUpper()))
                    {
                        proces.Refresh();
                        if (!proces.HasExited)
                            proces.Kill();
                    }
                }
                //------------------Main Application Process Kill-----------------*/            
                currentappProcess.Kill();

            }
            catch (Exception)
            {
            }
        }
        private void RemovingTepFiles()
        {
            try
            {
                string[] parmanentFiles = new string[] { "DbConnection" };
                string directorypath = AppDomain.CurrentDomain.BaseDirectory + "Configuration\\";
                string[] filePathList = Directory.GetFiles(directorypath, "*.xml");
                int filepathCounts = 0;
                for (filepathCounts = 0; filepathCounts < filePathList.Length; filepathCounts++)
                {
                    string readfileName = filePathList[filepathCounts].Substring(filePathList[filepathCounts].LastIndexOf("\\") + 1).ToUpperInvariant();
                    if (readfileName.IndexOf(parmanentFiles[0].ToUpperInvariant()) >= 0) continue;
                    File.Delete(filePathList[filepathCounts]);
                }
            }
            catch (Exception)
            {
            }

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            RemovingTepFiles();
            RemoveInstances();

        }

        private void tsm_Import_MeterIDLists_Click(object sender, EventArgs e)
        {
            frmMeterRange objipmid = new frmMeterRange();
            objipmid.ShowDialog();
        }


        private void tsm_Run_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Run", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }

        private void tsm_Import_TestProcedureFile_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Import", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }

        private void tsm_Export_TestProcedureFile_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Export", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmProcedureOpen objpropen = new frmProcedureOpen("Import", objetyusermgt);
            objpropen.UpdateMsg += new frmProcedureOpen.UpdateMainMsgHandler(MainForm_UpdateMsg);
            objpropen.ShowDialog();
        }

        private void ts_ico_ImportID_Click(object sender, EventArgs e)
        {
            frmMeterRange objipmid = new frmMeterRange();
            objipmid.ShowDialog();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagement objum = new frmUserManagement("New", objetyusermgt);
            objum.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagement objum = new frmUserManagement("PWD", objetyusermgt);
            objum.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCabconPMP objabout = new AboutCabconPMP();
            objabout.ShowDialog();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\Configuration\\Cabcon_PMP.chm");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable To open Help File !", "Cabcon PMP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ts_Help_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\Configuration\\Cabcon_PMP.chm");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable To open Help File !", "Cabcon PMP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsm_ServerSettings_Click(object sender, EventArgs e)
        {
            frmServerSettings objserversett = new frmServerSettings(true);
            objserversett.ShowDialog();
        }

        private void tsm_productionStageReport_Click(object sender, EventArgs e)
        {
            frmProductionStausReport objpsr = new frmProductionStausReport();
            objpsr.ShowDialog();
        }

        private void routineTestReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.frmRoutineTestReport objroutinetest = new CabconPMP.Report.frmRoutineTestReport(objetyusermgt);
            objroutinetest.ShowDialog();
        }

        private void tsm_missingMeterReport_Click(object sender, EventArgs e)
        {
            frmMissingMeterReport objmissmeterrpt = new frmMissingMeterReport();
            objmissmeterrpt.ShowDialog();
        }

        private void tsm_parametersWiseReport_Click(object sender, EventArgs e)
        {
            frmReportTestWise objrtw = new frmReportTestWise();
            objrtw.ShowDialog();
        }

        private void tsm_rutineTestReportFileFormat_Click(object sender, EventArgs e)
        {
            frmImportRTRFormat objrtr = new frmImportRTRFormat();
            objrtr.ShowDialog();

        }

        private void backupDataReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupDataResultsReport objbdr = new frmBackupDataResultsReport();
            objbdr.ShowDialog();

        }

        private void toolStripLabelSync_Click(object sender, EventArgs e)
        {
            FrmSyncLogList frmobj = new FrmSyncLogList();
            if (!frmobj.IsDisposed)
                frmobj.ShowDialog();
            //PMPExSyncService service = new PMPExSyncService();
            //service.Do_Work(new object());
        }


        private void toolStripLabelReject_Click(object sender, EventArgs e)
        {
            frmErrorList.ShowInstance(objetyusermgt);
            //frmErrorList objfrmErrList = frmErrorList.GetInstance(objetyusermgt);
            //objfrmErrList.Show();
            //objfrmErrList.Activate();
        }

        private void toolStripLabelError_Click(object sender, EventArgs e)
        {
            CabconPMPREJECTIONTOOL.AccessPassword frmobj = new CabconPMPREJECTIONTOOL.AccessPassword(objetyusermgt);
            frmobj.ShowDialog();
        }

        private void tsm_newrejection_Click(object sender, EventArgs e)
        {
            frmUpdateEntry objfrm = new frmUpdateEntry(objetyusermgt);
            objfrm.ShowDialog();
        }

        private void tsm_rejectlist_Click(object sender, EventArgs e)
        {
            toolStripLabelReject_Click(new object(), EventArgs.Empty);
        }

        private void rejectionEntryCompactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripLabelError_Click(new object(), EventArgs.Empty);
        }

        private void pcbBackgroundImage_Click(object sender, EventArgs e)
        {

        }
        List<Meter> m_meterlist = new List<Meter>();

        private void toolRetry_Click(object sender, EventArgs e)
        {
            ConnectedMeterCollector meterCollector = new ConnectedMeterCollector();
            m_meterlist = meterCollector.CollectConnectedMeters();

            if (m_meterlist == null || m_meterlist.Count == 0)
            {
                MessageBox.Show("Attention\n\nNo connected meters were found on the configured COM ports.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void calibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var objfrmConfig = new frmConfiguration())
                {
                    objfrmConfig.UpdateMsg += MainForm_UpdateMsg;
                    objfrmConfig.StartPosition = FormStartPosition.CenterParent;
                    objfrmConfig.ShowDialog(this); // modal, owned by this form
                    objfrmConfig.UpdateMsg -= MainForm_UpdateMsg;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open configuration: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calibrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTestRun(
                _dbConnectionFactory,
                _runRepository,
                _procedureRepository,
                _meterTypeRepository,
                _benchRepository,
                _currentUser
            );
            frm.Show();
        }

        private void addProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmProcedure(_procedureRepository);
            frm.Show();
        }

        private void meterTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMeterType(_meterTypeRepository);
            frm.Show();
        }
    }
}
