namespace iTEC_Cireseii
{
    partial class ModifyProduct
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
            this.delightLabel = new System.Windows.Forms.Label();
            this.delightBox = new System.Windows.Forms.TextBox();
            this.SearchProductGridView = new System.Windows.Forms.DataGridView();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.newGroupBox = new System.Windows.Forms.TextBox();
            this.newGroupLabel = new System.Windows.Forms.Label();
            this.newPointsBox = new System.Windows.Forms.TextBox();
            this.newPointsLabel = new System.Windows.Forms.Label();
            this.newImageBox = new System.Windows.Forms.TextBox();
            this.newImageLocationLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SearchProductGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // delightLabel
            // 
            this.delightLabel.AutoSize = true;
            this.delightLabel.Location = new System.Drawing.Point(12, 9);
            this.delightLabel.Name = "delightLabel";
            this.delightLabel.Size = new System.Drawing.Size(46, 13);
            this.delightLabel.TabIndex = 0;
            this.delightLabel.Text = "Delight :";
            // 
            // delightBox
            // 
            this.delightBox.Location = new System.Drawing.Point(64, 6);
            this.delightBox.Name = "delightBox";
            this.delightBox.Size = new System.Drawing.Size(158, 20);
            this.delightBox.TabIndex = 1;
            this.delightBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchProductGridView
            // 
            this.SearchProductGridView.AllowUserToAddRows = false;
            this.SearchProductGridView.AllowUserToDeleteRows = false;
            this.SearchProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchProductGridView.Location = new System.Drawing.Point(12, 32);
            this.SearchProductGridView.Name = "SearchProductGridView";
            this.SearchProductGridView.ReadOnly = true;
            this.SearchProductGridView.RowHeadersVisible = false;
            this.SearchProductGridView.Size = new System.Drawing.Size(210, 218);
            this.SearchProductGridView.TabIndex = 2;
            this.SearchProductGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SearchProductGridView_CellMouseDown);
            // 
            // newNameBox
            // 
            this.newNameBox.Location = new System.Drawing.Point(297, 32);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(100, 20);
            this.newNameBox.TabIndex = 4;
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Location = new System.Drawing.Point(226, 35);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(66, 13);
            this.newNameLabel.TabIndex = 3;
            this.newNameLabel.Text = "New Name :";
            // 
            // newGroupBox
            // 
            this.newGroupBox.Location = new System.Drawing.Point(297, 58);
            this.newGroupBox.Name = "newGroupBox";
            this.newGroupBox.Size = new System.Drawing.Size(100, 20);
            this.newGroupBox.TabIndex = 6;
            // 
            // newGroupLabel
            // 
            this.newGroupLabel.AutoSize = true;
            this.newGroupLabel.Location = new System.Drawing.Point(225, 61);
            this.newGroupLabel.Name = "newGroupLabel";
            this.newGroupLabel.Size = new System.Drawing.Size(67, 13);
            this.newGroupLabel.TabIndex = 5;
            this.newGroupLabel.Text = "New Group :";
            // 
            // newPointsBox
            // 
            this.newPointsBox.Location = new System.Drawing.Point(298, 84);
            this.newPointsBox.Name = "newPointsBox";
            this.newPointsBox.Size = new System.Drawing.Size(100, 20);
            this.newPointsBox.TabIndex = 8;
            // 
            // newPointsLabel
            // 
            this.newPointsLabel.AutoSize = true;
            this.newPointsLabel.Location = new System.Drawing.Point(226, 87);
            this.newPointsLabel.Name = "newPointsLabel";
            this.newPointsLabel.Size = new System.Drawing.Size(67, 13);
            this.newPointsLabel.TabIndex = 7;
            this.newPointsLabel.Text = "New Points :";
            // 
            // newImageBox
            // 
            this.newImageBox.Location = new System.Drawing.Point(229, 123);
            this.newImageBox.Name = "newImageBox";
            this.newImageBox.Size = new System.Drawing.Size(169, 20);
            this.newImageBox.TabIndex = 10;
            // 
            // newImageLocationLabel
            // 
            this.newImageLocationLabel.AutoSize = true;
            this.newImageLocationLabel.Location = new System.Drawing.Point(247, 107);
            this.newImageLocationLabel.Name = "newImageLocationLabel";
            this.newImageLocationLabel.Size = new System.Drawing.Size(111, 13);
            this.newImageLocationLabel.TabIndex = 9;
            this.newImageLocationLabel.Text = "New Image Location :";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(229, 149);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(323, 149);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newImageBox);
            this.Controls.Add(this.newImageLocationLabel);
            this.Controls.Add(this.newPointsBox);
            this.Controls.Add(this.newPointsLabel);
            this.Controls.Add(this.newGroupBox);
            this.Controls.Add(this.newGroupLabel);
            this.Controls.Add(this.newNameBox);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.SearchProductGridView);
            this.Controls.Add(this.delightBox);
            this.Controls.Add(this.delightLabel);
            this.Name = "ModifyProduct";
            this.Text = "Modify Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyProduct_FormClosing);
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchProductGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label delightLabel;
        private System.Windows.Forms.TextBox delightBox;
        private System.Windows.Forms.DataGridView SearchProductGridView;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.TextBox newGroupBox;
        private System.Windows.Forms.Label newGroupLabel;
        private System.Windows.Forms.TextBox newPointsBox;
        private System.Windows.Forms.Label newPointsLabel;
        private System.Windows.Forms.TextBox newImageBox;
        private System.Windows.Forms.Label newImageLocationLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}