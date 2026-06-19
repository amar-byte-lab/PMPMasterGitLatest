using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CabconPMP.datalayer
{
    public class FakeData
    {
        public List<ProcedureInfo> procedureNames = new List<ProcedureInfo>
                {
                    new ProcedureInfo { Index = 1, Name = "Procedure1" },
                    new ProcedureInfo { Index = 2, Name = "Procedure2" },
                    new ProcedureInfo { Index = 3, Name = "Procedure3" },
                    new ProcedureInfo { Index = 4, Name = "Procedure4" },
                    new ProcedureInfo { Index = 5, Name = "Procedure5" }
                };


        public List<PortInfo> portList = new List<PortInfo>
                {
                    new PortInfo
                    {
                        Position = 1,
                        PortName = "COM1",
                        PCBAId = "PCBA001"
                    },
                    //new PortInfo
                    //{
                    //    Position = 2,
                    //    PortName = "COM2",
                    //    PCBAId = "PCBA002"
                    //},
                    //new PortInfo
                    //{
                    //    Position = 3,
                    //    PortName = "COM3",
                    //    PCBAId = "PCBA003"
                    //},
                    //new PortInfo
                    //{
                    //    Position = 4,
                    //    PortName = "COM4",
                    //    PCBAId = "PCBA004"
                    //}
                };

        // All procedures now accept a CancellationToken and honor it
        public async Task<positionResponse> Procedure1(CancellationToken ct)
        {
            // allow cancellation during simulated work
            await Task.Delay(10000, ct);
            ct.ThrowIfCancellationRequested();

            return new positionResponse()
            {
                Result = "Response_Method1",
                Status = "Pass"
            };
        }

        public async Task<positionResponse> Procedure2(CancellationToken ct)
        {
            await Task.Delay(10000, ct);
            ct.ThrowIfCancellationRequested();

            return new positionResponse()
            {
                Result = "Response_Method2",
                Status = "Pass"
            };
        }

        public async Task<positionResponse> Procedure3(CancellationToken ct)
        {
            await Task.Delay(10000, ct);
            ct.ThrowIfCancellationRequested();

            return new positionResponse()
            {
                Result = "Response_Method3",
                Status = "Pass"
            };
        }

        public async Task<positionResponse> Procedure4(CancellationToken ct)
        {
            try
            {
                await Task.Delay(10000, ct);
                ct.ThrowIfCancellationRequested();

                throw new Exception("Test Failure");
            }
            catch (OperationCanceledException)
            {
                // propagate cancellation
                throw;
            }
            catch (Exception)
            {
                return new positionResponse()
                {
                    Result = "Response_Method4",
                    Status = "Fail"
                };
            }
        }

        public async Task<positionResponse> Procedure5(CancellationToken ct)
        {
            try
            {
                await Task.Delay(10000, ct);
                ct.ThrowIfCancellationRequested();

                throw new Exception("Test Failure");
            }
            catch (OperationCanceledException)
            {
                // propagate cancellation
                throw;
            }
            catch (Exception)
            {
               return new positionResponse
                {
                    Result = "Response_Method5",
                    Status = "Fail"
                };
            }
        }
    }
}

public class invokedProcedure
{
    public int SlNo { get; set; }
    public string ProcedureName { get; set; }
}
public class PortInfo
{
    public int Position { get; set; }
    public string PortName { get; set; }
    public string PCBAId { get; set; }
}
public class ProcedureResult
{
    public int Position { get; set; }
    public string ProcedureName { get; set; }
    public string Response { get; set; }
    public string Status { get; set; }
}
public class positionResponse
{
    public int Position { get; set; }
    public string Status { get; set; }
    public string Result { get; set; }
}
public class ProcedureInfo
{
    public int Index { get; set; }
    public string Name { get; set; }
    // updated method signature to accept CancellationToken
    public Func<CancellationToken, Task<positionResponse>> Method { get; set; }
}

public enum ExecutionMode
{
    AllSteps,
    SingleStep
}