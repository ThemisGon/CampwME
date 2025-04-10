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
    
    public partial class OnlineHelp : Form
    {
        public static OnlineHelp OnlineHelpInstance;
        public OnlineHelp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            OnlineHelpInstance = this;
            this.StartPosition = FormStartPosition.CenterScreen;

            Map.Visible = true;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Map.Visible = true;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = true;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = true;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = true;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = true;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = true;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = true;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = true;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = true;
            Order.Visible = false;
            Concert.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = true;
            Concert.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Map.Visible = false;
            Stakes.Visible = false;
            Panels.Visible = false;
            Lighting.Visible = false;
            SolarPanel.Visible = false;
            ShelterNavigation.Visible = false;
            Home.Visible = false;
            TourismNavigation.Visible = false;
            WeatherConditions.Visible = false;
            Order.Visible = false;
            Concert.Visible = true;
        }

        private void Cursor_Change(object sender, EventArgs e)
        {
            button2.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            button6.Cursor = Cursors.Hand;
            button7.Cursor = Cursors.Hand;
            button9.Cursor = Cursors.Hand;
            button10.Cursor = Cursors.Hand;
            button11.Cursor = Cursors.Hand;
            button12.Cursor = Cursors.Hand;
            button13.Cursor = Cursors.Hand;
        }
    }
}
