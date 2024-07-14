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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            item f = new item();
            f.Show();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Unit u = new Unit();
            u.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window? ";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
