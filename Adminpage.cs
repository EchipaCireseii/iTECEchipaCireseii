using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;

namespace iTEC_Cireseii
{
    public partial class AdminPage : Form
    {
        private string language = null;
        public AdminPage(string _language)
        {
            InitializeComponent();
            language = _language;
            if (_language == "ro")
            {
                usersMenu.Text = "Utilizatori";
                addUserMenu.Text = "Adaugă Utilizator";
                modifyUserMenu.Text = "Modifică Utilizatori";

                delightsMenu.Text = "Delicatese";
                addDelightMenu.Text = "Adaugă Delicatese";
                modifyDelightMenu.Text = "Modifică Delicatese";

                groupsMenu.Text = "Grupe";
                addDelightGroupMenu.Text = "Adaugă Grupă Delicatesă";
                modifyDelightGroupMenu.Text = "Modifică Grupă Delicatesă";
                addUserGroupMenu.Text = "Adaugă Grupă Utilizatori";
                modifyUserGroupMenu.Text = "Modifică Grupă Utilizatori";

                exportMenu.Text = "Export";
                exportToExcelMenu.Text = "Exportare la Excel";
                messageToolStripMenuItem.Text = "Mesaj";
                newWelcomeMesageToolStripMenuItem.Text = "Mesaj nou de Bun Venit";
            }
            else 
            {
                usersMenu.Text = "Users";
                addUserMenu.Text = "Add User";
                modifyUserMenu.Text = "Modify User";

                delightsMenu.Text = "Delights";
                addDelightMenu.Text = "Add Deligth";
                modifyDelightMenu.Text = "Modify Deligth";

                groupsMenu.Text = "Groups";
                addDelightGroupMenu.Text = "Add Delight Groups";
                modifyDelightGroupMenu.Text = "Modify Delight Groups";
                addUserGroupMenu.Text = "Add User Groups";
                modifyUserGroupMenu.Text = "Modify User Groups";

                exportMenu.Text = "Export";
                exportToExcelMenu.Text = "Export to Excel";

                messageToolStripMenuItem.Text = "Message";
                newWelcomeMesageToolStripMenuItem.Text = "New Welcome Message";
            }
        }

        private void addUserMenu_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser(this,language);
            this.Enabled = false;
            adduser.Show();
        }

        private void addDelightMenu_Click(object sender, EventArgs e)
        {
            AddProduct addproduct = new AddProduct(this,language);
            this.Enabled = false;
            addproduct.Show();
        }

        private void modifyUserMenu_Click(object sender, EventArgs e)
        {
            ModifyUser modifyuser = new ModifyUser(this,language);
            this.Enabled = false;
            modifyuser.Show();
        }

        private void modifyDelightMenu_Click(object sender, EventArgs e)
        {
            ModifyProduct modify1 = new ModifyProduct(this,language);
            this.Enabled = false;
            modify1.Show();
        }

        private void addDelightGroupMenu_Click(object sender, EventArgs e)
        {
            AddDelightGroups addDelightGroups = new AddDelightGroups(this, language);
            this.Enabled = false;
            addDelightGroups.Show();
        }

        private void modifyDelightGroupMenu_Click(object sender, EventArgs e)
        {
            ModifyDelightGroups modifyDelightGroups = new ModifyDelightGroups(this, language);
            this.Enabled = false;
            modifyDelightGroups.Show();
        }

        private void addUserGroupMenu_Click(object sender, EventArgs e)
        {
            AddUserGroups addUserGroups = new AddUserGroups(this, language);
            addUserGroups.Show();
            this.Enabled = false;
        }

        private void modifyUserGroupMenu_Click(object sender, EventArgs e)
        {
            ModifyUserGroups modify3 = new ModifyUserGroups(this,language);
            modify3.Show();
            this.Enabled = false;
        }

