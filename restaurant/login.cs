using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            string USER, PASSWORD;
            if (txtuser.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Please enter Data");
            }
            else
            {

                USER = txtuser.Text.ToString();
                PASSWORD = txtpass.Text.ToString();


                if (USER == "A" && PASSWORD == "B")
                {
                    admin f = new admin();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }

            }
        }

        private void butclose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}