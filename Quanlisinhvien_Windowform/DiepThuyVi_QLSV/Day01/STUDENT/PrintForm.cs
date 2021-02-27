using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using appp = Microsoft.Office.Interop.Excel.Application;


namespace Day01
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void PrintForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM std"));
        }
        public void fillGrid(SqlCommand command)
        {

            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (rdoAll.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM std"));
            }
            else if (rdimale.Checked ==true)
            {
                fillGrid(new SqlCommand("SELECT * FROM std WHERE gender ='male'"));
            }
            else if(rdofemale.Checked == true)
            {
                fillGrid(new SqlCommand("SELECT * FROM std WHERE gender='female'"));

            }
            if(rdoyes.Checked==true)
            {
                DateTime first = dtpfirst.Value;
                DateTime last = dtplast.Value;
                fillGrid(new SqlCommand("SELECT * FROM std WHERE bdate BETWEEN '" + first + "' AND '" + last + "'"));
            }



         
        }

        private void rdono_CheckedChanged(object sender, EventArgs e)
        {
            if (rdono.Checked == true)
            {
                dtpfirst.Enabled = false;
                dtplast.Enabled = false;
            }
        }

        private void rdoyes_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoyes.Checked ==true)
            {
                dtpfirst.Enabled = true;
                dtplast.Enabled = true;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog() { Filter = "Text Document|.txt", ValidateNames = true };
            if (svf.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(svf.FileName);
                for (int i = 0; i < dataGridView1.Rows.Count ; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        writer.Write("  "+ dataGridView1.Rows[i].Cells[j].Value.ToString() + "  |");
                    }
                    writer.WriteLine("");

                }
                writer.Close();
               
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveex = new SaveFileDialog();          
            if (saveex.ShowDialog() == DialogResult.OK)
            {
                appp obj = new appp();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 15;
                for (int i = 1; i < dataGridView1.Columns.Count+1 ; i++)
                {
                    obj.Cells[1, i] = dataGridView1.Columns[i-1].HeaderText;
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
                obj.ActiveWorkbook.SaveCopyAs(saveex.FileName+".xlsx");
                obj.ActiveWorkbook.Saved = true;
                MessageBox.Show("Data Saved", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Not Saved", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            DateTime bdate;
            SaveFileDialog save = new SaveFileDialog() { Filter = "Microsoft Word Document|.doc", ValidateNames = true };
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            write.Write(bdate.ToString("yyyy-MM-dd") + "\t");
                        }
                        else if (j == dataGridView1.Columns.Count - 2)
                        {
                            write.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            write.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t");
                        }

                    }
                    write.WriteLine("");

                }
                write.Dispose();
                MessageBox.Show("File Saved", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
