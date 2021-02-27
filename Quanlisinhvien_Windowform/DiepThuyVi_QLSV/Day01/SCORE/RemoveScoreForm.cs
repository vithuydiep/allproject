using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01.SCORE
{
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();

        }
        SCORES score = new SCORES();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int courseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                if(MessageBox.Show("Are you sure you want to remove this score?", "Remove Score", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    if(score.deleteScore(studentID,courseID))
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
