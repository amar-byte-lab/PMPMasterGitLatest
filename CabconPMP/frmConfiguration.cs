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
        public delegate void UpdateMainMsgHandler(object sender, UpdateEventArgs e);
        public event UpdateMainMsgHandler UpdateMsg;

        public frmConfiguration()
        {
            InitializeComponent(); COMMONENTITY.FormStyleHelper.Apply(this);
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
                ItemIndex++;
            }
        }

        // '>' : Move selected items from All -> Selected (transfer)
        private void btnDispAutoMove_Click(object sender, EventArgs e)
        {
            MoveItem(lstDisplayAutoAll, lstDisplatAutoSelected);
            lblDisplayParaTotalSelected.Text = "Total Selected:" + "\n          " + lstDisplatAutoSelected.Items.Count.ToString();
        }

        // '>>' : Move all items from All -> Selected (transfer)
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

        // '<' : Move selected items from Selected -> All (transfer back)
        private void btnDispAutoRemove_Click(object sender, EventArgs e)
        {
            RemoveItem(lstDisplayAutoAll, lstDisplatAutoSelected);
            lblDisplayParaTotalSelected.Text = "Total Selected:" + "\n          " + lstDisplatAutoSelected.Items.Count.ToString();
        }

        // '<<' : Move all items from Selected -> All
        private void btnDispAutoRemoveAll_Click(object sender, EventArgs e)
        {
            MoveAll(lstDisplatAutoSelected, lstDisplayAutoAll);
            lblDisplayParaTotalSelected.Text = "Total Selected:" + "\n          " + lstDisplatAutoSelected.Items.Count.ToString();
        }

        // '^' : Move selected items up within Selected list
        private void btnDispAutoMoveUP_Click(object sender, EventArgs e)
        {
            MoveSelectedUp(lstDisplatAutoSelected);
            // no change in count
        }

        // 'v' : Move selected items down within Selected list
        private void btnDispAutoMoveDown_Click(object sender, EventArgs e)
        {
            MoveSelectedDown(lstDisplatAutoSelected);
        }

        // Transfer all items from source -> destination (destination appended, then source cleared)
        private void MoveAll(ListBox source, ListBox destination)
        {
            if (source == null || destination == null) return;

            var items = source.Items.Cast<object>().ToArray();
            if (items.Length == 0) return;

            // Append items to destination
            destination.BeginUpdate();
            foreach (var it in items)
                destination.Items.Add(it);
            destination.EndUpdate();

            // Clear source
            source.Items.Clear();
        }

        // Move selected items from source -> destination (preserve order)
        private void MoveItem(ListBox source, ListBox destination)
        {
            if (source == null || destination == null) return;
            if (source.SelectedItems.Count == 0) return;

            var toMove = source.SelectedItems.Cast<object>().ToList();

            // Insert into destination preserving order and current selection index logic
            int insertIndex = destination.SelectedIndex >= 0 ? destination.SelectedIndex + 1 : destination.Items.Count;
            if (insertIndex < 0) insertIndex = 0;

            destination.BeginUpdate();
            foreach (var item in toMove)
            {
                destination.Items.Insert(insertIndex++, item);
            }
            destination.EndUpdate();

            // Remove from source
            foreach (var item in toMove)
                source.Items.Remove(item);

            // Update selection on destination to reflect the moved block
            int firstNewIndex = insertIndex - toMove.Count;
            destination.ClearSelected();
            for (int i = 0; i < toMove.Count; i++)
                destination.SetSelected(firstNewIndex + i, true);
        }

        // Move selected items from 'selected list' back to 'all list'
        private void RemoveItem(ListBox targetAll, ListBox selectedList)
        {
            if (targetAll == null || selectedList == null) return;
            if (selectedList.SelectedItems.Count == 0) return;

            var toMove = selectedList.SelectedItems.Cast<object>().ToList();

            // Append to targetAll (end)
            targetAll.BeginUpdate();
            foreach (var item in toMove)
                targetAll.Items.Add(item);
            targetAll.EndUpdate();

            // Remove from selectedList
            foreach (var item in toMove)
                selectedList.Items.Remove(item);

            // adjust selection
            if (selectedList.Items.Count > 0)
            {
                int selIdx = Math.Min(selectedList.Items.Count - 1, selectedList.SelectedIndex);
                if (selIdx >= 0) selectedList.SelectedIndex = selIdx;
            }
        }

        // Move selected items up one position within the same list
        private void MoveSelectedUp(ListBox list)
        {
            if (list == null) return;
            int n = list.Items.Count;
            if (n <= 1) return;

            var items = list.Items.Cast<object>().ToList();
            var selectedFlags = new bool[n];
            foreach (int i in list.SelectedIndices) selectedFlags[i] = true;

            // If topmost is selected, nothing to move for that item.
            for (int i = 1; i < n; i++)
            {
                if (selectedFlags[i] && !selectedFlags[i - 1])
                {
                    // swap items and flags
                    var tmpItem = items[i - 1];
                    items[i - 1] = items[i];
                    items[i] = tmpItem;
                    selectedFlags[i - 1] = true;
                    selectedFlags[i] = false;
                }
            }

            // Update UI
            list.BeginUpdate();
            list.Items.Clear();
            foreach (var it in items) list.Items.Add(it);
            list.EndUpdate();

            // Restore selection
            list.ClearSelected();
            for (int i = 0; i < selectedFlags.Length; i++)
                if (selectedFlags[i]) list.SetSelected(i, true);
        }

        // Move selected items down one position within the same list
        private void MoveSelectedDown(ListBox list)
        {
            if (list == null) return;
            int n = list.Items.Count;
            if (n <= 1) return;

            var items = list.Items.Cast<object>().ToList();
            var selectedFlags = new bool[n];
            foreach (int i in list.SelectedIndices) selectedFlags[i] = true;

            for (int i = n - 2; i >= 0; i--)
            {
                if (selectedFlags[i] && !selectedFlags[i + 1])
                {
                    var tmpItem = items[i + 1];
                    items[i + 1] = items[i];
                    items[i] = tmpItem;
                    selectedFlags[i + 1] = true;
                    selectedFlags[i] = false;
                }
            }

            // Update UI
            list.BeginUpdate();
            list.Items.Clear();
            foreach (var it in items) list.Items.Add(it);
            list.EndUpdate();

            // Restore selection
            list.ClearSelected();
            for (int i = 0; i < selectedFlags.Length; i++)
                if (selectedFlags[i]) list.SetSelected(i, true);
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            ResetsConfigurations(false);
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

        private void lblSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstDisplatAutoSelected.Items.Count > 0)
                {
                    frmCalibration objcalib = new frmCalibration(lstDisplatAutoSelected.Items.Cast<string>().Select((item, index) => new KeyValuePair<int, string>(index, item)).ToList());
                    objcalib.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving the configuration values. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
