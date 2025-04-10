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
    public partial class Weather : Form
    {
        public static Image WeatherSelectedImage { get; private set; } // Static property to store the selected image

        public static Weather WeatherInstance;
        public Weather()
        {
            InitializeComponent();
            WeatherInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (Home.HomeSelectedImage == Properties.Resources.Strong_protected_tent)
            {
                button8.Visible = false;
                label37.AutoSize = false;
                label37.Text = "You have the best Protection";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Pass Form1 as the parent
            home.Show(); // Show Home
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your cloths has been upgraded to Strong Protected Cloths");
            WeatherSelectedImage = Properties.Resources.Strong_protected_tent;
            button8.Visible = false;
            label37.AutoSize = false;
            label37.Text = "You have the best Protection";
        }

        private void Cursor_Change(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
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
