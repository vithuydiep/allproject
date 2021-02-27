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

namespace Day01.USERSV
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }
        USER user = new USER();

       
        private void EditUserForm_Load(object sender, EventArgs e)
        {

            MyDB mydb = new MyDB();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from hr where id =@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                picturebox.Image = Image.FromStream(picture);
                picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                txtid.Text = table.Rows[0][0].ToString();
                txtfname.Text = table.Rows[0][1].ToString();
                txtlname.Text = table.Rows[0][2].ToString();
                txtusername.Text = table.Rows[0][3].ToString();
                txtPass.Text = table.Rows[0][4].ToString();
                txtconfirm.Text = table.Rows[0][4].ToString();

            }

        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string username = txtusername.Text;
            string pass = txtPass.Text;
            MemoryStream pic = new MemoryStream();
            if(verif())
            {
                try
                {

                    picturebox.Image.Save(pic, picturebox.Image.RawFormat);
                if (user.updateUser(id,fname,lname,username,pass,pic))
                {
                    MessageBox.Show("User Edited", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error", "Editt User", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

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

        private void btnup_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picturebox.Image = Image.FromFile(open.FileName);
                picturebox.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
        bool verif()
        {
            if ((txtid.Text.Trim() == "") || (txtfname.Text.Trim() == "") || (txtlname.Text.Trim() == "") || (txtusername.Text.Trim() == "") || (txtPass.Text.Trim() == "") || (picturebox.Image == null))
            {
                return false;
            }
            else return true;

        }
    }
}
