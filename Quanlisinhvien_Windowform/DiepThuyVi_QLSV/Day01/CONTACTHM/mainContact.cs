using Day01.USERSV;
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
    public partial class mainContact : Form
    {
        public mainContact()
        {
            InitializeComponent();
           
        }
        MyDB mydb = new MyDB();
        public void getImageAndUsername()
        {
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
                avatar.Image = Image.FromStream(picture);
                avatar.SizeMode = PictureBoxSizeMode.Zoom;
                lblname.Text = "Welcome Back ( " + table.Rows[0]["uname"].ToString() + " )";

            }
        }
        GROUP groupcontact = new GROUP();
        private void mainContact_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            fillcbx();
        }
        public void fillcbx()
        {
            cbxgroup1.DataSource = groupcontact.SelectGroupList();
            cbxgroup1.DisplayMember = "namegroup";
            cbxgroup1.ValueMember = "id";
            cbxgroup2.DataSource = groupcontact.SelectGroupList();
            cbxgroup2.DisplayMember = "namegroup";
            cbxgroup2.ValueMember = "id";
        }
            private string RandomString(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                sb.Append(c);
            }
            if (lowerCase)
                return sb.ToString().ToLower();
            return sb.ToString();

        }

        private void btnaddgr_Click(object sender, EventArgs e)
        {
            
            try
            {
                string namegroup = txtnamegr.Text;
                string id = RandomString(5, false);
                if(verify1())
                {
                    if(groupcontact.insertgroup(id,namegroup))
                    {
                        MessageBox.Show("This Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtnamegr.Clear();
                        fillcbx();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid ", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }catch { }
        }
        bool verify1()
        {
            if ((txtnamegr.Text.Trim() == "") )
            {
                return false;
            }
            else return true;
        }

        private void btnremovegr_Click(object sender, EventArgs e)
        {
            try
            {
                string id = cbxgroup2.SelectedValue.ToString();
               
                if (MessageBox.Show("Are you sure you want to remove this group?", "Remove Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (groupcontact.removegroup(id))
                    {
                        MessageBox.Show("The Group Deleted", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillcbx();
                    }
                    else
                    {
                        MessageBox.Show("Group Not Delete", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
        bool verify2()
        {
            if (txtnewname.Text.Trim() == "")
            {
                return false;
            }
            else return true;
        }

        private void btneditgr_Click(object sender, EventArgs e)
        {

            try
            {
                string id = cbxgroup1.SelectedValue.ToString();
                string newname = txtnewname.Text;
                if (verify2())
                {
                    if (groupcontact.editgroup(id, newname))
                    {
                        MessageBox.Show("This Name Group Edited", "Edit Name Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillcbx();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Name Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnaddcontact_Click(object sender, EventArgs e)
        {
            AddContactForm add = new AddContactForm();
            add.Show(this);
        }

        private void btneditcontact_Click(object sender, EventArgs e)
        {
            EditContactForm edit = new EditContactForm();
            edit.Show(this);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            try
            {
                int id = Convert.ToInt32(txtcontactid.Text);
                SelectContactForm selectContactForm = new SelectContactForm();
                selectContactForm.dataGridView1.DataSource = contact.SelectContact(id);
                selectContactForm.dataGridView1.ReadOnly = true;
                selectContactForm.dataGridView1.AllowUserToAddRows = false;
                selectContactForm.Show(this);
            }catch
            {
                MessageBox.Show("Enter id to select", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnremovecontact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            try
            {
                int id = Convert.ToInt32(txtcontactid.Text);
                if (MessageBox.Show("Are you sure you want to remove this contact ?", "Remove Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    if (contact.deleteContact(id))
                    {
                        MessageBox.Show("This contact deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcontactid.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch
            {
                MessageBox.Show("Enter id to remove", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            ShowListForm showListForm = new ShowListForm();
            showListForm.Show(this);
        }

        private void editif_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditUserForm editUser = new EditUserForm();
            editUser.Show(this);
        }

        private void refinf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtcontactid.Clear();
            txtnamegr.Clear();
            txtnewname.Clear();
        }
    }
}
