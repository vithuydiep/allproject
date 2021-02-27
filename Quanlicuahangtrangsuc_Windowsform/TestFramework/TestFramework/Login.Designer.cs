namespace TestFramework
{
    partial class Login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btngis = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.btngis);
            this.panel2.Controls.Add(this.txbPass);
            this.panel2.Controls.Add(this.txbUser);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(289, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 416);
            this.panel2.TabIndex = 7;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(181, 291);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(124, 45);
            this.btnlogin.TabIndex = 15;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btngis
            // 
            this.btngis.BackColor = System.Drawing.Color.Gainsboro;
            this.btngis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngis.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngis.Location = new System.Drawing.Point(40, 291);
            this.btngis.Name = "btngis";
            this.btngis.Size = new System.Drawing.Size(124, 45);
            this.btngis.TabIndex = 14;
            this.btngis.Text = "REGISTER";
            this.btngis.UseVisualStyleBackColor = false;
            this.btngis.Click += new System.EventHandler(this.btngis_Click);
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.ForeColor = System.Drawing.Color.DimGray;
            this.txbPass.Location = new System.Drawing.Point(26, 226);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(292, 29);
            this.txbPass.TabIndex = 21;
            this.txbPass.Text = "password";
            this.txbPass.Enter += new System.EventHandler(this.tbpass_Enter_1);
            this.txbPass.Leave += new System.EventHandler(this.tbpass_Leave_1);
            // 
            // txbUser
            // 
            this.txbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUser.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.ForeColor = System.Drawing.Color.DimGray;
            this.txbUser.Location = new System.Drawing.Point(26, 158);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(292, 29);
            this.txbUser.TabIndex = 20;
            this.txbUser.Text = "username";
            this.txbUser.TextChanged += new System.EventHandler(this.txbUser_TextChanged);
            this.txbUser.Enter += new System.EventHandler(this.tbuser_Enter_1);
            this.txbUser.Leave += new System.EventHandler(this.tbuser_Leave_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 1);
            this.label3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 1);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login Here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Blue;
            this.guna2PictureBox1.Image = global::TestFramework.Properties.Resources.PIC6;
            this.guna2PictureBox1.Location = new System.Drawing.Point(879, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(28, 31);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 39;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TestFramework.Properties.Resources._97_979583_display_of_full_page_app_intro_page_bts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 500);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngis;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Button btnlogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}