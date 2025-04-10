
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CampwME
{
    public partial class Lighting : Form
    {
        public static Lighting LightingInstance;
        public bool TPink = false;
        public bool TPurple = false;
        public bool TBlue = false;
        public bool TGold = false;
        public bool TRed = false;

        public Lighting()
        {
            InitializeComponent();
            LightingInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Setting the TrackBar properties
            trackBar1.Minimum = 0; // Minimum value
            trackBar1.Maximum = 2; // Maximum value
            trackBar1.TickFrequency = 1; // Set the frequency of ticks
            trackBar1.Value = 2; // Default value

            // Initial image based on the trackbar value
            UpdateImage(trackBar1.Value);
            button1.MouseHover += Change_Cursor;
            button2.MouseHover += Change_Cursor;
            button3.MouseHover += Change_Cursor;
            button4.MouseHover += Change_Cursor;
            button5.MouseHover += Change_Cursor;
            button6.MouseHover += Change_Cursor;
            button7.MouseHover += Change_Cursor;
            button8.MouseHover += Change_Cursor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "Current";
            label3.AutoSize = false;
            label3.Text = "Choose a Colour";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            //panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label4.Text = "Event";
            label3.AutoSize = false;
            label3.Text = "Choose a Colour";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            //panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.InsidePink;
            button8.Visible = true;
            TPink = true;
            TPurple = false;
            TBlue = false;
            TGold = false;
            TRed = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.InsideBlue;
            button8.Visible = true;
            TPink = false;
            TPurple = false;
            TBlue = true;
            TGold = false;
            TRed = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.InsidePurple;
            button8.Visible = true;
            TPink = false;
            TPurple = true;
            TBlue = false;
            TGold = false;
            TRed = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.InsideGold;
            button8.Visible = true;
            TPink = false;
            TPurple = false;
            TBlue = false;
            TGold = true;
            TRed = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.InsideRed;
            button8.Visible = true;
            TPink = false;
            TPurple = false;
            TBlue = false;
            TGold = false;
            TRed = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Exposure")
            {
                label3.AutoSize = false;
                label3.Text = "Adjust the Exposure";
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                trackBar1.Visible = true;
                button8.Text = "Continue";
            }
            else
            {
                if (label4.Text == "Current")
                {
                    // Show a MessageBox with Yes and No buttons
                    DialogResult result = MessageBox.Show("Do you want to change the lighting for an event?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Check which button the user clicked
                    if (result == DialogResult.Yes)
                    {
                        trackBar1.Value = 2;
                        label5.AutoSize = false;
                        label5.Text = "Current";
                        pictureBox2.Image = pictureBox1.Image;
                        pictureBox2.Visible = true;
                        pictureBox1.Image = Properties.Resources.Inside_of_Tent2;
                        label4.Text = "Event";
                        label3.AutoSize = false;
                        label3.Text = "Choose a Colour";
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = true;
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        button7.Visible = true;
                        trackBar1.Visible = false;
                        button8.Text = "Exposure";
                        button8.Visible = false;

                    }
                    else
                    {
                        SolarP solar = new SolarP(); // Pass Form1 as the parent
                        solar.Show(); // Show SolarP
                        Visible = false;
                    }
                }
                else
                {
                    // Show a MessageBox with Yes and No buttons
                    DialogResult result = MessageBox.Show("Do you want to change the current lighting?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Check which button the user clicked
                    if (result == DialogResult.Yes)
                    {
                        trackBar1.Value = 2;
                        label5.AutoSize = false;
                        label5.Text = "Event";
                        pictureBox2.Image = pictureBox1.Image;
                        pictureBox2.Visible = true;
                        pictureBox1.Image = Properties.Resources.Inside_of_Tent2;
                        label4.Text = "Current";
                        label3.AutoSize = false;
                        label3.Text = "Choose a Colour";
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = true;
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        button7.Visible = true;
                        trackBar1.Visible = false;
                        button8.Text = "Exposure";
                        button8.Visible = false;

                    }
                    else
                    {
                        SolarP solar = new SolarP(); // Pass Form1 as the parent
                        solar.Show(); // Show SolarP
                        Visible = false;
                    }
                }
                
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Update the image based on the selected value of the trackbar
            UpdateImage(trackBar1.Value);
        }
        // Method to update the image based on trackbar value
        private void UpdateImage(int value)
        {
            if (TPink == true)
            {
                switch (value)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.InsidePinkval0; // Replace with your image
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.InsidePinkval1; // Replace with your image
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.InsidePink; // Replace with your image
                        break;
                }
            }
            if (TPurple == true)
            {
                switch (value)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.InsidePurpleval0; // Replace with your image
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.InsidePurpleval1; // Replace with your image
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.InsidePurple; // Replace with your image
                        break;
                }
            }
            if (TBlue == true)
            {
                switch (value)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.InsideBlueval0; // Replace with your image
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.InsideBlueval1; // Replace with your image
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.InsideBlue; // Replace with your image
                        break;
                }
            }
            if (TGold == true)
            {
                switch (value)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.InsideGoldval0; // Replace with your image
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.InsideGoldval1; // Replace with your image
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.InsideGold; // Replace with your image
                        break;
                }
            }
            if (TRed == true)
            {
                switch (value)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.InsideRedval0; // Replace with your image
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.InsideRedval1; // Replace with your image
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.InsideRed; // Replace with your image
                        break;
                }
            }
        }

        private void Info_Enter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void Info_Leave(object sender, EventArgs e)
        {
            label5.Visible=false;
        }

        private void Condition_Enter(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void Condition_Leave(object sender, EventArgs e)
        {
            label6.Visible=false;
        }

        private void Change_Cursor(object sender, EventArgs e)
        {
            pictureBox3.Cursor = Cursors.Help;
            pictureBox2.Cursor = Cursors.Help;
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            button6.Cursor = Cursors.Hand;
            button7.Cursor = Cursors.Hand;
            button8.Cursor = Cursors.Hand;
            trackBar1.Cursor = Cursors.Hand;
            Help.Cursor= Cursors.Help;

        }

        private void Help_Click(object sender, EventArgs e)
        {
            OnlineHelp onhel = new OnlineHelp(); // Pass Form1 as the parent
            onhel.Show(); // Show bas
            //Visible = false;
        }
    }

}
