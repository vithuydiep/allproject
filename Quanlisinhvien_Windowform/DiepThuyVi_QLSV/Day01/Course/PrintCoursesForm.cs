using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using appp = Microsoft.Office.Interop.Excel.Application;

namespace Day01.COURSE
{
    public partial class PrintCoursesForm : Form
    {
        public PrintCoursesForm()
        {
            InitializeComponent();
        }

        

        private void btnfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveex = new SaveFileDialog();
            if (saveex.ShowDialog() == DialogResult.OK)
            {
                appp obj = new appp();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 15;
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    obj.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            obj.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(saveex.FileName + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                MessageBox.Show("Data Saved", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Not Saved", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void btntext_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "Text Document|.txt", ValidateNames = true };

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    write.Write(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    write.Write("\t");
                    write.Write(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    write.Write("\t");
                    write.Write(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    write.Write("\t");
                    write.Write(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    write.WriteLine();
                }
                write.Dispose();
                MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrintCoursesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet5.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.loginDBDataSet5.course);
            // TODO: This line of code loads data into the 'loginDBDataSet5.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.loginDBDataSet5.course);

        }
    }
}
