using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01
{
    public partial class addStudentForm : Form
    {
        public addStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(textBox1.Text);
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            DateTime bdate = dateTimePicker1.Value;
            string addr = textBox4.Text;
            string phone = textBox5.Text;
            string gender = "Male";
            if(radioButton2.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;


            if((this_year - born_year)<10 || (this_year - born_year)>100)
            {
                MessageBox.Show("The student Age must be between 10 and 100", "Invalid Birht Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, addr, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((textBox2.Text.Trim() == "") || (textBox3.Text.Trim()=="") || (textBox5.Text.Trim() == "") || (pictureBox1.Image == null))
            {
                return false;
            }
            else return true;

        }
    }
}
