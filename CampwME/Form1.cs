using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace CampwME
{
    public partial class Form1 : Form
    {
        //Bazo ena instance public gia na mporo na pernao dedomena apo thn mia sthn allh
        public static Form1 form1Instance;

        public Form1()
        {
            InitializeComponent();
            form1Instance = this;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new System.Drawing.Point(200, 100); // Set X=200, Y=100

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Map map = new Map(); // Pass Form1 as the parent
            map.Show(); // Show Map
            Visible = false;
        }

        private void Cursor_Change(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }
    }
}
