using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace iTEC_Cireseii
{
    /// <summary>
    /// Crearea produselor pentru vot
    /// </summary>
    public class Item
    {
       private string name;
       private int points;
       private string imageLocation;
       private string group;
       private TextBox textBox = null;
       private TrackBar trackBar = null;

       public string Name { get { return name; } set { name = value; } }
       public string Group { get { return group; } set { group = value; } }
       public string ImageLocation { get { return imageLocation; } set { imageLocation = value; } }
       public int Points { get { return points; } set { points = value; } }
        /// <summary>
        /// Transformarea clasei pentru reprezantarea sub forma de produs pe pagina User-ului
        /// </summary>
        /// <returns></returns>
       public Button GetAsButton()
       {
           // Button initialization
           Button itemButton = new Button();
           itemButton.Text = "";
           itemButton.BackColor = Color.White;
           itemButton.Size = new Size(418, 92);
           itemButton.FlatAppearance.BorderSize = 0;
           itemButton.TabStop = false;

           // PictureBox Avatar
           PictureBox pictureBox = new PictureBox();
           pictureBox.ImageLocation = imageLocation;
           pictureBox.BackColor = Color.Silver;
           pictureBox.Location = new Point(5,5);
           pictureBox.Size = new Size(110,itemButton.Height-10);
           pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

           // Label Descriere
           Label descriereLabel = new Label();
           descriereLabel.Text = "Product: " +name;
           descriereLabel.Location = new Point(pictureBox.Location.X + pictureBox.Width + 5, 5);
           descriereLabel.Font = new Font("Consolas", 12);
           descriereLabel.AutoSize = true;

           // Label Descriere
           Label pretLabel = new Label();
           pretLabel.Text = "Price in points: " + points.ToString();
           pretLabel.Location = new Point(pictureBox.Location.X + pictureBox.Width + 5, 22);
           pretLabel.Font = new Font("Consolas", 12);
           pretLabel.AutoSize = true;

           // Trackbar
           TrackBar trackBar = new TrackBar();
           trackBar.Location = new Point(descriereLabel.Location.X, pretLabel.Location.Y + 20);
           trackBar.ValueChanged += new EventHandler(trackBar_ValueChanged);
           this.trackBar = trackBar;

           // TextBox
           TextBox textBox = new TextBox();
           textBox.Size = new Size(34, 20);
           textBox.Location = new Point(trackBar.Location.X + trackBar.Width + 3, trackBar.Location.Y);
           textBox.Text = "0";
           textBox.TextChanged += new EventHandler(textBox_TextChanged);
           this.textBox = textBox;

           itemButton.Controls.Add(descriereLabel);
           itemButton.Controls.Add(pretLabel);
           itemButton.Controls.Add(pictureBox);
           itemButton.Controls.Add(trackBar);
           itemButton.Controls.Add(textBox);

           return itemButton;
       }

       void textBox_TextChanged(object sender, EventArgs e)
       {
           TextBox textBox = (TextBox)sender;
           int result = -1;
           int.TryParse(textBox.Text, out result);
           if (result >= 0 && result <= trackBar.Maximum)
               trackBar.Value = result;
           else
           {
               MessageBox.Show("Valoare incorecta!");
               textBox.Text = "0";
               trackBar.Value = 0;
           }
       }

       void trackBar_ValueChanged(object sender, EventArgs e)
       {
           TrackBar trackBar = (TrackBar)sender;
           textBox.Text = trackBar.Value.ToString();
       }
    }
}
