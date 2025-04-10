using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CampwME
{
    public partial class Concert : Form
    {
        private Timer timer;
        private int elapsedTime = 0;
        private int duration = 5; // Duration in seconds

        public static Concert ConcertInstance;
        public Concert()
        {
            InitializeComponent();
            ConcertInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize Timer
            timer = new Timer();
            timer.Interval = 100; // Timer tick interval in milliseconds
            timer.Tick += Timer_Tick;

            // Initialize ProgressBar
            //progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = duration * 1000; // Convert seconds to milliseconds
            progressBar1.Value = 0;

            StartProgress();
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
            label3.Visible = true;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Pass Form1 as the parent
            home.Show(); // Show Home
            Visible = false;
        }

        private void StartProgress()
        {
            // Reset progress bar and timer
            elapsedTime = 0;
            progressBar1.Value = 0;
            timer.Start();
        }

        private void Cursor_Change(object sender, EventArgs e)
        {
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
