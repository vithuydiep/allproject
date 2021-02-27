namespace Day01.COURSE
{
    partial class EditCourseForm
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
            this.comboboxCourse = new System.Windows.Forms.ComboBox();
            this.txtlabel = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.numperiod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numperiod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // comboboxCourse
            // 
            this.comboboxCourse.FormattingEnabled = true;
            this.comboboxCourse.Location = new System.Drawing.Point(238, 63);
            this.comboboxCourse.Name = "comboboxCourse";
            this.comboboxCourse.Size = new System.Drawing.Size(275, 34);
            this.comboboxCourse.TabIndex = 2;
            this.comboboxCourse.SelectedIndexChanged += new System.EventHandler(this.comboboxCourse_SelectedIndexChanged);
            // 
            // txtlabel
            // 
            this.txtlabel.Location = new System.Drawing.Point(238, 118);
            this.txtlabel.Name = "txtlabel";
            this.txtlabel.Size = new System.Drawing.Size(275, 32);
            this.txtlabel.TabIndex = 3;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(238, 239);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(275, 112);
            this.txtdes.TabIndex = 3;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnedit.Location = new System.Drawing.Point(105, 384);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(348, 47);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // numperiod
            // 
            this.numperiod.Location = new System.Drawing.Point(238, 180);
            this.numperiod.Name = "numperiod";
            this.numperiod.Size = new System.Drawing.Size(275, 32);
            this.numperiod.TabIndex = 5;
            this.numperiod.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(569, 472);
            this.Controls.Add(this.numperiod);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtlabel);
            this.Controls.Add(this.comboboxCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numperiod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboboxCourse;
        private System.Windows.Forms.TextBox txtlabel;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.NumericUpDown numperiod;
    }
}