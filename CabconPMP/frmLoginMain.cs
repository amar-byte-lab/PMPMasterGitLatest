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
            
            this.txtBenchId.BackColor = System.Drawing.Color.Transparent;
            this.txtBenchId.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.btnUserDropdown.BackColor = System.Drawing.Color.Transparent;
            this.flpPorts.BackColor = System.Drawing.Color.Transparent;

            // Button styling
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(31, 58, 96); // Cabcon dark blue
            this.btnLogin.ForeColor = System.Drawing.Color.White;

            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 96);
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(31, 58, 96);

            _personRepository = personRepository;

             LoadOperators();
        }

        private ContextMenuStrip userMenu = new ContextMenuStrip();

        private async void LoadOperators()
        {
            try
            {
                var users = await _personRepository.GetAllAsync();
                userMenu.Items.Clear();
                foreach (var user in users)
                {
                    userMenu.Items.Add(user.Name, null, (s, e) => { txtUser.Text = user.Name; });
                }
                if (userMenu.Items.Count > 0) txtUser.Text = userMenu.Items[0].Text;

                txtUser.Click += (s, e) => ShowUserMenu();
                btnUserDropdown.Click += (s, e) => ShowUserMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading operators: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowUserMenu()
        {
            userMenu.Show(txtUser, new Point(0, txtUser.Height));
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BALUserManagement objum = new BALUserManagement();
            try
            {
                string username = txtUser.Text.Trim();
                string password = "supervisor";//txtPassword.Text.Trim();

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

                    List<string> selectedPorts = new List<string>();
                    foreach (Control ctrl in flpPorts.Controls)
                    {
                        if (ctrl is CheckBox cb && cb.Checked)
                            selectedPorts.Add(cb.Text);
                    }
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
            flpPorts.Controls.Clear();
            foreach (string Port in PortNames) 
            {
                CheckBox cb = new CheckBox();
                cb.Text = Port;
                cb.AutoSize = true;
                cb.BackColor = Color.Transparent;
                cb.CheckedChanged += clbPorts_ItemCheck;
                flpPorts.Controls.Add(cb);
            }

            Point panelLoc = PanelLoginControl.Location;
            PanelLoginControl.Parent = pictureBox1;
            PanelLoginControl.Location = panelLoc;
            txtUser.Focus();
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
            // Draw a stylish 1px border around the transparent controls
            using (Pen borderPen = new Pen(Color.FromArgb(180, 200, 220), 1))
            {
                // Around txtUser
                Rectangle rectUser = new Rectangle(txtUser.Left - 1, txtUser.Top - 1, 248 + 1, txtUser.Height + 1);
                e.Graphics.DrawRectangle(borderPen, rectUser);

                // Around txtPassword
                Rectangle rectPass = new Rectangle(txtPassword.Left - 1, txtPassword.Top - 1, txtPassword.Width + 1, txtPassword.Height + 1);
                e.Graphics.DrawRectangle(borderPen, rectPass);

                // Around txtBenchId
                Rectangle rectBench = new Rectangle(txtBenchId.Left - 1, txtBenchId.Top - 1, txtBenchId.Width + 1, txtBenchId.Height + 1);
                e.Graphics.DrawRectangle(borderPen, rectBench);

                // Around flpPorts
                Rectangle rectPorts = new Rectangle(flpPorts.Left - 1, flpPorts.Top - 1, flpPorts.Width + 1, flpPorts.Height + 1);
                e.Graphics.DrawRectangle(borderPen, rectPorts);
            }
        }

        private bool _updatingSelectAll;
        private void chkPortSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (_updatingSelectAll) return;

            _updatingSelectAll = true;
            foreach (Control ctrl in flpPorts.Controls)
            {
                if (ctrl is CheckBox cb) cb.Checked = chkPortSelectAll.Checked;
            }
            _updatingSelectAll = false;
        }

        private void clbPorts_ItemCheck(object sender, EventArgs e)
        {
            if (_updatingSelectAll) return;

            BeginInvoke(new Action(() =>
            {
                _updatingSelectAll = true;
                int checkedCount = 0;
                int totalCount = 0;
                foreach (Control ctrl in flpPorts.Controls)
                {
                    if (ctrl is CheckBox cb)
                    {
                        totalCount++;
                        if (cb.Checked) checkedCount++;
                    }
                }
                chkPortSelectAll.Checked = (checkedCount == totalCount && totalCount > 0);
                _updatingSelectAll = false;
            }));
        }

        private void clbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
