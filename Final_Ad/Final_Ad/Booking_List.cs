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
    public partial class Booking_List : Form
    {
        public SqlConnection conn;
        public String constring;
        public Booking_List()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
            /*string BookDate = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (BookDate == "")
            {
                Bookkey = 0;
            }
            else {
                Bookkey = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            } */
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           /* string Bookid = "";
            e.Graphics.DrawString("Booking Summary", new Font("Century Gothic", 25, FontStyle.Regular), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Booking Id"+ Bookid, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.BlueViolet, new Point(130,150));*/
        }

        private void Booking_List_Load(object sender, EventArgs e)
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
            display();
        }
        private void display() {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Bookingtbl";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Bookingtbl where Customer_id='" + cust_ID.Text + "'";

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Booking Detail successfully Delete.", "Success");
                
            }
    
 
    
        
        

        private void cust_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Main_Form mf = new Main_Form();
            mf.Show();
            Hide();
        }

    }
}
