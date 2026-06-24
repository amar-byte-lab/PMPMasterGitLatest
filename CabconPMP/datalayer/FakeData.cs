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
                };
        LayerInterface objLI = new LayerInterface();

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

        public string ReadMeterPcbaId(LayerInterface layerInterface)
        {
            try
            {
                byte[] pcbaObis = DLMSDataStracture.PCBAIDDataStracture.PCBAIDOBIS;
                byte classCode = DLMSDataStracture.PCBAIDDataStracture.PCBAIDClassID;
                byte attributeId = DLMSDataStracture.PCBAIDDataStracture.PCBAIDValueAttribute;

                int readResponse = layerInterface.ReadDataCommand(pcbaObis, classCode, attributeId);
                if (readResponse != (int)LayerInterface.ProgrammingCode.Success)
                {
                    return string.Empty;
                }

                string[] pcbaData = DLMSDataStracture.DLMSDataFormator(
                    GlobalObjects.objSerialComm.ReceiveBuffer,
                    18,
                    true);

                if (pcbaData != null && pcbaData.Length > 0 && !string.IsNullOrWhiteSpace(pcbaData[0]))
                {
                    return pcbaData[0];
                }

                return BitConverter.ToString(GlobalObjects.objSerialComm.ReceiveBuffer).Replace("-", string.Empty);
            }
            catch
            {
                return string.Empty;
            }
        }

        private static string ReadMeterRtc(LayerInterface layerInterface)
        {
            try
            {
                byte[] meterRtcObis = DLMSDataStracture.MeterRTCDataStracture.MeterRTCOBIS;
                byte classCode = DLMSDataStracture.MeterRTCDataStracture.MeterRTCClassID;
                byte attributeId = DLMSDataStracture.MeterRTCDataStracture.MeterRTCValueAttribute;

                int readResponse = layerInterface.ReadDataCommand(meterRtcObis, classCode, attributeId);
                if (readResponse != (int)LayerInterface.ProgrammingCode.Success)
                {
                    return string.Empty;
                }

                string[] rtcData = DLMSDataStracture.DLMSDataFormator(
                    GlobalObjects.objSerialComm.ReceiveBuffer,
                    18,
                    false);

                if (rtcData != null && rtcData.Length > 0 && !string.IsNullOrWhiteSpace(rtcData[0]))
                {
                    return rtcData[0];
                }

                return BitConverter.ToString(GlobalObjects.objSerialComm.ReceiveBuffer).Replace("-", string.Empty);
            }
            catch
            {
                return string.Empty;
            }
        }

        public async Task<positionResponse<string>> ReadMeterRtc(CancellationToken ct, LayerInterface layer)
        {

            string rtc = ReadMeterRtc(layer);
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

        public async Task<positionResponse<string>> ReadPCBAId(CancellationToken ct, LayerInterface layer)
        {

            string rtc = ReadMeterRtc(layer);
            string pcbaResponse = ReadMeterPcbaId(layer);
            var testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;
            if (pcbaResponse.IndexOf(StaticVariables.ERRORPreFix) < 0) { testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Pass; }
            else testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;
            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = pcbaResponse,
                Status = testExecutionStatus == (int)StaticVariables.ExecutionReurnStatus.Pass ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> Procedure2(CancellationToken ct)
        {
            await Task.Delay(10000, ct);
            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = "Response_Method2",
                Status = "Pass"
            };
        }

        private static string VerifyEnergy(LayerInterface layerInterface)
        {
            try
            {
                byte[] meterRtcObis = DLMSDataStracture.MeterRTCDataStracture.MeterRTCOBIS;
                byte classCode = DLMSDataStracture.MeterRTCDataStracture.MeterRTCClassID;
                byte attributeId = DLMSDataStracture.MeterRTCDataStracture.MeterRTCValueAttribute;

                int readResponse = layerInterface.ReadDataCommand(meterRtcObis, classCode, attributeId);
                if (readResponse != (int)LayerInterface.ProgrammingCode.Success)
                {
                    return string.Empty;
                }

                string[] rtcData = DLMSDataStracture.DLMSDataFormator(
                    GlobalObjects.objSerialComm.ReceiveBuffer,
                    18,
                    false);

                if (rtcData != null && rtcData.Length > 0 && !string.IsNullOrWhiteSpace(rtcData[0]))
                {
                    return rtcData[0];
                }

                return BitConverter.ToString(GlobalObjects.objSerialComm.ReceiveBuffer).Replace("-", string.Empty);
            }
            catch
            {
                return string.Empty;
            }
        }


        public async Task<positionResponse<string>> Calibrate(CancellationToken ct, LayerInterface layer)
        {
            try
            {
                ct.ThrowIfCancellationRequested();

                if (!layer.ConnectToMeter()) return null;


                var iii = VerifyEnergy(layer);

                var txt_calPhase = "";

                CalibrationConstants_1Phase objcalconstant = new CalibrationConstants_1Phase();
                txt_calPhase = objcalconstant.CalPhaseEnergy("2300");

                if (!objLI.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                    DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                    DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                    DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                    DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                    GetCaliBytes(txt_calPhase, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_PhaseEnergy),
                    DLMSDataStracture.DataStractureRequest.SetRequest_Normal))
                    return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                objLI.AssociationDisconnect();
            }


            return new positionResponse<string>()
            {
                Payload = "Response_Method2",
                Status = "Pass"
            };
        }

        public string VerifyEnergy(string defaultVal, string refminVal, string refmaxVal)
        {
            string CmdResponse = "";
            try
            {
                CmdResponse = ReadDataFromMeter("F00B(11)", StaticVariables._R1, "\x03");
                if (CmdResponse.IndexOf(StaticVariables.ERRORPreFix) >= 0) return CmdResponse;
                return IsValidEnergy(CmdResponse, defaultVal, refminVal, refmaxVal);
            }
            catch (Exception ex)
            {
                return StaticVariables.ERRORPreFix + ex.Message + "Meter Response :" + CmdResponse;
            }



        }

        private string IsValidEnergy(string CmdResponse, string defaultVal, string minVal, string maxVal)
        {
            string validatedResponse = string.Empty;
            try
            {
                CommonMethods objcomnMethod = new CommonMethods();
                if (CmdResponse.Length < 10) return StaticVariables.ERRORPreFix + CmdResponse;
                string ValueCmdResponse = objcomnMethod.HexToDecimalConversion(CmdResponse.Substring(1, 8));
                decimal IR_kWh = (Convert.ToDecimal(ValueCmdResponse) / 1000M);
                if (objcomnMethod.isValidReadParameters(defaultVal, minVal, maxVal, IR_kWh)) validatedResponse = " Meter Energy Is  =" + IR_kWh.ToString();
                else validatedResponse = StaticVariables.ERRORPreFix + " Meter Energy Is  =" + IR_kWh.ToString() + ", Response =" + CmdResponse;
                return validatedResponse;
            }
            catch (Exception ex)
            {
                return StaticVariables.ERRORPreFix + ex.Message + ", Response =" + CmdResponse;
            }
        }
        private string ReadDataFromMeter(string ipCommand, string readCommandType, string responseStopByte)
        {
            try
            {
                IECLayerInterface objIECLI = new IECLayerInterface();
                Thread.Sleep(100);
                string CmdResponse = "";
                string Command = StaticVariables._SOH + readCommandType + StaticVariables._STX + objIECLI.GetStrToHexCmd(ipCommand) + StaticVariables._ETX;
                string bcc = objIECLI.GetCalculatedBCC(Command.Substring(2));
                Command += bcc;

                if (readCommandType == StaticVariables._ACK) CmdResponse = objIECLI.WriteDataToMeter(StaticVariables._ACK, responseStopByte);//"\x04"
                else CmdResponse = objIECLI.WriteDataToMeter(Command, responseStopByte);//"\x03"
                if (CmdResponse.Length < 5) { return StaticVariables.ERRORPreFix + "COMM Failed."; }

                const string regexReadbuffer = @"(\(([\w\W]*?)\))";
                MatchCollection matches = Regex.Matches(CmdResponse, regexReadbuffer, RegexOptions.Multiline | RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);
                string[] Bufferdata = new string[matches.Count];
                int rcnt = 0;
                string opCommand = string.Empty;
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    Bufferdata[rcnt] = groups["0"].Value;
                    opCommand = opCommand + Bufferdata[rcnt];
                    rcnt++;
                }
                if (opCommand.Length <= 0) { return StaticVariables.ERRORPreFix + "In Valid Response :" + opCommand; }
                return opCommand;
            }
            catch (Exception ex)
            {
                return StaticVariables.ERRORPreFix + ex.Message;
            }
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