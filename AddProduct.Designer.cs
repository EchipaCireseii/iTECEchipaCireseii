namespace iTEC_Cireseii
{
    partial class AddProduct
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.pointstextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.imageLocationBox = new System.Windows.Forms.TextBox();
            this.imageLocationLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(12, 35);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(36, 13);
            this.groupLabel.TabIndex = 1;
            this.groupLabel.Text = "Group";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(12, 60);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(36, 13);
            this.pointsLabel.TabIndex = 2;
            this.pointsLabel.Text = "Points";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(68, 6);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(173, 20);
            this.nametextBox.TabIndex = 3;
            // 
            // pointstextBox
            // 
            this.pointstextBox.Location = new System.Drawing.Point(68, 60);
            this.pointstextBox.Name = "pointstextBox";
            this.pointstextBox.Size = new System.Drawing.Size(173, 20);
            this.pointstextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 149);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 30);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(137, 149);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 30);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // imageLocationBox
            // 
            this.imageLocationBox.Location = new System.Drawing.Point(12, 109);
            this.imageLocationBox.Name = "imageLocationBox";
            this.imageLocationBox.Size = new System.Drawing.Size(229, 20);
            this.imageLocationBox.TabIndex = 9;
            // 
            // imageLocationLabel
            // 
            this.imageLocationLabel.AutoSize = true;
            this.imageLocationLabel.Location = new System.Drawing.Point(85, 93);
            this.imageLocationLabel.Name = "imageLocationLabel";
            this.imageLocationLabel.Size = new System.Drawing.Size(80, 13);
            this.imageLocationLabel.TabIndex = 8;
            this.imageLocationLabel.Text = "Image Location";
            // 
            // groupBox
            // 
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(68, 33);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(173, 21);
            this.groupBox.TabIndex = 10;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 191);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.imageLocationBox);
            this.Controls.Add(this.imageLocationLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pointstextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox pointstextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox imageLocationBox;
        private System.Windows.Forms.Label imageLocationLabel;
        private System.Windows.Forms.ComboBox groupBox;
    }
}