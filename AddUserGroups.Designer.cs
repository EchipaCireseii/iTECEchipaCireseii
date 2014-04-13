namespace iTEC_Cireseii
{
    partial class AddUserGroups
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
            this.userGroupsListBox = new System.Windows.Forms.ListBox();
            this.newGroupBox = new System.Windows.Forms.TextBox();
            this.newGroupLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.pointsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userGroupsListBox
            // 
            this.userGroupsListBox.FormattingEnabled = true;
            this.userGroupsListBox.Location = new System.Drawing.Point(12, 97);
            this.userGroupsListBox.Name = "userGroupsListBox";
            this.userGroupsListBox.Size = new System.Drawing.Size(246, 199);
            this.userGroupsListBox.TabIndex = 0;
            // 
            // newGroupBox
            // 
            this.newGroupBox.Location = new System.Drawing.Point(82, 6);
            this.newGroupBox.Name = "newGroupBox";
            this.newGroupBox.Size = new System.Drawing.Size(176, 20);
            this.newGroupBox.TabIndex = 1;
            // 
            // newGroupLabel
            // 
            this.newGroupLabel.AutoSize = true;
            this.newGroupLabel.Location = new System.Drawing.Point(12, 9);
            this.newGroupLabel.Name = "newGroupLabel";
            this.newGroupLabel.Size = new System.Drawing.Size(64, 13);
            this.newGroupLabel.TabIndex = 2;
            this.newGroupLabel.Text = "New Group:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(12, 35);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(39, 13);
            this.pointsLabel.TabIndex = 5;
            this.pointsLabel.Text = "Points:";
            // 
            // pointsBox
            // 
            this.pointsBox.Location = new System.Drawing.Point(82, 32);
            this.pointsBox.Name = "pointsBox";
            this.pointsBox.Size = new System.Drawing.Size(176, 20);
            this.pointsBox.TabIndex = 4;
            // 
            // AddUserGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 312);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.pointsBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newGroupLabel);
            this.Controls.Add(this.newGroupBox);
            this.Controls.Add(this.userGroupsListBox);
            this.Name = "AddUserGroups";
            this.Text = "AddUserGroups";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUserGroups_FormClosing);
            this.Load += new System.EventHandler(this.AddUserGroups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userGroupsListBox;
        private System.Windows.Forms.TextBox newGroupBox;
        private System.Windows.Forms.Label newGroupLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TextBox pointsBox;
    }
}