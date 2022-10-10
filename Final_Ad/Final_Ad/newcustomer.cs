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
    public partial class newcustomer : Form
    {
        public SqlConnection conn;
        public String constring;
       // public CustomerDesign()
        public newcustomer()
        {
            InitializeComponent();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
             if (txtname.Text == " " || txtnic.Text == "" || comboBox1.Text == "" || txtphno.Text == "" || txtemail.Text == "")
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
                    cmd.CommandText = "INSERT INTO Customer VALUES(  '" + txtname.Text + "','" + txtnic.Text + "','" + comboBox1.Text + "','" + txtphno.Text + "', '" + txtemail.Text + "' )";


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data successfully inserted");

                    clear();
                    display();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }
             public void display()
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }
             public void clear()
             {

                 txtcusid.Clear();
                 txtname.Clear();
                 txtnic.Clear();
                 comboBox1.Text = "";
                 txtphno.Clear();
                 txtemail.Clear();
                 //   txtname.Focus(); 
             }

             private void deletbtn_Click(object sender, EventArgs e)
             {

                 if (txtcusid.Text == "")
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
                         cmd.CommandText = "Delete from Customer where customer_id  = '" + txtcusid.Text + "'";
                         cmd.ExecuteNonQuery();
                         conn.Close();
                         MessageBox.Show("Data successfully Delete");
                         display();
                         clear();

                     }
                     catch (Exception Ex)
                     {
                         MessageBox.Show(Ex.Message);
                     }
                 }
             }

             private void upbtn_Click(object sender, EventArgs e)
             {

                 if (txtname.Text == " " || txtnic.Text == "" || comboBox1.Text == "" || txtphno.Text == "" || txtemail.Text == "")
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
                         cmd.CommandText = " update Customer set Name =  '" + txtname.Text + "', NIC_Number =  '" + txtnic.Text + "', Gender =  '" + comboBox1.Text + "', Email  = '" + txtemail.Text + "',Mobile_Number  = '" + txtphno.Text + "' where customer_id = '" + txtcusid.Text + "'";
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

             private void newcustomer_Load(object sender, EventArgs e)
             {
                 try
                 {
                     constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\VISHNU\Documents\HallBookingManagement.mdf;Integrated Security=True;Connect Timeout=30";
                     conn = new SqlConnection(constring);
                     display();
                     conn.ConnectionString = constring;
                 }

                 catch (Exception x)
                 {
                     MessageBox.Show("Db_error" + x);
                 }
             }

             private void scarchbtn_Click(object sender, EventArgs e)
             {

                 conn.Open();

                 SqlCommand cmd = conn.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "select * from Customer where customer_id ='" + txtcusid.Text + "'";

                 cmd.ExecuteNonQuery();                                                               // use to execute command statement which to give u from sql comand // Activation Code

                 DataTable dt = new DataTable();
                 SqlDataAdapter da = new SqlDataAdapter(cmd);                                        // squl adpter Adapt the data from mysqul 
                 da.Fill(dt);                                                                        // Fill The Table form the adpter on the gride view 

                 dataGridView1.DataSource = dt;

                 conn.Close();

                 txtcusid.Clear();
             }

             private void button2_Click(object sender, EventArgs e)
             {
                 Main_Form mf = new Main_Form();
                 mf.Show();
                 Hide();
             }
        }
    }

