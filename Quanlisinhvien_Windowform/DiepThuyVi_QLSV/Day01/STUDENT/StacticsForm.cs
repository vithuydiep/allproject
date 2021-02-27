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
    public partial class StacticsForm : Form
    {
        public StacticsForm()
        {
            InitializeComponent();
        }
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;

        private void StacticsForm_Load(object sender, EventArgs e)
        {
          
            panTotalColor = pnlTotal.BackColor;
            panMaleColor = pnlMale.BackColor;
            panFemaleColor = pnlFemale.BackColor;

            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));

            lbltotal.Text = ("Total Students: " + total.ToString());
            lblmale.Text = ("Male: " + (maleStudentsPercentage.ToString("0.00") + "%"));
            lblfemale.Text = ("Female : " + (femaleStudentsPercentage.ToString("0.00") + "%"));
        }

        private void lbltotal_MouseEnter(object sender, EventArgs e)
        {
            lbltotal.ForeColor = panTotalColor;
            pnlTotal.BackColor = Color.White;
        }

        private void lbltotal_MouseLeave(object sender, EventArgs e)
        {
            lbltotal.ForeColor = Color.White;
            pnlTotal.BackColor = panTotalColor;
        }

        private void lblfemale_MouseEnter(object sender, EventArgs e)
        {
            lblfemale.ForeColor = panFemaleColor;
            pnlFemale.BackColor = Color.White;
        }

        private void lblfemale_MouseLeave(object sender, EventArgs e)
        {
            lblfemale.ForeColor = Color.White;
            pnlFemale.BackColor = panFemaleColor;
        }

        private void lblmale_MouseEnter_1(object sender, EventArgs e)
        {
            lblmale.ForeColor = panMaleColor;
            pnlMale.BackColor = Color.White;
        }

        private void lblmale_MouseLeave_1(object sender, EventArgs e)
        {
             lblmale.ForeColor = Color.White;
            pnlMale.BackColor = panMaleColor;
        }
    }
}
