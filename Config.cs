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
    public partial class Config : Form
    {
        Form loginForm = null;

        public Config(string _language, Form _loginForm)
        {
            InitializeComponent();
            loginForm = _loginForm;
            loginForm.Enabled = false;
            //Limba Romana
            if (_language == "ro")
            {
                userLabel.Text = "Utilizator";
                passLabel.Text = "Parolă";
                saveButton.Text = "Salvează";
                exitButton.Text = "Ieşire";
            }
            //Limba Engleza
            if (_language == "uk")
            {
                userLabel.Text = "Username";
                passLabel.Text = "Password";
                saveButton.Text = "Save";
                exitButton.Text = "Exit";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter("config.cfg"))
                {
                    streamWriter.WriteLine("Server: " + serverBox.Text);
                    streamWriter.WriteLine("Database: " + databaseBox.Text);
                    streamWriter.WriteLine("Username: " + userBox.Text);
                    streamWriter.WriteLine("Password: " + passBox.Text);
                }
                MessageBox.Show("Fisierul config.cfg a fost configurat!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("A aparut o eroare la crearea fisierului config.cfg./nVerificati daca acesta nu exista deja.");
            }
        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        }
}
