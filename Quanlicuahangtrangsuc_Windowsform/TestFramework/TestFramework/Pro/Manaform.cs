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
    public partial class Manaform : Form
    {
        public Manaform()
        {
            InitializeComponent();
        }
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
                lblname.Text =  table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();

            }
        }
        private void Manaform_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            getImageAndUsername();
            timer2.Start();
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbtren.Checked == true)
            {

                ProgressBar1.Increment(10);
                ProgressBar2.Increment(10);
                ProgressBar3.Increment(10);
                ProgressBar4.Increment(10);
                ProgressBar5.Increment(10);
                ProgressBar6.Increment(10);
                //rbduoi.Checked = true;
            }
            else
            {
                ProgressBar1.Increment(10);
                ProgressBar2.Increment(10);
                ProgressBar3.Increment(10);
                ProgressBar4.Increment(10);
                ProgressBar5.Increment(10);
                ProgressBar6.Increment(10);
                rbtren.Checked = true;

            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rbtren.Checked == true)
            {
                //ProgressBar1.Increment(1);
                //ProgressBar2.Increment(1);
                //ProgressBar3.Increment(1);
                //ProgressBar4.Increment(1);
                //ProgressBar5.Increment(1);
                //ProgressBar6.Increment(1);
                //rbduoi.Checked = true;
                ProgressBar1.Value = 0;
                ProgressBar2.Value = 0;
                ProgressBar3.Value = 0;
                ProgressBar4.Value = 0;
                ProgressBar5.Value = 0;
                ProgressBar6.Value = 0;
            }
            else
            {
                //ProgressBar1.Increment(1);
                //ProgressBar2.Increment(1);
                //ProgressBar3.Increment(1);
                //ProgressBar4.Increment(1);
                //ProgressBar5.Increment(1);
                //ProgressBar6.Increment(1);
                //rbduoi.Checked = true;
                ProgressBar1.Value = 0;
                ProgressBar2.Value = 0;
                ProgressBar3.Value = 0;
                ProgressBar4.Value = 0;
                ProgressBar5.Value = 0;
                ProgressBar6.Value = 0;
            }
            timer1.Start();
        }

        private void rbtren_CheckedChanged(object sender, EventArgs e)
        {
        //    ProgressBar1.Increment(20);
        //    ProgressBar2.Increment(20);
        //    ProgressBar3.Increment(20);
        //    ProgressBar4.Increment(20);
        //    ProgressBar5.Increment(20);
        //    ProgressBar6.Increment(20);
        }

        private void rbduoi_CheckedChanged(object sender, EventArgs e)
        {
            //ProgressBar1.Increment(20);
            //ProgressBar2.Increment(20);
            //ProgressBar3.Increment(20);
            //ProgressBar4.Increment(20);
            //ProgressBar5.Increment(20);
            //ProgressBar6.Increment(20);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            addnewProduct newpro = new addnewProduct();
            newpro.Show();
            
        }

        private void ptbmange_Click(object sender, EventArgs e)
        {
            manapro mana = new manapro();
            mana.ShowDialog();

        }

        private void ptbList_Click(object sender, EventArgs e)
        {
            ManageForm mast = new ManageForm();
            mast.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Timekeeping timek = new Timekeeping();
            timek.Show();

        }

        private void ptbCre_Click(object sender, EventArgs e)
        {
            order or = new order();
            or.Show();
            
        }

        private void ptbsale_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            sale.ShowDialog();


        }

        private void ptbSta_Click(object sender, EventArgs e)
        {
            Statistic stapro = new Statistic();
            stapro.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.ShowDialog();
        }

        private void avatar_Click(object sender, EventArgs e)
        {

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



