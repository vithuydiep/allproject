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
    public partial class StaticsResultForm : Form
    {
        public StaticsResultForm()
        {
            InitializeComponent();
        }
        SCORES score = new SCORES();
        STUDENT student = new STUDENT();
        private void StaticsResultForm_Load(object sender, EventArgs e)
        {
            DataTable table = score.getAvgScoreByCourse();
            lbtkythuat.Text = table.Rows[0][1].ToString();
            lbldoituong.Text = table.Rows[1][1].ToString() ;
            lblwind.Text = table.Rows[2][1].ToString() ;
            lbltoan2.Text = table.Rows[3][1].ToString() ;

            DataTable table2 = score.getresult();
            double total = Convert.ToDouble(student.totalStudent());
            double totalordinary = Convert.ToDouble(score.totalOrdinary());
            double totalgood = Convert.ToDouble(score.totalGood());
            double totalverygood = Convert.ToDouble(score.totalVerygood());
            double totalfail = Convert.ToDouble(score.totalFail());

            double pttb = totalordinary *(100 / total);
            double ptkha = totalgood * (100 / total);
            double ptgioi = totalverygood * (100 / total);
            double ptrot = totalfail * (100 / total);

            lblfail.Text = ptrot.ToString("0.00") + "%";
            lblgioi.Text = ptgioi.ToString("0.00") + "%";
            lblkha.Text = ptkha.ToString("0.00") + "%";
            lbltb.Text = pttb.ToString("0.00") + "%";
        }
    }
}
