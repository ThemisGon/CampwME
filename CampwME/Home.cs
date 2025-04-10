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
    public partial class Home : Form
    {
        public static Image HomeSelectedImage { get; private set; } // Static property to store the selected image
        public static Home HomeInstance;
        public Home()
        {
            InitializeComponent();
            HomeInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(107, 98, 47); // Custom RGB color
            pictureBox1.Image = Panels.SelectedImage;
            HomeSelectedImage = Panels.SelectedImage;
            if (Weather.WeatherSelectedImage != null)
            {
                pictureBox1.Image = Weather.WeatherSelectedImage;
                HomeSelectedImage = Weather.WeatherSelectedImage;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                // Check if an image is saved in Panels.SelectedImage
                if (Panels.SelectedImage != null)
                {
                    // Assuming pictureBoxMain is the PictureBox to display the image
                    pictureBox1.Image = Panels.SelectedImage;
                }
                else
                {
                    // Provide feedback if no image was saved
                    MessageBox.Show("No image was selected in the previous form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display the exception message in case an error occurs
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TourismNavigation tourismNavigation = new TourismNavigation(); // Pass Form1 as the parent
            tourismNavigation.Show(); // Show Home
            Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Panels.SelectedImage;
            HomeSelectedImage = Panels.SelectedImage;
            if (Weather.WeatherSelectedImage != null)
            {
                pictureBox1.Image = Weather.WeatherSelectedImage;
                HomeSelectedImage = Weather.WeatherSelectedImage;
            }
            Weather weather = new Weather();
            weather.Show(); // Show Weather
            Visible = false ;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            Visible=false ;
        }

        private void Cursor_Change(object sender, EventArgs e)
        {
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox5.Cursor = Cursors.Hand;
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
