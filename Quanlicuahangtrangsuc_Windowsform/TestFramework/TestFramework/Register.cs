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

namespace TestFramework
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        MyData mydb = new MyData();
        public bool themTaikhoan(string username, string pass, int feature , string phone, int idstaff)
        {
            SqlCommand command;
            command = new SqlCommand("execute addaccount @Username,@Pass, @Feature, @phone,@idstaff", mydb.GetConnection);
            command.Parameters.Add("@Username", SqlDbType.Char).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.Char).Value = pass;
            command.Parameters.Add("@Feature", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@phone", SqlDbType.Char).Value = phone;
            command.Parameters.Add("@idstaff", SqlDbType.Int).Value = idstaff;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        bool verif()
        {
            if (txbUser.Text.Trim() == "" || txbPass.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txbUser.Text;
            string pass = txbPass.Text;
            string phone = txtphone.Text;
            int id = Convert.ToInt32(txtidstaff.Text);
            try
            {
                if (verif())
                {
                    if (txbPass.Text == txbagain.Text)
                    {
                        if (themTaikhoan(user, pass, 1, phone,id) )
                        {
                            MessageBox.Show("Account created", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Account create failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Some info is vacant!", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please full fill carefully!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void txbUser_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == "Username")
            {
                txbUser.Text = "";
                txbUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }

        private void txbUser_Leave(object sender, EventArgs e)
        {
            if (txbUser.Text == "")
            {
                txbUser.Text = "Username";
                txbUser.ForeColor = Color.DimGray;
            }
        }

        private void txbPass_Leave(object sender, EventArgs e)
        {
            if (txbPass.Text == "")
            {
                txbPass.Text = "Password";
                txbPass.ForeColor = Color.DimGray;
                txbPass.UseSystemPasswordChar = false;
            }
        }

        private void txbPass_Enter(object sender, EventArgs e)
        {
            if (txbPass.Text == "Password")
            {
                txbPass.Text = "";
                txbPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
                txbPass.UseSystemPasswordChar = true;

            }
        }

        private void btngis_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.ShowDialog();
        }

        private void txbagain_Enter(object sender, EventArgs e)
        {
            if (txbagain.Text == "enter password again")
            {
                txbagain.Text = "";
                txbagain.ForeColor = System.Drawing.SystemColors.WindowFrame;
                txbagain.UseSystemPasswordChar = true;

            }
        }

        private void txbagain_Leave(object sender, EventArgs e)
        {
            if (txbagain.Text == "")
            {
                txbagain.Text = "enter password again";
                txbagain.ForeColor = Color.DimGray;
                txbagain.UseSystemPasswordChar = false;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            if (txtphone.Text == "Phone Number")
            {
                txtphone.Text = "";
                txtphone.ForeColor = System.Drawing.SystemColors.WindowFrame;
                

            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                txtphone.Text = "Phone Number";
                txtphone.ForeColor = Color.DimGray;
            }
        }

        private void txtidstaff_Enter(object sender, EventArgs e)
        {
            if (txtidstaff.Text == "ID Staff")
            {
                txtidstaff.Text = "";
                txtidstaff.ForeColor = System.Drawing.SystemColors.WindowFrame;

            }
        }

        private void txtidstaff_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                txtphone.Text = "ID Staff";
                txtphone.ForeColor = Color.DimGray;
            }
        }
    }
    }

