using Day01.COURSE;
using Day01.RESULTSV;
using Day01.SCORE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStudentForm addStdF = new addStudentForm();
            addStdF.Show(this);
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsListForm stlist = new studentsListForm();
            stlist.Show(this);
        }

        

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageForm mnagef = new ManageForm();
            mnagef.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDeleteStudentsForms edref = new updateDeleteStudentsForms();
            edref.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm pf = new PrintForm();
            pf.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addcf = new AddCourseForm();
            addcf.Show(this);
        }

        private void remToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm remvf = new RemoveCourseForm();
            remvf.Show(this);
        }

        private void editCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editf = new EditCourseForm();
            editf.Show(this);
        }

        private void statisticChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StacticsForm stf = new StacticsForm();
            stf.Show(this);
        }

        private void pieChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Piechart pc = new Piechart();
            pc.Show(this);
        }

        private void columnChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColumnChart cc = new ColumnChart();
            cc.Show(this);
        }

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manage = new ManageCourseForm();
            manage.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCoursesForm print = new PrintCoursesForm();
            print.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScore = new AddScoreForm();
            addScore.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScore = new RemoveScoreForm();
            removeScore.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScore = new ManageScoreForm();
            manageScore.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse avgScoreByCourse = new AvgScoreByCourse();
            avgScoreByCourse.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show(this);
        }

        private void staticsResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsResultForm staticsResultForm = new StaticsResultForm();
            staticsResultForm.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScoreForm printScoreForm = new PrintScoreForm();
            printScoreForm.Show();
        }

        private void staticsResultByCourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaticsChartByCourse a = new StaticsChartByCourse();
            a.Show(this);
        }

        private void staticsResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsChartResult a = new StaticsChartResult();
            a.Show(this);

        }
    }
}
 