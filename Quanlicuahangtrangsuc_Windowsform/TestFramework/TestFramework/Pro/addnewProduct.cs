using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFramework
{
    public partial class addnewProduct : Form
    {
        public addnewProduct()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(open.FileName);
                pic.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PRODUCT product = new PRODUCT();
            int ms = Convert.ToInt32(txtid.Text);
            string name = txtname.Text;
            int price = Convert.ToInt32(txtprice.Text);
            string description = txtdes.Text;
            string type = comboBox1.SelectedItem.ToString();
            DateTime inputday = (DateTime)dtpinput.Value;
            int amount = Convert.ToInt32(txtamount.Text);
            MemoryStream picture = new MemoryStream();

            if (verif())
            {

                pic.Image.Save(picture, pic.Image.RawFormat);
                if (product.addProduct(ms, name, price, description, type, inputday, amount, picture))
                {
                    MessageBox.Show("New Product Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        bool verif()
        {
            if ((txtname.Text.Trim() == "") || (txtprice.Text.Trim() == "") || (pic.Image == null))
            {
                return false;
            }
            else return true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Pro.Manaform mana = new Pro.Manaform();
            mana.ShowDialog();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbid_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.AddStaff newstaff = new Staff.AddStaff();
            newstaff.ShowDialog();
        }

        private void listProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.manapro manapro = new Pro.manapro();
            manapro.ShowDialog();

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewProduct newpro = new addnewProduct();
            newpro.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.order neworder = new Pro.order();
            neworder.ShowDialog();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.SaleForm newsale= new Pro.SaleForm();
            newsale.ShowDialog();

        }

        private void statisticToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pro.Statistic sta = new Pro.Statistic();
            sta.ShowDialog();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.ManageForm newma = new Staff.ManageForm();
            newma.ShowDialog();
        }

        private void timekeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.Timekeeping timekeeping = new Staff.Timekeeping();
            timekeeping.ShowDialog();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.Salary sal = new Staff.Salary();
            sal.ShowDialog();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.StatisticStaff stastaff = new Staff.StatisticStaff();
            stastaff.ShowDialog();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.order ord = new Pro.order();
            ord.Show();
            this.Close();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.manaOrder manaord = new Pro.manaOrder();
            manaord.Show();
            this.Close();
        }
    }
}

