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
    public partial class LoginUserandAdmin : Form
    {
        public LoginUserandAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fmstaff = new Form1();
            fmstaff.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminform Adfrom = new Adminform();
            Adfrom.Show();
            Hide();
        }
    }
}
