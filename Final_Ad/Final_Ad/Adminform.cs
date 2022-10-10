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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ibresult.Text = "";

            if (txtusername.Text == "" || txtpassword.Text == "")
            {

                Ibresult.Text = "Plese Provide Both User Name and Password";
            }

            else
            {
                if (txtusername.Text == "vish" && txtpassword.Text == "123")
                {
                    Ibresult.Text = "Sucessfully logged in";

                    MessageBox.Show("Sucessfully Logged in");
                    Staff stf = new Staff();
                    stf.Show();
                    Hide();
                    
                }
                    
                else
                {
                    Ibresult.Text = "invalid user name or Password";

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginUserandAdmin lgas = new LoginUserandAdmin();
            lgas.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}