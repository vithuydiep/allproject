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
using System.Drawing.Imaging;

namespace TestFramework.Pro
{
    public partial class manapro : Form
    {
        public manapro()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void manapro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diamondGroupDataSet6.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.diamondGroupDataSet6.Product);


            fillGrid(new SqlCommand("SELECT * FROM Product where state = 1"));
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pctPr.Image = Image.FromFile(open.FileName);
                pctPr.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + txtms.Text);
            if (pctPr.Image == null)
            {
                MessageBox.Show("No Image In PictureBox", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (svf.ShowDialog() == DialogResult.OK)
                pctPr.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void txtms_Click(object sender, EventArgs e)
        {
            txtms.Clear();
            label1.Visible = true;
        }

        private void txtname_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            label2.Visible = true;
        }

        private void txtprice_Click(object sender, EventArgs e)
        {
            txtprice.Clear();
            label3.Visible = true;
        }

        private void txtdes_Click(object sender, EventArgs e)
        {
            txtdes.Clear();
            label4.Visible = true;
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Type")
            {
                label5.Visible = false;
            }
        }

        private void txtms_MouseLeave(object sender, EventArgs e)
        {
            if (txtms.Text == "")
            {
                label1.Visible = false;
                txtms.Text = "MS";
            }
        }

        private void txtname_MouseLeave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                label2.Visible = false;
                txtname.Text = "Name";
            }
        }

        private void txtprice_MouseLeave(object sender, EventArgs e)
        {
            if (txtprice.Text == "")
            {
                label3.Visible = false;
                txtprice.Text = "Price";
            }
        }

        private void txtdes_MouseLeave(object sender, EventArgs e)
        {
            if (txtdes.Text == "")
            {
                label4.Visible = false;
                txtdes.Text = "Description";
            }
        }

        private void txtSL_Click(object sender, EventArgs e)
        {
            txtSL.Clear();
            label8.Visible = true;
        }

        private void txtSL_MouseLeave(object sender, EventArgs e)
        {
            if (txtSL.Text == "")
            {
                label8.Visible = false;
                txtSL.Text = "Amount";
            }
        }
        PRODUCT product = new PRODUCT();
        
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = product.getProducts(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE CONCAT(id,name,type,price) LIKE N'%" + txtfind.Text + "%'");
            fillGrid(command);
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Pro.Manaform mana = new Manaform();
            mana.ShowDialog();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PRODUCT product = new PRODUCT();
            int ms = Convert.ToInt32(txtms.Text);
            string name = txtname.Text;
            int price = Convert.ToInt32(txtprice.Text);
            string description = txtdes.Text;
            string type = comboBox1.SelectedItem.ToString();
            DateTime inputday = dtpinput.Value;
            int amount = Convert.ToInt32(txtSL.Text);
            MemoryStream pic = new MemoryStream();

            if (verif())
            {
                pctPr.Image.Save(pic, pctPr.Image.RawFormat);
                if (product.addProduct(ms, name, price, description, type, inputday, amount, pic))
                {
                    MessageBox.Show("New Product Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM pdt"));
                    txtdes.Clear();
                    txtms.Clear();
                    txtname.Clear();
                    txtprice.Clear();
                    txtdes.Clear();
                    comboBox1.Text = "Type";
                    txtSL.Clear();
                    //pctPr.Image = Properties.Resources.Circle_icons_image_svg;
                }
                else
                {
                    MessageBox.Show("Error", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool verif()
        {
            if ((txtname.Text.Trim() == "") || (txtprice.Text.Trim() == "") || (pctPr.Image == null))
            {
                return false;
            }
            else return true;

        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            int ms;
            string name = txtname.Text;
            int price = Convert.ToInt32(txtprice.Text);
            string description = txtdes.Text;
            string type = comboBox1.SelectedItem.ToString();
            DateTime inputday = dtpinput.Value;
            int amount = Convert.ToInt32(txtSL.Text);
            MemoryStream pic = new MemoryStream();
            try
            {
                if (verif())
                {
                    ms = Convert.ToInt32(txtms.Text);
                    pctPr.Image.Save(pic, pctPr.Image.RawFormat);
                    if (product.updateProduct(ms, name, price, description, type, inputday, amount, pic))
                    {
                        MessageBox.Show("Product Edited", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("select * from pdt"));

                    }
                    else
                    {
                        MessageBox.Show("Error", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            txtms.Text = "MS";
            txtname.Text = "Name";
            txtprice.Text = "Price";
            txtdes.Text = "Description";
            comboBox1.Text = "Type";
            txtSL.Text = "Amount";
            //pctPr.Image = Properties.Resources.Circle_icons_image_svg;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int ms = Convert.ToInt32(txtms.Text);
                if (MessageBox.Show("Are you sure you want to remove this product", "Manage Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (product.deleteProduct(ms))
                    {
                        MessageBox.Show("This Product Deleted", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label8.Visible = false;
                        txtms.Text = "MS";
                        txtname.Text = "Name";
                        txtprice.Text = "Price";
                        txtdes.Text = "Description";
                        comboBox1.Text = "Type";
                        txtSL.Text = "Amount";
                        //pctPr.Image = Properties.Resources.Circle_icons_image_svg;
                        fillGrid(new SqlCommand("Select * from pdt"));
                    }
                    else MessageBox.Show("Error", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;

            txtms.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdes.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpinput.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
            txtSL.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            pctPr.Image = Image.FromStream(picture);
            pctPr.SizeMode = PictureBoxSizeMode.Zoom;
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
