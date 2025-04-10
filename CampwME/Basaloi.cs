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
    public partial class Basaloi : Form
    {
        public static Basaloi basInstance;
        private int Trackbar1_timh;
        private int Trackbar2_timh;
        private int T1 = 0;
        private int Trackbar4_timh;
        private int Trackbar3_timh;
        private int Trackbar6_timh;
        private int Trackbar5_timh;
        private int T2 = 0;
        private int T3 = 0;
        private bool Times = true;

        public Basaloi()
        {
            InitializeComponent();
            basInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TurnValuestoZero();
            label1.Text = trackBar1.Value.ToString();
            Trackbar1_timh = trackBar1.Value;
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            TurnValuestoZero();
            label12.Text = trackBar2.Value.ToString();
            Trackbar2_timh = trackBar2.Value;
            
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label14.Text = trackBar4.Value.ToString();
            Trackbar4_timh = trackBar4.Value;
            TurnValuestoZero();
            
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label13.Text = trackBar3.Value.ToString();
            Trackbar3_timh = trackBar3.Value;
            TurnValuestoZero();
            
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label16.Text = trackBar6.Value.ToString();
            Trackbar6_timh = trackBar6.Value;
            TurnValuestoZero();
            
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            TurnValuestoZero();
            label15.Text = trackBar5.Value.ToString();
            Trackbar5_timh = trackBar5.Value;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Math.Abs(Trackbar1_timh - Trackbar2_timh) <= 30)
            {
               T1 = 1;
               Times = true;
            }
            if (Math.Abs(Trackbar3_timh - Trackbar4_timh) <= 30)
            {
               T2 = 1;
               Times = true;
            }
            if (Math.Abs(Trackbar6_timh - Trackbar5_timh) <= 30)
            {
               T3 = 1;
               Times = true;
            }
            ShowMessage();
            TurnValuestoZero();
            
        }
        private void ShowMessage()
        {
            if (T1 != 1)
            {
                MessageBox.Show("There must be a difference of 30 degrees between the angle and the pressure!, Adjust the values of the Top Stakes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Times = false;
            }
            if (T2 != 1)
            {
                MessageBox.Show("There must be a difference of 30 degrees between the angle and the pressure!, Adjust the values of the Middle Stakes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Times = false;
            }
            if (T3 != 1)
            {
                MessageBox.Show("There must be a difference of 30 degrees between the angle and the pressure!, Adjust the values of the Bottom Stakes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Times = false;
            }
            if (Times == true)
            {
                MessageBox.Show("The values you selected where correct!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Panels panels = new Panels();
                panels.Show();
                Visible = false;
            }
        }
        private void TurnValuestoZero()
        {
            T1 = 0;
            T2 = 0;
            T3 = 0;
        }

        private void Cursor_Change(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            trackBar1.Cursor = Cursors.Hand;
            trackBar2.Cursor = Cursors.Hand;
            trackBar3.Cursor = Cursors.Hand;
            trackBar4.Cursor = Cursors.Hand;
            trackBar5.Cursor = Cursors.Hand;
            trackBar6.Cursor = Cursors.Hand;
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
