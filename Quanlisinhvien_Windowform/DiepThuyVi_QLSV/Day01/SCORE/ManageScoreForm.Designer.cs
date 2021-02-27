namespace Day01.SCORE
{
    partial class ManageScoreForm
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
            this.cboxcourse = new System.Windows.Forms.ComboBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshowst = new System.Windows.Forms.Button();
            this.btnshowscore = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnavg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxcourse
            // 
            this.cboxcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxcourse.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxcourse.FormattingEnabled = true;
            this.cboxcourse.Location = new System.Drawing.Point(220, 122);
            this.cboxcourse.Name = "cboxcourse";
            this.cboxcourse.Size = new System.Drawing.Size(281, 33);
            this.cboxcourse.TabIndex = 10;
            // 
            // txtdes
            // 
            this.txtdes.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(220, 272);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(280, 125);
            this.txtdes.TabIndex = 7;
            // 
            // txtscore
            // 
            this.txtscore.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(221, 198);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(171, 33);
            this.txtscore.TabIndex = 8;
            // 
            // txtsid
            // 
            this.txtsid.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsid.Location = new System.Drawing.Point(220, 48);
            this.txtsid.Name = "txtsid";
            this.txtsid.ReadOnly = true;
            this.txtsid.Size = new System.Drawing.Size(172, 33);
            this.txtsid.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(62, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(113, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(591, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 492);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnshowst
            // 
            this.btnshowst.Location = new System.Drawing.Point(588, 37);
            this.btnshowst.Name = "btnshowst";
            this.btnshowst.Size = new System.Drawing.Size(334, 33);
            this.btnshowst.TabIndex = 12;
            this.btnshowst.Text = "Show Students";
            this.btnshowst.UseVisualStyleBackColor = true;
            this.btnshowst.Click += new System.EventHandler(this.btnshowst_Click);
            // 
            // btnshowscore
            // 
            this.btnshowscore.Location = new System.Drawing.Point(932, 37);
            this.btnshowscore.Name = "btnshowscore";
            this.btnshowscore.Size = new System.Drawing.Size(334, 33);
            this.btnshowscore.TabIndex = 12;
            this.btnshowscore.Text = "Show Scores";
            this.btnshowscore.UseVisualStyleBackColor = true;
            this.btnshowscore.Click += new System.EventHandler(this.btnshowscore_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Lime;
            this.btnadd.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(108, 440);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(168, 49);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Red;
            this.btnremove.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(306, 440);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(168, 49);
            this.btnremove.TabIndex = 13;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnavg
            // 
            this.btnavg.BackColor = System.Drawing.Color.DarkCyan;
            this.btnavg.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavg.Location = new System.Drawing.Point(55, 519);
            this.btnavg.Name = "btnavg";
            this.btnavg.Size = new System.Drawing.Size(480, 49);
            this.btnavg.TabIndex = 14;
            this.btnavg.Text = "Average Score By Course";
            this.btnavg.UseVisualStyleBackColor = false;
            this.btnavg.Click += new System.EventHandler(this.btnavg_Click);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1278, 627);
            this.Controls.Add(this.btnavg);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnshowscore);
            this.Controls.Add(this.btnshowst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboxcourse);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxcourse;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshowst;
        private System.Windows.Forms.Button btnshowscore;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnavg;
    }
}