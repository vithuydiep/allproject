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
    public partial class listSameName : Form
    {
        public listSameName()
        {
            InitializeComponent();
        }

        private void listSameName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet3.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.loginDBDataSet3.std);

        }
    }
}
