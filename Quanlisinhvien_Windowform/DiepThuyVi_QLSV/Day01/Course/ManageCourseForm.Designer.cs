namespace Day01.COURSE
{
    partial class ManageCourseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtlabel = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.numericupdownhours = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownhours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Label :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hours Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description :";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(195, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(128, 30);
            this.txtid.TabIndex = 1;
            // 
            // txtlabel
            // 
            this.txtlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlabel.Location = new System.Drawing.Point(195, 112);
            this.txtlabel.Name = "txtlabel";
            this.txtlabel.Size = new System.Drawing.Size(237, 30);
            this.txtlabel.TabIndex = 2;
            // 
            // txtdes
            // 
            this.txtdes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(195, 242);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(237, 113);
            this.txtdes.TabIndex = 4;
            // 
            // numericupdownhours
            // 
            this.numericupdownhours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdownhours.Location = new System.Drawing.Point(195, 173);
            this.numericupdownhours.Name = "numericupdownhours";
            this.numericupdownhours.Size = new System.Drawing.Size(128, 30);
            this.numericupdownhours.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(550, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 441);
            this.listBox1.TabIndex = 3;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnfirst.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfirst.Location = new System.Drawing.Point(22, 394);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(115, 43);
            this.btnfirst.TabIndex = 5;
            this.btnfirst.Text = "First";
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnnext.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnext.Location = new System.Drawing.Point(143, 394);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(115, 43);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnprevious.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprevious.Location = new System.Drawing.Point(264, 394);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(115, 43);
            this.btnprevious.TabIndex = 7;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlast.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlast.Location = new System.Drawing.Point(385, 394);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(115, 43);
            this.btnlast.TabIndex = 8;
            this.btnlast.Text = "Last";
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Lime;
            this.btnadd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(8, 469);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(154, 45);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnedit.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(184, 469);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(154, 45);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Red;
            this.btnremove.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(364, 469);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(154, 45);
            this.btnremove.TabIndex = 6;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotal.Location = new System.Drawing.Point(732, 493);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(197, 42);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(973, 570);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericupdownhours);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtlabel);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownhours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtlabel;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.NumericUpDown numericupdownhours;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label lbltotal;
    }
}