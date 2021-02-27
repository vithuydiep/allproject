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

namespace Day01
{
    public partial class loignForm : Form
    {
        public loignForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addnewUserForm addf = new addnewUserForm();
            addf.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDB db = new MyDB();
            if (rdoStudent.Checked == true)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM NguoiDung WHERE Username=@User AND Password=@Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {

                    mainForm MainF = new mainForm();
                    MainF.ShowDialog(this);

                }
                else
                {

                    errorProvider1.SetError(textBox2, "Sai mật khẩu!");
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }else if(rdoHuman.Checked ==true)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM hr WHERE uname=@User AND pwd=@Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {

                    int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                    Globals.SetGlobalUserId(userid);
                    mainContact main = new mainContact();
                    main.Show();

                }
                else
                {

                    errorProvider1.SetError(textBox2, "Sai mật khẩu!");
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
           
        }

      
    }
}
