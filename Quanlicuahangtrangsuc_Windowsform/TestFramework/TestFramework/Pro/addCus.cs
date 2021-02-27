using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFramework.Class;

namespace TestFramework.Pro
{
    public partial class addCus : Form
    {
        public addCus()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            string phone = txtphone.Text;
            string name = txtname.Text;
            string address = txtaddr.Text;  
            if (verif())
            {
                if (order.updateCus(phone,name,address))
                {
                    MessageBox.Show("New Customer Added", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        bool verif()
        {
            if ((txtname.Text.Trim() == "") || (txtphone.Text.Trim() == "") || (txtaddr.Text.Trim() == null))
            {
                return false;
            }
            else return true;
        }

        private void addCus_Load(object sender, EventArgs e)
        {
            txtphone.Text = GlobalsPhone.GlobalPhone;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
