using BALLAYER;
using CabconPMP.Data;
using CabconPMP.Models;
using COMMONENTITY;
using LNG.Communication.SerialCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static CabconPMP.Data.MeterTypeRepository;
namespace CabconPMP
{
    public partial class frmLoginMain : Form
    {
        GlobalMethods objsv = new GlobalMethods();
        EntityUserManagement objetyusermgt = new EntityUserManagement();
        BALDBConnectionTest objdbcon = new BALDBConnectionTest();
        SerialComm objSerialComm = new SerialComm();
        Association association = new Association();
        public Person LoggedInUser { get; private set; }

        private readonly PersonRepository _personRepository;

         public frmLoginMain(PersonRepository personRepository)
         {
             InitializeComponent(); 
             COMMONENTITY.FormStyleHelper.Apply(this);

             // Apply visual transparency overrides after global styling
             this.PanelLoginControl.BackColor = System.Drawing.Color.Transparent;
             this.PanelLoginControl.BackgroundImage = null;
             this.PanelLoginControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
             this.PanelLoginControl.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLoginControl_Paint);


             this.txtPassword.BackColor = System.Drawing.Color.Transparent;
             this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;

            _personRepository = personRepository;

             LoadOperators();
        }

        private async void LoadOperators()
        {
            try
            {
                var users = await _personRepository.GetAllAsync();
                cmbUser.Items.Clear();
                foreach (var user in users)
                {
                    cmbUser.Items.Add(user.Name);
                }
                if (cmbUser.Items.Count > 0) cmbUser.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading operators: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BALUserManagement objum = new BALUserManagement();
            try
            {
                string username = cmbUser.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please select or enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = await _personRepository.ValidateUserAsync(username, password);
                if (user != null)
                {
                    LoggedInUser = user;
                    DialogResult = DialogResult.OK;

                    //--------------------Set Default Settings-----------------
                    association.DefaultSettings();
                    //-------------------Show Custom Setting-----------------------
                    association.ShowDefaultSettings();
                    association.CheckAllAssociation();

                    //-------------------Save Association Setting-----------------------
                    List<string> selectedPorts = new List<string>();
                    foreach (object it in clbPorts.CheckedItems) selectedPorts.Add(it.ToString());
                    association.SaveAssociation(selectedPorts);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid User , Please Enter Valid Password !", "Cabcon PMP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPassword.Focus();
                    return;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Cabcon PMP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            
        }

        private void frmLoginMain_Load(object sender, EventArgs e)
        {
            //-------------------Get Avilable COM Port---------------
            string[] PortNames = objSerialComm.GetAvailablePorts();
            Array.Reverse(PortNames);
            foreach (string Port in PortNames) clbPorts.Items.Add(Port);

            Point panelLoc = PanelLoginControl.Location;
            PanelLoginControl.Parent = pictureBox1;
            PanelLoginControl.Location = panelLoc;
            cmbUser.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { txtPassword.Focus(); }
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { btnLogin_Click(this, e); }
        }

        private void txtuserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtuserID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PanelLoginControl_Paint(object sender, PaintEventArgs e)
        {
            // Draw a stylish 1px border around the transparent text boxes
            using (Pen borderPen = new Pen(Color.FromArgb(180, 200, 220), 1))
            {
                // Around cmbUser
                Rectangle rectUser = new Rectangle(cmbUser.Left - 1, cmbUser.Top - 1, cmbUser.Width + 1, cmbUser.Height + 1);
                e.Graphics.DrawRectangle(borderPen, rectUser);

                // Around txtPassword
                Rectangle rectPass = new Rectangle(txtPassword.Left - 1, txtPassword.Top - 1, txtPassword.Width + 1, txtPassword.Height + 1);
                e.Graphics.DrawRectangle(borderPen, rectPass);
            }
        }

        private bool _updatingSelectAll;
        private void chkPortSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (_updatingSelectAll)
                return;

            _updatingSelectAll = true;

            for (int i = 0; i < clbPorts.Items.Count; i++)
            {
                clbPorts.SetItemChecked(i, chkPortSelectAll.Checked);
            }

            _updatingSelectAll = false;
        }

        private void clbPorts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_updatingSelectAll)
                return;

            BeginInvoke(new Action(() =>
            {
                _updatingSelectAll = true;

                chkPortSelectAll.Checked =
                    clbPorts.CheckedItems.Count == clbPorts.Items.Count;

                _updatingSelectAll = false;
            }));
        }

        private void clbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
