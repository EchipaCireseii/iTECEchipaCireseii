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
    public partial class AddProduct : Form
    {
        private string language="";
        private Form form = null;

        public AddProduct(Form _form,string _language)
        {
            InitializeComponent();
            form = _form;
            language = _language;
            if (language == "ro")
            {
                nameLabel.Text = "Nume";
                groupLabel.Text = "Grupă";
                pointsLabel.Text = "Puncte";
                imageLocationLabel.Text = "Locaţia Imaginii";
                saveButton.Text = "Salvează";
                exitButton.Text = "Ieşire";
                this.Text = "Adaugă Delicatese";
            }
            else if (language == "uk")
            {
                nameLabel.Text = "Name";
                groupLabel.Text = "Group";
                pointsLabel.Text = "Points";
                imageLocationLabel.Text = "Image Location";
                saveButton.Text = "Save";
                exitButton.Text = "Exit";
                this.Text = "Add Deligths";
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            foreach (string group in MySQL.GetGroups())
            {
                groupBox.Items.Add(group);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MySQL.InsertProduct(nametextBox.Text,groupBox.Text,int.Parse(pointstextBox.Text),imageLocationBox.Text,language);
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }
    }
}
