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


namespace restaurant
{
    public partial class Bill : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RGKQI3QU\KAMAKSHI;Initial Catalog=restaurant;Integrated Security=True");
        SqlDataAdapter cmd, com;
        int a, flag = 1;

        private void Bill_Load(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "select * from Item";
                cmd.CommandText = query;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboitemname.Items.Add(reader["I_name"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    con.Open();
                    cmd.CommandText = "insert into Master(I_date,subtotal)values " + "(getdate() ," + txtbilltotal.Text + ") select scope_identity() ";

                   string Invoice_no = cmd.ExecuteScalar().ToString();

                    foreach (ListViewItem ListItem in listView1.Items)
                    {
                        cmd.CommandText = "insert into Bill(Master_id,item,rate,quantity,total)values('" + Invoice_no + "','" + ListItem.SubItems[0].Text + "','" + ListItem.SubItems[1].Text + "','" + ListItem.SubItems[2].Text + "','" + ListItem.SubItems[3].Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    MessageBox.Show("Bill Created Successfully, with invoice #" + Invoice_no);

                    new Receipt(Invoice_no).Show();
                }


                catch (Exception ee)
                {
                    MessageBox.Show("Bill Not Saved, Error!" + ee);
                } 
            }
            else
            {
                MessageBox.Show("Must Add an Item in the list");
            }
        }

        private void txtitemquantity_TextChanged(object sender, EventArgs e)
        {
            if (txtitemquantity.Text != "" && txtitemrate.Text != "")
            {
                txttot.Text = ((Convert.ToInt16(txtitemquantity.Text)) * (Convert.ToInt16(txtitemrate.Text))).ToString();
            }
        }

        private void comboitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "select I_rate from Item where I_name='" + comboitemname.Text + "'";
                cmd.CommandText = query;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    txtitemrate.Text = reader["I_rate"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void butbillprint_Click(object sender, EventArgs e)
        {
           // new Form1().Show();
        }

        private void txtitemrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbilltotal_TextChanged(object sender, EventArgs e)
        {

        }

        public Bill()
        {
            InitializeComponent();
        }

        private void butadditemlist_Click(object sender, EventArgs e)
        {

            string[] arr = new string[4];
            arr[0] = comboitemname.SelectedItem.ToString();
            arr[1] = txtitemrate.Text;
            arr[2] = txtitemquantity.Text;
            arr[3] = txttot.Text;

            ListViewItem lvi = new ListViewItem(arr);

            listView1.Items.Add(lvi);

            txtitemquantity.Text = "";
            txtitemrate.Text = "";
            comboitemname.Text = "";
           

            txtbilltotal.Text = (Convert.ToInt16(txtbilltotal.Text) + Convert.ToInt16(txttot.Text)).ToString();
            txttot.Text = "";

        }
    }
}
