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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }
        public void fillcbx()
        {
            GROUP group = new GROUP();
            cbxgroup.DataSource = group.SelectGroupList();
            cbxgroup.DisplayMember = "namegroup";
            cbxgroup.ValueMember = "namegroup";
        }
        Contact contact = new Contact();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtid.Text);
                DataTable table = contact.GetContactById(id);
                txtfname.Text = table.Rows[0][1].ToString();
                txtlname.Text = table.Rows[0][2].ToString();
                txtphone.Text = table.Rows[0][3].ToString();
                txtaddress.Text = table.Rows[0][4].ToString();
                txtemail.Text = table.Rows[0][5].ToString();
                cbxgroup.Text = table.Rows[0][6].ToString();
                byte[] pic;
                pic = (byte[])table.Rows[0][7];
                MemoryStream picture = new MemoryStream(pic);
                picturebox.Image = Image.FromStream(picture);
                picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch { }
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            fillcbx();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string phone = txtphone.Text;
            string email = txtemail.Text;
            string address = txtaddress.Text;
            string group = cbxgroup.SelectedValue.ToString();
            int id = Convert.ToInt32(txtid.Text);
            int userid = Globals.GlobalUserId;
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                picturebox.Image.Save(pic, picturebox.Image.RawFormat);
                if (contact.updateContact(id, fname, lname, phone, address, email, userid, group, pic))
                {
                    MessageBox.Show("This contact edited", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        bool verif()
        {
            if ((txtfname.Text.Trim() == "") || (txtlname.Text.Trim() == "") || (txtphone.Text.Trim() == "") || (picturebox.Image == null) || (txtemail.Text.Trim() == "") || (txtaddress.Text.Trim() == ""))
            {
                return false;
            }
            else return true;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
