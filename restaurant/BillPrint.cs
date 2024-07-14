using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Hotel
{
    public partial class BillPrint : Form
    {
        public BillPrint()
        {
            InitializeComponent();
        }

        private void BillPrint_Load(object sender, EventArgs e)
        {
         /*   string ConnectionString = "Data Source=LAPTOP-RGKQI3QU\SQLEXPRESS;Initial Catalog=restaurant;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(" select * from View_Bill where Invoice_no='"++"'");
            DataSet1 ds=new DataSet1();
            da.Fill(ds,"DataTableBill");

            Repo*/
        }
    }
}