        private void setUserGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUserGroups setUserGroups = new SetUserGroups(this, language);
            setUserGroups.Show();
            this.Enabled = false;
        }
        /// <summary>
        /// Crearea unui fisier de raport Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportToExcelMenu_Click(object sender, EventArgs e)
        {
            //Buget si creare Excel
            string budget = Microsoft.VisualBasic.Interaction.InputBox("Enter the budget for this month", "Set Budget", null, MousePosition.X, MousePosition.Y);
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(XlSheetType.xlWorksheet);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlApp.ActiveSheet;

            xlApp.Visible = true;
            object misValue = System.Reflection.Missing.Value;
            //Populare Excel
            xlWorkSheet.Cells[1, 1] = "Year";
            xlWorkSheet.Cells[1, 2] = "Month";
            xlWorkSheet.Cells[1, 3] = "Budget";
            xlWorkSheet.Cells[1, 4] = "Number of votes";
            xlWorkSheet.Cells[1, 5] = "Point in RON";

            xlWorkSheet.Cells[1, 8] = "Products";
            xlWorkSheet.Cells[1, 9] = "Votes";

            int pointPer = int.Parse(budget) / MySQL.GetTotalVotes();
            xlWorkSheet.Cells[2, 1] = DateTime.Now.ToLocalTime().Year;
            xlWorkSheet.Cells[2, 2] = DateTime.Now.ToLocalTime().Month;
            xlWorkSheet.Cells[2, 3] = budget + " RON";
            xlWorkSheet.Cells[2, 4] = MySQL.GetTotalVotes().ToString() + " votes";
            xlWorkSheet.Cells[2, 5] = pointPer.ToString() + " RON per point";

            string[] products = MySQL.GetVotedProducts();
            int[] values = new int[products.Length];

            for (int i = 0; i < products.Length; i++)
                values[i] = MySQL.GetVotesPerProduct(products[i]);

            for (int i = 0; i < products.Length; i++)
            {
                xlWorkSheet.Cells[i + 2, 8] = products[i];
                xlWorkSheet.Cells[i + 2, 9] = values[i];
            }
            //Adaugare Grafic Excel
            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(0, 40, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("H1", "I" + (products.Length + 1).ToString());
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlPie;
            chartPage.ChartWizard(Title: "Votes report");

            var range = xlWorkSheet.get_Range("A1", "E2");
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Color = System.Drawing.ColorTranslator.ToOle(Color.Black);
            range.EntireColumn.AutoFit();

            chartRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            chartRange.Borders.Color = System.Drawing.ColorTranslator.ToOle(Color.Black);
            chartRange.EntireColumn.AutoFit();

            xlWorkSheet.get_Range("A1", "E1").Font.Bold = true;
            xlWorkSheet.get_Range("H1", "I1").Font.Bold = true;
            //Crearea tabelului de raport al bugetului individual
            xlWorkSheet.Cells[24, 1] = "Individual budget report for month " + DateTime.Now.ToLocalTime().Month; 
            xlWorkSheet.Cells[25, 1] = "Product";
            xlWorkSheet.Cells[25, 2] = "Value";
            xlWorkSheet.get_Range("A25", "B25").Font.Bold = true;
            xlWorkSheet.get_Range("A25", "B25").EntireColumn.AutoFit();

            for (int i = 0; i < products.Length; i++)
            {
                xlWorkSheet.Cells[i + 26, 1] = products[i];
                xlWorkSheet.Cells[i + 26, 2] = (values[i] * pointPer).ToString() + " RON";
            }
            xlWorkSheet.get_Range("A25", "B" + (26 + products.Length - 1).ToString()).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            xlWorkSheet.get_Range("A25", "B" + (26 + products.Length - 1).ToString()).Borders.Color = ColorTranslator.ToOle(Color.Black);
        }
        //Adaugare un nou mesaj
        private void newWelcomeMesageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newMessage = "";
            if (language == "ro")
            { 
                newMessage = Microsoft.VisualBasic.Interaction.InputBox("Inserați noul mesaj de bun venit aici: ", "Nou Mesaj de Bun Venit", "", MousePosition.X, MousePosition.Y);
            }
            else
            {
                newMessage = Microsoft.VisualBasic.Interaction.InputBox("Insert the new welcome message here: ", "New Welcome Message", "", MousePosition.X, MousePosition.Y); 
            }

            if (newMessage.Length > 0 && newMessage != null)
                MySQL.InsertWelcomeMessage(newMessage);
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            string[] products = MySQL.GetVotedProducts();
            int[] values = new int[products.Length];

            for (int i = 0; i < products.Length; i++)
                values[i] = MySQL.GetVotesPerProduct(products[i]);

            for (int i = 0; i < products.Length; i++)
            {
                this.pieChart.Series["Votes"].Points.AddXY(products[i],values[i]);
            }
            registeredUsers.Text = MySQL.GetRegisteredUsers().ToString();
           
        }
     }
}
