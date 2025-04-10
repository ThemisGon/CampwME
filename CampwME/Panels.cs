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
    public partial class Panels : Form
    {
        private Bitmap originalImage;   // Original image
        private Bitmap revealedImage;  // Gradually revealed image
        private Timer revealTimer;     // Timer for revealing the image
        private int currentStage;      // Tracks the current stage (0-3)
        private int stageHeight;       // Height of each stage (25% of the total image)

        public static Image SelectedImage { get; private set; } // Static property to store the selected image

        public static Panels PanelInstance;
        public Panels()
        {
            InitializeComponent();
            PanelInstance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(107, 98, 47); // Custom RGB color

            // Check if an image is loaded into pictureBox1
            if (pictureBox1.Image != null)
            {
                originalImage = new Bitmap(pictureBox1.Image);
                revealedImage = new Bitmap(originalImage.Width, originalImage.Height);

                // Start with a blank image in the PictureBox
                pictureBox1.Image = revealedImage;

                // Calculate the height for each stage (25% of the total image height)
                stageHeight = originalImage.Height / 4;
            }
            else
            {
                MessageBox.Show("No image loaded in pictureBox1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Initialize ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 4; // 4 stages (0-4)
            progressBar1.Value = 0;

            // Initialize Timer
            revealTimer = new Timer();
            revealTimer.Interval = 1000; // Adjust the interval for each stage (1 second per stage)
            revealTimer.Tick += RevealTimer_Tick;

            // Start the reveal process
            currentStage = 0;
            revealTimer.Start();
        }
        private void RevealTimer_Tick(object sender, EventArgs e)
        {
            if (currentStage < 4) // Ensure we only reveal up to 100%
            {
                using (Graphics g = Graphics.FromImage(revealedImage))
                {
                    // Draw the next 25% of the image
                    g.DrawImage(originalImage,
                                new Rectangle(0, 0, originalImage.Width, (currentStage + 1) * stageHeight), // Destination
                                new Rectangle(0, 0, originalImage.Width, (currentStage + 1) * stageHeight), // Source
                                GraphicsUnit.Pixel);
                }

                // Update the PictureBox
                pictureBox1.Image = revealedImage;
                pictureBox1.Refresh();

                // Update the ProgressBar
                progressBar1.Value = currentStage + 1;

                // Move to the next stage
                currentStage++;
            }
            else
            {
                // Stop the timer once all stages are complete
                revealTimer.Stop();
                progressBar1.Visible = false;
                label2.AutoSize = false; // Disable AutoSize
                label2.Text = "Your Tent has been created!";
                label7.Text = "Protected Clothes:";
                label1.Visible = true;
                pictureBox3.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox9.Visible = true;
            }
        }
        private void PictureBox_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }
        private void LightingPage(object sender, EventArgs e)
        {
            Lighting lighting = new Lighting(); // Pass Form1 as the parent
            lighting.Show(); // Show Lighting
            Visible = false;
        }

        private void Weather_Enter(object sender, EventArgs e)
        {
            panel3.Visible = true;
            Cursor = Cursors.Help;
            label9.Visible = true;
        }

        private void Weather_Leave(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Cursor = Cursors.Default;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Tent;
            // Show a MessageBox with Yes and No buttons
            DialogResult result = MessageBox.Show("Are you sure with your decision?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check which button the user clicked
            if (result == DialogResult.Yes)
            {
                SelectedImage = Properties.Resources.Tent; // Save the image in the static property
                Lighting lighting = new Lighting(); // Pass Form1 as the parent
                lighting.Show(); // Show Lighting
                Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Light_protected_tent;
            pictureBox1.Location = new Point(190, 157);
            pictureBox1.Height = 106;
            pictureBox1.Width = 92;
            // Show a MessageBox with Yes and No buttons
            DialogResult result = MessageBox.Show("Are you sure with your decision?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check which button the user clicked
            if (result == DialogResult.Yes)
            {
                SelectedImage = Properties.Resources.Light_protected_tent; // Save the image in the static property
                Lighting lighting = new Lighting(); // Pass Form1 as the parent
                lighting.Show(); // Show Lighting
                Visible = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Strong_protected_tent;
            pictureBox1.Location = new Point(175, 157);
            pictureBox1.Height = 113;
            pictureBox1.Width = 125;
            // Show a MessageBox with Yes and No buttons
            DialogResult result = MessageBox.Show("Are you sure with your decision?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check which button the user clicked
            if (result == DialogResult.Yes)
            {
                SelectedImage = Properties.Resources.Strong_protected_tent; // Save the image in the static property
                Lighting lighting = new Lighting(); // Pass Form1 as the parent
                lighting.Show(); // Show Lighting
                Visible = false;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Light_protected_tent;
            SelectedImage = Properties.Resources.Light_protected_tent; // Save the image in the static property
            MessageBox.Show("The Light Protected Cloths have been placed!", "Protected Cloths", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Lighting lighting = new Lighting(); // Pass Form1 as the parent
            lighting.Show(); // Show Lighting
            Visible = false;
        }

        private void Auto_Enter(object sender, EventArgs e)
        {
            panel4.Visible = true;
            Cursor = Cursors.Help;
        }

        private void Auto_Leave(object sender, EventArgs e)
        {
            panel4.Visible = false;
            Cursor = Cursors.Default;
        }

        private void hover_image(object sender, EventArgs e)
        {
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox6.Cursor = Cursors.Hand;
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
