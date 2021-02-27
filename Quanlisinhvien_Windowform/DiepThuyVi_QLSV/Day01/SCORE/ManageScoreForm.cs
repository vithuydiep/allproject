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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        SCORES score = new SCORES();
        COURSES course = new COURSES();
        string data = "score";

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
            cboxcourse.DataSource = course.getAllCourses();
            cboxcourse.DisplayMember = "label";
            cboxcourse.ValueMember = "id";
        }

        private void btnshowst_Click(object sender, EventArgs e)
        {
            data = "std";
            SqlCommand command = new SqlCommand("select id,fname,lname,bdate from std");
            dataGridView1.DataSource = student.getStudents(command);
        }

        private void btnshowscore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = score.getStudentScore();
        }

        void getDataFromDatagridView()
        {
            if(data == "std")
            {
                txtsid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if(data =="score")
            {
                txtsid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cboxcourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridView();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(txtsid.Text);
                int courseID = Convert.ToInt32(cboxcourse.SelectedValue);
                float scorevalue = Convert.ToInt32(txtscore.Text);
                string description = txtdes.Text;
                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scorevalue, description))
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
                    MessageBox.Show("The Score for thí Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int courseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                if (MessageBox.Show("Are you sure you want to remove this score?", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentID, courseID))
                    {
                        MessageBox.Show("The Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = score.getStudentScore();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Delete", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnavg_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse avgScoreBy = new AvgScoreByCourse();
            avgScoreBy.Show(this);
        }
    }
}
