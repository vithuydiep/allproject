using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01.COURSE
{
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();
        int pos;

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            listBox1.DataSource = course.getAllCourses();
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "label";
            listBox1.SelectedItem = null;
            lbltotal.Text = "Total Courses: " + course.totalCourses();

        }
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            listBox1.SelectedIndex = index;
            txtid.Text = dr.ItemArray[0].ToString();
            txtlabel.Text = dr.ItemArray[1].ToString();
            numericupdownhours.Value = int.Parse(dr.ItemArray[2].ToString());
            txtdes.Text = dr.ItemArray[3].ToString();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            pos = listBox1.SelectedIndex;
            showData(pos);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            string label = txtlabel.Text;
            int period = (int)numericupdownhours.Value;
            string description = txtdes.Text;
            if (label.Trim() == "")
            {
                MessageBox.Show("Add A Courses Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(label))
            {
                if (course.insertCourse(id, label, period, description))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdes.Clear();
                    txtid.Clear();
                    txtlabel.Clear();
                    numericupdownhours.Value = 10;
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string label = txtlabel.Text;
            int period = (int)numericupdownhours.Value;
            string des = txtdes.Text;
            int id = int.Parse(txtid.Text);

            if (!course.checkCourseName(Name, Convert.ToInt32(txtid.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, label, period, des))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtid.Text);
                if (MessageBox.Show("Are you sure you want to delete this course ? ", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.removeCourse(id))
                    {
                        MessageBox.Show("The Course Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtdes.Clear();
                        txtid.Clear();
                        txtlabel.Clear();
                        numericupdownhours.Value = 10;
                        reloadListBoxData();
                    }
                    else
                        MessageBox.Show("Course Not Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Nummeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if(pos < (course.getAllCourses().Rows.Count -1) )
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if(pos >0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }
    }
}
