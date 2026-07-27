using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApplicationInterface;
using COMMONENTITY;
using Utilities;
using SmartCalibration.Actions;

namespace SmartCalibration.DataLayer
{
    public class MeterCalibrator
    {
        public async Task<positionResponse<string>> ReadPCBAId(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm)
        {
            string PCBAID = ccm.ReadPCBAID();
            var testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;
            if (PCBAID.IndexOf(StaticVariables.ERRORPreFix) < 0) { testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Pass; }
            else testExecutionStatus = (int)StaticVariables.ExecutionReurnStatus.Fail;
            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = PCBAID,
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

        public async Task<positionResponse<string>> CalibrateRealError(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm, int currentPos, string stepName, string currentIb, string currentImax, byte currentParamLength, string voltageValue, GenericAction action)
        {
            // 1. Run the calibration cycle locally
            string result = PerformCalibrationCycleSinglePhase(layer, ccm, currentIb, currentImax, currentParamLength, voltageValue);
            
            ct.ThrowIfCancellationRequested();

            double errorVal = 0.0;
            bool success = false;

            if (result.IndexOf(StaticVariables.ERRORPreFix) < 0 && action != null)
            {
                // Reset Calibration Registers before starting
                action.CALIBRESET(currentPos, 0);
                await Task.Delay(1000, ct);

                // Perform calibration actions dynamically based on the step configuration
                if (stepName.ToLower().Contains("creep") || stepName.ToLower().Contains("starting"))
                {
                    // Verify step using CALIBVERIFY
                    action.CALIBVERIFY(currentPos, 0);
                }
                else if (stepName.ToLower().Contains("accuracy") || stepName.ToLower().Contains("active"))
                {
                    // Execute active calibration
                    action.CALIBACTIVE(currentPos, 0);
                }
                else if (stepName.ToLower().Contains("current") || stepName.ToLower().Contains("ib"))
                {
                    // Execute current calibration
                    action.CALIBCURRENT(currentPos, 0);
                }
                else
                {
                    // Calibration of Voltage/Current (FVI)
                    action.CALIBFVI(currentPos, 0);
                }

                errorVal = action.mresulterror;
                success = true;
            }

            return new positionResponse<string>()
            {
                Payload = errorVal.ToString("F2"),
                Status = (success && result.IndexOf(StaticVariables.ERRORPreFix) < 0) ? "Pass" : "Fail"
            };
        }

        public string PerformCalibrationCycleSinglePhase(LayerInterface layer, CommonCommandMethods ccm, string currentIb, string currentImax, byte currentParamLength, string voltageValue)
        {
            try
            {
                System.Windows.Forms.TextBox[] txtboxobject = new System.Windows.Forms.TextBox[] { };

                // 1. Read the power of the single phase meter initially
                if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerOBIS, txtboxobject, "0", 1M, DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerClassID, DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerValueAttribute)) 
                { 
                    return StaticVariables.ERRORPreFix + "COMM Failed to read initial active power."; 
                }
                string[] initialPowerRaw = DLMSDataStracture.DLMSDataFormator(GlobalObjects.objSerialComm.ReceiveBuffer, 18, false);
                if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerClassID, 0x03)) 
                { 
                    return StaticVariables.ERRORPreFix + "COMM Failed to read initial active power scalar."; 
                }
                string initialPower = ApplyScalarUnits(GlobalObjects.objSerialComm.ReceiveBuffer, initialPowerRaw[0]);

                // 2. Write current to the meter
                string writeCurrentRes = ccm.WriteCuttentRating(currentIb, currentImax, currentParamLength);
                if (writeCurrentRes.IndexOf(StaticVariables.ERRORPreFix) >= 0)
                {
                    return writeCurrentRes;
                }

                // 3. Write voltage to the meter
                string writeVoltageRes = ccm.WriteRefVoltage(voltageValue);
                if (writeVoltageRes.IndexOf(StaticVariables.ERRORPreFix) >= 0)
                {
                    return writeVoltageRes;
                }

