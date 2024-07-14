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
    public partial class Unit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RGKQI3QU\KAMAKSHI;Initial Catalog=restaurant;Integrated Security=True");
        SqlDataAdapter cmd, com;
        int a, flag = 1;

        public Unit()
        {
            InitializeComponent();
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            if (txtuniname.Text == "")
            {
                MessageBox.Show("Please Enter Unit");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Unit(Unit_no,Unit) values(" + Int16.Parse(txtunino.Text) + ",'" + txtuniname.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Unit inserted Successfully");
                txtunino.Focus();
                txtuniname.Text = "";
                txtunino.Text = "";
            }
        }

        private void butview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Unit";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void butdel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from Unit where Unit_no=" + Int16.Parse(txtunino.Text) + "";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Unit Deleted Successfully");
                txtunino.Focus();
                txtuniname.Text = "";
                txtunino.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.restaurantDataSet.Unit);

        }

        private void butnew_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtuniname.Focus();
            con.Open();
            string query = "Select Max(Unit_no) from Unit";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();

                if (val == "")
                {
                    txtunino.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtunino.Text = a.ToString();
                }
                con.Close();
            }
        }
    }
}
