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

namespace Day01
{
    public partial class studentsListForm : Form
    {
        public studentsListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void studentsListForm_Load(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            updateDeleteStudentsForms updateform = new updateDeleteStudentsForms();

            updateform.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateform.txtfName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateform.txtlname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateform.dtptime.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            //gender
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Male"))
            {
                updateform.rdoMale.Checked = true;
            }

            updateform.txtphone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateform.txtaddr.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //code hình ảnh
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateform.pictureBox1.Image = Image.FromStream(picture);
            updateform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM std");

            dataGridView1.ReadOnly = true;// nap lai du lieu len datagrid view

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 80;

            dataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false; // dong nay tren stackoverflow
        }
    }
}
