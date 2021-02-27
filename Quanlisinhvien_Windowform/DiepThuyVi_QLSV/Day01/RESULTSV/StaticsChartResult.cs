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

namespace Day01.RESULTSV
{
    public partial class StaticsChartResult : Form
    {
        public StaticsChartResult()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        private void StaticsChartByScore_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "insert into temp(temp.student_id ,temp.avg ) select A.student_id,A.avg from(select student_id, AVG(score.student_score) as avg from std INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = course.id group by student_id) A update temp set Result = 'Fail' where temp.avg < 5 update temp set Result = 'Ordinary' where temp.avg >= 5 and temp.avg < 7 update temp set Result = 'Good' where temp.avg >= 7 and temp.avg < 8 update temp set Result = 'Very Good' where temp.avg >= 8 select Result , Count(*) as SL from temp group by Result ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            chart1.DataSource = table;
            chart1.Titles.Add("Statics Result").Font = new Font("Times New Roman", 15);
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Result";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart1.Series["Result"].XValueMember = "Result";
            chart1.Series["Result"].YValueMembers = "SL";
            deletetemp();
  
        }

        public bool deletetemp()
        {
            SqlCommand command = new SqlCommand("delete from temp", mydb.getConnection);
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (button1.Text == "Pie Chart")
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                button1.Text = "Column Chart";
            }
            else
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                button1.Text = "Pie Chart";
            }
        }
    }
}
