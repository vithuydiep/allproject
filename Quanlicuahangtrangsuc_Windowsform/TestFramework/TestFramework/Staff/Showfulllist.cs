using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFramework.Staff
{
    public partial class Showfulllist : Form
    {
        public Showfulllist()
        {
            InitializeComponent();
        }
        Class.Chamcong cong = new Class.Chamcong();

        private void btsearch_Click(object sender, EventArgs e)
        {
            DateTime ngay = dtchamcong.Value;
            grid.DataSource = cong.Loadfulllistdk(ngay);
        }

        private void Showfulllist_Load(object sender, EventArgs e)
        {
            grid.DataSource = cong.Loadfulllist();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            grid.DataSource = cong.Loadfulllist();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Pro.Manaform mana = new Pro.Manaform();
            mana.Show();
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
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

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
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
