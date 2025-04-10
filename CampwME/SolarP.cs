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
    public partial class SolarP : Form
    {
        public static SolarP SolarPInstance;
        public SolarP()
        {
            InitializeComponent();
            SolarPInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            label10.Text = progressBar4.Value.ToString();
            label12.Text = progressBar4.Value.ToString();
            label13.Text = progressBar1.Value.ToString();
            label14.Text = progressBar2.Value.ToString();
            label15.Text = progressBar3.Value.ToString();

            button1.MouseHover += Cursor_Change;
            button2.MouseHover += Cursor_Change;
            button3.MouseHover += Cursor_Change;
            button4.MouseHover += Cursor_Change;
            button5.MouseHover += Cursor_Change;
            button6.MouseHover += Cursor_Change;
            button7.MouseHover += Cursor_Change;
            button8.MouseHover += Cursor_Change;
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == false)
            {
                int timh1 = 0;
                int timh = 0;
                if (progressBar2.Value > 0)
                {
                    int plithos = progressBar2.Value / 10;
                    for (int i = 0; i < plithos; i++)
                    {
                        timh = timh + 2;
                    }
                }
                if (progressBar3.Value > 0)
                {
                    int plithos1 = progressBar3.Value / 10;
                    for (int i = 0; i < plithos1; i++)
                    {
                        timh1 = timh1 + 2;
                    }
                }
                int timh_sun = timh + timh1;
                progressBar4.Value = progressBar4.Value + timh + timh1;
                MessageBox.Show("You saved "+timh_sun.ToString()+"% Energy");
                label10.Text = progressBar4.Value.ToString();
                label12.Text = progressBar4.Value.ToString();
                label14.Text = "0";
                label15.Text = "0";
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            else
            {
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            //materialSwitch1.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value = progressBar2.Value - 10;

                UpdateProgressMinus();
            }
            else
            {
                MessageBox.Show("It can't go lower");
            }
            //progressBar2.Value = progressBar2.Value - 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value < 100)
            {
                progressBar2.Value = progressBar2.Value + 10;
                UpdateProgressPlus();
            }
            else
            {
                MessageBox.Show("It can't go higher");
            }
        }



        private void UpdateProgressMinus()
        {
            progressBar4.Value = progressBar4.Value + 2;
            MessageBox.Show("You saved 2% Energy");
            label10.Text = progressBar4.Value.ToString();
            label12.Text = progressBar4.Value.ToString();
            label13.Text = progressBar1.Value.ToString();
            label14.Text = progressBar2.Value.ToString();
            label15.Text = progressBar3.Value.ToString();
        }
        private void UpdateProgressPlus()
        {
            progressBar4.Value = progressBar4.Value - 2;
            label10.Text = progressBar4.Value.ToString();
            label12.Text = progressBar4.Value.ToString();
            label13.Text = progressBar1.Value.ToString();
            label14.Text = progressBar2.Value.ToString();
            label15.Text = progressBar3.Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value = progressBar1.Value - 10;

                UpdateProgressMinus();
            }
            else
            {
                MessageBox.Show("It can't go lower");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                UpdateProgressPlus();
            }
            else
            {
                MessageBox.Show("It can't go higher");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value > 0)
            {
                progressBar3.Value = progressBar3.Value - 10;

                UpdateProgressMinus();
            }
            else
            {
                MessageBox.Show("It can't go lower");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value < 100)
            {
                progressBar3.Value = progressBar3.Value + 10;
                UpdateProgressPlus();
            }
            else
            {
                MessageBox.Show("It can't go higher");
            }
        }

        private void Weather_Enter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void Weather_Leave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Show a MessageBox with Yes and No buttons
            DialogResult result = MessageBox.Show("Do you want us to take control for the Energy your tent is using?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check which button the user clicked
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for your trust! We will close the AirCondition because the Cold weather is not here yet.", "Automatic Save Energy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int timh1 = 0;
                int timh = 0;
                if (progressBar2.Value > 0)
                {
                    int plithos = progressBar2.Value / 10;
                    for (int i = 0; i < plithos; i++)
                    {
                        timh = timh + 2;
                    }
                }
                if (progressBar3.Value > 0)
                {
                    int plithos1 = progressBar3.Value / 10;
                    for (int i = 0; i < plithos1; i++)
                    {
                        timh1 = timh1 + 2;
                    }
                }
                int timh_sun = timh + timh1;
                progressBar4.Value = progressBar4.Value + timh + timh1;
                MessageBox.Show("You saved" + timh_sun.ToString() + "% Energy");
                label10.Text = progressBar4.Value.ToString();
                label12.Text = progressBar4.Value.ToString();
                label14.Text = "0";
                label15.Text = "0";
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shelter shelter = new Shelter(); // Pass Form1 as the parent
            shelter.Show(); // Show shelter
            Visible = false;

            //Home home = new Home(); // Pass Form1 as the parent
            //home.Show(); // Show Home
            //Visible = false;
        }

        private void Cursor_Change(object sender, EventArgs e)
        {
            pictureBox3.Cursor = Cursors.Help;
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            button6.Cursor = Cursors.Hand;
            button7.Cursor = Cursors.Hand;
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
