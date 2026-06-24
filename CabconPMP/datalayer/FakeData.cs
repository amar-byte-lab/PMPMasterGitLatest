using ApplicationInterface;
using COMMONENTITY;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace CabconPMP.datalayer
{
    public class FakeData
    {
        // All procedures now return a generic positionResponse<TPayload>.
        // For these fake procedures the payload is a simple string.
        public async Task<positionResponse<string>> Procedure1(CancellationToken ct)
        {
            // allow cancellation during simulated work
            await Task.Delay(10000, ct);
            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = "Response_Method1",
                Status = "Pass"
            };
        }

        public async Task<positionResponse<string>> ReadPCBAId(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm)
        {

            string rtc = ccm.ReadPCBAID();
            var testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;
            if (rtc.IndexOf(StaticVariables.ERRORPreFix) < 0) { testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Pass; }
            else testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;
            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = rtc,
                Status = testExecutionStatus == (int)StaticVariables.ExecutionReurnStatus.Pass ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> ReadMeterRtc(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm)
        {

            string rtc = ccm.ReadPCBAID();
            var testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;
            if (rtc.IndexOf(StaticVariables.ERRORPreFix) < 0) { testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Pass; }
            else testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;
            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = rtc,
                Status = testExecutionStatus == (int)StaticVariables.ExecutionReurnStatus.Pass ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> ReadEnergy(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm)
        {
            int testExecutionStatus = -1;
            string readenergyResponse = ccm.VerifyEnergy("", "0", "5000");
            if (readenergyResponse.IndexOf(StaticVariables.ERRORPreFix) < 0) testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Pass;
            else testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = readenergyResponse,
                Status = testExecutionStatus == (int)StaticVariables.ExecutionReurnStatus.Pass ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> Calibrate(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm)
        {
            bool calibrationResult = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute, 
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS, 
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID, 
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType, 
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength, 
                GetCaliBytes("+00.00", 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_PhaseEnergy), 
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = calibrationResult.ToString(),
                Status = calibrationResult ? "Pass" : "Fail"
            };
        }

        public static List<byte> GetCaliBytes(string txtbx, byte dlmsDataType, byte commandIdetifier)
        {
            List<byte> databyte = new List<byte>();
            string calidatabyte;
            int dataTypeLen = 4;
            if (txtbx == null) calidatabyte = "00";
            else calidatabyte = txtbx.Trim().Replace(".", "");
            if (calidatabyte.Length <= 0) calidatabyte = "0";
            string wholeDataByte = string.Format("{0:x}", Convert.ToInt32(calidatabyte));

            if (dlmsDataType == 0x12) dataTypeLen = 4;
            else if (dlmsDataType == 0x6) dataTypeLen = 8;
            else dataTypeLen = 4;
            wholeDataByte = wholeDataByte.PadLeft(dataTypeLen, '0');
            databyte.Add(0x0F);//Type of Identifier
            databyte.Add(commandIdetifier);
            databyte.Add(dlmsDataType);
            int bytecnt = 0;
            while (bytecnt < wholeDataByte.Length)
            {
                databyte.Add(Convert.ToByte(wholeDataByte.Substring(bytecnt, 2), 16));
                bytecnt += 2;
            }
            return databyte;
        }

        public async Task<positionResponse<string>> MeterReset(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm)
        {
            bool mtrReset  = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetResetCaliBytes(DLMSDataStracture.CalibrationDataStracture.CalibrationDataByte_ResetAllCalibration,
                    0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_ResetAll),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();
            return new positionResponse<string>()
            {
                Payload = mtrReset.ToString(),
                Status = mtrReset ? "Pass" : "Fail"
            };
        }

        private List<byte> GetResetCaliBytes(byte resetsByte, byte dlmsDataType, byte commandIdetifier)
        {
            List<byte> databyte = new List<byte>();
            string wholeDataByte = resetsByte.ToString("00");
            int dataTypeLen = 4;
            if (dlmsDataType == 0x12) dataTypeLen = 4;
            else if (dlmsDataType == 0x6) dataTypeLen = 8;
            else dataTypeLen = 4;
            wholeDataByte = wholeDataByte.PadLeft(dataTypeLen, '0');
            databyte.Add(0x0F);//Type of Identifier
            databyte.Add(commandIdetifier);
            databyte.Add(dlmsDataType);
            int bytecnt = 0;
            while (bytecnt < wholeDataByte.Length)
            {
                databyte.Add(Convert.ToByte(wholeDataByte.Substring(bytecnt, 2), 16));
                bytecnt += 2;
            }
            return databyte;
        }

        public async Task<positionResponse<string>> Procedure3(CancellationToken ct)
        {
            await Task.Delay(10000, ct);
            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = "Response_Method3",
                Status = "Pass"
            };
        }

        public async Task<positionResponse<string>> Procedure4(CancellationToken ct)
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
                return new positionResponse<string>()
                {
                    Payload = "Response_Method4",
                    Status = "Fail"
                };
            }
        }

        public async Task<positionResponse<string>> Procedure5(CancellationToken ct)
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
               return new positionResponse<string>
                {
                    Payload = "Response_Method5",
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

// Generic position response — payload can grow/change in future
public class positionResponse<TPayload>
{
    public int Position { get; set; }
    public string Status { get; set; }
    public TPayload Payload { get; set; }
}

public enum ExecutionMode
{
    AllSteps,
    SingleStep
}