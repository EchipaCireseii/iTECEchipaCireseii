using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTEC_Cireseii
{
    public partial class WelcomePage : Form
    {
        private string language = "";
        public WelcomePage(string _language)
        {
            InitializeComponent();
            language = _language;
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            if (language == "ro") { this.Text = "Pagină de Bun Venit"; }
            else {this.Text="Welcome Page";}
            this.richTextBox1.Font = new Font("Bauhaus Std", 16, FontStyle.Bold);
            this.richTextBox1.BackColor = Color.FromArgb(221, 221, 221);
            this.richTextBox1.BorderStyle = BorderStyle.None;
            this.richTextBox1.ForeColor = Color.Orange;
            this.richTextBox1.Text = MySQL.GetWelcomeMessage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
