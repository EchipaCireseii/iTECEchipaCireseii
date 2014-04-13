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
    public partial class ModifyUser : Form
    {
        private int selectedRowIndex = -1;
        private string language = "";
        private Form form = null;

        public ModifyUser(Form _form,string _language)
        {
            InitializeComponent();
            language = _language;
            form = _form;
            if (language == "ro")
            {
                userLabel.Text = "Utilizator iniţial : ";
                newUserLabel.Text = "Utilizator curent : ";
                newpassLabel.Text = "Parolă : ";
                newgroupLabel.Text = "Grup :";
                newpointsLabel.Text = "Puncte :";
                newtypeLabel.Text = "Tip :";
                updateButton.Text = "Schimbă";
                cancelButton.Text = "Anulare";
                this.Text = "Modifică Utilizator";
            }
            else 
            {
                userLabel.Text = "User Name : ";
                newUserLabel.Text = "New User Name : ";
                newpassLabel.Text = "Password : ";
                newgroupLabel.Text = "Group :";
                newpointsLabel.Text = "Points :";
                newtypeLabel.Text = "Type :";
                updateButton.Text = "Update";
                cancelButton.Text = "Cancel";
                this.Text = "Modify User";
            }

                SearchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            MySQL.Refresh(this.SearchGridView);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (userTextBox.Text != "") 
                MySQL.Search(SearchGridView, userTextBox.Text); 
            else  
                MySQL.Refresh(this.SearchGridView); 
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySQL.DeleteUser(int.Parse(SearchGridView[0,selectedRowIndex].Value.ToString()));
        }

        private void SearchGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                selectedRowIndex = e.RowIndex;
                contextMenu.Show(MousePosition);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] userData = MySQL.GetUserData(int.Parse(SearchGridView[0, selectedRowIndex].Value.ToString()));
            newUserNameBox.Text = userData[0];
            newPasswordBox.Text = userData[1];
            newGroupBox.Text = userData[2];
            newPointsBox.Text = userData[3];
            newTypeBox.Text = userData[4];
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int result = -1;
            int.TryParse(newPointsBox.Text, out result);
            if (result > -1)
            {
                MySQL.UpdateUserData(int.Parse(SearchGridView[0, selectedRowIndex].Value.ToString()), newUserNameBox.Text, newPasswordBox.Text,
                    newGroupBox.Text, int.Parse(newPointsBox.Text), newTypeBox.Text);
                MySQL.Refresh(SearchGridView);
            }
            else
            {
                if (language == "ro")
                {
                    MessageBox.Show("Points text box is not correct!");
                }
                else
                {
                    MessageBox.Show("Câmpul puncte nu este corect!");
                }
            }
        }

        private void ModifyUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }
     }
}
