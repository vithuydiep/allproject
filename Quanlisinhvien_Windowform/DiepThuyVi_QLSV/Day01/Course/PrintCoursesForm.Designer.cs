namespace Day01.COURSE
{
    partial class PrintCoursesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnfile = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btntext = new System.Windows.Forms.Button();
            this.loginDBDataSet5 = new Day01.LoginDBDataSet5();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Day01.LoginDBDataSet5TableAdapters.courseTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.courseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            // 
            // btnfile
            // 
            this.btnfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfile.Location = new System.Drawing.Point(170, 507);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(152, 48);
            this.btnfile.TabIndex = 1;
            this.btnfile.Text = "To Excel";
            this.btnfile.UseVisualStyleBackColor = false;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnprint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(328, 507);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(152, 48);
            this.btnprint.TabIndex = 1;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btntext
            // 
            this.btntext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btntext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntext.Location = new System.Drawing.Point(12, 507);
            this.btntext.Name = "btntext";
            this.btntext.Size = new System.Drawing.Size(152, 48);
            this.btntext.TabIndex = 1;
            this.btntext.Text = "To File Text";
            this.btntext.UseVisualStyleBackColor = false;
            this.btntext.Click += new System.EventHandler(this.btntext_Click);
            // 
            // loginDBDataSet5
            // 
            this.loginDBDataSet5.DataSetName = "LoginDBDataSet5";
            this.loginDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "course";
            this.courseBindingSource1.DataSource = this.loginDBDataSet5;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "label";
            this.dataGridViewTextBoxColumn2.HeaderText = "label";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "period";
            this.dataGridViewTextBoxColumn3.HeaderText = "period";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // PrintCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(937, 567);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btntext);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintCoursesForm";
            this.Text = "PrintCoursesForm";
            this.Load += new System.EventHandler(this.PrintCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btntext;
        
        private System.Windows.Forms.BindingSource courseBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private LoginDBDataSet5 loginDBDataSet5;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private LoginDBDataSet5TableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}