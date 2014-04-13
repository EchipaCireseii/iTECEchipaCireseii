namespace iTEC_Cireseii
{
    partial class ModifyDelightGroups
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
            this.groupListBox = new System.Windows.Forms.ListBox();
            this.newBox = new System.Windows.Forms.TextBox();
            this.newGroupLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.delightBox = new System.Windows.Forms.TextBox();
            this.initialGroupLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupListBox
            // 
            this.groupListBox.FormattingEnabled = true;
            this.groupListBox.Location = new System.Drawing.Point(15, 69);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(236, 134);
            this.groupListBox.TabIndex = 2;
            this.groupListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupListBox_MouseDown);
            // 
            // newBox
            // 
            this.newBox.Location = new System.Drawing.Point(97, 35);
            this.newBox.Name = "newBox";
            this.newBox.Size = new System.Drawing.Size(154, 20);
            this.newBox.TabIndex = 4;
            // 
            // newGroupLabel
            // 
            this.newGroupLabel.AutoSize = true;
            this.newGroupLabel.Location = new System.Drawing.Point(26, 38);
            this.newGroupLabel.Name = "newGroupLabel";
            this.newGroupLabel.Size = new System.Drawing.Size(67, 13);
            this.newGroupLabel.TabIndex = 3;
            this.newGroupLabel.Text = "New Group :";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 209);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(176, 209);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // delightBox
            // 
            this.delightBox.Location = new System.Drawing.Point(97, 10);
            this.delightBox.Name = "delightBox";
            this.delightBox.Size = new System.Drawing.Size(154, 20);
            this.delightBox.TabIndex = 1;
            // 
            // initialGroupLabel
            // 
            this.initialGroupLabel.AutoSize = true;
            this.initialGroupLabel.Location = new System.Drawing.Point(24, 17);
            this.initialGroupLabel.Name = "initialGroupLabel";
            this.initialGroupLabel.Size = new System.Drawing.Size(69, 13);
            this.initialGroupLabel.TabIndex = 0;
            this.initialGroupLabel.Text = "Initial Group :";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ModifyDelightGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 244);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newBox);
            this.Controls.Add(this.newGroupLabel);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.delightBox);
            this.Controls.Add(this.initialGroupLabel);
            this.Name = "ModifyDelightGroups";
            this.Text = "Modify Delight Groups";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyDelightGroups_FormClosing);
            this.Load += new System.EventHandler(this.ModifyDelightGroups_Load);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groupListBox;
        private System.Windows.Forms.TextBox newBox;
        private System.Windows.Forms.Label newGroupLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox delightBox;
        private System.Windows.Forms.Label initialGroupLabel;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}