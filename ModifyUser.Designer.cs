namespace iTEC_Cireseii
{
    partial class ModifyUser
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
            this.userLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.SearchGridView = new System.Windows.Forms.DataGridView();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.newpassLabel = new System.Windows.Forms.Label();
            this.newGroupBox = new System.Windows.Forms.TextBox();
            this.newgroupLabel = new System.Windows.Forms.Label();
            this.newPointsBox = new System.Windows.Forms.TextBox();
            this.newpointsLabel = new System.Windows.Forms.Label();
            this.newTypeBox = new System.Windows.Forms.TextBox();
            this.newtypeLabel = new System.Windows.Forms.Label();
            this.newUserNameBox = new System.Windows.Forms.TextBox();
            this.newUserLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(13, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(66, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User Name :";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(85, 6);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 20);
            this.userTextBox.TabIndex = 1;
            this.userTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchGridView
            // 
            this.SearchGridView.AllowUserToAddRows = false;
            this.SearchGridView.AllowUserToDeleteRows = false;
            this.SearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGridView.Location = new System.Drawing.Point(12, 32);
            this.SearchGridView.Name = "SearchGridView";
            this.SearchGridView.ReadOnly = true;
            this.SearchGridView.RowHeadersVisible = false;
            this.SearchGridView.Size = new System.Drawing.Size(173, 249);
            this.SearchGridView.TabIndex = 2;
            this.SearchGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SearchGridView_CellMouseDown);
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(287, 57);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.newPasswordBox.TabIndex = 4;
            // 
            // newpassLabel
            // 
            this.newpassLabel.AutoSize = true;
            this.newpassLabel.Location = new System.Drawing.Point(190, 60);
            this.newpassLabel.Name = "newpassLabel";
            this.newpassLabel.Size = new System.Drawing.Size(84, 13);
            this.newpassLabel.TabIndex = 3;
            this.newpassLabel.Text = "New Password :";
            // 
            // newGroupBox
            // 
            this.newGroupBox.Location = new System.Drawing.Point(287, 83);
            this.newGroupBox.Name = "newGroupBox";
            this.newGroupBox.Size = new System.Drawing.Size(100, 20);
            this.newGroupBox.TabIndex = 6;
            // 
            // newgroupLabel
            // 
            this.newgroupLabel.AutoSize = true;
            this.newgroupLabel.Location = new System.Drawing.Point(190, 86);
            this.newgroupLabel.Name = "newgroupLabel";
            this.newgroupLabel.Size = new System.Drawing.Size(67, 13);
            this.newgroupLabel.TabIndex = 5;
            this.newgroupLabel.Text = "New Group :";
            // 
            // newPointsBox
            // 
            this.newPointsBox.Location = new System.Drawing.Point(287, 110);
            this.newPointsBox.Name = "newPointsBox";
            this.newPointsBox.Size = new System.Drawing.Size(100, 20);
            this.newPointsBox.TabIndex = 8;
            // 
            // newpointsLabel
            // 
            this.newpointsLabel.AutoSize = true;
            this.newpointsLabel.Location = new System.Drawing.Point(190, 113);
            this.newpointsLabel.Name = "newpointsLabel";
            this.newpointsLabel.Size = new System.Drawing.Size(67, 13);
            this.newpointsLabel.TabIndex = 7;
            this.newpointsLabel.Text = "New Points :";
            // 
            // newTypeBox
            // 
            this.newTypeBox.Location = new System.Drawing.Point(288, 136);
            this.newTypeBox.Name = "newTypeBox";
            this.newTypeBox.Size = new System.Drawing.Size(100, 20);
            this.newTypeBox.TabIndex = 10;
            // 
            // newtypeLabel
            // 
            this.newtypeLabel.AutoSize = true;
            this.newtypeLabel.Location = new System.Drawing.Point(190, 139);
            this.newtypeLabel.Name = "newtypeLabel";
            this.newtypeLabel.Size = new System.Drawing.Size(62, 13);
            this.newtypeLabel.TabIndex = 9;
            this.newtypeLabel.Text = "New Type :";
            // 
            // newUserNameBox
            // 
            this.newUserNameBox.Location = new System.Drawing.Point(287, 32);
            this.newUserNameBox.Name = "newUserNameBox";
            this.newUserNameBox.Size = new System.Drawing.Size(100, 20);
            this.newUserNameBox.TabIndex = 12;
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Location = new System.Drawing.Point(190, 35);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(91, 13);
            this.newUserLabel.TabIndex = 11;
            this.newUserLabel.Text = "New User Name :";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(191, 165);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(81, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(307, 165);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 288);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newUserNameBox);
            this.Controls.Add(this.newUserLabel);
            this.Controls.Add(this.newTypeBox);
            this.Controls.Add(this.newtypeLabel);
            this.Controls.Add(this.newPointsBox);
            this.Controls.Add(this.newpointsLabel);
            this.Controls.Add(this.newGroupBox);
            this.Controls.Add(this.newgroupLabel);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.newpassLabel);
            this.Controls.Add(this.SearchGridView);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userLabel);
            this.Name = "ModifyUser";
            this.Text = "Modify User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyUser_FormClosing);
            this.Load += new System.EventHandler(this.ModifyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.DataGridView SearchGridView;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.Label newpassLabel;
        private System.Windows.Forms.TextBox newGroupBox;
        private System.Windows.Forms.Label newgroupLabel;
        private System.Windows.Forms.TextBox newPointsBox;
        private System.Windows.Forms.Label newpointsLabel;
        private System.Windows.Forms.TextBox newTypeBox;
        private System.Windows.Forms.Label newtypeLabel;
        private System.Windows.Forms.TextBox newUserNameBox;
        private System.Windows.Forms.Label newUserLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}