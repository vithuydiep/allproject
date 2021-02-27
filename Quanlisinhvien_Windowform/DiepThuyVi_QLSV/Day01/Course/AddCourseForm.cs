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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            COURSES course = new COURSES();
            int id = Convert.ToInt32(txtid.Text);
            string label = txtlabel.Text;
            int period = Convert.ToInt32(txtperiod.Text);
            string description = txtdes.Text;
            if(label.Trim()=="")
            {
                MessageBox.Show("Add A Courses Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(course.checkCourseName(label))
            {
                if(course.insertCourse(id,label,period,description))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdes.Clear();
                    txtid.Clear();
                    txtlabel.Clear();
                    txtperiod.Clear();
                }else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
