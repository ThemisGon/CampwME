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
    public partial class ShelterNavigation : Form
    {
        private Timer timer;
        private int elapsedTime = 0;
        private int duration = 5; // Duration in seconds
        private int Timh = 0;

        public static ShelterNavigation ShelterNavigationInstance;
        public ShelterNavigation()
        {
            InitializeComponent();
            ShelterNavigationInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize Timer
            timer = new Timer();
            timer.Interval = 100; // Timer tick interval in milliseconds
            timer.Tick += Timer_Tick;

            // Initialize ProgressBar
            progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = duration * 1000; // Convert seconds to milliseconds
            progressBar1.Value = 0;
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime += timer.Interval;
            if (elapsedTime <= duration * 1000)
            {
                progressBar1.Value = elapsedTime;
                
            }
            else
            {
                Timh++;
                timer.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                elapsedTime = 0;
                // Trigger the action after the progress bar fills up
                PerformActionAfterProgress();
            }
        }

        private void PerformActionAfterProgress()
        {
            if (Timh == 1)
            {
                label1.AutoSize = false;
                label1.Text = "Choose what path you want to follow";
                pictureBox2.Image = Properties.Resources.DecisionShelterMap;
                label3.Text = "White Path\r\nSpeed: 00:13:00\r\nRoad: Normal\r\nDifficulty: Normal\r\n";
                label4.Text = "Yellow Path\r\nSpeed: 00:20:00\r\nRoad: Normal\r\nDifficulty: Hard\r\n";
                button1.Enabled = true;
                button8.Enabled = true;
            }
            else if (Timh == 2) 
            {
                label1.AutoSize = false;
                label1.Text = "You have navigated to the shelter";
                pictureBox2.Image = Properties.Resources.EndShelterMap;
                button1.Visible = false;
                button8.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                label5.Visible = true;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                elapsedTime = 0;
                //duration = 7;
                StartProgress();
            }
            else
            {
                Timh = 0;
                label5.Visible = false;
                label1.AutoSize = false;
                label1.Text = "You can move back to camping";
                button2.Visible = true;

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Text = "Following the White Path";
            progressBar1.Visible = true;
            button1.Enabled = false;
            button8.Enabled = false;
            StartProgress();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Text = "Following the Yellow Path";
            progressBar1.Visible = true;
            button1.Enabled = false;
            button8.Enabled = false;
            StartProgress();

        }
        private void StartProgress()
        {
            // Reset progress bar and timer
            elapsedTime = 0;
            progressBar1.Value = 0;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Pass Form1 as the parent
            home.Show(); // Show Home
            Visible = false;
            
        }
        private void Cursor_Change(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            button8.Cursor = Cursors.Hand;
            Help.Cursor = Cursors.Help;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            OnlineHelp onhel = new OnlineHelp(); // Pass Form1 as the parent
            onhel.Show(); // Show bas
            //Visible = false;
        }
    }
}
