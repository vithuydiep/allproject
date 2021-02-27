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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        Class.Chamcong cong = new Class.Chamcong();
        Class.Luong luong = new Class.Luong();

        private void Salary_Load(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(cbmonth.SelectedItem);
            int year = Convert.ToInt32(cbyear.SelectedItem);
            grid1.DataSource = cong.LoadCCthang(year, month);
            dataGridView1.DataSource = luong.LoadLuong(month, year);
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(cbmonth.SelectedItem);
            int year = Convert.ToInt32(cbyear.SelectedItem);

            if (luong.checktinhluong(month, year))
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int manv = (int)dataGridView1.Rows[i].Cells[0].Value;
                    float ngaycong = float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    float hesocv = float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    float luongcb = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());


                    double thuclanh = Math.Round((((luongcb + (luongcb * hesocv)) / 24) * ngaycong));
                    luong.TinhLuong(manv, month, year, thuclanh);


                }

            }
            else
            {
                MessageBox.Show("This month had payroll", "Payroll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            grid2.DataSource = luong.Loadgrid2(month, year);
        }

        private void bttable_Click(object sender, EventArgs e)
        {
            Staff.SalaryStaff salarstaff = new Staff.SalaryStaff();
            salarstaff.Show();
        }

        private void cbmonth_SelectedValueChanged(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(cbmonth.SelectedItem);
            int year = Convert.ToInt32(cbyear.SelectedItem);
            grid1.DataSource = luong.LoadLuongcc(month, year);
            dataGridView1.DataSource = luong.LoadLuong(month, year);
        }

        private void cbyear_SelectedValueChanged(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(cbmonth.SelectedItem);
            int year = Convert.ToInt32(cbyear.SelectedItem);
            grid1.DataSource = luong.LoadLuongcc(month, year);
            dataGridView1.DataSource = luong.LoadLuong(month, year);
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

        private void manaageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.manaOrder manaord = new Pro.manaOrder();
            manaord.Show();
            this.Close();
        }
    }
}
