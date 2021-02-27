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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            comboboxCourse.DataSource = course.getAllCourses();
            comboboxCourse.DisplayMember = "label";
            comboboxCourse.ValueMember = "id";
            comboboxCourse.SelectedItem = null;
        }
        public void fillCombo(int index)
        {
            comboboxCourse.DataSource = course.getAllCourses();
            comboboxCourse.DisplayMember = "label";
            comboboxCourse.ValueMember = "id";
            comboboxCourse.SelectedIndex = index;
        }

        private void comboboxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboboxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                txtlabel.Text = table.Rows[0][1].ToString();
                numperiod.Value = Int32.Parse(table.Rows[0][2].ToString());
                txtdes.Text = table.Rows[0][3].ToString();
            }
            catch { }
            
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            string label = txtlabel.Text;
            int period = (int)numperiod.Value;
            string des = txtdes.Text;
            int id = (int)comboboxCourse.SelectedValue;

            if(!course.checkCourseName(Name,Convert.ToInt32(comboboxCourse.SelectedValue)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(course.updateCourse(id,label,period,des))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(comboboxCourse.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

     

        
    }
}
