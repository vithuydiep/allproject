using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFramework.Class;
using Microsoft.Office.Interop.Excel;
using appp = Microsoft.Office.Interop.Excel.Application;



namespace TestFramework.Pro
{
    public partial class manaOrder : Form
    {
        public manaOrder()
        {
            InitializeComponent();
        }

        private void manaOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billdataset.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.billdataset.Bill);
            // TODO: This line of code loads data into the 'diamondGroupDataSet3.Bill' table. You can move, or remove it, as needed.
            //this.billTableAdapter.Fill(this.diamondGroupDataSet3.Bill);

        }
        Order order = new Order();
        private void btneditor_Click(object sender, EventArgs e)
        {

           
                int id;
                int phone = Convert.ToInt32(txtphoneor.Text);
                string product = txtproductor.Text;
                int amount = Convert.ToInt32(txtamountor.Text);
                int price = Convert.ToInt32(txtpriceor.Text);
                int total = Convert.ToInt32(txttotalor.Text);
                DateTime date = datetimeor.Value;
                int sale = Convert.ToInt32(txtsaleor.Text);
                int manv = GlobalsMaNV.GlobalMaNV;
                try
                {
                    id = Convert.ToInt32(txtidor.Text);
                    if (order.editbill(id, phone, amount, product, price, total, date, sale, manv))
                    {
                        MessageBox.Show("This Order Edited", "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGridOr(new SqlCommand("select * from Bill"));

                    }
                    else
                    {
                        MessageBox.Show("Error", "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }





                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        public void fillGridOr(SqlCommand command)
        {
            data.ReadOnly = true;
            data.RowTemplate.Height = 80;
            data.DataSource = order.getOrders(command);
        }
        private void btnremoveor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidor.Text);
            if (MessageBox.Show("Are you sure you want to remove this order ?", "Manage Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (order.delteBill(id))
                {
                    MessageBox.Show("This order removed", "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fillGridOr(new SqlCommand("select * from Bill"));
                    lbelidor.Visible = false;
                    lbelproductor.Visible = false;
                    lblamountor.Visible = false;
                    lblphoneor.Visible = false;
                    lblsaleor.Visible = false;
                    lblpriceor.Visible = false;
                    lbltotalor.Visible = false;
                    txtidor.Text = "ID";          
                    txtphoneor.Text = "Phone";
                    txtproductor.Text = "Name's Product";
                    txtamountor.Text = "Amount";
                    txtpriceor.Text = "Price";
             
                    txttotalor.Text = "Total";

                    txtsaleor.Text = "Sales";
                }
                else MessageBox.Show("Error", "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnresetor_Click(object sender, EventArgs e)
        {
            lbelidor.Visible = false;         
            lbelproductor.Visible = false;  
            lblamountor.Visible = false;
            lblphoneor.Visible = false;
            lblsaleor.Visible = false;
            lblpriceor.Visible = false;
            lbltotalor.Visible = false;
            txtidor.Text = "ID";
            txtphoneor.Text = "Phone";
            txtproductor.Text = "Name's Product";
            txtamountor.Text = "Amount";
            txtpriceor.Text = "Price";
            txttotalor.Text = "Total";
            txtsaleor.Text = "Sales";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveex = new SaveFileDialog();
            if (saveex.ShowDialog() == DialogResult.OK)
            {
                appp obj = new appp();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 15;
                for (int i = 1; i < data.Columns.Count + 1; i++)
                {
                    obj.Cells[1, i] = data.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        if (data.Rows[i].Cells[j].Value != null)
                        {
                            obj.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(saveex.FileName + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                MessageBox.Show("Data Saved", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Not Saved", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtidor_MouseLeave(object sender, EventArgs e)
        {
            if (txtidor.Text == "")
            {
                lbelidor.Visible = false;
                txtidor.Text = "ID";
            }
        }

        private void txtidor_Click(object sender, EventArgs e)
        {
            txtidor.Clear();
            lbelidor.Visible = true;
        }

       
     
        private void txtphoneor_MouseLeave(object sender, EventArgs e)
        {
            if (txtphoneor.Text == "")
            {
                lblphoneor.Visible = false;
                txtphoneor.Text = "Phone";
            }
        }

        private void txtphoneor_Click(object sender, EventArgs e)
        {
            txtphoneor.Clear();
            lblphoneor.Visible = true;
        }

        private void txtproductor_MouseLeave(object sender, EventArgs e)
        {
            if (txtproductor.Text == "")
            {
                lbelproductor.Visible = false;
                txtproductor.Text = "Name Product";
            }
        }

        private void txtproductor_Click(object sender, EventArgs e)
        {
            txtproductor.Clear();
            lbelproductor.Visible = true;
        }

        private void txtamountor_MouseLeave(object sender, EventArgs e)
        {
            if (txtamountor.Text == "")
            {
                lblamountor.Visible = false;
                txtamountor.Text = "Amount";
            }
        }

        private void txtpriceor_MouseLeave(object sender, EventArgs e)
        {
            if (txtpriceor.Text == "")
            {
                lblpriceor.Visible = false;
                txtpriceor.Text = "Price";
            }
        }

        private void txtsaleor_MouseLeave(object sender, EventArgs e)
        {
            if (txtsaleor.Text == "")
            {
                lblsaleor.Visible = false;
                txtsaleor.Text = "Sales";
            }
        }

        private void txttotalor_MouseLeave(object sender, EventArgs e)
        {
            if (txttotalor.Text == "")
            {
                lbltotalor.Visible = false;
                txttotalor.Text = "Total";
            }
        }

        private void txtamountor_Click(object sender, EventArgs e)
        {
            txtamountor.Clear();
            lblamountor.Visible = true;
        }

        private void txtpriceor_Click(object sender, EventArgs e)
        {
            txtpriceor.Clear();
            lblpriceor.Visible = true;
        }

        private void txtsaleor_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void txtsaleor_Click(object sender, EventArgs e)
        {
            txtsaleor.Clear();
            lblsaleor.Visible = true;
        }

        private void txttotalor_Click(object sender, EventArgs e)
        {
            txttotalor.Clear();
            lbltotalor.Visible = true;
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbelidor.Visible = true;
          
            lbelproductor.Visible = true;
         
            lblamountor.Visible = true;
            lblphoneor.Visible = true;
            lblsaleor.Visible = true;
            lblpriceor.Visible = true;
            lbltotalor.Visible = true;
            txtidor.Text = data.CurrentRow.Cells[0].Value.ToString();
         
            txtphoneor.Text = data.CurrentRow.Cells[1].Value.ToString();
            txtproductor.Text = data.CurrentRow.Cells[3].Value.ToString();
            txtamountor.Text = data.CurrentRow.Cells[2].Value.ToString();
            txtpriceor.Text = data.CurrentRow.Cells[4].Value.ToString();

            txttotalor.Text = data.CurrentRow.Cells[5].Value.ToString();
            datetimeor.Value = (DateTime)data.CurrentRow.Cells[6].Value;
            txtsaleor.Text = data.CurrentRow.Cells[7].Value.ToString();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order ord = new order();
            ord.Show();
            this.Close();
        }

        private void manageOderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manaOrder manaord = new manaOrder();
            manaord.Show();
            this.Close();
        }
    }
}
