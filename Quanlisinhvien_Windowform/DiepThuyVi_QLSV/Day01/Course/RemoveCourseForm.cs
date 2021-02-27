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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            COURSES course = new COURSES();
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                if(MessageBox.Show("Are you sure you want to delete this course ? ","Remove Course",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (course.removeCourse(id))
                    {
                        MessageBox.Show("The Course Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Clear();
                    }
                    else
                        MessageBox.Show("Course Not Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Nummeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
