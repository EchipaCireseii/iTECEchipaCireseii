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
    public partial class SetUserGroups : Form
    {
        private Form form = null;
        private string language = "";
        private ListBox selectedListBox = null;

        public SetUserGroups(Form _form, string _language)
        {
            InitializeComponent();
            form = _form;
            language = _language;
        }

        private void SetUserGroups_Load(object sender, EventArgs e)
        {
            foreach (string user in MySQL.SelectUsersByGroups(""))
            {
                usersListBox.Items.Add(user);
            }
            foreach (string group in MySQL.GetUsersGroups())
            {
                ListBox listBox = new ListBox();
                listBox.Items.Add("Group: " + group);
                listBox.Items.Add("Points: " + MySQL.GetUsersGroupsPoints(group));
                flowLayoutPanel1.Controls.Add(listBox);
                listBox.AllowDrop = true;
                listBox.DragEnter += new DragEventHandler(listBox_DragEnter);
                listBox.DragDrop += new DragEventHandler(listBox_DragDrop);
                listBox.MouseDown += new MouseEventHandler(listBox_MouseDown);
                listBox.MouseEnter += new EventHandler(listBox_MouseEnter);
                listBox.SelectionMode = SelectionMode.MultiExtended;
                foreach (string user in MySQL.SelectUsersByGroups(group))
                {
                    listBox.Items.Add(user);
                }
            }
            if (language == "ro")
            {
                this.Text = "Setare grupe utilizatori";
                saveBut.Text = "Salvează";
                resetBut.Text = "Reîncearcă";
            }
            else
            {
                this.Text = "Set User Groups";
                saveBut.Text = "Save";
                resetBut.Text = "Reset";
            }
        }

        void listBox_MouseEnter(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            selectedListBox = listBox;
        }

        void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                listBox.DoDragDrop(listBox.SelectedItems, DragDropEffects.Copy);
                selectedListBox = listBox;
            }
            else
            {
                selectedListBox = listBox;
                menuStrip.Show(MousePosition);
            }
        }

        private void SetUserGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }

        private void usersListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                usersListBox.DoDragDrop(usersListBox.SelectedItems, DragDropEffects.Copy);
            }
        }

        void listBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void listBox_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            foreach (Object item in usersListBox.SelectedItems)
            {
                listBox.Items.Add((string)item);
            }
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(usersListBox);
            selectedItems = usersListBox.SelectedItems;
            for (int i = selectedItems.Count - 1; i >= 0; i--)
                usersListBox.Items.Remove(selectedItems[i]);
        }

        private void usersListBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void usersListBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                foreach (Object item in selectedListBox.SelectedItems)
                {
                    string itemValue = (string)item;
                    if (!itemValue.Contains("Points:") && !itemValue.Contains("Group:"))
                        usersListBox.Items.Add((string)item);
                }
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(selectedListBox);
                selectedItems = selectedListBox.SelectedItems;
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    string itemValue = (string)selectedItems[i];
                    if (!itemValue.Contains("Points:") && !itemValue.Contains("Group:"))
                        selectedListBox.Items.Remove(selectedItems[i]);
                }
            }
            catch { }
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            foreach (Object obj in usersListBox.Items)
            {
                MySQL.SetUsersGroupAndPoints((string)obj, "", 0, false);
            }
            foreach (ListBox listBox in flowLayoutPanel1.Controls)
            {
                MySQL.SetGroupsPoints(listBox.Items[0].ToString().Replace("Group:", "").Trim(), int.Parse(listBox.Items[1].ToString().Replace("Points:", "").Trim()));
                for (int i = 2; i < listBox.Items.Count; i++)
			    {
                    MySQL.SetUsersGroupAndPoints(listBox.Items[i].ToString(), listBox.Items[0].ToString().Replace("Group:", "").Trim(),
                        int.Parse(listBox.Items[1].ToString().Replace("Points:", "").Trim()), true);
			    }
            }
            MessageBox.Show("Salvare reusita!");
        }

        private void resetBut_Click(object sender, EventArgs e)
        {
            foreach (ListBox listBox in flowLayoutPanel1.Controls)
            {
                for (int i = 2; i < listBox.Items.Count; i++)
                {
                    listBox.Items.Remove(listBox.Items[i]);
                }
            }
            usersListBox.Items.Clear();
            foreach (string user in MySQL.GetUsers())
            {
                usersListBox.Items.Add(user);
            }
        }

        private void changePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Enter a new value: ", "Points value changing", "0", MousePosition.X, MousePosition.Y);
            selectedListBox.Items[1] = "Points: " + result;
        }
    }
}
