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
    public partial class ModifyDelightGroups : Form
    {
        private Form form = null;
        private string language = "";

        public ModifyDelightGroups(Form _form, string _language)
        {
            InitializeComponent();
            form = _form;
            language = _language;
        }

        void Update()
        {
            groupListBox.Items.Clear();
            foreach (string group in MySQL.GetGroups())
            {
                groupListBox.Items.Add(group);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyDelightGroups_Load(object sender, EventArgs e)
        {
            foreach (string group in MySQL.GetGroups())
            {
                groupListBox.Items.Add(group);
            }
            if (language == "ro")
            {
                initialGroupLabel.Text = "Grup iniţial :";
                newGroupLabel.Text = "Grup nou :";
                updateButton.Text = "Schimbă";
                exitButton.Text = "Ieşire";
                this.Text = "Modifică grupe delicatese";
            }
            else
            {
                initialGroupLabel.Text = "Initial Group :";
                newGroupLabel.Text = "New Group :";
                updateButton.Text = "Update";
                exitButton.Text = "Exit";
                this.Text = "Modify Delight Groups";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (language == "ro" && DialogResult.OK == MessageBox.Show("Doriti sa actualizati si produsele cu denumirea grupei noi?", "Actualizare", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                ||
                language == "uk" && DialogResult.OK == MessageBox.Show("Do you want to update products associated with the new group?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                MySQL.UpdateProductGroups(newBox.Text, delightBox.Text, true);
                delightBox.Text = "";
                newBox.Text = "";
                Update();
            }
            else
            {
                MySQL.UpdateProductGroups(newBox.Text, delightBox.Text, false);
                delightBox.Text = "";
                newBox.Text = "";
                Update();
            }
        }

        private void ModifyDelightGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }

        private void groupListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                groupListBox.SelectedIndex = groupListBox.IndexFromPoint(e.Location);
                menuStrip.Show(MousePosition);
            }
            else if (e.Button == MouseButtons.Left)
            {
                groupListBox.SelectedIndex = groupListBox.IndexFromPoint(e.Location);
                if (groupListBox.SelectedItem != null)
                    delightBox.Text = groupListBox.SelectedItem.ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySQL.DeleteProductGroup(groupListBox.SelectedItem.ToString());
            Update();
        }
    }
}
