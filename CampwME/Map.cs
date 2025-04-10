using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampwME
{
    public partial class Map : Form
    {
        private Label infoLabel;
        public static Map MapInstance;
        public Map()
        {
            InitializeComponent();
            MapInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(107, 98, 47); // Custom RGB color
            pictureBox3.BackColor = System.Drawing.Color.FromArgb(129, 127, 127); // Custom RGB color
            pictureBox4.BackColor = System.Drawing.Color.FromArgb(107, 98, 47); // Custom RGB color
            pictureBox5.BackColor = System.Drawing.Color.FromArgb(107, 98, 47); // Custom RGB color

            // Initialize Label
            infoLabel = new Label
            {
                Text = "Αυτό είναι το μήνυμα!",
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Black,
                Padding = new Padding(10),
                Location = new Point(150, 150),
                Font = new Font("Arial", 12, FontStyle.Bold),
                Visible = false // Ξεκινάει κρυφό
            };
            

            // Add MouseEnter and MouseLeave events to PictureBox
            pictureBox2.MouseEnter += PictureBox_MouseEnter;
            pictureBox2.MouseLeave += PictureBox_MouseLeave;

        }

        public void NextPage()
        {
            Basaloi bas = new Basaloi(); // Pass Form1 as the parent
            bas.Show(); // Show bas
            Visible = false;
        }

        private void PlaceIcon_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void PlaceIcon2_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void PlaceIcon3_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void PlaceIcon4_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        // Show label when the mouse enters the PictureBox
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = true;
            //label10.Visible = true;
            infoLabel.Visible = true;
        }

        // Hide label when the mouse leaves the PictureBox
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
            //label10.Visible = false;
            infoLabel.Visible = false;
        }
        private void Details(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox5.Cursor = Cursors.Hand;
            
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            OnlineHelp onhel = new OnlineHelp(); // Pass Form1 as the parent
            onhel.Show(); // Show bas
            //Visible = false;
        }

        private void Change_Cursor(object sender, EventArgs e)
        {
            Help.Cursor = Cursors.Help;
        }
    }
}
    
