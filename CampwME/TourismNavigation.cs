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
    public partial class TourismNavigation : Form
    {
        public static TourismNavigation TourismNavigationInstance;
        public TourismNavigation()
        {
            InitializeComponent();
            TourismNavigationInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Pass Form1 as the parent
            home.Show(); // Show Home
            Visible = false;
        }

        private void Monument_Leave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void CursorChange(object sender, EventArgs e)
        {
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox6.Cursor = Cursors.Hand;
            Help.Cursor = Cursors.Help;
            
        }

        private void Mountain_Leave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void Hiking_Leave(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void Beach_Leave(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            OnlineHelp onhel = new OnlineHelp(); // Pass Form1 as the parent
            onhel.Show(); // Show bas
            //Visible = false;
        }
    }
}
