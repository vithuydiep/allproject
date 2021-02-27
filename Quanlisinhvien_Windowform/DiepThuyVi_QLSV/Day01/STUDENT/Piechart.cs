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

namespace Day01
{
    public partial class Piechart : Form
    {
        public Piechart()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
     

        private void Piechart_Load(object sender, EventArgs e)
        {
          
            DataTable tb = student.getStudents(new SqlCommand("Select gender,count(id) as SL  from std group by gender"));
            chart1.DataSource = tb;

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Gender";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart1.Series["Gender"].XValueMember = "gender";
            chart1.Series["Gender"].YValueMembers = "SL";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
    }
}
