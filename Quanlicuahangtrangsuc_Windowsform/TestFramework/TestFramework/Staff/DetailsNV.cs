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
using System.IO;
using System.Data.SqlClient;

namespace TestFramework.Staff
{
    public partial class DetailsNV : Form
    {
        public DetailsNV()
        {
            InitializeComponent();
        }
        NV staff = new NV();
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public Image Hinh(Image image)
        {
            image = picstaff.Image;
            return image;
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

        private void btedit_Click(object sender, EventArgs e)
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
                try
                {
                    manv = tbmanv.Text;
                    picstaff.BackgroundImage.Save(pic, picstaff.BackgroundImage.RawFormat);
                    if (staff.updateStaff(manv, holot, ten, gioitinh, diachi, pic, sodienthoai, machucvu))
                    {
                        MessageBox.Show("Successfully!", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btremove_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = tbmanv.Text;
                if ((MessageBox.Show("Are you sure you want to delete this staff?", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (staff.deleteStaff(manv))
                    {
                        MessageBox.Show("Successfully!", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbmanv.Text = "";
                        tbholot.Text = "";
                        tbten.Text = "";
                        tbdiachi.Text = "";
                        tbsdt.Text = "";
                        tbmacv.Text = "";
                        picstaff.BackgroundImage = null;

                    }
                    else
                    {
                        MessageBox.Show("Staff not deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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

        private void guna2PictureBox4_Click(object sender, EventArgs e)
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
    }
}
