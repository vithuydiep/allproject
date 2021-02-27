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
//using System.Data;

namespace TestFramework.Pro
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void startd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtsale_Click(object sender, EventArgs e)
        {
            txtsale.Clear();
            label4.Visible = true;
        }

  

        private void txtsale_MouseLeave(object sender, EventArgs e)
        {
            if (txtsale.Text == "")
            {
                txtsale.Text = "Sales (%)";
                label4.Visible = false;
            }
        }

      

       
        private void txtname_MouseLeave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Name";
                label7.Visible = false;
            }
        }

        private void txtname_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            label7.Visible = true;
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = salect.getAllSales(command);
            dataGridView1.AllowUserToAddRows = false;
        }
        CTSALES salect = new CTSALES();

        private void btnadd_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int id = rand.Next(0, 100);
            DateTime start = startd.Value;
            DateTime finish = finishd.Value;
            string name = txtname.Text;
            int sale = Convert.ToInt32(txtsale.Text);

            if (verif())
            {
                if (salect.insertsale(id, start, finish, name, sale))
                {

                    MessageBox.Show("This Sales Promotion Added", "Add new Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("  select startdate as 'Start Day', finishdate as 'Finish Day', sales.name as 'Name', sale as 'Sale (%)' from sales"));
                }
                else
                    MessageBox.Show("Error", "Add new Promotion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verif()
        {
            if (txtname.Text.Trim() == "" || txtsale.Text.Trim() == "" )
            {
                return false;
            }
            return true;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("  select startdate as 'Start Day', finishdate as 'Finish Day', sales.name as 'Name', sale as 'Sale (%)' from sales"));

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            DateTime start = startd.Value;
            DateTime finish = finishd.Value;
            string name = txtname.Text;
            int sale = Convert.ToInt32(txtsale.Text);
            if (verif())
            {
                if (salect.updatesale(start, finish, name, sale))
                {

                    MessageBox.Show("This Sales Promotion Edited", "Edit Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("  select startdate as 'Start Day', finishdate as 'Finish Day', sales.name as 'Name', sale as 'Sale (%)' from sales"));
                }
                else
                    MessageBox.Show("Error", "Edit Promotion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                if (MessageBox.Show("Are you sure you want to remove this promotion ?", "Delete Promotion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (salect.deleteProduct(name))
                    {
                        MessageBox.Show("This Promotion Deleted", "Delete Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("  select startdate as 'Start Day', finishdate as 'Finish Day', sales.name as 'Name', sale as 'Sale (%)' from sales"));
                    }
                    else
                        MessageBox.Show("Error", "Delete Promotion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            startd.Value = (DateTime)dataGridView1.CurrentRow.Cells[0].Value;
            finishd.Value = (DateTime)dataGridView1.CurrentRow.Cells[1].Value;
            txtname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsale.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            label4.Visible = true;
            label7.Visible = true;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Manaform mana = new Manaform();
            mana.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.AddStaff newstaff = new Staff.AddStaff();
            newstaff.Show();
            this.Close();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.ManageForm newma = new Staff.ManageForm();
            newma.Show();
            this.Close();
        }

        private void timekeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.Timekeeping timekeeping = new Staff.Timekeeping();
            timekeeping.Show();
            this.Close();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.Salary sal = new Staff.Salary();
            sal.Show();
            this.Close();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.StatisticStaff stastaff = new Staff.StatisticStaff();
            stastaff.Show();
            this.Close();
        }

        private void listProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.manapro manapro = new Pro.manapro();
            manapro.Show();
            this.Close();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewProduct newpro = new addnewProduct();
            newpro.Show();
            this.Close();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.order neworder = new Pro.order();
            neworder.Show();
            this.Close();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.SaleForm newsale = new Pro.SaleForm();
            newsale.Show();
            this.Close();
        }

        private void statisticToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pro.Statistic sta = new Pro.Statistic();
            sta.Show();
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.order ord = new order();
            ord.Show();
            this.Close();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.manaOrder manaord = new manaOrder();
            manaord.Show();
            this.Close();
        }
    }
}

