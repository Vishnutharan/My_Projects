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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\VISHNU\Documents\HallBookingManagement.mdf;Integrated Security=True;Connect Timeout=30");
        private void display()
        {
            conn.Open();
            string query = "Select* from stafftbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            staffdgv.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (staffnametxt.Text == "" || staffphonetxt.Text == "" || staffpasswordtxt.Text == "" || staffgendercom.SelectedIndex == -1)
            {
                MessageBox.Show("Data Is Missing");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO stafftbl VALUES('" + staffnametxt.Text + "','" + staffphonetxt.Text + "','" + staffgendercom.Text + "', '" + staffpasswordtxt.Text + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data successfully inserted");
                    display();
                    clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            display();
        }
        //int staffkey = 0;
        private void clear()
        {
            staffnametxt.Text = "";
            staffpasswordtxt.Text = "";
            staffidtxt.Text = "";
           // staffkey = 0;
            staffphonetxt.Text = "";
            staffgendercom.SelectedItem = -1;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {

            if (staffidtxt.Text == "")
            {
                MessageBox.Show("Please Provide The Id You need to Delete");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from stafftbl where Staff_Id = '" + staffidtxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data successfully Delete");
                    clear();
                    display();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void staffdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*    staffnametxt.Text = staffdgv.SelectedRows[0].Cells[1].Value.ToString();
                staffphonetxt.Text = staffdgv.SelectedRows[0].Cells[2].Value.ToString();
                staffgendercom.SelectedItem = staffdgv.SelectedRows[0].Cells[3].Value.ToString();
                staffpasswordtxt.Text = staffdgv.SelectedRows[0].Cells[4].Value.ToString();

                if (staffdgv.Text == "")
                {
                    staffkey = 0;
                }
                else
                {
                    staffkey = Convert.ToInt32(staffdgv.SelectedRows[0].Cells[0].Value.ToString());
                } */
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

                             }

        private void scarchbtn_Click(object sender, EventArgs e)
        {

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stafftbl where Staff_Id ='" + staffidtxt.Text + "'";

            cmd.ExecuteNonQuery();                                                               // use to execute command statement which to give u from sql comand // Activation Code

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);                                        // squl adpter Adapt the data from mysqul 
            da.Fill(dt);                                                                        // Fill The Table form the adpter on the gride view 

            staffdgv.DataSource = dt;

            conn.Close();

            staffidtxt.Clear();

        }

        private void upbtn_Click(object sender, EventArgs e)
        {

            if (staffidtxt.Text == " " || staffnametxt.Text == "" || staffphonetxt.Text == "" || staffgendercom.Text == "" || staffpasswordtxt.Text == "")
            {
                MessageBox.Show("Data Is Missing");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " UPDATE stafftbl Staff_Name =  '" + staffnametxt.Text + "', Staff_Phone =  '" + staffphonetxt.Text + "', Staff_Gender =  '" + staffgendercom + "', Staff_Password  = '" + staffpasswordtxt.Text + "', where Staff_Id = '" + staffidtxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data successfully Updated");
                    clear();
                    display();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Adminform Af = new Adminform();
            Af.Show();
            Hide();
        }
                     }
             }
      