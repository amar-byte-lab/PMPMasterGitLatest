using System;
using System.Collections.Generic;

namespace CabconPMP.Models
{
    public class Bench
    {
        public string BenchName { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public short NumPhase { get; set; } = 3;
        public short NumPosition { get; set; } = 48;
        public short SioPortNo { get; set; } = 1;
        public string SioFormat { get; set; } = string.Empty;
        public string RefStdName { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public short DBRevision { get; set; } = 2;
    }

    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; } = string.Empty;
        public short Status { get; set; }
        public string Password { get; set; } = string.Empty;
        public DateTime? TimeModified { get; set; }
        public string Comment { get; set; } = string.Empty;
    }

    public class MeterType
    {
        public int MeterTypeID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string ApprovalNo { get; set; } = string.Empty;
        public short LineType { get; set; } = 1;
        public short ConnectMode { get; set; } = 1;
        public short Principal { get; set; } = 1;
        public double Ub { get; set; } = 220.0;
        public double Ib { get; set; } = 5.0;
        public double Imax { get; set; } = 60.0;
        public double? AccP { get; set; }
        public double? AccQ { get; set; }
        public double? AccS { get; set; }
        public string ChContent { get; set; } = string.Empty;
        public DateTime? TimeModified { get; set; }
        public string Comment { get; set; } = string.Empty;
    }

    public class TestProcedure
    {
        public int ProcedureID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? TimeModified { get; set; }
        public short Revision { get; set; } = 1;
        public List<PStep> Steps { get; set; } = new List<PStep>();
    }

    public class PStep
    {
        public int ProcedureID { get; set; }
        public short PStepNo { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UA { get; set; } = string.Empty;
        public string UB { get; set; } = string.Empty;
        public string UC { get; set; } = string.Empty;
        public string IA { get; set; } = string.Empty;
        public string IB { get; set; } = string.Empty;
        public string IC { get; set; } = string.Empty;
        public short IsImax { get; set; }
        public string PHI { get; set; } = string.Empty;
        public string FREQ { get; set; } = string.Empty;
        public short Waveform { get; set; } = 1;
        public short PhaseSeq { get; set; } = 1;
        public short TestTypeID { get; set; } = 1;
        public short Measurement { get; set; } = 1;
        public string NumPulses { get; set; } = string.Empty;
        public string ULIMIT { get; set; } = string.Empty;
        public string LLIMIT { get; set; } = string.Empty;
        public short ChannelNo { get; set; } = 1;
        public short Storing { get; set; }
        public short FileIE { get; set; }
        public short Duration { get; set; }
        public string Timeout { get; set; } = string.Empty;
        public short Finally { get; set; }
        public string ACMDS { get; set; } = string.Empty;
        public string BCMDS { get; set; } = string.Empty;
        public string CCMDS { get; set; } = string.Empty;
        public short WithAmp { get; set; }
    }

    public class Run
    {
        public string TestSequence { get; set; }
        public int RunID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime TimeRun { get; set; } = DateTime.Now;
        public int? SupervisorID { get; set; }
        public int? OperatorID { get; set; }
        public float? MinTemp { get; set; }
        public float? MaxTemp { get; set; }
        public float? MinRH { get; set; }
        public float? MaxRH { get; set; }
        public short Status { get; set; }
        public string Comment { get; set; } = string.Empty;
    }

    public class RStep
    {
        public int RunID { get; set; }
        public short StepNo { get; set; }
        public string Name { get; set; } = string.Empty;
        public double UA { get; set; }
        public double UB { get; set; }
        public double UC { get; set; }
        public double IA { get; set; }
        public double IB { get; set; }
        public double IC { get; set; }
        public short IsImax { get; set; }
        public double PHI { get; set; }
        public double FREQ { get; set; } = 50.0;
        public short Waveform { get; set; } = 1;
        public short PhaseSeq { get; set; } = 1;
        public short TestTypeID { get; set; } = 1;
        public short Measurement { get; set; } = 1;
        public int NumPulses { get; set; }
        public double ULIMIT { get; set; }
        public double LLIMIT { get; set; }
        public short ChannelNo { get; set; } = 1;
        public short Storing { get; set; }
        public short FileIE { get; set; }
        public short Duration { get; set; }
        public int Timeout { get; set; }
        public short Finally { get; set; }
        public string Belonged { get; set; } = string.Empty;
        public string ACMDS { get; set; } = string.Empty;
        public string BCMDS { get; set; } = string.Empty;
        public string CCMDS { get; set; } = string.Empty;
        public short WithAmp { get; set; }
        public short BelongedRevision { get; set; } = 1;
    }

    public class RMeter
    {
        public int RunID { get; set; }
        public short PositionNo { get; set; }
        public short Status { get; set; }
        public string MeterName { get; set; } = string.Empty;
        public string OwnerNo { get; set; } = string.Empty;
        public string MSN { get; set; } = string.Empty;
        public short? YearOfManufacture { get; set; }
        public string LastApproval { get; set; } = string.Empty;
        public string ContractNo { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public string ClientNo { get; set; } = string.Empty;
    }

    public class RMeterData
    {
        public int RunID { get; set; }
        public string MeterName { get; set; } = string.Empty;
        public short LineType { get; set; } = 1;
        public short ConnectMode { get; set; } = 1;
        public short Principal { get; set; } = 1;
        public double Ub { get; set; } = 220.0;
        public double Ib { get; set; } = 5.0;
        public double Imax { get; set; } = 60.0;
        public string ChContent { get; set; } = string.Empty;
    }

    public class RResult
    {
        public int RunID { get; set; }
        public short StepNo { get; set; }
        public short PositionNo { get; set; }
        public string RValue { get; set; } = string.Empty;
    }
}
