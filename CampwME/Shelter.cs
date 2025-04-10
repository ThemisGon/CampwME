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
    public partial class Shelter : Form
    {
        public static Shelter ShelterInstance;
        public Shelter()
        {
            InitializeComponent();
            ShelterInstance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShelterNavigation shelterNavigation = new ShelterNavigation(); // Pass Form1 as the parent
            shelterNavigation.Show(); // Show shelterNavigation
            Visible = false;
        }

        private void Cursor_Change(object sender, EventArgs e)
        {
            button8.Cursor = Cursors.Hand;
        }
    }
}
