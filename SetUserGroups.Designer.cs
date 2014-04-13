namespace iTEC_Cireseii
{
    partial class SetUserGroups
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
            this.components = new System.ComponentModel.Container();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBut = new System.Windows.Forms.Button();
            this.resetBut = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersListBox
            // 
            this.usersListBox.AllowDrop = true;
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(12, 12);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.usersListBox.Size = new System.Drawing.Size(170, 459);
            this.usersListBox.TabIndex = 0;
            this.usersListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.usersListBox_DragDrop);
            this.usersListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.usersListBox_DragEnter);
            this.usersListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.usersListBox_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(188, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(451, 430);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(188, 12);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(75, 23);
            this.saveBut.TabIndex = 2;
            this.saveBut.Text = "Save";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // resetBut
            // 
            this.resetBut.Location = new System.Drawing.Point(269, 12);
            this.resetBut.Name = "resetBut";
            this.resetBut.Size = new System.Drawing.Size(75, 23);
            this.resetBut.TabIndex = 3;
            this.resetBut.Text = "Reset";
            this.resetBut.UseVisualStyleBackColor = true;
            this.resetBut.Click += new System.EventHandler(this.resetBut_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePointsToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // changePointsToolStripMenuItem
            // 
            this.changePointsToolStripMenuItem.Name = "changePointsToolStripMenuItem";
            this.changePointsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changePointsToolStripMenuItem.Text = "Change Points";
            this.changePointsToolStripMenuItem.Click += new System.EventHandler(this.changePointsToolStripMenuItem_Click);
            // 
            // SetUserGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 482);
            this.Controls.Add(this.resetBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.usersListBox);
            this.Name = "SetUserGroups";
            this.Text = "Set User Groups";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetUserGroups_FormClosing);
            this.Load += new System.EventHandler(this.SetUserGroups_Load);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Button resetBut;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem changePointsToolStripMenuItem;
    }
}