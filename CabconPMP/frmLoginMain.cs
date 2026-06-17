using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BALLAYER;
using COMMONENTITY;
using LNG.Communication.SerialCommunication;
namespace CabconPMP
{
    public partial class frmLoginMain : Form
    {
        GlobalMethods objsv = new GlobalMethods();
        EntityUserManagement objetyusermgt = new EntityUserManagement();
        BALDBConnectionTest objdbcon = new BALDBConnectionTest();
        SerialComm objSerialComm = new SerialComm();
        Association association = new Association();

        int loginLimit = 3;
         public frmLoginMain()
         {
             InitializeComponent(); 
             COMMONENTITY.FormStyleHelper.Apply(this);

             // Apply visual transparency overrides after global styling
             this.PanelLoginControl.BackColor = System.Drawing.Color.Transparent;
             this.PanelLoginControl.BackgroundImage = null;
             this.PanelLoginControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
             this.PanelLoginControl.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLoginControl_Paint);

             this.txtuserID.BackColor = System.Drawing.Color.Transparent;
             this.txtuserID.BorderStyle = System.Windows.Forms.BorderStyle.None;

             this.txtPassword.BackColor = System.Drawing.Color.Transparent;
             this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
         }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BALUserManagement objum = new BALUserManagement();
            try
            {
               /* objetyusermgt.LogType = "aa";
                  frmMain objmain = new frmMain(objetyusermgt);
                objmain.Show();*/

                objetyusermgt.LoginuserID = txtuserID.Text.Trim();
                objetyusermgt.Loginpassword = txtPassword.Text.Trim();

                if (!objdbcon.IsDBFileExist())
                {
                    frmServerSettings objserversett = new frmServerSettings(false);
                    objserversett.ShowDialog();
                }

                if (!objdbcon.IsDBConnected())
                {
                    MessageBox.Show("Unable To Connect DataBase, Server May Down" + "\n" + "Please Contact System Administrator !", "Cabcon PMP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataSet ds = objum.Select_LoginUseronUserIDandPWD(objetyusermgt);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    List<string> selectedPorts = new List<string>();
                    foreach (object it in clbPorts.CheckedItems) selectedPorts.Add(it.ToString());
                    association.SaveAssociation(selectedPorts);

                    objetyusermgt.LogType = ds.Tables[0].Rows[0][2].ToString();
                    frmMain objmain = new frmMain(objetyusermgt);
                    objmain.Show();
                    this.Hide();
                }
                else
                {
                    if (loginLimit-- <= 0)
                    {
                        MessageBox.Show("Unauthorized Access, Please Contact Administrator !", "Cabcon PMP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
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
            //--------------------Set Default Settings-----------------
            association.DefaultSettings();
            //-------------------Show Custom Setting-----------------------
            association.ShowDefaultSettings();
            association.CheckAllAssociation();


            Point panelLoc = PanelLoginControl.Location;
            PanelLoginControl.Parent = pictureBox1;
            PanelLoginControl.Location = panelLoc;
            txtuserID.Focus();
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
                // Around txtuserID
                Rectangle rectUser = new Rectangle(txtuserID.Left - 1, txtuserID.Top - 1, txtuserID.Width + 1, txtuserID.Height + 1);
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
    }
}
