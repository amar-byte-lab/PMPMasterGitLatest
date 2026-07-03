namespace CabconPMP
{
    partial class frmLoginMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLoginControl = new System.Windows.Forms.Panel();
            this.chkPortSelectAll = new System.Windows.Forms.CheckBox();
            this.clbPorts = new System.Windows.Forms.CheckedListBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtBenchId = new CabconPMP.TransparentTextBox();
            this.lblBenchId = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new CabconPMP.TransparentTextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelLoginControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::CabconPMP.Properties.Resources.login_page;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 458);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // PanelLoginControl
            // 
            this.PanelLoginControl.BackColor = System.Drawing.Color.White;
            this.PanelLoginControl.BackgroundImage = global::CabconPMP.Properties.Resources.Background;
            this.PanelLoginControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLoginControl.Controls.Add(this.cmbUser);
            this.PanelLoginControl.Controls.Add(this.chkPortSelectAll);
            this.PanelLoginControl.Controls.Add(this.clbPorts);
            this.PanelLoginControl.Controls.Add(this.lblPort);
            this.PanelLoginControl.Controls.Add(this.txtBenchId);
            this.PanelLoginControl.Controls.Add(this.lblBenchId);
            this.PanelLoginControl.Controls.Add(this.btnLogin);
            this.PanelLoginControl.Controls.Add(this.btnClose);
            this.PanelLoginControl.Controls.Add(this.label3);
            this.PanelLoginControl.Controls.Add(this.label2);
            this.PanelLoginControl.Controls.Add(this.txtPassword);
            this.PanelLoginControl.Location = new System.Drawing.Point(379, 146);
            this.PanelLoginControl.Name = "PanelLoginControl";
            this.PanelLoginControl.Size = new System.Drawing.Size(303, 283);
            this.PanelLoginControl.TabIndex = 23;
            // 
            // chkPortSelectAll
            // 
            this.chkPortSelectAll.AutoSize = true;
            this.chkPortSelectAll.Location = new System.Drawing.Point(96, 133);
            this.chkPortSelectAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPortSelectAll.Name = "chkPortSelectAll";
            this.chkPortSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkPortSelectAll.TabIndex = 24;
            this.chkPortSelectAll.Text = "Select All";
            this.chkPortSelectAll.UseVisualStyleBackColor = true;
            this.chkPortSelectAll.CheckedChanged += new System.EventHandler(this.chkPortSelectAll_CheckedChanged);
            // 
            // clbPorts
            // 
            this.clbPorts.FormattingEnabled = true;
            this.clbPorts.Location = new System.Drawing.Point(96, 67);
            this.clbPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbPorts.Name = "clbPorts";
            this.clbPorts.Size = new System.Drawing.Size(168, 64);
            this.clbPorts.TabIndex = 23;
            this.clbPorts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPorts_ItemCheck);
            this.clbPorts.SelectedIndexChanged += new System.EventHandler(this.clbPorts_SelectedIndexChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(23, 67);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(59, 13);
            this.lblPort.TabIndex = 20;
            this.lblPort.Text = "Select Port";
            // 
            // txtBenchId
            // 
            this.txtBenchId.BackColor = System.Drawing.Color.Transparent;
            this.txtBenchId.Location = new System.Drawing.Point(96, 154);
            this.txtBenchId.MaxLength = 16;
            this.txtBenchId.Name = "txtBenchId";
            this.txtBenchId.Size = new System.Drawing.Size(168, 20);
            this.txtBenchId.TabIndex = 19;
            // 
            // lblBenchId
            // 
            this.lblBenchId.AutoSize = true;
            this.lblBenchId.BackColor = System.Drawing.Color.Transparent;
            this.lblBenchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchId.Location = new System.Drawing.Point(23, 156);
            this.lblBenchId.Name = "lblBenchId";
            this.lblBenchId.Size = new System.Drawing.Size(52, 13);
            this.lblBenchId.TabIndex = 18;
            this.lblBenchId.Text = "Bench ID";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(96, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(188, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "User ID";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Location = new System.Drawing.Point(96, 199);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(96, 177);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(167, 21);
            this.cmbUser.TabIndex = 25;
            // 
            // frmLoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 458);
            this.Controls.Add(this.PanelLoginControl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cabcon PMP";
            this.Load += new System.EventHandler(this.frmLoginMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelLoginControl.ResumeLayout(false);
            this.PanelLoginControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelLoginControl;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CabconPMP.TransparentTextBox txtPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TransparentTextBox txtBenchId;
        private System.Windows.Forms.Label lblBenchId;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.CheckedListBox clbPorts;
        private System.Windows.Forms.CheckBox chkPortSelectAll;
        private System.Windows.Forms.ComboBox cmbUser;
    }
}

