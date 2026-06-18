namespace CabconPMP
{
    partial class frmConfiguration
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblSave = new System.Windows.Forms.ToolStripLabel();
            this.lblReset = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblClose = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox70 = new System.Windows.Forms.GroupBox();
            this.lblDisplayParaTotalSelected = new System.Windows.Forms.Label();
            this.lstDisplayAutoAll = new System.Windows.Forms.ListBox();
            this.btnDispAutoMoveDown = new System.Windows.Forms.Button();
            this.btnDispAutoMoveUP = new System.Windows.Forms.Button();
            this.label241 = new System.Windows.Forms.Label();
            this.label242 = new System.Windows.Forms.Label();
            this.btnDispAutoMove = new System.Windows.Forms.Button();
            this.btnDispAutoRemove = new System.Windows.Forms.Button();
            this.btnDispAutoRemoveAll = new System.Windows.Forms.Button();
            this.btnDispAutoMoveAll = new System.Windows.Forms.Button();
            this.lstDisplatAutoSelected = new System.Windows.Forms.ListBox();
            this.label243 = new System.Windows.Forms.Label();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.groupBox70.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSave,
            this.toolStripSeparator3,
            this.lblReset,
            this.toolStripSeparator2,
            this.lblClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1267, 33);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblSave
            // 
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(53, 28);
            this.lblSave.Text = "Save";
            this.lblSave.ToolTipText = "Save Configuration File As *.cfg";
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblReset
            // 
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(58, 28);
            this.lblReset.Text = "Reset";
            this.lblReset.ToolTipText = "Reset Configuration Screen";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // lblClose
            // 
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(59, 28);
            this.lblClose.Text = "Close";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox70
            // 
            this.groupBox70.Controls.Add(this.lblDisplayParaTotalSelected);
            this.groupBox70.Controls.Add(this.lstDisplayAutoAll);
            this.groupBox70.Controls.Add(this.btnDispAutoMoveDown);
            this.groupBox70.Controls.Add(this.btnDispAutoMoveUP);
            this.groupBox70.Controls.Add(this.label241);
            this.groupBox70.Controls.Add(this.label242);
            this.groupBox70.Controls.Add(this.btnDispAutoMove);
            this.groupBox70.Controls.Add(this.btnDispAutoRemove);
            this.groupBox70.Controls.Add(this.btnDispAutoRemoveAll);
            this.groupBox70.Controls.Add(this.btnDispAutoMoveAll);
            this.groupBox70.Controls.Add(this.lstDisplatAutoSelected);
            this.groupBox70.Location = new System.Drawing.Point(47, 159);
            this.groupBox70.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox70.Name = "groupBox70";
            this.groupBox70.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox70.Size = new System.Drawing.Size(1172, 579);
            this.groupBox70.TabIndex = 17;
            this.groupBox70.TabStop = false;
            // 
            // lblDisplayParaTotalSelected
            // 
            this.lblDisplayParaTotalSelected.AutoSize = true;
            this.lblDisplayParaTotalSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayParaTotalSelected.Location = new System.Drawing.Point(526, 438);
            this.lblDisplayParaTotalSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayParaTotalSelected.Name = "lblDisplayParaTotalSelected";
            this.lblDisplayParaTotalSelected.Size = new System.Drawing.Size(113, 17);
            this.lblDisplayParaTotalSelected.TabIndex = 44;
            this.lblDisplayParaTotalSelected.Text = "Total Selected";
            // 
            // lstDisplayAutoAll
            // 
            this.lstDisplayAutoAll.FormattingEnabled = true;
            this.lstDisplayAutoAll.ItemHeight = 20;
            this.lstDisplayAutoAll.Location = new System.Drawing.Point(9, 55);
            this.lstDisplayAutoAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDisplayAutoAll.Name = "lstDisplayAutoAll";
            this.lstDisplayAutoAll.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDisplayAutoAll.Size = new System.Drawing.Size(511, 484);
            this.lstDisplayAutoAll.TabIndex = 43;
            // 
            // btnDispAutoMoveDown
            // 
            this.btnDispAutoMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveDown.Location = new System.Drawing.Point(584, 349);
            this.btnDispAutoMoveDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoMoveDown.Name = "btnDispAutoMoveDown";
            this.btnDispAutoMoveDown.Size = new System.Drawing.Size(30, 71);
            this.btnDispAutoMoveDown.TabIndex = 42;
            this.btnDispAutoMoveDown.Text = "v";
            this.btnDispAutoMoveDown.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveDown.Click += new System.EventHandler(this.btnDispAutoMoveDown_Click);
            // 
            // btnDispAutoMoveUP
            // 
            this.btnDispAutoMoveUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveUP.Location = new System.Drawing.Point(544, 349);
            this.btnDispAutoMoveUP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoMoveUP.Name = "btnDispAutoMoveUP";
            this.btnDispAutoMoveUP.Size = new System.Drawing.Size(30, 71);
            this.btnDispAutoMoveUP.TabIndex = 41;
            this.btnDispAutoMoveUP.Text = "^";
            this.btnDispAutoMoveUP.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveUP.Click += new System.EventHandler(this.btnDispAutoMoveUP_Click);
            // 
            // label241
            // 
            this.label241.AutoSize = true;
            this.label241.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label241.Location = new System.Drawing.Point(722, 20);
            this.label241.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(159, 20);
            this.label241.TabIndex = 40;
            this.label241.Text = "Selected Methods";
            // 
            // label242
            // 
            this.label242.AutoSize = true;
            this.label242.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label242.Location = new System.Drawing.Point(156, 20);
            this.label242.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(108, 20);
            this.label242.TabIndex = 39;
            this.label242.Text = "All Methods";
            // 
            // btnDispAutoMove
            // 
            this.btnDispAutoMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMove.Location = new System.Drawing.Point(546, 140);
            this.btnDispAutoMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoMove.Name = "btnDispAutoMove";
            this.btnDispAutoMove.Size = new System.Drawing.Size(75, 43);
            this.btnDispAutoMove.TabIndex = 36;
            this.btnDispAutoMove.Text = ">";
            this.btnDispAutoMove.UseVisualStyleBackColor = true;
            this.btnDispAutoMove.Click += new System.EventHandler(this.btnDispAutoMove_Click);
            // 
            // btnDispAutoRemove
            // 
            this.btnDispAutoRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoRemove.Location = new System.Drawing.Point(546, 245);
            this.btnDispAutoRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoRemove.Name = "btnDispAutoRemove";
            this.btnDispAutoRemove.Size = new System.Drawing.Size(75, 43);
            this.btnDispAutoRemove.TabIndex = 37;
            this.btnDispAutoRemove.Text = "<";
            this.btnDispAutoRemove.UseVisualStyleBackColor = true;
            this.btnDispAutoRemove.Click += new System.EventHandler(this.btnDispAutoRemove_Click);
            // 
            // btnDispAutoRemoveAll
            // 
            this.btnDispAutoRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoRemoveAll.Location = new System.Drawing.Point(544, 297);
            this.btnDispAutoRemoveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoRemoveAll.Name = "btnDispAutoRemoveAll";
            this.btnDispAutoRemoveAll.Size = new System.Drawing.Size(75, 43);
            this.btnDispAutoRemoveAll.TabIndex = 38;
            this.btnDispAutoRemoveAll.Text = "<<";
            this.btnDispAutoRemoveAll.UseVisualStyleBackColor = true;
            this.btnDispAutoRemoveAll.Click += new System.EventHandler(this.btnDispAutoRemoveAll_Click);
            // 
            // btnDispAutoMoveAll
            // 
            this.btnDispAutoMoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAutoMoveAll.Location = new System.Drawing.Point(546, 192);
            this.btnDispAutoMoveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAutoMoveAll.Name = "btnDispAutoMoveAll";
            this.btnDispAutoMoveAll.Size = new System.Drawing.Size(75, 43);
            this.btnDispAutoMoveAll.TabIndex = 11;
            this.btnDispAutoMoveAll.Text = ">>";
            this.btnDispAutoMoveAll.UseVisualStyleBackColor = true;
            this.btnDispAutoMoveAll.Click += new System.EventHandler(this.btnDispAutoMoveAll_Click);
            // 
            // lstDisplatAutoSelected
            // 
            this.lstDisplatAutoSelected.FormattingEnabled = true;
            this.lstDisplatAutoSelected.ItemHeight = 20;
            this.lstDisplatAutoSelected.Location = new System.Drawing.Point(651, 55);
            this.lstDisplatAutoSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDisplatAutoSelected.Name = "lstDisplatAutoSelected";
            this.lstDisplatAutoSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDisplatAutoSelected.Size = new System.Drawing.Size(511, 484);
            this.lstDisplatAutoSelected.TabIndex = 8;
            // 
            // label243
            // 
            this.label243.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label243.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label243.Location = new System.Drawing.Point(493, 95);
            this.label243.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label243.Name = "label243";
            this.label243.Size = new System.Drawing.Size(300, 25);
            this.label243.TabIndex = 46;
            this.label243.Text = "Auto Scroll Method List";
            this.label243.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 840);
            this.Controls.Add(this.label243);
            this.Controls.Add(this.groupBox70);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfiguration_FormClosing);
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox70.ResumeLayout(false);
            this.groupBox70.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox70;
        private System.Windows.Forms.Label lblDisplayParaTotalSelected;
        private System.Windows.Forms.ListBox lstDisplayAutoAll;
        private System.Windows.Forms.Button btnDispAutoMoveDown;
        private System.Windows.Forms.Button btnDispAutoMoveUP;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.Label label242;
        private System.Windows.Forms.Button btnDispAutoMove;
        private System.Windows.Forms.Button btnDispAutoRemove;
        private System.Windows.Forms.Button btnDispAutoRemoveAll;
        private System.Windows.Forms.Button btnDispAutoMoveAll;
        private System.Windows.Forms.ListBox lstDisplatAutoSelected;
        private System.Windows.Forms.Label label243;
        private System.Windows.Forms.ToolStripLabel lblSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}