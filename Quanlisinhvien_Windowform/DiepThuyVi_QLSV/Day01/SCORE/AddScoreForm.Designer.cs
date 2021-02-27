namespace Day01.SCORE
{
    partial class AddScoreForm
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
            this.txtsid = new System.Windows.Forms.TextBox();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.cboxcourse = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(118, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(67, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // txtsid
            // 
            this.txtsid.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsid.Location = new System.Drawing.Point(225, 52);
            this.txtsid.Name = "txtsid";
            this.txtsid.ReadOnly = true;
            this.txtsid.Size = new System.Drawing.Size(172, 33);
            this.txtsid.TabIndex = 1;
            // 
            // txtscore
            // 
            this.txtscore.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(226, 202);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(171, 33);
            this.txtscore.TabIndex = 1;
            // 
            // txtdes
            // 
            this.txtdes.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(225, 276);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(280, 125);
            this.txtdes.TabIndex = 1;
            // 
            // cboxcourse
            // 
            this.cboxcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxcourse.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxcourse.FormattingEnabled = true;
            this.cboxcourse.Location = new System.Drawing.Point(225, 126);
            this.cboxcourse.Name = "cboxcourse";
            this.cboxcourse.Size = new System.Drawing.Size(281, 33);
            this.cboxcourse.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(564, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 435);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Lime;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(191, 439);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(220, 55);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add Score";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1014, 515);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboxcourse);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.ComboBox cboxcourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
    }
}