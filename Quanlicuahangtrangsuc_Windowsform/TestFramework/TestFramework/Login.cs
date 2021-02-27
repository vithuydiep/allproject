using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TestFramework.Class;

namespace TestFramework
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        MyData mydb = new MyData();
        private void Login_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            //tbuser.BackColor = Color.FromArgb(100, 1, 1, 1);
            //tbpass.BackColor = Color.FromArgb(100, 1, 1, 1);
            
        }

        
        private void tbuser_Enter_1(object sender, EventArgs e)
        {
            if (txbUser.Text == "username")
            {
                txbUser.Text = "";
                txbUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void tbuser_Leave_1(object sender, EventArgs e)
        {
            if (txbUser.Text == "")
            {
                txbUser.Text = "username";
                txbUser.ForeColor = Color.DimGray;
            }
        }

        private void tbpass_Enter_1(object sender, EventArgs e)
        {
            if (txbPass.Text == "password")
            {
                txbPass.Text = "";
                txbPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
                txbPass.UseSystemPasswordChar = true;

            }
        }

        private void tbpass_Leave_1(object sender, EventArgs e)
        {
            if (txbPass.Text == "")
            {
                txbPass.Text = "password";
                txbPass.ForeColor = Color.DimGray;
                txbPass.UseSystemPasswordChar = false;
            }
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("select * from dbo.loginacc(@User,@Pass)  ", mydb.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = txbUser.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txbPass.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count >0)
            {
                int temp = Convert.ToInt32(table.Rows[0][1].ToString());
                if (temp == 0)
                {
                    int userid = Convert.ToInt32(table.Rows[0][0].ToString());
                    GlobalsMaNV.SetGlobalMaNV(userid);
                    Pro.Manaform a = new Pro.Manaform();
                    a.ShowDialog();
                    this.Hide();
                }
                else if (temp == 1)
                {
                    int userid = Convert.ToInt32(table.Rows[0][0].ToString());
                    GlobalsMaNV.SetGlobalMaNV(userid);
                    formMain form = new formMain();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("username or password incorrect!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Account does not exist !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


         
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            formMain mainne = new formMain();
            mainne.ShowDialog();

        }

        private void btngis_Click(object sender, EventArgs e)
        {
            Register gis = new Register();
            gis.ShowDialog();
        }

        private void txbUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
