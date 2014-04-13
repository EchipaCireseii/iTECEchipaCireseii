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
    public partial class ModifyProduct : Form
    {
        private int selectedRowIndex = -1;
        private string language = "";
        private Form form = null;

        public ModifyProduct(Form _form, string _language)
        {
            InitializeComponent();
            form = _form;
            language = _language;
            SearchProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            MySQL.RefreshProduct(this.SearchProductGridView);
            if (language == "ro")
            {
                delightLabel.Text = "Delicatesă :";
                newNameLabel.Text = "Nume Nou :";
                newGroupLabel.Text = "Grupă Nouă :";
                newPointsLabel.Text = "Puncte Noi :";
                newImageLocationLabel.Text = "Noua locaţie a imaginii :";
                updateButton.Text = "Schimbă";
                closeButton.Text = "Închide";
                this.Text = "Modifică Delicatesă";
            }
            else
            {
                delightLabel.Text = "Delight :";
                newNameLabel.Text = "New Name :";
                newGroupLabel.Text = "New Group :";
                newPointsLabel.Text = "New Points :";
                newImageLocationLabel.Text = "New Image Location :";
                updateButton.Text = "Update";
                closeButton.Text = "Close";
                this.Text = "Modifică Delight";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (delightBox.Text != "")
                MySQL.SearchProduct(SearchProductGridView, delightBox.Text);
            else
                MySQL.RefreshProduct(this.SearchProductGridView);
        }

        private void SearchProductGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectedRowIndex = e.RowIndex;
                contextMenu.Show(MousePosition);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySQL.DeleteProduct(int.Parse(SearchProductGridView[0,selectedRowIndex].Value.ToString()));
            MySQL.RefreshProduct(SearchProductGridView);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] productsData = MySQL.GetProductsData(int.Parse(SearchProductGridView[0, selectedRowIndex].Value.ToString()));
            newNameBox.Text = productsData[0];
            newGroupBox.Text = productsData[1];
            newPointsBox.Text = productsData[2];
            newImageBox.Text = productsData[3];
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySQL.UpdateProductsData(int.Parse(SearchProductGridView[0, selectedRowIndex].Value.ToString()), newNameBox.Text,
                newGroupBox.Text, int.Parse(newPointsBox.Text), newImageBox.Text);
            MySQL.RefreshProduct(SearchProductGridView);
        }

        private void ModifyProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Enabled = true;
        }

    }
}
