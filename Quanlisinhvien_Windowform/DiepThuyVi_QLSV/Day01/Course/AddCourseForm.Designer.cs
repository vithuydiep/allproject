namespace Day01.COURSE
{
    partial class AddCourseForm
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
            this.txtperiod = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Label             :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Period           :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description   :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(207, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(319, 32);
            this.txtid.TabIndex = 1;
            // 
            // txtlabel
            // 
            this.txtlabel.Location = new System.Drawing.Point(208, 92);
            this.txtlabel.Name = "txtlabel";
            this.txtlabel.Size = new System.Drawing.Size(319, 32);
            this.txtlabel.TabIndex = 1;
            // 
            // txtperiod
            // 
            this.txtperiod.Location = new System.Drawing.Point(208, 152);
            this.txtperiod.Name = "txtperiod";
            this.txtperiod.Size = new System.Drawing.Size(319, 32);
            this.txtperiod.TabIndex = 1;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(207, 215);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(319, 112);
            this.txtdes.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(174, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(571, 422);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtperiod);
            this.Controls.Add(this.txtlabel);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
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
        private System.Windows.Forms.TextBox txtperiod;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Button btnAdd;
    }
}