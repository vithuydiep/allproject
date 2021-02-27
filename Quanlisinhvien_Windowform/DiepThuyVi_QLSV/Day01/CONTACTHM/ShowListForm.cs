using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01
{
    public partial class ShowListForm : Form
    {
        public ShowListForm()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        GROUP group = new GROUP();
        void reloadListBoxData()
        {
            listBox1.DataSource = group.SelectGroupList();
            listBox1.DisplayMember = "namegroup";
            listBox1.ValueMember = "namegroup";
            listBox1.SelectedItem = null;

       

        }
 
        string groupn;
        private void listBox1_Click(object sender, EventArgs e)
        {

            groupn = listBox1.SelectedValue.ToString();
            dataGridView1.DataSource = contact.SelectContactList(new SqlCommand("select * from mycontact where groupid = N'" + groupn + "'"));
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }



        private void ShowListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet4.mycontact' table. You can move, or remove it, as needed.
            this.mycontactTableAdapter.Fill(this.loginDBDataSet4.mycontact);
            // TODO: This line of code loads data into the 'loginDBDataSet4.mycontact' table. You can move, or remove it, as needed.

            reloadListBoxData();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
           
        }

    }
}
