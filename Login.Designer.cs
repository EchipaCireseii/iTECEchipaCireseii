namespace iTEC_Cireseii
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.userLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginBut = new System.Windows.Forms.Button();
            this.ukLanguage = new System.Windows.Forms.PictureBox();
            this.roLanguage = new System.Windows.Forms.PictureBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ukLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(6, 16);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(58, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginBut);
            this.groupBox1.Controls.Add(this.ukLanguage);
            this.groupBox1.Controls.Add(this.roLanguage);
            this.groupBox1.Controls.Add(this.languageLabel);
            this.groupBox1.Controls.Add(this.passBox);
            this.groupBox1.Controls.Add(this.userBox);
            this.groupBox1.Controls.Add(this.passLabel);
            this.groupBox1.Controls.Add(this.userLabel);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // loginBut
            // 
            this.loginBut.Location = new System.Drawing.Point(114, 68);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(56, 23);
            this.loginBut.TabIndex = 2;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = true;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // ukLanguage
            // 
            this.ukLanguage.Image = ((System.Drawing.Image)(resources.GetObject("ukLanguage.Image")));
            this.ukLanguage.Location = new System.Drawing.Point(92, 73);
            this.ukLanguage.Name = "ukLanguage";
            this.ukLanguage.Size = new System.Drawing.Size(16, 16);
            this.ukLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ukLanguage.TabIndex = 5;
            this.ukLanguage.TabStop = false;
            this.ukLanguage.Click += new System.EventHandler(this.ukLanguage_Click);
            // 
            // roLanguage
            // 
            this.roLanguage.Image = ((System.Drawing.Image)(resources.GetObject("roLanguage.Image")));
            this.roLanguage.Location = new System.Drawing.Point(70, 73);
            this.roLanguage.Name = "roLanguage";
            this.roLanguage.Size = new System.Drawing.Size(16, 16);
            this.roLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roLanguage.TabIndex = 2;
            this.roLanguage.TabStop = false;
            this.roLanguage.Click += new System.EventHandler(this.roLanguage_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(6, 73);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(58, 13);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "Language:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(70, 39);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 3;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(70, 13);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 20);
            this.userBox.TabIndex = 2;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(6, 42);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(56, 13);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 130);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ukLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roLanguage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ukLanguage;
        private System.Windows.Forms.PictureBox roLanguage;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginBut;
    }
}

