using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01.SCORE
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        SCORES score = new SCORES();

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }
    }
}
