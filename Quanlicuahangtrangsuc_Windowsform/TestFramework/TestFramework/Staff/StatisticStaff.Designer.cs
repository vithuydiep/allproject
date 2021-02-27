namespace TestFramework.Staff
{
    partial class StatisticStaff
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panTKNV = new System.Windows.Forms.Panel();
            this.panTotal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panNam = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panNu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timekeepingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panTKNV.SuspendLayout();
            this.panTotal.SuspendLayout();
            this.panNam.SuspendLayout();
            this.panNu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(620, 288);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Staff rate";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(585, 426);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // panTKNV
            // 
            this.panTKNV.Controls.Add(this.panTotal);
            this.panTKNV.Controls.Add(this.panNam);
            this.panTKNV.Controls.Add(this.panNu);
            this.panTKNV.Location = new System.Drawing.Point(17, 338);
            this.panTKNV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panTKNV.Name = "panTKNV";
            this.panTKNV.Size = new System.Drawing.Size(593, 321);
            this.panTKNV.TabIndex = 8;
            // 
            // panTotal
            // 
            this.panTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panTotal.Controls.Add(this.label2);
            this.panTotal.Location = new System.Drawing.Point(5, 5);
            this.panTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panTotal.Name = "panTotal";
            this.panTotal.Size = new System.Drawing.Size(580, 151);
            this.panTotal.TabIndex = 0;
            this.panTotal.MouseEnter += new System.EventHandler(this.panTotal_MouseEnter);
            this.panTotal.MouseLeave += new System.EventHandler(this.panTotal_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(153, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Staff: ";
            // 
            // panNam
            // 
            this.panNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panNam.Controls.Add(this.label3);
            this.panNam.Location = new System.Drawing.Point(5, 160);
            this.panNam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panNam.Name = "panNam";
            this.panNam.Size = new System.Drawing.Size(276, 151);
            this.panNam.TabIndex = 1;
            this.panNam.MouseEnter += new System.EventHandler(this.panNam_MouseEnter);
            this.panNam.MouseLeave += new System.EventHandler(this.panNam_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(43, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Male:";
            // 
            // panNu
            // 
            this.panNu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panNu.Controls.Add(this.label4);
            this.panNu.Location = new System.Drawing.Point(292, 160);
            this.panNu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panNu.Name = "panNu";
            this.panNu.Size = new System.Drawing.Size(293, 151);
            this.panNu.TabIndex = 2;
            this.panNu.MouseEnter += new System.EventHandler(this.panNu_MouseEnter);
            this.panNu.MouseLeave += new System.EventHandler(this.panNu_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(33, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Female:";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Blue;
            this.guna2PictureBox3.Image = global::TestFramework.Properties.Resources.pic7;
            this.guna2PictureBox3.Location = new System.Drawing.Point(4, 783);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(37, 38);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 40;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Azure;
            this.panel14.Controls.Add(this.guna2PictureBox1);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Controls.Add(this.menuStrip1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1292, 145);
            this.panel14.TabIndex = 57;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Blue;
            this.guna2PictureBox1.Image = global::TestFramework.Properties.Resources.PIC6;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1240, 4);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(37, 38);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 38;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click_1);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkCyan;
            this.panel15.Location = new System.Drawing.Point(1, 137);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1293, 1);
            this.panel15.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 104);
            this.label8.TabIndex = 0;
            this.label8.Text = "Jelwery";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.productToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 94);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(435, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.timekeepingToolStripMenuItem,
            this.salaryToolStripMenuItem,
            this.statisticToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 36);
            this.toolStripMenuItem1.Text = "Staff";
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.addStaffToolStripMenuItem.Text = "Add Staff";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.detailToolStripMenuItem.Text = "List Staff";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // timekeepingToolStripMenuItem
            // 
            this.timekeepingToolStripMenuItem.Name = "timekeepingToolStripMenuItem";
            this.timekeepingToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.timekeepingToolStripMenuItem.Text = "Timekeeping";
            this.timekeepingToolStripMenuItem.Click += new System.EventHandler(this.timekeepingToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.salaryToolStripMenuItem.Text = "Salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listProductsToolStripMenuItem,
            this.addProductToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.statisticToolStripMenuItem1});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // listProductsToolStripMenuItem
            // 
            this.listProductsToolStripMenuItem.Name = "listProductsToolStripMenuItem";
            this.listProductsToolStripMenuItem.Size = new System.Drawing.Size(272, 36);
            this.listProductsToolStripMenuItem.Text = "Manage Product";
            this.listProductsToolStripMenuItem.Click += new System.EventHandler(this.listProductsToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(272, 36);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(272, 36);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem1
            // 
            this.statisticToolStripMenuItem1.Name = "statisticToolStripMenuItem1";
            this.statisticToolStripMenuItem1.Size = new System.Drawing.Size(272, 36);
            this.statisticToolStripMenuItem1.Text = "Statistic";
            this.statisticToolStripMenuItem1.Click += new System.EventHandler(this.statisticToolStripMenuItem1_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.manageOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // manageOrderToolStripMenuItem
            // 
            this.manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
            this.manageOrderToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.manageOrderToolStripMenuItem.Text = "Manage Order";
            this.manageOrderToolStripMenuItem.Click += new System.EventHandler(this.manageOrderToolStripMenuItem_Click);
            // 
            // StatisticStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 825);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.panTKNV);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StatisticStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticStaff";
            this.Load += new System.EventHandler(this.StatisticStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panTKNV.ResumeLayout(false);
            this.panTotal.ResumeLayout(false);
            this.panTotal.PerformLayout();
            this.panNam.ResumeLayout(false);
            this.panNam.PerformLayout();
            this.panNu.ResumeLayout(false);
            this.panNu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panTKNV;
        private System.Windows.Forms.Panel panTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panNu;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Panel panel14;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timekeepingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrderToolStripMenuItem;
    }
}