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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void hallbtn_Click(object sender, EventArgs e)
        {
            

        }

        private void hallbtn_Click_1(object sender, EventArgs e)
        {
            LoginUserandAdmin lgas = new LoginUserandAdmin();
            lgas.Show();
            Hide();
        }
    }
}
