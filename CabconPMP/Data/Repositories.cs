using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CabconPMP.Models;
using Dapper;

namespace CabconPMP.Data
{
    public class BenchRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public BenchRepository(IDbConnectionFactory factory) => _dbConnectionFactory = factory;

        public async Task<Bench> GetBenchAsync()
        {
            using (var db = _dbConnectionFactory.CreateConnection())
            {
                return (await db.QueryAsync<Bench>("SELECT * FROM Bench")).FirstOrDefault();
            }
        }

        public async Task SaveBenchAsync(Bench bench)
        {
            using (var db = _dbConnectionFactory.CreateConnection())
            {
                string sql = @"
                UPDATE Bench 
                SET Owner = @Owner, NumPhase = @NumPhase, NumPosition = @NumPosition, 
                    SioPortNo = @SioPortNo, SioFormat = @SioFormat, RefStdName = @RefStdName, 
                    Comment = @Comment, DBRevision = @DBRevision
                WHERE BenchName = @BenchName;
                
                IF @@ROWCOUNT = 0
                BEGIN
                    INSERT INTO Bench (BenchName, Owner, NumPhase, NumPosition, SioPortNo, SioFormat, RefStdName, Comment, DBRevision)
                    VALUES (@BenchName, @Owner, @NumPhase, @NumPosition, @SioPortNo, @SioFormat, @RefStdName, @Comment, @DBRevision);
                END;";
                await db.ExecuteAsync(sql, bench);
            }
        }
    }

    public class PersonRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public PersonRepository(IDbConnectionFactory factory) => _dbConnectionFactory = factory;

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            using (var db = _dbConnectionFactory.CreateConnection())    
            {
                return await db.QueryAsync<Person>("SELECT * FROM Person");
            }
        }

        public async Task<Person> ValidateUserAsync(string name, string password)
        {
            using( var db = _dbConnectionFactory.CreateConnection())
            {
                return (await db.QueryAsync<Person>(
                    "SELECT * FROM Person WHERE Name = @Name AND Password = @Password",
                    new { Name = name, Password = password }
                )).FirstOrDefault();
            }
        }
    }

    public class MeterTypeRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public MeterTypeRepository(IDbConnectionFactory factory) => _dbConnectionFactory = factory;

        public async Task<IEnumerable<MeterType>> GetAllAsync()
        {
            using (var db = _dbConnectionFactory.CreateConnection())    
            {
                return await db.QueryAsync<MeterType>("SELECT * FROM MeterType");
            }
        }

        public async Task<MeterType> GetByIdAsync(int id)
        {
            using (var db = _dbConnectionFactory.CreateConnection())
            {
                return (await db.QueryAsync<MeterType>("SELECT * FROM MeterType WHERE MeterTypeID = @Id", new { Id = id })).FirstOrDefault();
            }
        }

        public async Task<int> InsertAsync(MeterType meterType)
        {
            using (var db = _dbConnectionFactory.CreateConnection())    
            {
                string sql = @"
                INSERT INTO MeterType (Name, Manufacturer, ApprovalNo, LineType, ConnectMode, Principal, Ub, Ib, Imax, AccP, AccQ, AccS, ChContent, TimeModified, Comment)
                OUTPUT INSERTED.MeterTypeID
                VALUES (@Name, @Manufacturer, @ApprovalNo, @LineType, @ConnectMode, @Principal, @Ub, @Ib, @Imax, @AccP, @AccQ, @AccS, @ChContent, GETDATE(), @Comment);";
                return await db.QuerySingleAsync<int>(sql, meterType);
            }
        }

        public async Task UpdateAsync(MeterType meterType)
        {
            using (var db = _dbConnectionFactory.CreateConnection())
            {
                string sql = @" 
                UPDATE MeterType
                SET Name = @Name, Manufacturer = @Manufacturer, ApprovalNo = @ApprovalNo, LineType = @LineType,
                    ConnectMode = @ConnectMode, Principal = @Principal, Ub = @Ub, Ib = @Ib, Imax = @Imax,
                    AccP = @AccP, AccQ = @AccQ, AccS = @AccS, ChContent = @ChContent,
                    TimeModified = GETDATE(), Comment = @Comment
                WHERE MeterTypeID = @MeterTypeID;";
                await db.ExecuteAsync(sql, meterType);
            }
        }

        public class ProcedureRepository
        {
            private readonly IDbConnectionFactory _dbConnectionFactory;
            public ProcedureRepository(IDbConnectionFactory factory) => _dbConnectionFactory = factory;

            public async Task<IEnumerable<TestProcedure>> GetAllAsync()
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                    return await db.QueryAsync<TestProcedure>("SELECT * FROM TestProcedure");
            }

            public async Task<TestProcedure> GetByIdAsync(int procedureId)
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                {
                    const string sql = @"
                    SELECT p.*, s.* 
                    FROM TestProcedure p
                    LEFT JOIN PStep s ON p.ProcedureID = s.ProcedureID
                    WHERE p.ProcedureID = @Id
                ORDER BY s.PStepNo;";

                    var dict = new Dictionary<int, TestProcedure>();
                    await db.QueryAsync<TestProcedure, PStep, TestProcedure>(sql, (proc, step) =>
                    {
                        if (!dict.TryGetValue(proc.ProcedureID, out var entry))
                        {
                            entry = proc;
                            entry.Steps = new List<PStep>();
                            dict.Add(entry.ProcedureID, entry);
                        }
                        if (step != null)
                        {
                            entry.Steps.Add(step);
                        }
                        return entry;
                    }, new { Id = procedureId }, splitOn: "ProcedureID");

                    return dict.Values.FirstOrDefault();
                }
            }

            public async Task<int> SaveAsync(TestProcedure procedure)
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                using (var transaction = db.BeginTransaction())
                    try
                    {
                        if (procedure.ProcedureID == 0)
                        {
                            string sql = @"
                        INSERT INTO TestProcedure (Name, TimeModified, Revision)
                        OUTPUT INSERTED.ProcedureID
                        VALUES (@Name, GETDATE(), @Revision);";
                            procedure.ProcedureID = await db.QuerySingleAsync<int>(sql, procedure, transaction);
                        }
                        else
                        {
                            string sql = @"
                        UPDATE TestProcedure 
                        SET Name = @Name, TimeModified = GETDATE(), Revision = @Revision 
                        WHERE ProcedureID = @ProcedureID;
                        DELETE FROM PStep WHERE ProcedureID = @ProcedureID;";
                            await db.ExecuteAsync(sql, procedure, transaction);
                        }

                        string stepSql = @"
                    INSERT INTO PStep (ProcedureID, PStepNo, Name, UA, UB, UC, IA, IB, IC, IsImax, PHI, FREQ, 
                                      Waveform, PhaseSeq, TestTypeID, Measurement, NumPulses, ULIMIT, LLIMIT, 
                                      ChannelNo, Storing, FileIE, Duration, Timeout, Finally, ACMDS, BCMDS, CCMDS, WithAmp)
                    VALUES (@ProcedureID, @PStepNo, @Name, @UA, @UB, @UC, @IA, @IB, @IC, @IsImax, @PHI, @FREQ, 
                            @Waveform, @PhaseSeq, @TestTypeID, @Measurement, @NumPulses, @ULIMIT, @LLIMIT, 
                            @ChannelNo, @Storing, @FileIE, @Duration, @Timeout, @Finally, @ACMDS, @BCMDS, @CCMDS, @WithAmp);";

                        foreach (var step in procedure.Steps)
                        {
                            step.ProcedureID = procedure.ProcedureID;
                            await db.ExecuteAsync(stepSql, step, transaction);
                        }

                        transaction.Commit();
                        return procedure.ProcedureID;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
            }
        }

        public class RunRepository
        {
            private readonly IDbConnectionFactory _dbConnectionFactory;
            public RunRepository(IDbConnectionFactory factory) => _dbConnectionFactory = factory;

            public async Task<IEnumerable<Run>> GetAllAsync()
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                {
                    return await db.QueryAsync<Run>("SELECT * FROM Run ORDER BY TimeRun DESC");
                }
            }

            public async Task<IEnumerable<RMeter>> GetMetersForRunAsync(int runId)
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                {
                    return await db.QueryAsync<RMeter>("SELECT * FROM RMeter WHERE RunID = @RunID", new { RunID = runId });
                }
            }

            public async Task<IEnumerable<RStep>> GetStepsForRunAsync(int runId)
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                {
                    return await db.QueryAsync<RStep>("SELECT * FROM RStep WHERE RunID = @RunID ORDER BY StepNo", new { RunID = runId });
                }
            }

            public async Task<int> InsertRunAsync(Run run, List<RStep> steps, List<RMeter> meters, List<RMeterData> meterData)
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        string runSql = @"
                        INSERT INTO Run (Name, TimeRun, SupervisorID, OperatorID, MinTemp, MaxTemp, MinRH, MaxRH, Status, Comment)
                    OUTPUT INSERTED.RunID
                    VALUES (@Name, @TimeRun, @SupervisorID, @OperatorID, @MinTemp, @MaxTemp, @MinRH, @MaxRH, @Status, @Comment);";

                        run.RunID = await db.QuerySingleAsync<int>(runSql, run, transaction);

                        string stepSql = @"
                    INSERT INTO RStep (RunID, StepNo, Name, UA, UB, UC, IA, IB, IC, IsImax, PHI, FREQ, 
                                      Waveform, PhaseSeq, TestTypeID, Measurement, NumPulses, ULIMIT, LLIMIT, 
                                      ChannelNo, Storing, FileIE, Duration, Timeout, Finally, Belonged, ACMDS, BCMDS, CCMDS, WithAmp, BelongedRevision)
                    VALUES (@RunID, @StepNo, @Name, @UA, @UB, @UC, @IA, @IB, @IC, @IsImax, @PHI, @FREQ, 
                            @Waveform, @PhaseSeq, @TestTypeID, @Measurement, @NumPulses, @ULIMIT, @LLIMIT, 
                            @ChannelNo, @Storing, @FileIE, @Duration, @Timeout, @Finally, @Belonged, @ACMDS, @BCMDS, @CCMDS, @WithAmp, @BelongedRevision);";
                        foreach (var step in steps)
                        {
                            step.RunID = run.RunID;
                            await db.ExecuteAsync(stepSql, step, transaction);
                        }

                        string meterSql = @"
                    INSERT INTO RMeter (RunID, PositionNo, Status, MeterName, OwnerNo, MSN, YearOfManufacture, LastApproval, ContractNo, ClientName, ClientNo)
                    VALUES (@RunID, @PositionNo, @Status, @MeterName, @OwnerNo, @MSN, @YearOfManufacture, @LastApproval, @ContractNo, @ClientName, @ClientNo);";
                        foreach (var mtr in meters)
                        {
                            mtr.RunID = run.RunID;
                            await db.ExecuteAsync(meterSql, mtr, transaction);
                        }

                        string mtrDataSql = @"
                    INSERT INTO RMeterData (RunID, MeterName, LineType, ConnectMode, Principal, Ub, Ib, Imax, ChContent)
                    VALUES (@RunID, @MeterName, @LineType, @ConnectMode, @Principal, @Ub, @Ib, @Imax, @ChContent);";
                        foreach (var data in meterData)
                        {
                            data.RunID = run.RunID;
                            await db.ExecuteAsync(mtrDataSql, data, transaction);
                        }

                        transaction.Commit();
                        return run.RunID;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            public async Task SaveResultsAsync(int runId, List<RResult> results)
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        string delSql = "DELETE FROM RResult WHERE RunID = @RunID;";
                        await db.ExecuteAsync(delSql, new { RunID = runId }, transaction);

                        string insSql = @"
                    INSERT INTO RResult (RunID, StepNo, PositionNo, RValue)
                    VALUES (@RunID, @StepNo, @PositionNo, @RValue);";

                        foreach (var res in results)
                        {
                            res.RunID = runId;
                            await db.ExecuteAsync(insSql, res, transaction);
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            public async Task<IEnumerable<RResult>> GetResultsForRunAsync(int runId)
            {
                using (var db = _dbConnectionFactory.CreateConnection())
                    return await db.QueryAsync<RResult>("SELECT * FROM RResult WHERE RunID = @RunID", new { RunID = runId });
            }
        }
    }
}
