namespace iTEC_Cireseii
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.menuControl = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.verifyTimer = new System.Windows.Forms.Timer(this.components);
            this.voteBoxUnclicked = new System.Windows.Forms.PictureBox();
            this.voteBoxClicked = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.voteBoxUnclicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBoxClicked)).BeginInit();
            this.SuspendLayout();
            // 
            // menuControl
            // 
            this.menuControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.menuControl.Location = new System.Drawing.Point(12, 137);
            this.menuControl.Name = "menuControl";
            this.menuControl.SelectedIndex = 0;
            this.menuControl.Size = new System.Drawing.Size(418, 362);
            this.menuControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // userBox
            // 
            this.userBox.AutoSize = true;
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userBox.Location = new System.Drawing.Point(99, 9);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(0, 20);
            this.userBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points:";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pointsLabel.Location = new System.Drawing.Point(99, 40);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(0, 20);
            this.pointsLabel.TabIndex = 4;
            // 
            // verifyTimer
            // 
            this.verifyTimer.Enabled = true;
            this.verifyTimer.Interval = 500;
            this.verifyTimer.Tick += new System.EventHandler(this.verifyTimer_Tick);
            // 
            // voteBoxUnclicked
            // 
            this.voteBoxUnclicked.Image = ((System.Drawing.Image)(resources.GetObject("voteBoxUnclicked.Image")));
            this.voteBoxUnclicked.Location = new System.Drawing.Point(16, 63);
            this.voteBoxUnclicked.Name = "voteBoxUnclicked";
            this.voteBoxUnclicked.Size = new System.Drawing.Size(137, 68);
            this.voteBoxUnclicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voteBoxUnclicked.TabIndex = 5;
            this.voteBoxUnclicked.TabStop = false;
            this.voteBoxUnclicked.Click += new System.EventHandler(this.voteBoxUnclicked_Click);
            // 
            // voteBoxClicked
            // 
            this.voteBoxClicked.Image = ((System.Drawing.Image)(resources.GetObject("voteBoxClicked.Image")));
            this.voteBoxClicked.Location = new System.Drawing.Point(16, 63);
            this.voteBoxClicked.Name = "voteBoxClicked";
            this.voteBoxClicked.Size = new System.Drawing.Size(137, 68);
            this.voteBoxClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voteBoxClicked.TabIndex = 6;
            this.voteBoxClicked.TabStop = false;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 510);
            this.Controls.Add(this.voteBoxClicked);
            this.Controls.Add(this.voteBoxUnclicked);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuControl);
            this.Name = "UserPage";
            this.Text = "User main page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPage_FormClosing);
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voteBoxUnclicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBoxClicked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl menuControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Timer verifyTimer;
        private System.Windows.Forms.PictureBox voteBoxUnclicked;
        private System.Windows.Forms.PictureBox voteBoxClicked;
    }
}