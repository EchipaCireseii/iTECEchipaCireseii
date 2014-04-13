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
    public partial class UserPage : Form
    {
        private string user = "";
        private int maxPoints = 0;
        private string language = "";

        public UserPage(string _user, string _language)
        {
            InitializeComponent();
            language = _language;
            userBox.Text = _user;
            user = _user;
            WelcomePage welcomePage = new WelcomePage(language);
            welcomePage.Show();
        }
        /// <summary>
        /// Incarcarea interfatei de vot pentru utilizator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserPage_Load(object sender, EventArgs e)
        {
            voteBoxUnclicked.BringToFront();
            foreach (string group in MySQL.GetGroups())
            {
                menuControl.TabPages.Add(group);
            }
            pointsLabel.Text = MySQL.GetUserPoints(user).ToString();
            maxPoints = int.Parse(pointsLabel.Text);
            if (int.Parse(pointsLabel.Text) == 0 && DateTime.Parse(MySQL.GetUserLastVoteTime(userBox.Text)).ToLocalTime().Month == DateTime.Now.ToLocalTime().Month)
            {
                if (language == "ro")
                { MessageBox.Show("Ai votat deja sau nu ai destule puncte. Revino luna viitoare."); }
                else { MessageBox.Show("You already voted or you don't have enough points. Come back next month."); }
                Application.ExitThread();
            }
            else if (int.Parse(pointsLabel.Text) == 0 && DateTime.Parse(MySQL.GetUserLastVoteTime(userBox.Text)).ToLocalTime().Month < DateTime.Now.ToLocalTime().Month)
            {
                MySQL.ResetUserVote(userBox.Text);
                pointsLabel.Text = MySQL.GetUserPoints(user).ToString();
                maxPoints = int.Parse(pointsLabel.Text);
            }
            // Popularea Taburilor cu produse/delicatese
            foreach (TabPage tab in menuControl.TabPages)
            {
                int count = 10;
                foreach (Item item in MySQL.GetItems())
                {
                    if (tab.Text == item.Group)
                    {
                        Button button = item.GetAsButton();
                        tab.Controls.Add(button);
                        button.Location = new Point(10, count);
                        count += 100;
                    }
                }
            }
            //Contorizarea nr. de voturi
            foreach (TabPage tabPage in menuControl.TabPages)
            {
                foreach (Button button in tabPage.Controls)
                {
                    foreach (Control control in button.Controls)
                    {
                        if (control.GetType() == typeof(TrackBar))
                        {
                            TrackBar trackBar = (TrackBar)control;
                            trackBar.Maximum = int.Parse(pointsLabel.Text);
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Verificarea in timp real ale voturilor utilizatorului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verifyTimer_Tick(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (TabPage tabPage in menuControl.TabPages)
            {
                foreach (Button button in tabPage.Controls)
                {
                    foreach (Control control in button.Controls)
                    {
                        if (control.GetType() == typeof(TrackBar))
                        {
                            TrackBar trackBar = (TrackBar)control;
                            sum += trackBar.Value;
                            break;
                        }
                    }
                }
            }
            pointsLabel.Text = (maxPoints - sum).ToString();
        }
        /// <summary>
        /// Finalizarea votului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voteBoxUnclicked_Click(object sender, EventArgs e)
        {
            if (int.Parse(pointsLabel.Text) == 0)
            {
                voteBoxClicked.BringToFront();
                foreach (TabPage tabPage in menuControl.TabPages)
                {
                    foreach (Button button in tabPage.Controls)
                    {
                        if (ButtonsOperations.GetValue(button) > 0)
                            MySQL.InsertVote(userBox.Text, ButtonsOperations.ExtractName(button), ButtonsOperations.GetValue(button), DateTime.Now.ToLocalTime().ToShortDateString());
                    }
                }
                if (language == "ro")
                {
                    MessageBox.Show("Ati votat cu succes!");
                    MySQL.UpdateUserVote(userBox.Text);
                    Application.ExitThread();
                }
                else
                {
                    MessageBox.Show("You have voted successfully!");
                    MySQL.UpdateUserVote(userBox.Text);
                    Application.ExitThread();
                }
            }
            else if (int.Parse(pointsLabel.Text) < 0)
            {
                if(language=="ro")
                    MessageBox.Show("Nu ai destule puncte!");
                else
                    MessageBox.Show("You don't have enough points!");
            }
            else if (int.Parse(pointsLabel.Text) > 0)
            {
                if(language =="ro")
                    MessageBox.Show("Nu ai folosit toate punctele!");
                else
                    MessageBox.Show("You didn't use all your points!");
            }
        }
        //Iesire
        private void UserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
