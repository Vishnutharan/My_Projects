using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Ad
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            newcustomer newcus = new newcustomer();
            newcus.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Booking bk = new Booking();
            bk.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Booking_List bkl = new Booking_List();
            bkl.Show();
            Hide();
        }
    }
}
