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
    public partial class item : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RGKQI3QU\KAMAKSHI;Initial Catalog=restaurant;Integrated Security=True");
        SqlDataAdapter cmd;
        int a, flag = 1;

        public item()
        {
            InitializeComponent();
        }

        private void item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.restaurantDataSet.Item);
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "select * from Category";
                cmd.CommandText = query;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combocat.Items.Add(reader["I_category"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "select * from Unit";
                cmd.CommandText = query;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combounit.Items.Add(reader["Unit"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void butsave1_Click(object sender, EventArgs e)
        {
            if (txtiname.Text == "")
            {
                MessageBox.Show("Please Enter Item");
            }
            else if (combocat.Text == "")
            {
                MessageBox.Show("Please Select Category");
            }
            else if (txtrate.Text == "")
            {
                MessageBox.Show("Please Enter Rate");
            }
            else if (combounit.Text == "")
            {
                MessageBox.Show("Please Select Unit");
            }
            else if (flag == 1)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Item(I_no,I_name,I_category,I_rate,I_Unit,I_entryDate) values(" + Int16.Parse(txtino.Text) + ",'" + txtiname.Text + "','" + combocat.Text + "'," + Int16.Parse(txtrate.Text) + ",'" + combounit.Text + "','" + dateTimePicker1.Value.ToString() + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Item inserted Successfully");
                

            }
            else
                if (flag == 2)
            {
                try
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "Update Item Set I_category='" + combocat.Text + "',I_rate='" + txtrate.Text + "', I_Unit='" + combounit.Text + "' where I_name='" + txtiname.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item Update Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                txtino.Text = "";
                txtiname.Text = "";
                combocat.Text = "";
                txtrate.Text = "";
                combounit.Text = "";
                this.dateTimePicker1.Text = "";
            }
        }

        private void butedit1_Click(object sender, EventArgs e)
        {
            flag = 2;
            txtiname.Focus();
        }

        private void butdel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from Item where I_name='" + txtiname.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Item Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void butview1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Item";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void butclose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnew1_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtino.Focus();
            con.Open();
            string query = "Select Max(I_no) from Item";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();

                if (val == "")
                {
                    txtino.Text = "101";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtino.Text = a.ToString();
                }
                con.Close();
            }
        }

        private void txtiname_leave(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                /*  string name = txtiname.Text;
                  SqlCommand command = new SqlCommand("select * from Dealer where [dealer_id]=" + name + "");
                  command.Connection = con;
                  SqlDataReader dr = null;
                  con.Open();
                  dr = command.ExecuteReader();
                 if (dr.Read())
                  {
                      txtino.Text = (dr["I_no"].ToString());
                      combocat.Text = (dr["I_category"].ToString());
                      txtrate.Text = (dr["I_rate"].ToString());
                      combounit.Text = (dr["I_unit"].ToString());
                      this.dateTimePicker1.Text = (dr["I_entrydate"].ToString());
                  }
                  con.Close();

              }
              else if ((flag == 2) && (txtiname.Text == ""))
              {
                  MessageBox.Show("Please Enter Dealer Id");
              }
              else
              {
              }*/

            }

        }
    }
}
