using Day01.COURSE;
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


namespace Day01.SCORE
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        SCORES score = new SCORES();
        STUDENT student = new STUDENT();
        COURSES course = new COURSES();

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            cboxcourse.DataSource = course.getAllCourses();
            cboxcourse.DisplayMember = "label";
            cboxcourse.ValueMember = "id";

            SqlCommand command = new SqlCommand("select id,fname,lname from std");
            dataGridView1.DataSource = student.getStudents(command);


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtsid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(txtsid.Text);
                int courseID = Convert.ToInt32(cboxcourse.SelectedValue);
                float scorevalue = Convert.ToInt32(txtscore.Text);
                string description = txtdes.Text;
                if(!score.studentScoreExist(studentID,courseID))
                {
                    if(score.insertScore(studentID,courseID,scorevalue,description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score for this Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
