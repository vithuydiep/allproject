
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFramework.Class;
using TestFramework.Staff;

namespace TestFramework.Pro
{
    public partial class order : Form
    {
        MyData mydb = new MyData();
        public void getImageAndUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from Staff where id = @manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = GlobalsMaNV.GlobalMaNV;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0][6];
                MemoryStream picture = new MemoryStream(pic);
                avatar.Image = Image.FromStream(picture);
                avatar.SizeMode = PictureBoxSizeMode.Zoom;
                lblname.Text = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();

            }
        }
        public order()
        {
            InitializeComponent();
        }
        PRODUCT products = new PRODUCT();
        CTSALES sa = new CTSALES();
        NV nv = new NV();
        KH kh = new KH();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Order myorder = new Order();
            NV nv = new NV();
            int id = Convert.ToInt32(txtid.Text);
            string phone = txtphone.Text;
            string product = txtPr.Text;
            int amount = Convert.ToInt32(txtamount.Text);
            int price = Convert.ToInt32(txtprice.Text);
            int total = Convert.ToInt32(txttotal.Text);
            DateTime date = datetime.Value;
            int sale = (int)listSales.SelectedValue;
            int manv = GlobalsMaNV.GlobalMaNV;
            int idpro = Globals.GlobalProductId;
            if (verif())
            {
                if (myorder.addbill(id, phone, amount, product, price, total, date, sale ,manv,idpro))
                {
                    
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand("select * from dbo.getPhone()", mydb.GetConnection);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        string phoneid = table.Rows[0][0].ToString();
                        GlobalsPhone.SetGlobalsPhone(phoneid);
                        addCus addCus = new addCus();
                        addCus.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("New Order Added", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Error", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //products.updateSLsale(Globals.GlobalProductId, amount);
            
           

        
        bool verif()
        {
            if (txtPr.Text.Trim() == "" || txtPr.Text.Trim() == "")
            {
                return false;
            }
            else return true;
        }
    }

        
        private void txtid_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            txtid.Clear();
        }

        

        
        private void txtid_MouseLeave(object sender, EventArgs e)
        {

        }



        private void txtphone_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtphone.Text == "")
            {
                //label2.Visible = false;
                //txtphone.Text = "Phone";
            }
        }


        private void txtPr_Click(object sender, EventArgs e)
        {
            txtPr.Clear();
            label6.Visible = true;
            formMain listPruduct = new formMain();
            listPruduct.Show(this);
            this.Hide();

            

        }

        private void txtamount_Click(object sender, EventArgs e)
        {
            txtamount.Clear();
            label3.Visible = true;
        }

        private void txtamount_MouseLeave(object sender, EventArgs e)
        {
            //if(txtamount.Text == "")
            //{
            //    //label3.Visible = false;
            //    txtamount.Text = "Amount";
            //}
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PRODUCT product = new PRODUCT();
                DataTable table = product.getProductById(Globals.GlobalProductId);
                int price = Convert.ToInt32(table.Rows[0][3]);
                label5.Visible = true;
                //txtprice.Text = price.ToString();
                txttotal.Text = (Convert.ToInt32(txtamount.Text) * price).ToString();
            }
            catch { }
        }

        private void txtprice_Click(object sender, EventArgs e)
        {
            txtprice.Clear();
            label5.Visible = true;
        }

        private void txtadd_Click(object sender, EventArgs e)
        {
            //txtadd.Clear();
            //label9.Visible = true;
        }

        public float valuesale(int id)
        {
            DataTable table = sa.getInf(id);
            int sale = Convert.ToInt32(table.Rows[0][0].ToString());
            float kq = (float)((100 - sale) * 0.01);
            return kq;
        }



        private void txttotal_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            txttotal.Clear();
        }

        
       

        

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
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

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
    
            this.Close();
        }
        CTSALES sal = new CTSALES();
        private void order_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            listSales.DataSource = sal.getall();
            listSales.ValueMember = "saleid";
            listSales.DisplayMember = "name";
        }

        private void txtphone_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtphone.Clear();
        }

        

        private void txtid_Enter(object sender, EventArgs e)
        {
            if (txtid.Text == "ID")
            {
                txtid.Text = "";
                txtid.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                txtid.Text = "ID";
                txtid.ForeColor = Color.DimGray;
            }
        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            if (txtphone.Text == "Phone")
            {
                txtphone.Text = "";
                txtphone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                txtphone.Text = "Phone";
                txtphone.ForeColor = Color.DimGray;
            }
        }

        private void txtprice_Enter(object sender, EventArgs e)
        {
            if (txtprice.Text == "Price")
            {
                txtprice.Text = "";
                txtprice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void txtprice_Leave(object sender, EventArgs e)
        {
            if (txtprice.Text == "")
            {
                txtprice.Text = "Price";
                txtprice.ForeColor = Color.DimGray;
            }
        }

        private void txtamount_Leave(object sender, EventArgs e)
        {
            if (txtamount.Text == "")
            {
                txtamount.Text = "Amount";
                txtamount.ForeColor = Color.DimGray;
            }
        }

        private void txtamount_Enter(object sender, EventArgs e)
        {
            if (txtamount.Text == "Amount")
            {
                txtamount.Text = "";
                txtamount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void txttotal_Leave(object sender, EventArgs e)
        {
            if (txttotal.Text == "")
            {
                txttotal.Text = "Total";
                txttotal.ForeColor = Color.DimGray;
            }
        }

        private void txttotal_Enter(object sender, EventArgs e)
        {
            if (txttotal.Text == "Total")
            {
                txttotal.Text = "";
                txttotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void listSales_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                label10.Visible = true;
                int bandau = Convert.ToInt32(txttotal.Text);
                int id = Convert.ToInt32(listSales.SelectedValue.ToString());
                float heso = valuesale(id);
                float gia = (float)((float)Convert.ToInt32(bandau) * heso);
                txttotal.Text = gia.ToString();
            }
            catch { }
        }

        private void lblname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailsNV detailnv = new DetailsNV();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from Staff where id =@uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.NChar).Value = GlobalsMaNV.GlobalMaNV;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            detailnv.tbmanv.Text = table.Rows[0][0].ToString();
            detailnv.tbholot.Text = table.Rows[0][1].ToString();
            detailnv.tbten.Text = table.Rows[0][2].ToString();
            if ((table.Rows[0][4].ToString() == "Nam"))
            {
                detailnv.rbnam.Checked = true;
            }
            else
            {
                detailnv.rbnu.Checked = true;
            }
            detailnv.tbdiachi.Text = table.Rows[0][5].ToString();
            detailnv.tbsdt.Text = table.Rows[0][3].ToString();
            detailnv.tbmacv.Text = table.Rows[0][7].ToString();
            byte[] pic;
            pic = (byte[])table.Rows[0][6];
            MemoryStream picture = new MemoryStream(pic);
            detailnv.picstaff.BackgroundImage = Image.FromStream(picture);
            detailnv.picstaff.BackgroundImageLayout = ImageLayout.Stretch;
            detailnv.Show();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manaOrder mana = new manaOrder();
            mana.Show();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.order ord = new order();
            ord.Show();
            this.Close();

        }

        private void manageOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Pro.manaOrder manaord = new manaOrder();
            manaord.Show();
            this.Close();
        }
    }
}
