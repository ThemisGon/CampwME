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
    public partial class Order : Form
    {
        public static Order OrderInstance;
        public Order()
        {
            InitializeComponent();
            OrderInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CursorChange(object sender, EventArgs e)
        {
            //panel3 Panel
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox3.Cursor = Cursors.Hand;
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            //FoodTime Panel
            pictureBox6.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            button6.Cursor = Cursors.Hand;
            button7.Cursor = Cursors.Hand;
            //DrinkTime Panel
            pictureBox8.Cursor = Cursors.Hand;
            button8.Cursor = Cursors.Hand;
            button9.Cursor = Cursors.Hand;
            button10.Cursor = Cursors.Hand;
            button11.Cursor = Cursors.Hand;
            button12.Cursor = Cursors.Hand;

            Help.Cursor = Cursors.Help;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "Click the Food Icon";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "Click the Drinks Icon";
        }

        //Food
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Foodtime.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }
        //Drinks
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Foodtime.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HelpFoodtime.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "Pay Now")
            {
                label14.Text = "It is served after breakfast at 12.30Pm";
            }
            else
            {
                label14.Text = "You Pay for the Product Now";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "Pay Later")
            {
                label14.Text = "It is served after Lunch at 4.30Pm";
            }
            else
            {
                label14.Text = "You Pay for the Product Later";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "Pay Now")
            {
                label11.Text = "Your order has been placed";
                label14.Text = "How can i Help?";
                label13.Text = "What does this functions do:";
                button5.Text = "Pay Now";
                button6.Text = "Pay Later";
                button7.Visible = false;
                button3.Text = "Pay Now";
                button4.Text = "Pay Later";
            }
            else
            {
                MessageBox.Show("The value of the product has been payed.");
                // Show a MessageBox with Yes and No buttons
                DialogResult result = MessageBox.Show("There is a concert happening nearby, will you be there ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Check which button the user clicked
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Perfect, let's head there now!");
                    Concert concert = new Concert();
                    concert.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("That's totally understandable you must be tired, let's head back to camping.");
                    Home home = new Home(); // Pass Form1 as the parent
                    home.Show(); // Show Home
                    Visible = false;
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "Pay Later")
            {
                label11.Text = "Your order has been placed";
                label14.Text = "How can i Help?";
                label13.Text = "What does this functions do:";
                button5.Text = "Pay Now";
                button6.Text = "Pay Later";
                button7.Visible = false;
                button3.Text = "Pay Now";
                button4.Text = "Pay Later";
            }
            else
            {
                MessageBox.Show("The value of the product has been placed into your bag and will be payed later.");
                // Show a MessageBox with Yes and No buttons
                DialogResult result = MessageBox.Show("There is a concert happening nearby, will you be there ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Check which button the user clicked
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Perfect, let's head there now!");
                    Concert concert = new Concert();
                    concert.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("That's totally understandable you must be tired, let's head back to camping.");
                    Home home = new Home(); // Pass Form1 as the parent
                    home.Show(); // Show Home
                    Visible = false;
                }
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label11.Text = "Your order has been placed";
            label14.Text = "How can i Help?";
            label13.Text = "What does this functions do:";
            button5.Text = "Pay Now";
            button6.Text = "Pay Later";
            button7.Visible = false;
            button3.Text = "Pay Now";
            button4.Text = "Pay Later";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            HelpDrinktime.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text != "Pay Now")
            {
                label15.Text = "It is served after breakfast at 12.30Pm";
            }
            else
            {
                label15.Text = "You Pay for the Product Now";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label16.Text = "Your order has been placed";
            label15.Text = "How can i Help?";
            label10.Text = "What does this functions do:";
            button12.Text = "Pay Now";
            button11.Text = "Pay Later";
            button8.Visible = false;
            button10.Text = "Pay Now";
            button9.Text = "Pay Later";
        }

        private void Help_Click(object sender, EventArgs e)
        {
            OnlineHelp onhel = new OnlineHelp(); // Pass Form1 as the parent
            onhel.Show(); // Show bas
            //Visible = false;
        }
    }
}
