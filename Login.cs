using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace iTEC_Cireseii
{
    public partial class Login : Form
    {
        private string language = "uk";

        public Login()
        {
            InitializeComponent();
        }

        private void roLanguage_Click(object sender, EventArgs e)
        {
            language = "ro";
            languageLabel.Text = "Limbă";
            userLabel.Text = "Utilizator:";
            passLabel.Text = "Parolă:";
            loginBut.Text = "Logare";
            this.Text = "Logare";
        }

        private void ukLanguage_Click(object sender, EventArgs e)
        {
            language = "uk";
            languageLabel.Text = "Language";
            userLabel.Text = "User:";
            passLabel.Text = "Password:";
            loginBut.Text = "Login";
            this.Text = "Login";
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            if (!MySQL.VerifyUser(userBox.Text, passBox.Text))
                if (language == "uk")
                    MessageBox.Show("Username/Password incorect");
                else
                    MessageBox.Show("Utilizator/Parola incorecta");
            else
            {
                if (MySQL.GetUserType(userBox.Text, passBox.Text) == "admin")
                {
                    AdminPage adminPage = new AdminPage(language);
                    adminPage.Show();
                    this.Hide();
                }
                else
                {
                    UserPage userPage = new UserPage(userBox.Text,language);
                    userPage.Show();
                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!File.Exists("config.cfg"))
            {
                MessageBox.Show("Fisierul config.cfg nu a fost gasit. Veti fi redirectionat catre configurarea acestuia.");
                Config config = new Config(language, this);
                config.Show();
            }
        }
    }
}
