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
    public partial class AddDelightGroups : Form
    {
        private Form form = null;
        private string language = "";

        public AddDelightGroups(Form _form, string _language)
        {
            InitializeComponent();
            form = _form;
            language = _language;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Update()
        {
            groupListBox.Items.Clear();
            foreach (string group in MySQL.GetGroups())
            {
                groupListBox.Items.Add(group);
            }
            newGroupTextBox.Text = "";
        }

        private void AddDelightGroups_Load(object sender, EventArgs e)
        {
            Update();
            if (language == "ro")
            {
                newGroupLabel.Text = "Nume nou grupă :";
                saveButton.Text = "Salvaţi";
                exitButton.Text = "Ieşire";
                this.Text = "Adăugare grupe delicatese";
            }
            else
            {
                newGroupLabel.Text = "New Group Name :";
                saveButton.Text = "Save";
                exitButton.Text = "Exit";
                this.Text = "Add Delight Groups";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MySQL.InsertDelightGroups(newGroupTextBox.Text,language);  
        }

        private void AddDelightGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }
    }
}
