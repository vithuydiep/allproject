using Day01.COURSE;
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

namespace Day01.RESULTSV
{
    public partial class StaticsChartByCourse : Form
    {
        public StaticsChartByCourse()
        {
            InitializeComponent();
        }

        private void StaticsChartByCourse_Load(object sender, EventArgs e)
        {
            SCORES score = new SCORES();
            DataTable tb = score.getAvgScoreByCourse();
            chart1.DataSource = tb;
            chart1.Titles.Add("Statics By Course").Font = new Font("Times New Roman", 15);
            chart1.ChartAreas["Course"].AxisX.Title = "Course";
            chart1.ChartAreas["Course"].AxisY.Title = "Score";
            chart1.Series["Course"].XValueMember = "label";
            chart1.Series["Course"].YValueMembers =  "averageGrade";

            
        }

      
    }
}
