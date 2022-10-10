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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\VISHNU\Documents\HallBookingManagement.mdf;Integrated Security=True;Connect Timeout=30");
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                beerpice.Enabled = true;
                beerquty.Enabled = true;
            }
            else
            {
                beerpice.Enabled = false;
                beerquty.Enabled = false;
                beerpice.Text = "";
                beerquty.Text = "";
            }
        }

        private void sodacheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (sodacheck.Checked == true)
            {
                sodaprice.Enabled = true;
                sodaqtn.Enabled = true;
            }
            else
            {
                sodaprice.Enabled = false;
                sodaqtn.Enabled = false;
                sodaprice.Text = "";
                sodaqtn.Text = "";
            }
        }

        private void winecheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (winecheck.Checked == true)
            {
                winprice.Enabled = true;
                winqtn.Enabled = true;
            }
            else
            {
                winprice.Enabled = false;
                winqtn.Enabled = false;
                winprice.Text = "";
                winqtn.Text = "";
            }
        }

        private void watercheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (watercheck.Checked == true)
            {
                waterprice.Enabled = true;
                waterqtn.Enabled = true;
            }
            else
            {
                waterprice.Enabled = false;
                waterqtn.Enabled = false;
                waterprice.Text = "";
                waterqtn.Text = "";
            }
        }

        private void juicecheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void juicecheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (juicecheck.Checked == true)
            {
                juiceprice.Enabled = true;
                juiceqtn.Enabled = true;
            }
            else
            {
                juiceprice.Enabled = false;
                juiceqtn.Enabled = false;
                juiceprice.Text = "";
                juiceqtn.Text = "";
            }
        }

        private void mottoncheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (mottoncheck.Checked == true)
            {
                mottonprice.Enabled = true;
                mottonqnt.Enabled = true;
            }
            else
            {
                mottonprice.Enabled = false;
                mottonqnt.Enabled = false;
                mottonprice.Text = "";
                mottonqnt.Text = "";
            }
        }

        private void chickencheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (chickencheck.Checked == true)
            {
                chickenprice.Enabled = true;
                chickenqtn.Enabled = true;
            }
            else
            {
                chickenprice.Enabled = false;
                chickenqtn.Enabled = false;
                chickenprice.Text = "";
                chickenqtn.Text = "";
            }
        }

        private void fishcheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (fishcheck.Checked == true)
            {
                fishprice.Enabled = true;
                fishqtn.Enabled = true;
            }
            else
            {
                fishprice.Enabled = false;
                fishqtn.Enabled = false;
                fishprice.Text = "";
                fishqtn.Text = "";
            }
        }

        private void soucagecheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (soucagecheck.Checked == true)
            {
                soucageprice.Enabled = true;
                soucageqtn.Enabled = true;
            }
            else
            {
                soucageprice.Enabled = false;
                soucageqtn.Enabled = false;
                soucageprice.Text = "";
                soucageqtn.Text = "";
            }
        }

        private void biriyanicheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (biriyanicheck.Checked == true)
            {
                biriyaniprice.Enabled = true;
                biriyaniqtn.Enabled = true;
            }
            else
            {
                biriyaniprice.Enabled = false;
                biriyaniqtn.Enabled = false;
                biriyaniprice.Text = "";
                biriyaniqtn.Text = "";
            }
        }

        private void CalculateDrink_Click(object sender, EventArgs e)
        {
            int beer = 0, soda = 0, wine = 0, water = 0, juice = 0;
            if (checkBox1.Checked == true && beerpice.Text == "" && beerquty.Text == "")
            {
                MessageBox.Show("Enter Beer Quantity");
            }
            else
            {
                beer = Convert.ToInt32(beerpice.Text) * Convert.ToInt32(beerquty.Text);
            }
            //   Soda
            if (sodacheck.Checked == true && sodaprice.Text == "" && sodaqtn.Text == "")
            {
                MessageBox.Show("Enter Soda Quantity");
            }
            else
            {
                soda = Convert.ToInt32(sodaprice.Text) * Convert.ToInt32(sodaqtn.Text);
            }
            //wine
            if (winecheck.Checked == true && winprice.Text == "" && winqtn.Text == "")
            {
                MessageBox.Show("Enter win Quantity");
            }
            else
            {
                wine = Convert.ToInt32(winprice.Text) * Convert.ToInt32(winqtn.Text);
            }
            //Water
            if (watercheck.Checked == true && waterprice.Text == "" && waterqtn.Text == "")
            {
                MessageBox.Show("Enter water Quantity");
            }
            else
            {
                water = Convert.ToInt32(waterprice.Text) * Convert.ToInt32(waterqtn.Text);
            }
            //Juice
            if (juicecheck.Checked == true && juiceprice.Text == "" && juiceqtn.Text == "")
            {
                MessageBox.Show("Enter juice Quantity");
            }
            else
            {
                juice = Convert.ToInt32(juiceprice.Text) * Convert.ToInt32(juiceqtn.Text);
            }
            int bevcost = wine + beer + juice + water + soda;
            CalculateDrink.Text = "" + bevcost;
        }
        // int Food_Cost = 0;
        private void CalculateFood_Click(object sender, EventArgs e)
        {

            int motton = 0, chicken = 0, fish = 0, soucage = 0, biriyani = 0;
            if (mottoncheck.Checked == true && mottonprice.Text == "" && mottonqnt.Text == "")
            {
                MessageBox.Show("Enter motton Quantity");
            }
            else
            {
                motton = Convert.ToInt32(mottonprice.Text) * Convert.ToInt32(mottonqnt.Text);
                //  dishes = dishes + "motton" + " ";
            }
            //   Chicken
            if (chickencheck.Checked == true && chickenprice.Text == "" && chickenqtn.Text == "")
            {
                MessageBox.Show("Enter chicken Quantity");
            }
            else
            {
                chicken = Convert.ToInt32(chickenprice.Text) * Convert.ToInt32(chickenqtn.Text);
            }
            //Fish
            if (fishcheck.Checked == true && fishprice.Text == "" && fishqtn.Text == "")
            {
                MessageBox.Show("Enter fish Quantity");
            }
            else
            {
                fish = Convert.ToInt32(fishprice.Text) * Convert.ToInt32(fishqtn.Text);
            }
            //soucages
            if (soucagecheck.Checked == true && soucageprice.Text == "" && soucageqtn.Text == "")
            {
                MessageBox.Show("Enter soucage Quantity");
            }
            else
            {
                soucage = Convert.ToInt32(soucageprice.Text) * Convert.ToInt32(soucageqtn.Text);
            }
            //Biriyani
            if (biriyanicheck.Checked == true && biriyaniprice.Text == "" && biriyaniqtn.Text == "")
            {
                MessageBox.Show("Enter Biriyani Quantity");
            }
            else
            {
                biriyani = Convert.ToInt32(biriyaniprice.Text) * Convert.ToInt32(biriyaniqtn.Text);
            }
            int bevcost = motton + chicken + fish + soucage + biriyani;
            CalculateFood.Text = "" + bevcost;
        }
        public void GetCustId()
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("Select customer_id from Customer", constring);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("customer_id", typeof(string));
            dt.Load(rdr);
            custidCb.ValueMember = "customer_id";
            custidCb.DataSource = dt;

            constring.Close();

        }
        private void Booking_Load(object sender, EventArgs e)
        {
            GetCustId();
        }
        private void fetchcustName()
        {
            constring.Open();
            string mysql       = "select * from Customer where customer_id=" + custidCb.SelectedValue.ToString() + "";
            SqlCommand cmd     = new SqlCommand(mysql, constring);
            DataTable dt       = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Custnamelbl.Text = "" + dr["Name"].ToString();
            }
            constring.Close();
        }
        private void custidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchcustName();
        }

        private void grdtotal_TextChanged(object sender, EventArgs e)
        {


        }

        private void grd_total_Click(object sender, EventArgs e)
        {
            int food      = int.Parse(CalculateFood.Text);
            int drinks    = int.Parse(CalculateDrink.Text);
            int icecreame = int.Parse(Calculateice.Text);
            int halltype  = int.Parse(calculatehall.Text);
            int others    = int.Parse(otharcost.Text);
            int total = food + drinks + icecreame + halltype + others;
            grdtotal.Text = total.ToString();

        }

        private void otharcost_TextChanged(object sender, EventArgs e)
        {
            int other_charge = Convert.ToInt32(otharcost.Text);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int Advance    = Convert.ToInt32(button17.Text);
            double advance = Advance;


        }

        private void balancebtn_Click(object sender, EventArgs e)
        {
            double Total   = int.Parse(grdtotal.Text);
            double Advance = int.Parse(advance.Text);
            double Balance = Total - Advance;
            balance.Text   = Balance.ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked  == true)
            {
                vanilaprice.Enabled = true;
                vanilaqtn.Enabled   = true;
            }
            else
            {
                vanilaprice.Enabled = false;
                vanilaqtn.Enabled   = false;
                vanilaprice.Text    = "";
                vanilaqtn.Text      = "";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int Venilla = 0, Chocolate = 0, Strawberry = 0, Neapolitan = 0, Cooki_ice = 0;
            if (checkBox11.Checked == true && vanilaprice.Text == "" && vanilaqtn.Text == "")
            {
                MessageBox.Show("Enter Venilla Quantity");
            }
            else
            {
                Venilla = Convert.ToInt32(vanilaprice.Text) * Convert.ToInt32(vanilaqtn.Text);
            }
            //   Chocolate
            if (checkBox10.Checked == true && choclateprice.Text == "" && chockqtn.Text == "")
            {
                MessageBox.Show("Enter Chocolate Quantity");
            }
            else
            {
                Chocolate = Convert.ToInt32(choclateprice.Text) * Convert.ToInt32(chockqtn.Text);
            }
            //Strawberry
            if (checkBox9.Checked == true && strawprice.Text == "" && straqtn.Text == "")
            {
                MessageBox.Show("Enter Strawberry Quantity");
            }
            else
            {
                Strawberry = Convert.ToInt32(strawprice.Text) * Convert.ToInt32(straqtn.Text);
            }
            //Neapolitan
            if (checkBox8.Checked == true && neapoliprice.Text == "" && neapoliqtm.Text == "")
            {
                MessageBox.Show("Enter Neapolitan Quantity");
            }
            else
            {
                Neapolitan = Convert.ToInt32(neapoliprice.Text) * Convert.ToInt32(neapoliqtm.Text);
            }
            //Cooki_ice
            if (checkBox7.Checked == true && cookiprice.Text == "" && cookiqtn.Text == "")
            {
                MessageBox.Show("Enter Cooki_ice Quantity");
            }
            else
            {
                Cooki_ice = Convert.ToInt32(cookiprice.Text) * Convert.ToInt32(cookiqtn.Text);
            }
            int bevcost = Venilla + Chocolate + Neapolitan + Strawberry + Cooki_ice;
            Calculateice.Text = "" + bevcost;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void custidCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked    == true)
            {
                choclateprice.Enabled = true;
                chockqtn.Enabled      = true;
            }
            else
            {
                choclateprice.Enabled = false;
                chockqtn.Enabled      = false;
                choclateprice.Text    = "";
                chockqtn.Text         = "";
            }

        }

        private void checkBox9_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked  == true)
            {
                strawprice.Enabled = true;
                straqtn.Enabled    = true;
            }
            else
            {
                strawprice.Enabled = false;
                straqtn.Enabled    = false;
                strawprice.Text    = "";
                straqtn.Text       = "";
            }
        }

        private void checkBox8_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked    == true)
            {
                neapoliprice.Enabled = true;
                neapoliqtm.Enabled   = true;
            }
            else
            {
                neapoliprice.Enabled = false;
                neapoliqtm.Enabled   = false;
                neapoliprice.Text    = "";
                neapoliqtm.Text      = "";
            }
        }

        private void checkBox7_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked  == true)
            {
                cookiprice.Enabled = true;
                cookiqtn.Enabled   = true;
            }
            else
            {
                cookiprice.Enabled = false;
                cookiqtn.Enabled   = false;
                cookiprice.Text    = "";
                cookiqtn.Text      = "";
            }
        }

        private void meetingview_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckStateChanged(object sender, EventArgs e)
        {
            // Wedding
            if (checkBox6.Checked == true)
            {
                wedprice.Enabled = true;
                wedhrs.Enabled = true;
            }
            else
            {
                wedprice.Enabled = false;
                wedhrs.Enabled = false;
                wedprice.Text = "";
                wedhrs.Text = "";
            }
        }

        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {
            // Birthday
            if (checkBox5.Checked == true)
            {
                birthprice.Enabled = true;
                birthhrs.Enabled = true;
            }
            else
            {
                birthprice.Enabled = false;
                birthhrs.Enabled = false;
                birthprice.Text = "";
                birthhrs.Text = "";
            }
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            // Reception
            if (checkBox4.Checked == true)
            {
                recepprice.Enabled = true;
                recephrs.Enabled = true;
            }
            else
            {
                recepprice.Enabled = false;
                recephrs.Enabled = false;
                recepprice.Text = "";
                recephrs.Text = "";
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            // Cultural
            if (checkBox2.Checked == true)
            {
                culturalprice.Enabled = true;
                culturalhrs.Enabled = true;
            }
            else
            {
                culturalprice.Enabled = false;
                culturalhrs.Enabled = false;
                culturalprice.Text = "";
                culturalhrs.Text = "";
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            // Meetings
            if (checkBox3.Checked == true)
            {
                meetingprice.Enabled = true;
                meetinghrs.Enabled = true;
            }
            else
            {
                meetingprice.Enabled = false;
                meetinghrs.Enabled = false;
                meetingprice.Text = "";
                meetinghrs.Text = "";
            }
        }
        // Halls
        private void button18_Click(object sender, EventArgs e)
        {
            int Wedding = 0, Birthday = 0, Reception = 0, Meetings = 0, Cultural = 0;
            if (checkBox6.Checked == true && wedprice.Text == "" && wedhrs.Text == "")
            {
                MessageBox.Show("Enter Hall Type ");
            }
            else
            {
                Wedding = Convert.ToInt32(wedprice.Text) * Convert.ToInt32(wedhrs.Text);
            }
            //   Birthday
            if (checkBox5.Checked == true && birthprice.Text == "" && birthhrs.Text == "")
            {
                MessageBox.Show("Enter The Hall Type");
            }
            else
            {
                Birthday = Convert.ToInt32(birthprice.Text) * Convert.ToInt32(birthhrs.Text);
            }
            //Reception
            if (checkBox4.Checked == true && recepprice.Text == "" && recephrs.Text == "")
            {
                MessageBox.Show("Enter The Hall Type");
            }
            else
            {
                Reception = Convert.ToInt32(recepprice.Text) * Convert.ToInt32(recephrs.Text);
            }
            //Meetings
            if (checkBox3.Checked == true && meetingprice.Text == "" && meetinghrs.Text == "")
            {
                MessageBox.Show("Enter The Hall Type");
            }
            else
            {
                Meetings = Convert.ToInt32(meetingprice.Text) * Convert.ToInt32(meetinghrs.Text);
            }
            //Cultural
            if (checkBox2.Checked == true && culturalprice.Text == "" && culturalhrs.Text == "")
            {
                MessageBox.Show("Enter The Hall Type");
            }
            else
            {
                Cultural = Convert.ToInt32(culturalprice.Text) * Convert.ToInt32(culturalhrs.Text);
            }
            int bevcost = Wedding + Birthday + Reception + Meetings + Cultural;
            calculatehall.Text = "" + bevcost;
        }

        private void clickbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void clickbtn_Click_1(object sender, EventArgs e)
        {
            /*constring.Open();
            SqlCommand cmd = constring.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Bookingtbl VALUES('" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + CalculateDrink.Text +"','"+CalculateFood.Text+ "','"+calculatehall.Text+ "','"+Calculateice.Text+ "','"+otharcost.Text+ "','"+grdtotal.Text+ "','"+advance.Text+ "','"+balance.Text+ "')";

            cmd.ExecuteNonQuery();
            constring.Close();

            MessageBox.Show("Booking Details Successfully Add ");
            /*if (custidCb.Text == "" || dateTimePicker1.Text == "" || comboBox1.Text == "" || Custnamelbl.Text == "" || textBox1.Text == "" || Custnamelbl.Text == "" || CalculateDrink.Text == "" || CalculateFood.Text == "" || calculatehall.Text == "" || Calculateice.Text == "" || otharcost.Text == "" || grdtotal.Text == "" || advance.Text == "" || balance.Text == "")
            {
                MessageBox.Show("Data Is Missing");
            }
            else
            {
                try
                {
                    constring.Open();
                    string query = "insert into Bookingtbl values('" + custidCb.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + Custnamelbl.Text + "','" + CalculateDrink.Text + "','" + CalculateFood.Text + "','" + calculatehall.Text + "','" + Calculateice.Text + "','" + otharcost.Text + "','" + grdtotal.Text + "','" + advance.Text + "','" + balance.Text + "' ) ";
                    SqlCommand cmd = new SqlCommand(query, constring);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Details Successfully Added");
                    constring.Close();
                    //display();
                    //clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }*/

            }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            if (custidCb.Text == "" || dateTimePicker1.Text == "" || comboBox1.Text == "" || Custnamelbl.Text == "" || textBox1.Text == "" || Custnamelbl.Text == "" || CalculateDrink.Text == "" || CalculateFood.Text == "" || calculatehall.Text == "" || Calculateice.Text == "" || otharcost.Text == "" || grdtotal.Text == "" || advance.Text == "" || balance.Text == "")
            {
                MessageBox.Show("Data Is Missing");
            }
            else
            {
                try
                {
                    constring.Open();
                    SqlCommand cmd = constring.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Bookingtbl VALUES('" + custidCb.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + CalculateDrink.Text + "','" + CalculateFood.Text + "','" + calculatehall.Text + "','" + Calculateice.Text + "','" + otharcost.Text + "','" + grdtotal.Text + "','" + advance.Text + "','" + balance.Text + "')";

                    cmd.ExecuteNonQuery();
                    constring.Close();

                    MessageBox.Show("Booking Details Successfully Add ");
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void Custnamelbl_Click(object sender, EventArgs e)
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
