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
    public partial class ModifyUserGroups : Form
    {
        private Form form = null;
        private string language = "";
        private string selectedName = "";

        public ModifyUserGroups(Form _form, string _language)
        {
            InitializeComponent();
            form = _form;
            language = _language;
        }

        void Update()
        {
            groupListBox.Items.Clear();
            foreach (string group in MySQL.GetUsersGroups())
            {
                groupListBox.Items.Add(group);
            }        
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyUserGroups_Load(object sender, EventArgs e)
        {
            foreach (string group in MySQL.GetUsersGroups())
            {
                groupListBox.Items.Add(group);
            }
            if (language == "ro")
            {
                initialGroupLabel.Text = "Grup iniţial :";
                newGroupLabel.Text = "Grup nou :";
                updateButton.Text = "Schimbă";
                exitButton.Text = "Ieşire";
                this.Text = "Modifică grupe utilizatori";
            }
            else
            {
                initialGroupLabel.Text = "Initial Group :";
                newGroupLabel.Text = "New Group :";
                updateButton.Text = "Update";
                exitButton.Text = "Exit";
                this.Text = "Modify User Groups";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if ((language == "ro" && DialogResult.OK == MessageBox.Show("Doriti sa actualizati si userii cu denumirea grupei noi?", "Actualizare", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                ||
                (language == "uk" && DialogResult.OK == MessageBox.Show("Do you want to update the users associated with the new group?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)))
            {
                MySQL.UpdateUsersGroups(newGroupTextBox.Text, initialGroupTextBox.Text, true);
                Update();
                initialGroupTextBox.Text = "";
                newGroupTextBox.Text = "";
            }
            else
            {
                MySQL.UpdateUsersGroups(newGroupTextBox.Text, initialGroupTextBox.Text, false);
                Update();
                initialGroupTextBox.Text = "";
                newGroupTextBox.Text = "";
            }
        }

      

        private void ModifyUserGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }

        private void groupListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Strip1.Show(MousePosition);
                groupListBox.SelectedIndex = groupListBox.IndexFromPoint(e.Location);
            }
            else if (e.Button == MouseButtons.Left)
            {
                groupListBox.SelectedIndex = groupListBox.IndexFromPoint(e.Location);
                if(groupListBox.SelectedItem != null)
                    initialGroupTextBox.Text = groupListBox.SelectedItem.ToString();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySQL.DeleteUsersGroups(groupListBox.SelectedItem.ToString());
            Update();
        }
    }
}
