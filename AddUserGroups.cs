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
    public partial class AddUserGroups : Form
    {
        private Form form = null;
        private string language = "";

        public AddUserGroups(Form _form, string _language)
        {
            InitializeComponent();
            form = _form;
            language = _language;
        }

        void Update()
        {
            userGroupsListBox.Items.Clear();
            foreach (string group in MySQL.GetUsersGroups())
            {
                userGroupsListBox.Items.Add(group);
            }        
        }

        private void AddUserGroups_Load(object sender, EventArgs e)
        {
            Update();
            if (language == "ro")
            {
                newGroupLabel.Text = "Grup Nou :";
                button1.Text = "Adaugă";
                this.Text = "Adaugă grupe utilizatori";
            }
            else
            {
                newGroupLabel.Text = "New Group :";
                button1.Text = "Add";
                this.Text = "Adaugă User Groups";
            }
        }

        private void AddUserGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySQL.AddUserGroup(newGroupBox.Text,int.Parse(pointsBox.Text));
            Update();
        }
    }
}
