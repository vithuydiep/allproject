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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
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
        bool verif()
        {
            if ((txtfname.Text.Trim() == "") || (txtlname.Text.Trim() == "") || (txtphone.Text.Trim() == "") || (picture.Image == null) || (txtemail.Text.Trim() == "") || (txtaddress.Text.Trim() == ""))
            {
                return false;
            }
            else return true;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          
            Contact contact = new Contact();
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string phone = txtphone.Text;
            string email = txtemail.Text;
            string address = txtaddress.Text;
            string group = cbxgroup.SelectedValue.ToString();
            int id = Convert.ToInt32(txtid.Text);
            int userid = Globals.GlobalUserId;
            MemoryStream pic = new MemoryStream(); 
            if(verif())
            {
                picture.Image.Save(pic, picture.Image.RawFormat);
                if(contact.insertContact(id,fname,lname,phone,address,email,userid,group,pic))
                {
                    MessageBox.Show("This contact added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }






        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            fillcbx();
            
        }
        public void fillcbx()
        {
            GROUP group = new GROUP();
            cbxgroup.DataSource = group.SelectGroupList();
            cbxgroup.DisplayMember = "namegroup";
            cbxgroup.ValueMember = "namegroup";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
