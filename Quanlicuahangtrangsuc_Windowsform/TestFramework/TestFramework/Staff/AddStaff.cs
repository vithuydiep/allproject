using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TestFramework.Class;

namespace TestFramework.Staff
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        NV staff = new NV();
        private void AddStaff_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string manv = tbmanv.Text.Trim();
            string holot = tbholot.Text;
            string ten = tbten.Text;
            string gioitinh = "Male";
            if (rbnu.Checked)
            {
                gioitinh = "Female";
            }
            string diachi = tbdiachi.Text;
            int sodienthoai = Convert.ToInt32(tbsdt.Text);
            int machucvu = Convert.ToInt32(tbmacv.Text);
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                picstaff.BackgroundImage.Save(pic, picstaff.BackgroundImage.RawFormat);
                if (staff.insertStaff(manv, holot, ten, gioitinh, diachi, pic, sodienthoai, machucvu))
                {
                    MessageBox.Show("Successfully!", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tbmanv.Text = "";
            tbholot.Text = "";
            tbten.Text = "";
            tbdiachi.Text = "";
            tbdiachi.Text = "";
            tbsdt.Text = "";
            tbmacv.Text = "";
            picstaff.BackgroundImage = null;
            //Mainform main = new Mainform();
            //main.Show();

        }
        bool verif()
        {
            if ((tbmanv.Text.Trim() == "")
                || (tbholot.Text.Trim() == "")
                || (tbten.Text.Trim() == "")
                || (tbdiachi.Text.Trim() == "")
                || (tbdiachi.Text.Trim() == "")
                || (tbsdt.Text.Trim() == "")
                || (tbmacv.Text.Trim() == "")
                || (picstaff.BackgroundImage == null))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picstaff.BackgroundImage = Image.FromFile(opf.FileName);
                picstaff.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageForm mana = new ManageForm();
            mana.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
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

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.manaOrder manaord = new Pro.manaOrder();
            manaord.Show();
            this.Close();
        }
    }
}
