using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01
{
    public partial class addnewUserForm : Form
    {
        public addnewUserForm()
        {
            InitializeComponent();
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            USER user = new USER();
           

                int id = Convert.ToInt32(txtid.Text);
                string fname = txtfname.Text;
                string lname = txtlname.Text;
                string username = txtusername.Text;
                string password = txtPass.Text;
                string confirm = txtconfirm.Text;
                MemoryStream pic = new MemoryStream();
                if (verif())
                {
                    picture.Image.Save(pic, picture.Image.RawFormat);
                    if (!user.usernameExist(txtusername.Text, "register"))
                    {
                        if (user.insertUser(id, fname, lname, username, password, pic))
                        {
                            MessageBox.Show("Registration Completed Succeed", "Add New Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Somethong Wrong", "Add new Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("This Username Already Exist, Try with another username", "Add new Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Required Fields -username/password/...", "Add new Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
           

      
            
        bool verif()
            {
                if ((txtid.Text.Trim() == "") || (txtfname.Text.Trim() == "") || (txtlname.Text.Trim() == "") || (txtusername.Text.Trim() == "") || (txtPass.Text.Trim() == "") || (picture.Image == null))
                {
                    return false;
                }
                else return true;

            }
       

        private void btnup_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(open.FileName);
                picture.SizeMode = PictureBoxSizeMode.Zoom;

            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addnewUserForm_Load(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
                txtconfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtconfirm.UseSystemPasswordChar = true;
            }
        }

        private void txtconfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtconfirm.Text != txtPass.Text)
            {
                errorProvider1.SetError(txtconfirm, "Không trùng khớp!");
            }
            else
                errorProvider1.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
