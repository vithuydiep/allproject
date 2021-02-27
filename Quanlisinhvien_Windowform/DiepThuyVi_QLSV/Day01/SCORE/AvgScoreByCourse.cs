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
    public partial class AvgScoreByCourse : Form
    {
        public AvgScoreByCourse()
        {
            InitializeComponent();
        }
        SCORES score = new SCORES();
        private void AvgScoreByCourse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getAvgScoreByCourse();
        }
    }
}
