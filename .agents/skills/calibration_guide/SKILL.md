---
name: calibration-guide
description: Reference guide for the energy meter calibration sequence logic, including step parameters, database schema, control modes, and execution flow.
---

# Energy Meter Calibration Reference Guide

This skill provides a detailed reference for the `AemCal` / `AemCalCS` energy meter calibration system. It explains the database tables, step attributes, control modes, and execution flows for use during development.

## 1. Database Schema (Calibration & Results)

The calibration system saves procedure definitions and run-time results across the following tables:

### Procedure Definition Tables
* **`TestProcedure`**: Stores metadata for each calibration sequence.
  - `ProcedureID` (Int, PK, Identity): Unique ID of the procedure.
  - `Name` (String): Name of the test procedure (e.g., "1-Phase Static Meter Accuracy").
  - `TimeModified` (DateTime): Last modification timestamp.
  - `Revision` (Short): Version/revision number of the procedure.
* **`PStep`**: Stores individual test steps belonging to a procedure.
  - `ProcedureID` (Int, FK): References `TestProcedure(ProcedureID)`.
  - `PStepNo` (Short): Sequential step index (e.g., 1, 2, 3...).
  - `Name` (String): Display name of the step.
  - `UA, UB, UC` (String): Target voltage percentages for phases A, B, and C (relative to nominal voltage $Ub$).
  - `IA, IB, IC` (String): Target current percentages for phases A, B, and C (relative to nominal current $Ib$ or $Imax$).
  - `IsImax` (Short): Flag (1/0) indicating whether current is relative to $Imax$ instead of $Ib$.
  - `PHI` (String): Phase angle / Power Factor angle (e.g., 0.0 for Unity, 60.0 for 0.5 Lag).
  - `FREQ` (String): Frequency (e.g., 50.0 Hz or 60.0 Hz).
  - `Waveform` (Short): Waveform selection index (1 for Sine wave).
  - `PhaseSeq` (Short): Phase sequence configuration (1 = ABC, 2 = ACB).
  - `TestTypeID` (Short): Test category (1 = Basic Error Test, 2 = Creep/QianDong Test, 3 = Starting/QiDong Test).
  - `NumPulses` (String): Number of pulses to count for error calculation.
  - `ULIMIT, LLIMIT` (String): Upper and lower allowable error limits in percentage (e.g., +0.5 to -0.5).
  - `ChannelNo` (Short): Error board pulse measurement register/channel (e.g., 1, 2).
  - `Storing` (Short): Flag to write results to database (1 = save, 0 = display only).
  - `Duration` (Short): Control mode indicator (0 = Manual, 1 = Program, 2 = Wait).
  - `Timeout` (String): Timeout limit in seconds before aborting the step.
  - `Finally` (Short): Post-execution check flag.
  - `ACMDS, BCMDS, CCMDS` (String): Commands sent before, during, or after the test step, separated by `|`.
  - `WithAmp` (Short): Flag (1/0) to keep power/current amplifier active during post-step communications.

### Run-Time & Result Tables
* **`Run`**: Stores the metadata of a calibration run.
  - `RunID` (Int, PK, Identity): Unique ID of the calibration run.
  - `Name` (String): User-defined name/identifier for the run.
  - `TimeRun` (DateTime): Run timestamp.
  - `Status` (Short): Run status code (e.g., 1 = Running, 2 = Completed).
* **`RStep`**: Stores the snapshots of the steps executed in the run.
* **`RMeter`**: Stores details of the meters placed on each bench position (1 to 48).
* **`RResult`**: Stores the final measured calibration errors.
  - `RunID` (Int), `StepNo` (Short), `PositionNo` (Short), `RValue` (String - error percentage or status).

---

## 2. Control Functions (Control Type)
The Control Type (represented by `Duration` field in database steps) governs step transitions and communications:
* **Manual (`Duration = 0`):** Standard sequential execution. The sequencer finishes the test step and moves directly to the next.
* **Program (`Duration = 1`):** Launches external calibration-related programs, automation scripts, or executable helpers specified in the commands.
* **Wait (`Duration = 2`):** The sequencer cuts power (drops voltage/current to 0) and displays a popup message asking the operator to press OK to continue. Used when manual connection changes or physical inspections are needed.
* **w/A (With Amplifier / `WithAmp = 1`):** Keeps the voltage/current amplifiers active at the end of the pulse-measurement phase while executing the post-step communication commands (`CCMDS`). This prevents electronic meters from losing calibration state due to power interruption.

---

## 3. Comport and Position Assignment
* **Comport:** Loaded from `Bench.SioPortNo` (e.g., 3 = COM3) and `Bench.SioFormat` (e.g., "19200,n,8,2") and passed to `YcBoardController`. It dictates the hardware port through which commands are written to the signal sources and error counter boards.
* **Position:** Represents the physical slot (1 to 48) on the test bench. The sequencer loops through the slots (`for (short pos = 1; pos <= maxPositions; pos++)`) and targets each position individually to configure the pulses, start test runs, and read back error percentages.

---

## 4. Run-Time Command Execution Flow (ACMDS, BCMDS, CCMDS)
Commands in step parameters can contain multiple entries separated by the pipe character `|`.
* **ACMDS (Before/Pre-step):** Split by `|` and run sequentially before turning on voltage/current. Includes setup queries or protocol baud configurations.
* **BCMDS (During/Parallel):** Executed in a parallel thread (`BCmdProc`) concurrently while the sequencer is waiting for the target `NumPulses` or `Duration`. It allows reading instantaneous registry values from the meter under load. If BCMDS run longer than the measurement loop, the sequencer waits for the thread to complete (up to timeout).
* **CCMDS (After/Post-step):** Executed after the measurement loop finishes and current has dropped (unless `WithAmp = 1`). Used to write final calibration constants or reset the meter.
* **Special commands:** If a command starts with `"wait "`, it parses the time (e.g. `wait 0:0:5` for 5 seconds) and sleeps the execution thread.

---

## 5. Sample Calibration Procedure (Reference Model)

Below is a standard 5-step test sequence for calibrating a single-phase static meter:

```
[Start Test]
  │
  ├─► Step 1: Baud Setup (UA=100%, IA=0%, Manual, w/A=0, ACMDS="AT+BAUD=9600")
  │     └─► Voltage turned ON, Baud command sent, moves to next step.
  │
  ├─► Step 2: Creep Test (UA=115%, IA=0%, Manual, 120s Duration, CCMDS="READ+CREEP")
  │     └─► Voltage raised, counts down 120s. Verifies zero pulses. Reads status.
  │
  ├─► Step 3: Starting Test (UA=100%, IA=0.4%, Manual, 60s Duration, Target=1 pulse)
  │     └─► Low starting current applied. Verifies meter triggers at least 1 pulse.
  │
  ├─► Step 4: Active Accuracy Test (UA=100%, IA=100%, Manual, w/A=1, BCMDS="READ+VOLT|READ+CURR", CCMDS="SAVE+CAL")
  │     ├─► Nominal load applied. Target is 10 pulses to compute error.
  │     ├─► Parallel Thread runs BCMDS to poll voltage/current during measurement.
  │     └─► Measurement ends. Amplifiers kept ON (w/A=1). Saves calibration data via CCMDS.
  │
  └─► Step 5: Terminal Check (UA=0%, IA=0%, Wait)
        └─► All power dropped. Operator prompted to verify display before completing.
```
