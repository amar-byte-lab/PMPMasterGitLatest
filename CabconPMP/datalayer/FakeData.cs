using System;
using System.Collections.Generic;

namespace CabconPMP.datalayer
{
    public class FakeData
    {
        public List<string> procedureNames = new List<string>()
            {
                "Procedure1",
                "Procedure2",
                "Procedure3",
                "Procedure4",
                "Procedure5"
            };
        public List<PortInfo> portList = new List<PortInfo>
                {
                    new PortInfo
                    {
                        Position = 1,
                        PortName = "COM1",
                        PCBAId = "PCBA001"
                    },
                    new PortInfo
                    {
                        Position = 2,
                        PortName = "COM2",
                        PCBAId = "PCBA002"
                    },
                    new PortInfo
                    {
                        Position = 3,
                        PortName = "COM3",
                        PCBAId = "PCBA003"
                    },
                    new PortInfo
                    {
                        Position = 4,
                        PortName = "COM4",
                        PCBAId = "PCBA004"
                    }
                };
        public positionResponse Procedure1()
        {
            return new positionResponse()
            {
                Result = "Response_Method1",
                Status = "Pass"
            };
        }

        public positionResponse Procedure2()
        {
            return new positionResponse()
            {
                Result = "Response_Method2",
                Status = "Pass"
            };
        }

        public positionResponse Procedure3()
        {
            return new positionResponse()
            {
                Result = "Response_Method3",
                Status = "Pass"
            };
        }

        public positionResponse Procedure4()
        {
            try
            {
                throw new Exception("Test Failure");
            }
            catch (Exception ex)
            {
                return new positionResponse()
                {
                    Result = "Response_Method4",
                    Status = "Fail"
                };
            }
        }

        public positionResponse Procedure5()
        {
            try
            {
                throw new Exception("Test Failure");
            }
            catch (Exception ex)
            {
                return new positionResponse()
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
    public string Result { get; set; }
    public string Status { get; set; }
}
public class ProcedureInfo
{
    public string Name { get; set; }
    public Func<positionResponse> Method { get; set; }
}