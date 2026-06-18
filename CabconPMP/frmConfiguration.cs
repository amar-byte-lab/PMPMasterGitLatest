using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using Utilities;
using ApplicationInterface;
namespace CabconPMP
{
    public partial class frmConfiguration : Form
    {

        Label[] lstEventList;
        CheckBox[] lstEventLog;
        CheckBox[] lstAlarm;
        public enum TAMPERCONFIGBIT
        {
            Earth_Tamper_Eanble = 0,
            Reverse_Tamper_Eanble = 1,
            Magnet_Tamper_Eanble = 2,
            Single_wire_Tamper_Eanble = 3,
            Neutral_Disturb_Tamper_Eanble = 4,
            Over_Voltage_Eanble = 5,
            Low_Voltage_Eanble = 6,
            Over_Current_Eanble = 7,
            Power_fail_Log_Eanble = 8,
            Over_Load_Eanble = 9,
            Cover_Open_Log_Eanble = 10,
            Coms_Card_Removal = 11,
            Relay_Disconnect_log_Eanble = 12,           
            Relay_Malfunction_Eanble = 13,
            ESD_Event_Eanble = 14,
            Reserved_1 = 15,
            Reserved_2 = 16,
            Reserved_3 = 17,
            Reserved_4 = 18,
            Reserved_5 = 19,
            Reserved_6 = 20,
            Reserved_7 = 21,
            Reserved_8 = 22,
            Reserved_9 = 23,
            Reserved_10 = 24,
            Reserved_11 = 25,
            Reserved_12 = 26,
            Reserved_13 = 27,
            Reserved_14 = 28,
            Reserved_15 = 29,
            Reserved_16 = 30,
            Reserved_17 = 31          


        }

        private string[] strtamperdetails = new string[] { "Earth Tamper", "Reverse Tamper", "Magnet Tamper", "Single wire Tamper", "Neutral Disturb Tamper", "Over Voltage", "Low Voltage", "Over Current", "Power fail Log", "Over Load", "Cover Open Log", "Coms Card Removal", "Relay Connect-Disconnect Log", "Relay Malfunction", "ESD Event" };

        #region Constant Variables

        public static int DefaultTamperPersistanceTime = 60;
        public static decimal DefaultTOUPriceSlab = 10.50M;

        #endregion

        TextBox[] txtobjtampPersistance;
        LayerInterface objLI = new LayerInterface();
        public delegate void UpdateMainMsgHandler(object sender, UpdateEventArgs e);
        public event UpdateMainMsgHandler UpdateMsg;
        UpdateEventArgs args = null;
        bool IsAbort = false;
        string pfdata = string.Empty;        
        byte[] HDLCCommand = new byte[200];
        //byte HDLCIndex = 0;
        string data = string.Empty;
        string opencfgFilePath = "";
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void txtPersistanceEarthO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPersistanceMagnetO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPersistanceRevO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPersistancePoweroffO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPersistanceSingleWireO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPersistanceVoltageDistO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPersistanceEarthR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPersistanceMagnetR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPersistanceRevR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
        private void frmConfiguration_Load(object sender, EventArgs e)
        {

            ResetsConfigurations(false);

        }

        private void ResetsConfigurations(bool IsReset)
        {
            try
            {
                FillDisplayParametersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in resetting the configuration values. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDisplayParametersList()
        {
            lstDisplayAutoAll.Items.Clear();
            lstDisplatAutoSelected.Items.Clear();
            DisplayParameterList objdispara = new DisplayParameterList();
            Dictionary<string, int> displayPara = objdispara.GetDisplayParameterList_MicroStarDLMS();
            string[] ParameterValue = displayPara.Keys.ToArray();
            int ItemIndex = 0;
            while (ItemIndex < ParameterValue.Length)
            {
                lstDisplayAutoAll.Items.Add(ParameterValue[ItemIndex]);
            }
        }

        private void btnDispAutoMove_Click(object sender, EventArgs e)
        {
            if (lstDisplatAutoSelected.Items.Count >= 64)
            {
                if (MessageBox.Show("Maximum Selection Limit is Only 64 Parameter!!" + "\n" + "Your Current Selection is: " + lstDisplatAutoSelected.Items.Count.ToString() + " Parameters \n" + "Do You Want to Add Selected Items ?", "DLMS-PT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            }
            MoveItem(lstDisplayAutoAll, lstDisplatAutoSelected);
            lblDisplayParaTotalSelected.Text = "Total Selected:" + "\n          " + lstDisplatAutoSelected.Items.Count.ToString();

        }

        private void btnDispAutoMoveAll_Click(object sender, EventArgs e)
        {
            MoveAll(lstDisplayAutoAll, lstDisplatAutoSelected);
            lblDisplayParaTotalSelected.Text = "Total Selected:" + "\n          " + lstDisplatAutoSelected.Items.Count.ToString();
            if (lstDisplatAutoSelected.Items.Count > 64)
            {
                MessageBox.Show("Maximum Selection Limit is Only 64 Parameter!!" + "\n" + "Your Current Selection is: " + lstDisplatAutoSelected.Items.Count.ToString() + " Parameters", "PowerTool", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void MoveAll(ListBox lstDisplatAutoAll, ListBox lstSelect)
        {

            lstSelect.Items.Clear();
            lstSelect.Items.AddRange(lstDisplatAutoAll.Items);

        }

        private void btnDispAutoRemove_Click(object sender, EventArgs e)
        {
            RemoveItem(lstDisplayAutoAll, lstDisplatAutoSelected);
            lblDisplayParaTotalSelected.Text = "Total Selected:" + "\n          " + lstDisplatAutoSelected.Items.Count.ToString();
        }

        private void MoveItem(ListBox lstTotal, ListBox lstSelect)
        {
            int lstAllIdx = lstTotal.SelectedIndex + 1;
            int SelectedIdx = lstSelect.SelectedIndex;
            if (lstTotal.SelectedItems.Count < 0) { lstTotal.SelectedIndex = 0; return; }
            foreach (object item in lstTotal.SelectedItems)
            {
                if (lstSelect.SelectedIndex >= 0) lstSelect.Items.Insert(++SelectedIdx, item);
                else lstSelect.Items.Add(item);
            }
            lstTotal.SelectedIndex = -1;
            lstSelect.SelectedIndex = -1;
            if (lstSelect.Items.Count >= SelectedIdx) lstSelect.SelectedIndex = SelectedIdx;
            if (lstAllIdx < lstTotal.Items.Count) lstTotal.SelectedIndex = lstAllIdx;
            lstTotal.Focus();
        }

        private void RemoveItem(ListBox lstTotal, ListBox lstSelect)
        {
            int lstselectedIdx = lstSelect.SelectedIndex;
            if (lstSelect.SelectedItems.Count == 0 && lstSelect.Items.Count > 0) { lstSelect.SelectedIndex = 0; return; }
            while (lstSelect.SelectedIndices.Count > 0)
            {
                lstSelect.Items.RemoveAt(lstSelect.SelectedIndex);
            }
            if (lstSelect.Items.Count > lstselectedIdx) lstSelect.SelectedIndex = lstselectedIdx;
            else if (lstSelect.Items.Count >= 1) lstSelect.SelectedIndex = lstSelect.Items.Count - 1;
            lstSelect.Focus();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
        }
        private void lblAbort_Click(object sender, EventArgs e)
        {
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

    }
}
