using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Ad
{
    public partial class Form1 : Form
    {
        public SqlConnection conn;
        public String constring;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\VISHNU\Documents\HallBookingManagement.mdf;Integrated Security=True;Connect Timeout=30";
                conn = new SqlConnection(constring);
                // display();
                conn.ConnectionString = constring;
            }

            catch (Exception x)
            {
                MessageBox.Show("Db_error" + x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adname.Text == "" || addpass.Text == "")
            {
                MessageBox.Show("Enter the username and password.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*)from stafftbl where Staff_Name='" + adname.Text + "'and Staff_Password='" + addpass.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        /* wrong.Visible = false;
                         Dashboard dss = new Dashboard();
                         this.Hide();
                         dss.Show();*/
                        MessageBox.Show("Sucessfully Login");
                        //  wrong.Visible = false;
                        Form1 dss = new Form1();
                        this.Hide();
                        dss.Show();
                        conn.Close();
                        Main_Form mf = new Main_Form();
                        mf.Show();
                        Hide();
                    }

                    else
                    {
                        MessageBox.Show("Enter The Correct Username or Password Login");

                        // wrong.Visible = true;
                        addpass.Clear();

                    }
                    


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginUserandAdmin lgas = new LoginUserandAdmin();
            lgas.Show();
            Hide();
        }
    }
}
