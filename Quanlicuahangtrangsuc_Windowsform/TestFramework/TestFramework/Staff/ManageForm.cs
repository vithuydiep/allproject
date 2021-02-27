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
using System.IO;
using Microsoft.Office.Interop.Excel;
using App = Microsoft.Office.Interop.Excel.Application;

namespace TestFramework.Staff
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }
        Class.NV nv = new Class.NV();
        private void btadd_Click(object sender, EventArgs e)
        {
            Staff.AddStaff addstaff = new AddStaff();
            addstaff.Show();
            this.Hide();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Staff");

            gridNhanvien.ReadOnly = true;

            gridNhanvien.RowTemplate.Height = 28;

            gridNhanvien.DataSource = nv.getStaff(command);

            gridNhanvien.AllowUserToAddRows = false;
        }
        public void FillGrid(SqlCommand command)
        {
            gridNhanvien.ReadOnly = true;
            gridNhanvien.RowTemplate.Height = 28;
            gridNhanvien.DataSource = nv.getStaff(command);
            //gridNhanvien.DataSource = staff.getStaff();
            //gridNhanvien.AllowUserToAddRows = false;

        }
        private void btexport_Click(object sender, EventArgs e)
        {
            App app = new App();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Columns.ColumnWidth = 25;
            for (int i = 1; i < gridNhanvien.Columns.Count; i++)
            {
                app.Cells[1, i] = gridNhanvien.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < gridNhanvien.Rows.Count; i++)
            {
                for (int j = 0; j < gridNhanvien.Columns.Count - 1; j++)
                {
                    if (gridNhanvien.Rows[i].Cells[j].Value != null)
                    {
                        app.Cells[i + 2, j + 1] = gridNhanvien.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "List staffs";
            sfd.DefaultExt = ".xlsx";
            sfd.Filter = "Excel Format (*.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Sucessful Export", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            app.Quit();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            string search = tbsearch.Text;
            SqlCommand command = new SqlCommand("SELECT * FROM Staff WHERE CONCAT(id, lastname, phone) LIKE'%" + search + "%'");
            FillGrid(command);
        }

        private void tbsearch_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void tbsearch_MouseLeave(object sender, EventArgs e)
        {
           
        }
        
        private void gridNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsNV detailnv = new DetailsNV();
            detailnv.tbmanv.Text = gridNhanvien.CurrentRow.Cells[0].Value.ToString();
            detailnv.tbholot.Text = gridNhanvien.CurrentRow.Cells[1].Value.ToString();
            detailnv.tbten.Text = gridNhanvien.CurrentRow.Cells[2].Value.ToString();
            if ((gridNhanvien.CurrentRow.Cells[4].Value.ToString() == "Nam"))
            {
                detailnv.rbnam.Checked = true;
            }
            else
            {
                detailnv.rbnu.Checked = true;
            }
            
            detailnv.tbdiachi.Text = gridNhanvien.CurrentRow.Cells[5].Value.ToString();
            detailnv.tbsdt.Text = gridNhanvien.CurrentRow.Cells[3].Value.ToString();
            detailnv.tbmacv.Text = gridNhanvien.CurrentRow.Cells[7].Value.ToString();
            byte[] pic;
            pic = (byte[])gridNhanvien.CurrentRow.Cells[6].Value;
            MemoryStream picture = new MemoryStream(pic);
            detailnv.picstaff.BackgroundImage = Image.FromStream(picture);
            detailnv.picstaff.BackgroundImageLayout = ImageLayout.Stretch;
          


            detailnv.Show();
            this.Close();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diamondGroupDataSet5.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.diamondGroupDataSet5.Staff);
        
        
            

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsearch_Enter(object sender, EventArgs e)
        {
            if (tbsearch.Text == "is, name, phone")
            {
                tbsearch.Text = "";
                tbsearch.ForeColor = SystemColors.ControlDark;
            }
        }

        private void tbsearch_Leave(object sender, EventArgs e)
        {
            if (tbsearch.Text == "")
            {
                tbsearch.Text = "id, name, phone";
                tbsearch.ForeColor = Color.DimGray;

            }
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

