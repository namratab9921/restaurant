using Microsoft.Reporting.WinForms;
using restaurant.report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class Form1 : Form
    {
        string _invoice_no;
        public Form1(string _no)
        {
            _invoice_no = _no;
            InitializeComponent();
        }

        public Form1()
        {
            // TODO: Complete member initialization
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=LAPTOP-RGKQI3QU\KAMAKSHI;Initial Catalog=restaurant;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from View_Bill where Invoice_no='"+_invoice_no+"'",con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTableBill");
            ReportDataSource datasource = new ReportDataSource("DataSetBill",ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=LAPTOP-RGKQI3QU\KAMAKSHI;Initial Catalog=restaurant;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from View_Bill where Invoice_no='" +textBox1.Text+ "'", con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTableBill");
            ReportDataSource datasource = new ReportDataSource("DataSetBill", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
