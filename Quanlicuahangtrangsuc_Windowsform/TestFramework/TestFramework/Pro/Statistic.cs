using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFramework.Pro
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            loadchart1();
            loadchart2();
            loadchart3();
            loadchart4();
            loadchart5();
            loadchart6();
            loadchart7();
        }
        PRODUCT product = new PRODUCT();
        public void loadchart1()
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select type, sum(curnumber) as Amount from Product group by type"));
            chart1.DataSource = table;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Type";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart1.Series["Type"].XValueMember = "type";
            chart1.Series["Type"].YValueMembers = "Amount";
        }
        public void loadchart2() //ring
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(curnumber) as Amount from Product where type ='Ring' group by name"));
            chart2.DataSource = table;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart2.Series["Ring"].XValueMember = "name";
            chart2.Series["Ring"].YValueMembers = "Amount";
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
        }
        public void loadchart3() //watch
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(curnumber) as Amount from Product where type ='Watch' group by name"));
            chart3.DataSource = table;
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart3.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart3.Series["Watch"].XValueMember = "name";
            chart3.Series["Watch"].YValueMembers = "Amount";
        }

        public void loadchart4() //necklace
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(curnumber) as Amount from Product where type ='Necklet' group by name"));
            chart4.DataSource = table;
            chart4.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart4.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart4.Series["Necklace"].XValueMember = "name";
            chart4.Series["Necklace"].YValueMembers = "Amount";
        }
        public void loadchart5() // earring
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(curnumber) as Amount from Product where type ='Earring' group by name"));
            chart5.DataSource = table;
            chart5.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart5.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart5.Series["Earring"].XValueMember = "name";
            chart5.Series["Earring"].YValueMembers = "Amount";
        }

        public void loadchart6() // bracklet
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(curnumber) as Amount from Product where type ='Barcelet' group by name"));
            chart6.DataSource = table;
            chart6.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart6.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart6.Series["Bracelet"].XValueMember = "name";
            chart6.Series["Bracelet"].YValueMembers = "Amount";
            chart6.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
        }
        public void loadchart7() 
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(amount) as Amount from Product  group by name"));
            chart7.DataSource = table;
            chart7.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart7.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart7.Series["Product"].XValueMember = "name";
            chart7.Series["Product"].YValueMembers = "Amount";
            // chart7.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void btn2_CheckedChanged(object sender, EventArgs e)
        {
            if (btn2.Checked == true)
            {
                chart7.Visible = true;
                btnbongtai.Visible = true;
                btndaychuyen.Visible = true;
                btndongho.Visible = true;
                btnnhan.Visible = true;
                btnvong.Visible = true;
            }
            else
            {
                chart7.Visible = false;
            }
            if (btn1.Checked == true)
            {
                btnbongtai.Visible = false;
                btndaychuyen.Visible = false;
                btndongho.Visible = false;
                btnnhan.Visible = false;
                btnvong.Visible = false;
            }
        }

        private void btnnhan_CheckedChanged(object sender, EventArgs e)
        {
            if (btnnhan.Checked == true)
            {
                chart2.Visible = true;
            }
            else
            {
                chart2.Visible = false;
            }
        }

        private void btn1_CheckedChanged(object sender, EventArgs e)
        {
            if (btn1.Checked == true)
            {
                chart1.Visible = true;
                btnbongtai.Visible = false;
                btndaychuyen.Visible = false;
                btndongho.Visible = false;
                btnnhan.Visible = false;
                btnvong.Visible = false;
            }
            else
            {
                chart1.Visible = false;
            }
        }

        private void btndongho_CheckedChanged(object sender, EventArgs e)
        {
            if (btndongho.Checked == true)
            {
                chart3.Visible = true;
            }
            else
            {
                chart3.Visible = false;
            }
        }

        private void btnbongtai_CheckedChanged(object sender, EventArgs e)
        {
            if (btnbongtai.Checked == true)
            {
                chart5.Visible = true;
            }
            else
            {
                chart5.Visible = false;
            }
        }

        private void btnvong_CheckedChanged(object sender, EventArgs e)
        {
            if (btnvong.Checked == true)
            {
                chart6.Visible = true;
            }
            else
            {
                chart6.Visible = false;
            }
        }

        private void btndaychuyen_CheckedChanged(object sender, EventArgs e)
        {
            if (btndaychuyen.Checked == true)
            {
                chart4.Visible = true;
            }
            else
            {
                chart4.Visible = false;
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Manaform mana = new Manaform();
            mana.Show();
            this.Close();
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

        private void guna2PictureBox4_Click(object sender, EventArgs e)
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