                // 4. Again read power of the single phase meter
                if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerOBIS, txtboxobject, "0", 1M, DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerClassID, DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerValueAttribute)) 
                { 
                    return StaticVariables.ERRORPreFix + "COMM Failed to read final active power."; 
                }
                string[] finalPowerRaw = DLMSDataStracture.DLMSDataFormator(GlobalObjects.objSerialComm.ReceiveBuffer, 18, false);
                if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadSignedActivePowerDataStracture.SignedActivePowerClassID, 0x03)) 
                { 
                    return StaticVariables.ERRORPreFix + "COMM Failed to read final active power scalar."; 
                }
                string finalPower = ApplyScalarUnits(GlobalObjects.objSerialComm.ReceiveBuffer, finalPowerRaw[0]);

                return $"InitialPower={initialPower}, FinalPower={finalPower}";
            }
            catch (Exception ex)
            {
                return StaticVariables.ERRORPreFix + ex.Message;
            }
        }

        public async Task<positionResponse<string>> CalibrateVoltage(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm, string value = "+00.00")
        {
            bool calibrationResult = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(value, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_Voltage),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = calibrationResult.ToString(),
                Status = calibrationResult ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> CalibratePhaseCurrent(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm, string value = "+00.00")
        {
            bool calibrationResult = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(value, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_PhaseCurrent),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = calibrationResult.ToString(),
                Status = calibrationResult ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> CalibrateNeutralCurrent(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm, string value = "+00.00")
        {
            bool calibrationResult = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(value, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_NeutralCurrent),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = calibrationResult.ToString(),
                Status = calibrationResult ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> CalibratePhaseAngle(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm, string value = "+00.00")
        {
            bool calibrationResult = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(value, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_PhaseAngle),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = calibrationResult.ToString(),
                Status = calibrationResult ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> CalibrateTemperature(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm, string value = "+00.00")
        {
            bool calibrationResult = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(value, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_Temperature),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = calibrationResult.ToString(),
                Status = calibrationResult ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> CalibrateMagnet(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm, string value = "+00.00")
        {
            bool calibrationResult = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(value, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_Magnet),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = calibrationResult.ToString(),
                Status = calibrationResult ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> CalibrateMagnetThreshold(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm, string value = "+00.00")
        {
            bool calibrationResult = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(value, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_MagnetThreshold),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = calibrationResult.ToString(),
                Status = calibrationResult ? "Pass" : "Fail"
            };
        }

        public async Task<positionResponse<string>> MeterReset(CancellationToken ct, LayerInterface layer, CommonCommandMethods ccm)
        {
            bool mtrReset = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
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

        public List<byte> GetCaliBytes(string txtbx, byte dlmsDataType, byte commandIdetifier)
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

        public async Task<positionResponse<string>> CalibrateEnergyError(
            CancellationToken ct, 
            LayerInterface layer, 
            CommonCommandMethods ccm, 
            string currentIb, 
            string currentImax, 
            byte currentParamLength, 
            string voltageValue, 
            double powerFactor, 
            int durationSeconds)
        {
            // 1. Write target current rating to the meter
            string writeCurrentRes = ccm.WriteCuttentRating(currentIb, currentImax, currentParamLength);
            if (writeCurrentRes.Contains(StaticVariables.ERRORPreFix))
            {
                return new positionResponse<string>() { Payload = writeCurrentRes, Status = "Fail" };
            }

            // 2. Write target reference voltage to the meter
            string writeVoltageRes = ccm.WriteRefVoltage(voltageValue);
            if (writeVoltageRes.Contains(StaticVariables.ERRORPreFix))
            {
                return new positionResponse<string>() { Payload = writeVoltageRes, Status = "Fail" };
            }

            // 3. Read initial energy from the meter
            System.Windows.Forms.TextBox[] txtboxobject = new System.Windows.Forms.TextBox[] { };
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttribute))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read initial energy value.", Status = "Fail" };
            }
            List<string> initialRawList = FormatIndivisualData(GlobalObjects.objSerialComm.ReceiveBuffer);
            if (initialRawList.Count <= 0)
            {
                return new positionResponse<string>() { Payload = "Invalid initial energy response format.", Status = "Fail" };
            }
            string initialValStr = initialRawList[0];
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttributeScalar))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read initial energy scalar.", Status = "Fail" };
            }
            initialValStr = ApplyScalarUnits(GlobalObjects.objSerialComm.ReceiveBuffer, initialValStr);
            double.TryParse(initialValStr, out double initialEnergy);

            // 4. Wait for duration/accumulation (delay)
            await Task.Delay(durationSeconds * 1000, ct);

            // 5. Read final energy from the meter
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttribute))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read final energy value.", Status = "Fail" };
            }
            List<string> finalRawList = FormatIndivisualData(GlobalObjects.objSerialComm.ReceiveBuffer);
            if (finalRawList.Count <= 0)
            {
                return new positionResponse<string>() { Payload = "Invalid final energy response format.", Status = "Fail" };
            }
            string finalValStr = finalRawList[0];
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttributeScalar))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read final energy scalar.", Status = "Fail" };
            }
            finalValStr = ApplyScalarUnits(GlobalObjects.objSerialComm.ReceiveBuffer, finalValStr);
            double.TryParse(finalValStr, out double finalEnergy);

            // 6. Calculate reference active energy accumulated: E_ref = (V * I * PF * T_hours) / 1000 (kWh)
            double.TryParse(voltageValue, out double V);
            double.TryParse(currentIb, out double I);
            double power = V * I * powerFactor; // Watts
            double refEnergy = (power * (durationSeconds / 3600.0)) / 1000.0; // kWh

            // 7. Calculate error percentage
            double meterEnergyDiff = finalEnergy - initialEnergy;
            double errorPct = 0.0;
            if (refEnergy > 0)
            {
                errorPct = ((meterEnergyDiff - refEnergy) / refEnergy) * 100.0;
            }

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = $"Initial={initialEnergy:F3} kWh, Final={finalEnergy:F3} kWh, MeterDiff={meterEnergyDiff:F6} kWh, RefEnergy={refEnergy:F6} kWh, Error={errorPct:F2}%",
                Status = "Pass"
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

        private string ApplyScalarUnits(byte[] Blockdata, string data)
        {
            int arraySize;
            int nByteIndex = 18;
            string strTemp = "";
            if (Blockdata[nByteIndex] == 0x01)
            {
                nByteIndex++;
                nByteIndex++;
                arraySize = Blockdata[nByteIndex++];
            }
            else
            {
                arraySize = Blockdata[nByteIndex++];
            }

            if (Blockdata[nByteIndex] == 0x02)
            {
                nByteIndex++;
                nByteIndex++;
                int bScale = Blockdata[nByteIndex++];
                nByteIndex++;
                if ((Blockdata[nByteIndex] >= 0x1B) && (Blockdata[nByteIndex] <= 0x20))
                {
                    bScale = (byte)(bScale - 3);
                }

                if (bScale > 127)
                {
                    bScale = 255 - bScale + 1;
                    strTemp = "-" + bScale.ToString();
                }
                else
                {
                    strTemp = bScale.ToString();
                }
            }
            string formatedData = ServiceClass.ServiceInstance.AllignData(data, Convert.ToInt16(strTemp));
            return formatedData;
        }

        private List<string> FormatIndivisualData(byte[] Blockdata)
        {
            List<string> datavalueList = new List<string>();
            try
            {
                if (Blockdata == null) return datavalueList;
                string data = string.Empty;
                string[] datavalue = new string[2];
                int nRowIndex = 0;
                int nByteIndex = 18;
                datavalue = DLMSDataStracture.DLMSDataFormator(Blockdata, nByteIndex, false);
                if (datavalue == null) return datavalueList;
                while (datavalue[0] != null)
                {
                    datavalueList.Add(datavalue[0]);
                    nByteIndex = Convert.ToInt16(datavalue[1]);
                    datavalue = DLMSDataStracture.DLMSDataFormator(Blockdata, nByteIndex, false);
                    if (datavalue == null) break;
                    nRowIndex++;
                }
                return datavalueList;
            }
            catch (Exception)
            {
                return datavalueList;
            }
        }
        public async Task<positionResponse<string>> PerformFullCalibrationSequence(
            CancellationToken ct, 
            LayerInterface layer, 
            CommonCommandMethods ccm, 
            int currentPos, 
            string stepName,
            string currentIb, 
            string currentImax, 
            byte currentParamLength, 
            string voltageValue, 
            double targetVoltage, 
            double targetCurrent, 
            double targetPhi)
        {
            // --- PART 1: UNITY PF CALIBRATION (Steps 1 to 6) ---
            
            // 1. First energy read kariba
            System.Windows.Forms.TextBox[] txtboxobject = new System.Windows.Forms.TextBox[] { };
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttribute))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read initial energy value.", Status = "Fail" };
            }
            List<string> initialRawList = FormatIndivisualData(GlobalObjects.objSerialComm.ReceiveBuffer);
            if (initialRawList.Count <= 0)
            {
                return new positionResponse<string>() { Payload = "Invalid initial energy response.", Status = "Fail" };
            }
            string initialValStr = initialRawList[0];
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttributeScalar))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read initial energy scalar.", Status = "Fail" };
            }
            initialValStr = ApplyScalarUnits(GlobalObjects.objSerialComm.ReceiveBuffer, initialValStr);
            double.TryParse(initialValStr, out double initialEnergy);

            // 2. Second Voltage set kariba
            string writeVoltageRes = ccm.WriteRefVoltage(voltageValue);
            //if (writeVoltageRes.Contains(StaticVariables.ERRORPreFix))
            //{
            //    return new positionResponse<string>() { Payload = "Failed to set reference voltage: " + writeVoltageRes, Status = "Fail" };
            //}

            // 3. third Current set kariba
            string writeCurrentRes = ccm.WriteCuttentRating(currentIb, currentImax, currentParamLength);
            //if (writeCurrentRes.Contains(StaticVariables.ERRORPreFix))
            //{
            //    return new positionResponse<string>() { Payload = "Failed to set current rating: " + writeCurrentRes, Status = "Fail" };
            //}

            // 4. Fourth phase angle set kariba (Standard Unity / targetPhi)
            var phaseAngleRes = await CalibratePhaseAngle(ct, layer, ccm, targetPhi.ToString("F2"));
            //if (phaseAngleRes.Status == "Fail")
            //{
            //    return new positionResponse<string>() { Payload = "Failed to set phase angle: " + phaseAngleRes.Payload, Status = "Fail" };
            //}

            // 5. Fifth energy read kariba
            await Task.Delay(5000, ct); // Accumulation window
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttribute))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read final energy value.", Status = "Fail" };
            }
            List<string> finalRawList = FormatIndivisualData(GlobalObjects.objSerialComm.ReceiveBuffer);
            //if (finalRawList.Count <= 0)
            //{
            //    return new positionResponse<string>() { Payload = "Invalid final energy response.", Status = "Fail" };
            //}
            string finalValStr = finalRawList[0];
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttributeScalar))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read final energy scalar.", Status = "Fail" };
            }
            finalValStr = ApplyScalarUnits(GlobalObjects.objSerialComm.ReceiveBuffer, finalValStr);
            double.TryParse(finalValStr, out double finalEnergy);

            // 6. Calculate reference energy and calibrate active energy coefficient
            double powerUnity = targetVoltage * targetCurrent * Math.Cos(targetPhi * Math.PI / 180.0);
            double refEnergyUnity = (powerUnity * (5.0 / 3600.0)) / 1000.0; // kWh
            double meterEnergyDiffUnity = finalEnergy - initialEnergy;
            double errorPctUnity = 0.0;
            if (refEnergyUnity > 0)
            {
                errorPctUnity = ((meterEnergyDiffUnity - refEnergyUnity) / refEnergyUnity) * 100.0;
            }
            string correctionFactorUnity = (1.0 + (errorPctUnity / 100.0)).ToString("F4");

            // Write Unity PF energy calibration coefficient to meter
            bool calibResUnity = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(correctionFactorUnity, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_PhaseEnergy),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            // --- PART 2: 50% LAG PF CALIBRATION (Step 7) ---
            
            // 7a. First energy read for Lag PF
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttribute))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read initial lag energy.", Status = "Fail" };
            }
            List<string> initialLagRawList = FormatIndivisualData(GlobalObjects.objSerialComm.ReceiveBuffer);
            if (initialLagRawList.Count <= 0)
            {
                return new positionResponse<string>() { Payload = "Invalid initial lag energy response.", Status = "Fail" };
            }
            string initialLagValStr = initialLagRawList[0];
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttributeScalar))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read initial lag energy scalar.", Status = "Fail" };
            }
            initialLagValStr = ApplyScalarUnits(GlobalObjects.objSerialComm.ReceiveBuffer, initialLagValStr);
            double.TryParse(initialLagValStr, out double initialEnergyLag);

            // 7b. Set Voltage and Current Rating
            ccm.WriteRefVoltage(voltageValue);
            ccm.WriteCuttentRating(currentIb, currentImax, currentParamLength);

            // 7c. Set phase angle to 50% Lag (60.00 degrees / Cos(60) = 0.5)
            var phaseAngleResLag = await CalibratePhaseAngle(ct, layer, ccm, "60.00");
            if (phaseAngleResLag.Status == "Fail")
            {
                return new positionResponse<string>() { Payload = "Failed to set lag phase angle: " + phaseAngleResLag.Payload, Status = "Fail" };
            }

            // 7d. Wait and Read final energy for Lag PF
            await Task.Delay(5000, ct);
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttribute))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read final lag energy.", Status = "Fail" };
            }
            List<string> finalLagRawList = FormatIndivisualData(GlobalObjects.objSerialComm.ReceiveBuffer);
            if (finalLagRawList.Count <= 0)
            {
                return new positionResponse<string>() { Payload = "Invalid final lag energy response.", Status = "Fail" };
            }
            string finalLagValStr = finalLagRawList[0];
            if (!layer.ReadByteFromMeter(DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhOBIS, txtboxobject, "0", 100M, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhClassID, DLMSDataStracture.ReadInstantkWhDataStracture.ReadInstantkWhValueAttributeScalar))
            {
                return new positionResponse<string>() { Payload = "COMM Failed to read final lag energy scalar.", Status = "Fail" };
            }
            finalLagValStr = ApplyScalarUnits(GlobalObjects.objSerialComm.ReceiveBuffer, finalLagValStr);
            double.TryParse(finalLagValStr, out double finalEnergyLag);

            // 7e. Calculate reference energy and calibrate active energy coefficient at 50% Lag (PF = 0.5)
            double powerLag = targetVoltage * targetCurrent * 0.5; // Cos(60) = 0.5
            double refEnergyLag = (powerLag * (5.0 / 3600.0)) / 1000.0; // kWh
            double meterEnergyDiffLag = finalEnergyLag - initialEnergyLag;
            double errorPctLag = 0.0;
            if (refEnergyLag > 0)
            {
                errorPctLag = ((meterEnergyDiffLag - refEnergyLag) / refEnergyLag) * 100.0;
            }
            string correctionFactorLag = (1.0 + (errorPctLag / 100.0)).ToString("F4");

            // Write Lag PF energy calibration coefficient to meter
            bool calibResLag = layer.WriteDataToMeter(DLMSDataStracture.CalibrationDataStracture.CalibrationValueAttribute,
                DLMSDataStracture.CalibrationDataStracture.CalibrationOBIS,
                DLMSDataStracture.CalibrationDataStracture.CalibrationClassID,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataType,
                DLMSDataStracture.CalibrationDataStracture.CalibrationDataLength,
                GetCaliBytes(correctionFactorLag, 0x06, DLMSDataStracture.CalibrationDataStracture.CalibrationFactorIentifier_PhaseEnergy),
                DLMSDataStracture.DataStractureRequest.SetRequest_Normal);

            ct.ThrowIfCancellationRequested();

            return new positionResponse<string>()
            {
                Payload = $"UnityError={errorPctUnity:F2}%, UnityCalib={calibResUnity}; LagError={errorPctLag:F2}%, LagCalib={calibResLag}",
                Status = (calibResUnity && calibResLag) ? "Pass" : "Fail"
            };
        }
    }
}
