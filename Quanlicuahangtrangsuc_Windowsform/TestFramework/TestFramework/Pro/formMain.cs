
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
using TestFramework;
using TestFramework.Class;
using TestFramework.Staff;

namespace TestFramework
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        MyData mydb = new MyData();
        PRODUCT product = new PRODUCT();
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
        private void listPruductForm_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            FillPanel(new SqlCommand("Select * from Product where state = 1"));
            //lọc 

            //cboxtype.DataSource = product.getAllProducts();
            //cboxtype.DisplayMember = "type";
            //cboxtype.ValueMember = "type";
            //cboxtype.SelectedItem = null;
        }


        //public void fillcbxtype(int index)
        //{
        //    cboxtype.DataSource = product.getAllProducts();
        //    cboxtype.DisplayMember = "type";
        //    cboxtype.ValueMember = "ms";
        //    cboxtype.SelectedItem = index;
        //}

        private void Pc_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Pc_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Infpro_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Infpro_MouseEnter(object sender, EventArgs e)
        {

        }

        private void gunaMediumRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdopc1.Checked == true)
            {
                ptbweb.Image = TestFramework.Properties.Resources._111;
            }
        }

        private void rdopc2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdopc2.Checked == true)
            {
                ptbweb.Image = TestFramework.Properties.Resources._124;
            }
        }

      

        public void FillPanel(SqlCommand command)
        {
            listPr.Controls.Clear();
            DataTable table = product.getProducts(command);
            for (int i = 0; i < table.Rows.Count; i++)
            {

                FlowLayoutPanel infpro = new FlowLayoutPanel();
                infpro.Name = table.Rows[i][0].ToString();
                PictureBox pc = new PictureBox();
                pc.Name = table.Rows[i][0].ToString();
                Label price = new Label();
                Label des = new Label();

                des.Size = new Size(265, 25);
                des.AutoSize = false;
                des.TabStop = false;
                des.BorderStyle = BorderStyle.None;
                des.TextAlign = ContentAlignment.TopCenter;
                des.Font = new System.Drawing.Font("Time New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                string description = (string)table.Rows[i][1].ToString();
                des.Text = description;

                price.ForeColor = Color.DarkCyan;
                price.AutoSize = false;
                price.TabStop = false;
                price.BorderStyle = BorderStyle.None;
                price.Size = new Size(264, 40);
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new System.Drawing.Font("Time New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                string temp = table.Rows[i][3].ToString();
                price.Text = Convert.ToDecimal(temp).ToString("#,##0") + "đ";

                byte[] pic;
                pic = (byte[])table.Rows[i][8];
                MemoryStream picture = new MemoryStream(pic);
                pc.Image = Image.FromStream(picture);
                pc.SizeMode = PictureBoxSizeMode.Zoom;
                pc.Size = new Size(264, 301);
                infpro.Height = 400;
                infpro.Width = 270;


                infpro.Controls.Add(pc);
                infpro.Controls.Add(des);
                infpro.Controls.Add(price);
                listPr.Controls.Add(infpro);
                listPr.FlowDirection = FlowDirection.LeftToRight;

                infpro.MouseEnter += Infpro_MouseEnter;
                infpro.MouseLeave += Infpro_MouseLeave;
                pc.MouseEnter += Pc_MouseEnter;
                pc.MouseLeave += Pc_MouseLeave;
                pc.Click += Pc_Click;
                infpro.Click += Infpro_Click;
            }



        }

        private void Pc_Click(object sender, EventArgs e)
        {


            InfProduct infProduct = new InfProduct();
            PictureBox pc = sender as PictureBox;
            int ms = Convert.ToInt32(pc.Name.ToString());
            DataTable table = product.getProductById(ms);
            infProduct.lblname.Text = table.Rows[0][1].ToString();
            string temp = table.Rows[0][3].ToString();
            infProduct.temp.Text = Convert.ToDecimal(temp).ToString("#,##0") + "đ";
            infProduct.lblprice.Text = table.Rows[0][3].ToString();
            infProduct.lblms.Text = table.Rows[0][0].ToString();
            infProduct.lbldes.Text = table.Rows[0][4].ToString();
            byte[] pic;
            pic = (byte[])table.Rows[0][8];
            MemoryStream picture = new MemoryStream(pic);
            infProduct.picture.Image = Image.FromStream(picture);
            infProduct.picture.SizeMode = PictureBoxSizeMode.Zoom;
            infProduct.Show(this);
            Globals.SetGlobalProductId(ms);

        }

        private void Infpro_Click(object sender, EventArgs e)
        {
            InfProduct infProduct = new InfProduct();
            FlowLayoutPanel flowLayoutPanel = sender as FlowLayoutPanel;
            int ms = Convert.ToInt32(flowLayoutPanel.Name.ToString());
            DataTable table = product.getProductById(ms);
            infProduct.lblname.Text = table.Rows[0][1].ToString();
            infProduct.lblprice.Text = table.Rows[0][2].ToString();
            string temp = table.Rows[0][2].ToString();
            infProduct.temp.Text = Convert.ToDecimal(temp).ToString("#,##0") + "đ";
            infProduct.lblms.Text = table.Rows[0][0].ToString();
            infProduct.lbldes.Text = table.Rows[0][3].ToString();
            byte[] pic;
            pic = (byte[])table.Rows[0][8];
            MemoryStream picture = new MemoryStream(pic);
            infProduct.picture.Image = Image.FromStream(picture);
            infProduct.picture.SizeMode = PictureBoxSizeMode.Zoom;
            infProduct.Show(this);
            Globals.SetGlobalProductId(ms);

        }



        private void btnNhan_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from dbo.findkey('Ring')");
            FillPanel(command);
        }

        private void btnDayco_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from dbo.findkey('Necklet')");
            FillPanel(command);
        }

        private void btnVong_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from dbo.findkey('Barcelet')");
            FillPanel(command);
        }

        private void btnDongho_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from dbo.findkey('Watch')");
            FillPanel(command);
        }

        private void btnhangmoi_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" select * from Product where state = 1 and DATEDIFF(DAY, inputday , CURRENT_TIMESTAMP) < 50");
            FillPanel(command);
        }

        private void nHẪNBẠCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1 and name like N'%Nhẫn Bạc%' ");
            FillPanel(command);
        }

        private void nHẪNVÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1 and name like N'%Nhẫn Vàng%' ");
            FillPanel(command);
        }

        private void nHẪNKIMCƯƠNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1 and name like N'%Kim Cuong%' ");
            FillPanel(command);
        }

        private void nHẪNNAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1 and name like N'%Nhẫn Nam%' ");
            FillPanel(command);
        }

        private void nHẪNNỮToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1  and name like N'%Nhẫn Nam%' ");
            FillPanel(command);
        }

        private void dÂYCỔVÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1  and name like N'%Dây cổ vàng%' ");
            FillPanel(command);
        }

        private void dÂYCỔBẠCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1  and name like N'%Dây cổ Bac%' ");
            FillPanel(command);
        }

        private void bôngTayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1  and name like N'%Bông tai Vàng%' ");
            FillPanel(command);
        }

        private void bÔNGTAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from dbo.findkey('Earring')");
            FillPanel(command);
        }

        private void bÔNGTAYBẠCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1  and name like N'%Bông tai bạc%' ");
            FillPanel(command);
        }

        private void vÒNGVÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where name state = 1  and like N'%Vòng tay Vàng%' ");
            FillPanel(command);
        }

        private void vÒNGBẠCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1  and name like N'%Vòng tay bạc%' ");
            FillPanel(command);
        }

        private void vÒNGKIMCƯƠNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1  and name like N'%Vòng tay kim cương%' ");
            FillPanel(command);
        }

        private void đỒNGHỒNAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1 and name like N'%nam%' ");
            FillPanel(command);
        }

        private void đỒNGHỒNỮToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where state = 1  and type ='Watch' and name like N'%nữ%' ");
            FillPanel(command);
        }

        private void nHẪNToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand(" select * from Product where type =N'Ring' and DATEDIFF(DAY, inputday , CURRENT_TIMESTAMP) < 50");
            FillPanel(command);
        }

        private void dÂYCỔToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" select * from Product where type =N'Barcelet' and DATEDIFF(DAY, inputday , CURRENT_TIMESTAMP) < 50");
            FillPanel(command);
        }

        private void vÒNGLẮCTAYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" select * from Product where type =N'Necklet' and DATEDIFF(DAY, inputday , CURRENT_TIMESTAMP) < 50");
            FillPanel(command);
        }

        private void đỒNGHỒToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" select * from Product where type =N'Watch' and DATEDIFF(DAY, inputday , CURRENT_TIMESTAMP) < 50");
            FillPanel(command);
        }

        private void bÔNGTAYToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" select * from Product where type =N'Earring' and DATEDIFF(DAY, inputday , CURRENT_TIMESTAMP) < 30");
            FillPanel(command);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rdopc1.Checked == true)
            {
                ptbweb.Image = TestFramework.Properties.Resources._111;
                rdopc2.Checked = true;
            }
            else
            {
                ptbweb.Image = TestFramework.Properties.Resources._124;
                rdopc1.Checked = true;

            }
        }

        private void cboxtype_SelectedValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string type = cboxtype.SelectedValue.ToString();
            //    SqlCommand command = new SqlCommand("select * from Product where type = N'" + type + "'");
            //    FillPanel(command);
            //}
            //catch
            //{ }
        }

        private void gunaPictureBox3_MouseHover(object sender, EventArgs e)
        {
            //gunaPictureBox3.BackColor = Color.LightGoldenrodYellow;
        }

        private void gunaPictureBox3_MouseLeave(object sender, EventArgs e)
        {
            //gunaPictureBox3.BackColor = Color.Transparent;
        }



        private void gunaTextBox1_MouseLeave(object sender, EventArgs e)
        {
            //if(gunaTextBox1.Text =="")
            //{
            //    gunaTextBox1.Text = "Search";
            //}
        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            gunaTextBox1.Text.Clone();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand(" select * from Product where price <1000000");
            FillPanel(command);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" select * from Product where price >= 1000000 and price < 5000000");
            FillPanel(command);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" select * from Product where price >= 5000000 and price < 10000000");
            FillPanel(command);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" select * from Product where price > 10000000");
            FillPanel(command);
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product where CONCAT(name,description,type) like N'%" + gunaTextBox1.Text + "%'");
            FillPanel(command);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
            Login log = new Login();
            log.Show();
            this.Visible = false;
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
    }

}
