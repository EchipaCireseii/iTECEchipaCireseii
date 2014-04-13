namespace iTEC_Cireseii
{
    partial class ModifyUserGroups
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
            this.initialGroupLabel = new System.Windows.Forms.Label();
            this.initialGroupTextBox = new System.Windows.Forms.TextBox();
            this.newGroupTextBox = new System.Windows.Forms.TextBox();
            this.newGroupLabel = new System.Windows.Forms.Label();
            this.groupListBox = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Strip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialGroupLabel
            // 
            this.initialGroupLabel.AutoSize = true;
            this.initialGroupLabel.Location = new System.Drawing.Point(12, 9);
            this.initialGroupLabel.Name = "initialGroupLabel";
            this.initialGroupLabel.Size = new System.Drawing.Size(100, 13);
            this.initialGroupLabel.TabIndex = 0;
            this.initialGroupLabel.Text = "Initial Group Name :";
            // 
            // initialGroupTextBox
            // 
            this.initialGroupTextBox.Location = new System.Drawing.Point(118, 6);
            this.initialGroupTextBox.Name = "initialGroupTextBox";
            this.initialGroupTextBox.Size = new System.Drawing.Size(152, 20);
            this.initialGroupTextBox.TabIndex = 1;
            // 
            // newGroupTextBox
            // 
            this.newGroupTextBox.Location = new System.Drawing.Point(118, 28);
            this.newGroupTextBox.Name = "newGroupTextBox";
            this.newGroupTextBox.Size = new System.Drawing.Size(152, 20);
            this.newGroupTextBox.TabIndex = 3;
            // 
            // newGroupLabel
            // 
            this.newGroupLabel.AutoSize = true;
            this.newGroupLabel.Location = new System.Drawing.Point(14, 31);
            this.newGroupLabel.Name = "newGroupLabel";
            this.newGroupLabel.Size = new System.Drawing.Size(98, 13);
            this.newGroupLabel.TabIndex = 2;
            this.newGroupLabel.Text = "New Group Name :";
            // 
            // groupListBox
            // 
            this.groupListBox.FormattingEnabled = true;
            this.groupListBox.Location = new System.Drawing.Point(15, 58);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(255, 147);
            this.groupListBox.TabIndex = 4;
            this.groupListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupListBox_MouseDown);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(15, 227);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(195, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Strip1
            // 
            this.Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.Strip1.Name = "Strip1";
            this.Strip1.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ModifyUserGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.newGroupTextBox);
            this.Controls.Add(this.newGroupLabel);
            this.Controls.Add(this.initialGroupTextBox);
            this.Controls.Add(this.initialGroupLabel);
            this.Name = "ModifyUserGroups";
            this.Text = "Modify User Groups";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyUserGroups_FormClosing);
            this.Load += new System.EventHandler(this.ModifyUserGroups_Load);
            this.Strip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initialGroupLabel;
        private System.Windows.Forms.TextBox initialGroupTextBox;
        private System.Windows.Forms.TextBox newGroupTextBox;
        private System.Windows.Forms.Label newGroupLabel;
        private System.Windows.Forms.ListBox groupListBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ContextMenuStrip Strip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}