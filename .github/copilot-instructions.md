# Copilot Instructions

## Project Guidelines
- When running procedures against meters, create a new LayerInterface per port using SerialPortSettings.Default.SerialPort (CSV), call ConnectToMeter(serialPortName) for that port, run the procedure, then disconnect. Use per-port connections and render actual port list from SerialPortSettings.Default.SerialPort.