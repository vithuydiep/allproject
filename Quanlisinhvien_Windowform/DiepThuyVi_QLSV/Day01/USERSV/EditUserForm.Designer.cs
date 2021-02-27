namespace Day01.USERSV
{
    partial class EditUserForm
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
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnup = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(257, 434);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.White;
            this.picturebox.Location = new System.Drawing.Point(655, 118);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(256, 243);
            this.picturebox.TabIndex = 27;
            this.picturebox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Picture: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 386);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Confirm:";
            // 
            // btnup
            // 
            this.btnup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Location = new System.Drawing.Point(655, 366);
            this.btnup.Margin = new System.Windows.Forms.Padding(2);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(256, 35);
            this.btnup.TabIndex = 0;
            this.btnup.Text = "Upload Pic";
            this.btnup.UseVisualStyleBackColor = false;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Lime;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(800, 425);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(158, 50);
            this.btnedit.TabIndex = 23;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Red;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(609, 425);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(158, 50);
            this.btnhuy.TabIndex = 22;
            this.btnhuy.Text = "Cancel";
            this.btnhuy.UseVisualStyleBackColor = false;
            // 
            // txtconfirm
            // 
            this.txtconfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtconfirm.Location = new System.Drawing.Point(221, 381);
            this.txtconfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(213, 30);
            this.txtconfirm.TabIndex = 0;
            this.txtconfirm.UseSystemPasswordChar = true;
            this.txtconfirm.TextChanged += new System.EventHandler(this.txtconfirm_TextChanged);
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtlname.Location = new System.Drawing.Point(221, 228);
            this.txtlname.Margin = new System.Windows.Forms.Padding(2);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(213, 30);
            this.txtlname.TabIndex = 0;
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtfname.Location = new System.Drawing.Point(221, 177);
            this.txtfname.Margin = new System.Windows.Forms.Padding(2);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(213, 30);
            this.txtfname.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Last Name:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtid.Location = new System.Drawing.Point(221, 122);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(112, 30);
            this.txtid.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "First Name:";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtusername.Location = new System.Drawing.Point(221, 276);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(213, 30);
            this.txtusername.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 70);
            this.label1.TabIndex = 29;
            this.label1.Text = "Edit My Information";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPass.Location = new System.Drawing.Point(221, 331);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(213, 30);
            this.txtPass.TabIndex = 30;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 334);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1039, 501);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}