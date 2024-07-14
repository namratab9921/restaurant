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
   
    public partial class Category : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-RGKQI3QU\KAMAKSHI;Initial Catalog=restaurant;Integrated Security=True");
        SqlDataAdapter cmd, com;
        int a, flag = 1;

        public Category()
        {
            InitializeComponent();
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            txtcategoryno.Focus();
            con.Open();
            string query = "Select Max(I_categoryno) from Category";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();

                if (val == "")
                {
                    txtcategoryno.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtcategoryno.Text = a.ToString();
                }
                con.Close();
            }
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            if (txtcategoryname.Text == "")
            {
                MessageBox.Show("Please Enter Category");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Category(I_categoryno,I_category) values(" + Int16.Parse(txtcategoryno.Text) + ",'" + txtcategoryname.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category inserted Successfully");
                txtcategoryno.Text = "";
                txtcategoryname.Text = "";
            }
        }

        private void butview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Category";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridcategory.DataSource = dt;
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
                cmd.CommandText = "delete from Category where I_category='" + txtcategoryname.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.restaurantDataSet.Category);

        }
    }
}
