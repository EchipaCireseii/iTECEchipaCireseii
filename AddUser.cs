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
    public partial class AddUser : Form
    {
        private string language = "";
        private Form form = null;
        public AddUser(Form _form,string _language)
        {
            InitializeComponent();
            form = _form;
            language = _language;
            if (language == "ro")
            {
                userLabel.Text = "Utilizator";
                passLabel.Text = "Parolă";
                pointLabel.Text = "Puncte";
                typeLabel.Text = "Tip";
                saveButton.Text = "Salvaţi";
                exitButton.Text = "Ieşire";
                this.Text = "Adaugă Utilizatori";
            }
            else
            {
                userLabel.Text = "Username";
                passLabel.Text = "Password";
                pointLabel.Text = "Points";
                typeLabel.Text = "Type";
                saveButton.Text = "Save";
                exitButton.Text = "Exit";
                this.Text = "Add Users";
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int result = -1;
            int.TryParse(pointsTextBox.Text, out result);
            if (result > -1)
                MySQL.InsertUser(userTextBox.Text,passTextBox.Text,result,typeTextBox.Text,language);
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }

  }
}
