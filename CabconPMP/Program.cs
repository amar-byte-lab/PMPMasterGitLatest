using CabconPMP.Data;
using COMMONENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static CabconPMP.Data.MeterTypeRepository;

namespace CabconPMP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var dbFactory = new SqlConnectionFactory();

            // Instantiate repositories
            var benchRepo = new BenchRepository(dbFactory);
            var personRepo = new PersonRepository(dbFactory);
            var meterTypeRepo = new MeterTypeRepository(dbFactory);
            var procedureRepo = new ProcedureRepository(dbFactory);
            var runRepo = new RunRepository(dbFactory);
            EntityUserManagement objetyusermgt = new EntityUserManagement();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(
                objetyusermgt,
                    dbFactory,
                personRepo,
                meterTypeRepo,
                procedureRepo,
                runRepo,
                benchRepo
                ));
        }
    }
}
