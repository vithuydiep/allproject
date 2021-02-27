namespace Day01
{
    partial class PrintForm
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
            this.btncheck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtplast = new System.Windows.Forms.DateTimePicker();
            this.dtpfirst = new System.Windows.Forms.DateTimePicker();
            this.rdono = new System.Windows.Forms.RadioButton();
            this.rdoyes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlusedate = new System.Windows.Forms.Label();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdimale = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btncheck);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rdofemale);
            this.panel1.Controls.Add(this.rdimale);
            this.panel1.Controls.Add(this.rdoAll);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 120);
            this.panel1.TabIndex = 0;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.Red;
            this.btncheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(918, 37);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(127, 42);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtplast);
            this.panel2.Controls.Add(this.dtpfirst);
            this.panel2.Controls.Add(this.rdono);
            this.panel2.Controls.Add(this.rdoyes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pnlusedate);
            this.panel2.Location = new System.Drawing.Point(374, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 95);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "And";
            // 
            // dtplast
            // 
            this.dtplast.Enabled = false;
            this.dtplast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtplast.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtplast.Location = new System.Drawing.Point(405, 50);
            this.dtplast.Name = "dtplast";
            this.dtplast.Size = new System.Drawing.Size(121, 27);
            this.dtplast.TabIndex = 4;
            // 
            // dtpfirst
            // 
            this.dtpfirst.Enabled = false;
            this.dtpfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfirst.Location = new System.Drawing.Point(217, 50);
            this.dtpfirst.Name = "dtpfirst";
            this.dtpfirst.Size = new System.Drawing.Size(128, 27);
            this.dtpfirst.TabIndex = 3;
            // 
            // rdono
            // 
            this.rdono.AutoSize = true;
            this.rdono.Checked = true;
            this.rdono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdono.Location = new System.Drawing.Point(300, 10);
            this.rdono.Name = "rdono";
            this.rdono.Size = new System.Drawing.Size(63, 29);
            this.rdono.TabIndex = 2;
            this.rdono.TabStop = true;
            this.rdono.Text = "NO";
            this.rdono.UseVisualStyleBackColor = true;
            this.rdono.CheckedChanged += new System.EventHandler(this.rdono_CheckedChanged);
            // 
            // rdoyes
            // 
            this.rdoyes.AutoSize = true;
            this.rdoyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoyes.Location = new System.Drawing.Point(206, 10);
            this.rdoyes.Name = "rdoyes";
            this.rdoyes.Size = new System.Drawing.Size(73, 29);
            this.rdoyes.TabIndex = 1;
            this.rdoyes.Text = "YES";
            this.rdoyes.UseVisualStyleBackColor = true;
            this.rdoyes.CheckedChanged += new System.EventHandler(this.rdoyes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "BirthDate Between : ";
            // 
            // pnlusedate
            // 
            this.pnlusedate.AutoSize = true;
            this.pnlusedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlusedate.Location = new System.Drawing.Point(14, 12);
            this.pnlusedate.Name = "pnlusedate";
            this.pnlusedate.Size = new System.Drawing.Size(171, 25);
            this.pnlusedate.TabIndex = 0;
            this.pnlusedate.Text = "Use Date Range : ";
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdofemale.Location = new System.Drawing.Point(236, 44);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(98, 29);
            this.rdofemale.TabIndex = 0;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdimale
            // 
            this.rdimale.AutoSize = true;
            this.rdimale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdimale.Location = new System.Drawing.Point(118, 44);
            this.rdimale.Name = "rdimale";
            this.rdimale.Size = new System.Drawing.Size(76, 29);
            this.rdimale.TabIndex = 0;
            this.rdimale.TabStop = true;
            this.rdimale.Text = "Male";
            this.rdimale.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAll.Location = new System.Drawing.Point(16, 44);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(55, 29);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 468);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Lime;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(559, 639);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(192, 43);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save To Text File";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Cyan;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(793, 639);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(192, 43);
            this.btnprint.TabIndex = 2;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Location = new System.Drawing.Point(325, 639);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(192, 43);
            this.btnexcel.TabIndex = 3;
            this.btnexcel.Text = "Save To Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.Location = new System.Drawing.Point(89, 639);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(192, 43);
            this.btnWord.TabIndex = 3;
            this.btnWord.Text = "Save To Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 707);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtplast;
        private System.Windows.Forms.DateTimePicker dtpfirst;
        private System.Windows.Forms.RadioButton rdono;
        private System.Windows.Forms.RadioButton rdoyes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pnlusedate;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdimale;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnWord;
    }
}