using Day01.COURSE;
using Day01.SCORE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        SCORES score = new SCORES();
        COURSES course = new COURSES();

        private void ResultForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getresult();
            DataGridViewColumn col = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            col.HeaderText = "Result";
            col.Visible = true;
            col.ReadOnly = true;
            col.CellTemplate = cell;
            dataGridView1.Columns.Add(col);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) < 5)
                    dataGridView1.Rows[i].Cells[8].Value = "Fail";
                else if( Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) >=5 && Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) < 7)
                    dataGridView1.Rows[i].Cells[8].Value = "Ordinary";
                else if(Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) >= 7 && Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) < 8 )
                    dataGridView1.Rows[i].Cells[8].Value = "Good";
                else if(Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) >= 8 )
                        dataGridView1.Rows[i].Cells[8].Value = "Very Good";

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtfname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtlname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            SqlCommand command = new SqlCommand("Select score.student_id, std.fname,std.lname, sum(case when course.label = N'Toán 2' then student_score else 0 end) as 'Toán 2' ,sum(case when course.label = N'Kỹ thuật lập trình' then student_score else 0 end) as 'Kỹ thuật lập trình',sum(case when course.label = N'Lập trình hướng đối tượng' then student_score else 0 end) as'OOP' , sum(case when course.label = N'Lập trình Windows' then student_score else 0 end) as'Lập trình Windows',avg(score.student_score) as ĐTB from std INNER JOIN score on std.id = score.student_id INNER JOIN course on score.course_id = course.id where CONCAT(score.student_id, std.fname) like N'%" + txtsearch.Text + "%' group by student_id, fname,lname ");
            dataGridView1.DataSource= score.getfind(command);
            DataGridViewColumn col = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            col.HeaderText = "Result";
            col.Visible = true;
            col.CellTemplate = cell;
            dataGridView1.Columns.Add(col);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) < 5)
                    dataGridView1.Rows[i].Cells[8].Value = "Fail";
                else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) >= 5 && Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) < 7)
                    dataGridView1.Rows[i].Cells[8].Value = "Ordinary";
                else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) >= 7  && Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) < 8)
                    dataGridView1.Rows[i].Cells[8].Value = "Good";
                else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value) >= 8)
                    dataGridView1.Rows[i].Cells[8].Value = "Very Good";

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
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
