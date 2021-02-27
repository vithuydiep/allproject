using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void ManageForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM std"));
        }
        public void fillGrid(SqlCommand command)
        {
            
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AllowUserToAddRows = false;

            //đếm sinh viên
            lbltotalstd.Text = "Total Students: " + dataGridView1.Rows.Count;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(txtID.Text);
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            DateTime bdate = dtpbdate.Value;
            string addr = txtadd.Text;
            string phone = txtphone.Text;
            string gender = "Male";
            if (rdiofemale.Checked==true)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dtpbdate.Value.Year;
            int this_year = DateTime.Now.Year;
            try
            {

                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The student Age must be between 10 and 100", "Invalid Birht Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (verif())
                {
                    pcbox.Image.Save(pic, pcbox.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, addr, pic))
                    {
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM std"));
                    }
                    else
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verif()
        {
            if ((txtfname.Text.Trim() == "") || (txtlname.Text.Trim() == "") || (txtphone.Text.Trim() == "") || (pcbox.Image == null))
            {
                return false;
            }
            else return true;

        }
    
        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pcbox.Image = Image.FromFile(open.FileName);
                pcbox.SizeMode = PictureBoxSizeMode.Zoom;

            }
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id;
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            DateTime bdate = dtpbdate.Value;
            string addr = txtadd.Text;
            string phone = txtphone.Text;
            string gender = "Male";
            if (rdiofemale.Checked==true)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dtpbdate.Value.Year;
            int this_year = DateTime.Now.Year;


            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student Age must be between 10 and 100", "Invalid Birht Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(txtID.Text);
                    pcbox.Image.Save(pic, pcbox.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, addr, pic))
                    {
                        MessageBox.Show("Student Edited", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM std"));
                    }
                    else
                        MessageBox.Show("Error", "Editt Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                int StudentID = Convert.ToInt32(txtID.Text);
                if (MessageBox.Show("Are you sure that you want to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(StudentID))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                        txtfname.Text = "";
                        txtlname.Text = "";
                        txtphone.Text = "";
                        txtadd.Text = "";
                        dtpbdate.Value = DateTime.Now;
                        pcbox.Image = null;
                        fillGrid(new SqlCommand("SELECT * FROM std"));

                    }

                    else
                    {
                        MessageBox.Show("Student not deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtphone.Text = "";
            txtadd.Text = "";
            dtpbdate.Value = DateTime.Now;
            rdiomale.Checked = true;
            pcbox.Image = null;
        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + txtID.Text);
            if (pcbox.Image == null)
            {
                MessageBox.Show("No Image In PictureBox", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (svf.ShowDialog() == DialogResult.OK)
                pcbox.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
           SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname,address) like N'%" + txtfind.Text + "%'");
           // SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname like N'%" + txtfind.Text + "%'");

            fillGrid(command);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtfname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtlname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpbdate.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString()=="Female")
            {
                rdiofemale.Checked = true;
            }
            else rdiomale.Checked = true;

            txtphone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtadd.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pcbox.Image = Image.FromStream(picture);
            pcbox.SizeMode = PictureBoxSizeMode.Zoom;
        }

       
    }

}
