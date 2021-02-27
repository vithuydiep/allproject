namespace Day01
{
    partial class mainContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.refinf = new System.Windows.Forms.LinkLabel();
            this.editif = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddcontact = new System.Windows.Forms.Button();
            this.btneditcontact = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnremovecontact = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.txtcontactid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnaddgr = new System.Windows.Forms.Button();
            this.txtnamegr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxgroup2 = new System.Windows.Forms.ComboBox();
            this.btnremovegr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtnewname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxgroup1 = new System.Windows.Forms.ComboBox();
            this.btneditgr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.refinf);
            this.panel1.Controls.Add(this.editif);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 94);
            this.panel1.TabIndex = 0;
            // 
            // refinf
            // 
            this.refinf.ActiveLinkColor = System.Drawing.Color.Black;
            this.refinf.AutoSize = true;
            this.refinf.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refinf.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.refinf.Location = new System.Drawing.Point(213, 46);
            this.refinf.Name = "refinf";
            this.refinf.Size = new System.Drawing.Size(63, 23);
            this.refinf.TabIndex = 2;
            this.refinf.TabStop = true;
            this.refinf.Text = "Refresh";
            this.refinf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refinf_LinkClicked);
            // 
            // editif
            // 
            this.editif.ActiveLinkColor = System.Drawing.Color.Black;
            this.editif.AutoSize = true;
            this.editif.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editif.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.editif.Location = new System.Drawing.Point(107, 46);
            this.editif.Name = "editif";
            this.editif.Size = new System.Drawing.Size(77, 23);
            this.editif.TabIndex = 2;
            this.editif.TabStop = true;
            this.editif.Text = "Edit Infor";
            this.editif.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editif.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editif_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 28);
            this.label12.TabIndex = 1;
            this.label12.Text = "|";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(102, 18);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(98, 28);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Welcome ";
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.White;
            this.avatar.Location = new System.Drawing.Point(12, 6);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(84, 82);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(497, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 492);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(683, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group";
            // 
            // btnaddcontact
            // 
            this.btnaddcontact.BackColor = System.Drawing.Color.Gold;
            this.btnaddcontact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcontact.Location = new System.Drawing.Point(36, 183);
            this.btnaddcontact.Name = "btnaddcontact";
            this.btnaddcontact.Size = new System.Drawing.Size(151, 54);
            this.btnaddcontact.TabIndex = 3;
            this.btnaddcontact.Text = "Add";
            this.btnaddcontact.UseVisualStyleBackColor = false;
            this.btnaddcontact.Click += new System.EventHandler(this.btnaddcontact_Click);
            // 
            // btneditcontact
            // 
            this.btneditcontact.BackColor = System.Drawing.Color.Gold;
            this.btneditcontact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditcontact.Location = new System.Drawing.Point(36, 256);
            this.btneditcontact.Name = "btneditcontact";
            this.btneditcontact.Size = new System.Drawing.Size(151, 54);
            this.btneditcontact.TabIndex = 3;
            this.btneditcontact.Text = "Edit";
            this.btneditcontact.UseVisualStyleBackColor = false;
            this.btneditcontact.Click += new System.EventHandler(this.btneditcontact_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnremovecontact);
            this.panel3.Controls.Add(this.btnselect);
            this.panel3.Controls.Add(this.txtcontactid);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 114);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(505, -171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(470, 111);
            this.panel5.TabIndex = 6;
            // 
            // btnremovecontact
            // 
            this.btnremovecontact.BackColor = System.Drawing.Color.Gold;
            this.btnremovecontact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovecontact.Location = new System.Drawing.Point(3, 58);
            this.btnremovecontact.Name = "btnremovecontact";
            this.btnremovecontact.Size = new System.Drawing.Size(467, 49);
            this.btnremovecontact.TabIndex = 5;
            this.btnremovecontact.Text = "Remove";
            this.btnremovecontact.UseVisualStyleBackColor = false;
            this.btnremovecontact.Click += new System.EventHandler(this.btnremovecontact_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Crimson;
            this.btnselect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(281, 8);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(189, 41);
            this.btnselect.TabIndex = 4;
            this.btnselect.Text = "Select Contact";
            this.btnselect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // txtcontactid
            // 
            this.txtcontactid.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.txtcontactid.Location = new System.Drawing.Point(155, 11);
            this.txtcontactid.Name = "txtcontactid";
            this.txtcontactid.Size = new System.Drawing.Size(120, 35);
            this.txtcontactid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Contact Id:";
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Gold;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(36, 498);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(151, 54);
            this.btnshow.TabIndex = 5;
            this.btnshow.Text = "Show Full List";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.btnaddgr);
            this.panel4.Controls.Add(this.txtnamegr);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(511, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 109);
            this.panel4.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.comboBox3);
            this.panel8.Controls.Add(this.button9);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(-5, 132);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(478, 174);
            this.panel8.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(182, 11);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(286, 36);
            this.comboBox3.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gold;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(3, 123);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(470, 43);
            this.button9.TabIndex = 6;
            this.button9.Text = "Remove";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Select Group :";
            // 
            // btnaddgr
            // 
            this.btnaddgr.BackColor = System.Drawing.Color.DarkOrange;
            this.btnaddgr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddgr.Location = new System.Drawing.Point(3, 57);
            this.btnaddgr.Name = "btnaddgr";
            this.btnaddgr.Size = new System.Drawing.Size(470, 43);
            this.btnaddgr.TabIndex = 6;
            this.btnaddgr.Text = "Add";
            this.btnaddgr.UseVisualStyleBackColor = false;
            this.btnaddgr.Click += new System.EventHandler(this.btnaddgr_Click);
            // 
            // txtnamegr
            // 
            this.txtnamegr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnamegr.Location = new System.Drawing.Point(182, 8);
            this.txtnamegr.Name = "txtnamegr";
            this.txtnamegr.Size = new System.Drawing.Size(286, 34);
            this.txtnamegr.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter Group Name :";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.cbxgroup2);
            this.panel6.Controls.Add(this.btnremovegr);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(511, 478);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(478, 109);
            this.panel6.TabIndex = 7;
            // 
            // cbxgroup2
            // 
            this.cbxgroup2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgroup2.FormattingEnabled = true;
            this.cbxgroup2.Location = new System.Drawing.Point(182, 11);
            this.cbxgroup2.Name = "cbxgroup2";
            this.cbxgroup2.Size = new System.Drawing.Size(286, 36);
            this.cbxgroup2.TabIndex = 7;
            // 
            // btnremovegr
            // 
            this.btnremovegr.BackColor = System.Drawing.Color.DarkOrange;
            this.btnremovegr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovegr.Location = new System.Drawing.Point(3, 57);
            this.btnremovegr.Name = "btnremovegr";
            this.btnremovegr.Size = new System.Drawing.Size(470, 43);
            this.btnremovegr.TabIndex = 6;
            this.btnremovegr.Text = "Remove";
            this.btnremovegr.UseVisualStyleBackColor = false;
            this.btnremovegr.Click += new System.EventHandler(this.btnremovegr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select Group :";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.txtnewname);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.cbxgroup1);
            this.panel7.Controls.Add(this.btneditgr);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(511, 298);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(478, 174);
            this.panel7.TabIndex = 8;
            // 
            // txtnewname
            // 
            this.txtnewname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnewname.Location = new System.Drawing.Point(182, 63);
            this.txtnewname.Name = "txtnewname";
            this.txtnewname.Size = new System.Drawing.Size(286, 34);
            this.txtnewname.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter New Name :";
            // 
            // cbxgroup1
            // 
            this.cbxgroup1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgroup1.FormattingEnabled = true;
            this.cbxgroup1.Location = new System.Drawing.Point(182, 11);
            this.cbxgroup1.Name = "cbxgroup1";
            this.cbxgroup1.Size = new System.Drawing.Size(286, 36);
            this.cbxgroup1.TabIndex = 7;
            // 
            // btneditgr
            // 
            this.btneditgr.BackColor = System.Drawing.Color.DarkOrange;
            this.btneditgr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditgr.Location = new System.Drawing.Point(1, 118);
            this.btneditgr.Name = "btneditgr";
            this.btneditgr.Size = new System.Drawing.Size(470, 43);
            this.btneditgr.TabIndex = 6;
            this.btneditgr.Text = "Edit";
            this.btneditgr.UseVisualStyleBackColor = false;
            this.btneditgr.Click += new System.EventHandler(this.btneditgr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select Group :";
            // 
            // mainContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1001, 603);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btneditcontact);
            this.Controls.Add(this.btnaddcontact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "mainContact";
            this.Text = "mainContact";
            this.Load += new System.EventHandler(this.mainContact_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaddcontact;
        private System.Windows.Forms.Button btneditcontact;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnremovecontact;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtcontactid;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnaddgr;
        private System.Windows.Forms.TextBox txtnamegr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxgroup2;
        private System.Windows.Forms.Button btnremovegr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtnewname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxgroup1;
        private System.Windows.Forms.Button btneditgr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel refinf;
        private System.Windows.Forms.LinkLabel editif;
    }
}