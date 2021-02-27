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
    public partial class updateDeleteStudentsForms : Form
    {
        public updateDeleteStudentsForms()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void button4_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = int.Parse(txtID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id =" + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                txtfName.Text = table.Rows[0]["fname"].ToString();
                txtlname.Text = table.Rows[0]["lname"].ToString();
                dtptime.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    rdoFemale.Checked = true;

                } else
                {
                    rdoMale.Checked = true;
                }
                txtphone.Text = table.Rows[0]["phone"].ToString();
                txtaddr.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnfPhone_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            SqlCommand command = new SqlCommand("SELECT *FROM std WHERE phone LIKE '%" + txtphone.Text + "%'");
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                txtID.Text = table.Rows[0]["id"].ToString();
                txtfName.Text = table.Rows[0]["fname"].ToString();
                txtlname.Text = table.Rows[0]["lname"].ToString();
                dtptime.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    rdoFemale.Checked = true;

                }
                else
                {
                    rdoMale.Checked = true;
                }

                txtaddr.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnFindfName_Click(object sender, EventArgs e)
        {

            MyDB mydb = new MyDB();

            string fristn = txtfName.Text.Trim();

            listSameName lsn = new listSameName();
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname,address) LIKE '%" + txtfName.Text + "%'");
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                lsn.dataGSameN.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                lsn.dataGSameN.RowTemplate.Height = 80;
                lsn.dataGSameN.DataSource = student.getStudents(command);
                picCol = (DataGridViewImageColumn)lsn.dataGSameN.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                lsn.dataGSameN.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show("Not found", "SearchStudent", MessageBoxButtons.OK);
            }
            lsn.Show(this);
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname,address) LIKE '%" + txtSearchName.Text + "%'");
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                txtID.Text = table.Rows[0]["id"].ToString();
                txtfName.Text = table.Rows[0]["fname"].ToString();
                txtlname.Text = table.Rows[0]["lname"].ToString();
                dtptime.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    rdoFemale.Checked = true;

                }
                else
                {
                    rdoMale.Checked = true;
                }
                txtphone.Text = table.Rows[0]["phone"].ToString();
                txtaddr.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int id;
            string fname = txtfName.Text;
            string lname = txtlname.Text;
            DateTime bdate = dtptime.Value;
            string addr = txtaddr.Text;
            string phone = txtphone.Text;
            string gender = "Male";
            if (rdoFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dtptime.Value.Year;
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
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, addr, pic))
                    {
                        MessageBox.Show("Student Edited", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        bool verif()
        {
            if ((txtfName.Text.Trim() == "") || (txtlname.Text.Trim() == "") || (txtphone.Text.Trim() == "") || (pictureBox1.Image == null))
            {
                return false;
            }
            else return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int StudentID = Convert.ToInt32(txtID.Text);
                if (MessageBox.Show("Are you sure that you want to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(StudentID))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                        txtfName.Text = "";
                        txtlname.Text = "";
                        txtphone.Text = "";
                        txtaddr.Text = "";
                        dtptime.Value = DateTime.Now;
                        pictureBox1.Image = null;


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

        private void updateDeleteStudentsForms_Load(object sender, EventArgs e)
        {

        }
    }
}
