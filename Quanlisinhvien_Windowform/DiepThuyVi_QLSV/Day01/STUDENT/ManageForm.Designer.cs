namespace Day01
{
    partial class ManageForm
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
            this.txtadd = new System.Windows.Forms.TextBox();
            this.dtpbdate = new System.Windows.Forms.DateTimePicker();
            this.btnupload = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.rdiofemale = new System.Windows.Forms.RadioButton();
            this.rdiomale = new System.Windows.Forms.RadioButton();
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndownload = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbltotalstd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(164, 313);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(275, 94);
            this.txtadd.TabIndex = 25;
            // 
            // dtpbdate
            // 
            this.dtpbdate.Location = new System.Drawing.Point(163, 160);
            this.dtpbdate.Name = "dtpbdate";
            this.dtpbdate.Size = new System.Drawing.Size(275, 22);
            this.dtpbdate.TabIndex = 22;
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(163, 622);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(136, 29);
            this.btnupload.TabIndex = 27;
            this.btnupload.Text = "Upload ";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(163, 261);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(275, 30);
            this.txtphone.TabIndex = 24;
            // 
            // rdiofemale
            // 
            this.rdiofemale.AutoSize = true;
            this.rdiofemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdiofemale.Location = new System.Drawing.Point(141, -1);
            this.rdiofemale.Name = "rdiofemale";
            this.rdiofemale.Size = new System.Drawing.Size(116, 33);
            this.rdiofemale.TabIndex = 1;
            this.rdiofemale.TabStop = true;
            this.rdiofemale.Text = "Female";
            this.rdiofemale.UseVisualStyleBackColor = true;
            // 
            // rdiomale
            // 
            this.rdiomale.AutoSize = true;
            this.rdiomale.Checked = true;
            this.rdiomale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdiomale.Location = new System.Drawing.Point(36, -1);
            this.rdiomale.Name = "rdiomale";
            this.rdiomale.Size = new System.Drawing.Size(87, 33);
            this.rdiomale.TabIndex = 0;
            this.rdiomale.TabStop = true;
            this.rdiomale.Text = "Male";
            this.rdiomale.UseVisualStyleBackColor = true;
            // 
            // pcbox
            // 
            this.pcbox.BackColor = System.Drawing.Color.SteelBlue;
            this.pcbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbox.Location = new System.Drawing.Point(164, 421);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(275, 201);
            this.pcbox.TabIndex = 26;
            this.pcbox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdiofemale);
            this.panel1.Controls.Add(this.rdiomale);
            this.panel1.Location = new System.Drawing.Point(163, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 34);
            this.panel1.TabIndex = 23;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(163, 110);
            this.txtlname.Multiline = true;
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(275, 30);
            this.txtlname.TabIndex = 21;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(163, 65);
            this.txtfname.Multiline = true;
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(275, 30);
            this.txtfname.TabIndex = 20;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(163, 21);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(94, 30);
            this.txtID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "BirthDate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student ID: ";
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(302, 622);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(136, 29);
            this.btndownload.TabIndex = 28;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(29, 672);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(152, 45);
            this.btnadd.TabIndex = 29;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(187, 672);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(152, 45);
            this.btnedit.TabIndex = 29;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Red;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(345, 672);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(152, 45);
            this.btnremove.TabIndex = 29;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(503, 672);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(152, 45);
            this.btnreset.TabIndex = 29;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(744, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Enter A Value To Search: ";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(1038, 21);
            this.txtfind.Multiline = true;
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(248, 33);
            this.txtfind.TabIndex = 31;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Location = new System.Drawing.Point(1310, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(152, 45);
            this.btnsearch.TabIndex = 29;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(465, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 585);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbltotalstd
            // 
            this.lbltotalstd.BackColor = System.Drawing.Color.DarkViolet;
            this.lbltotalstd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalstd.Location = new System.Drawing.Point(1192, 654);
            this.lbltotalstd.Name = "lbltotalstd";
            this.lbltotalstd.Size = new System.Drawing.Size(270, 37);
            this.lbltotalstd.TabIndex = 33;
            this.lbltotalstd.Text = "Total Students : ";
            this.lbltotalstd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1475, 732);
            this.Controls.Add(this.lbltotalstd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.dtpbdate);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.pcbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadd;
        internal System.Windows.Forms.DateTimePicker dtpbdate;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.RadioButton rdiofemale;
        private System.Windows.Forms.RadioButton rdiomale;
        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltotalstd;
    }
}