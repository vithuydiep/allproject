namespace TestFramework.Staff
{
    partial class ManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridNhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btadd = new Guna.UI2.WinForms.Guna2Button();
            this.btrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btexport = new Guna.UI2.WinForms.Guna2Button();
            this.btsearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.diamondGroupDataSet5 = new TestFramework.DiamondGroupDataSet5();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new TestFramework.DiamondGroupDataSet5TableAdapters.StaffTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diamondGroupDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridNhanvien
            // 
            this.gridNhanvien.AllowUserToAddRows = false;
            this.gridNhanvien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridNhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridNhanvien.AutoGenerateColumns = false;
            this.gridNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNhanvien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridNhanvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridNhanvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridNhanvien.ColumnHeadersHeight = 30;
            this.gridNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn,
            this.idposDataGridViewTextBoxColumn});
            this.gridNhanvien.DataSource = this.staffBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridNhanvien.EnableHeadersVisualStyles = false;
            this.gridNhanvien.GridColor = System.Drawing.Color.Blue;
            this.gridNhanvien.Location = new System.Drawing.Point(29, 240);
            this.gridNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.gridNhanvien.Name = "gridNhanvien";
            this.gridNhanvien.ReadOnly = true;
            this.gridNhanvien.RowHeadersVisible = false;
            this.gridNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNhanvien.Size = new System.Drawing.Size(1240, 537);
            this.gridNhanvien.TabIndex = 1;
            this.gridNhanvien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridNhanvien.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.gridNhanvien.ThemeStyle.GridColor = System.Drawing.Color.Blue;
            this.gridNhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridNhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridNhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridNhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridNhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridNhanvien.ThemeStyle.HeaderStyle.Height = 30;
            this.gridNhanvien.ThemeStyle.ReadOnly = true;
            this.gridNhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridNhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridNhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridNhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridNhanvien.ThemeStyle.RowsStyle.Height = 22;
            this.gridNhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridNhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNhanvien_CellContentClick);
            // 
            // btadd
            // 
            this.btadd.BorderColor = System.Drawing.Color.DarkCyan;
            this.btadd.BorderThickness = 2;
            this.btadd.CheckedState.Parent = this.btadd;
            this.btadd.CustomImages.Parent = this.btadd;
            this.btadd.FillColor = System.Drawing.Color.Aquamarine;
            this.btadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.DimGray;
            this.btadd.HoverState.Parent = this.btadd;
            this.btadd.Location = new System.Drawing.Point(40, 20);
            this.btadd.Margin = new System.Windows.Forms.Padding(4);
            this.btadd.Name = "btadd";
            this.btadd.ShadowDecoration.Parent = this.btadd;
            this.btadd.Size = new System.Drawing.Size(195, 48);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "ADD";
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btrefresh.BorderThickness = 2;
            this.btrefresh.CheckedState.Parent = this.btrefresh;
            this.btrefresh.CustomImages.Parent = this.btrefresh;
            this.btrefresh.FillColor = System.Drawing.Color.PaleTurquoise;
            this.btrefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefresh.ForeColor = System.Drawing.Color.DimGray;
            this.btrefresh.HoverState.Parent = this.btrefresh;
            this.btrefresh.Location = new System.Drawing.Point(256, 20);
            this.btrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.ShadowDecoration.Parent = this.btrefresh;
            this.btrefresh.Size = new System.Drawing.Size(195, 48);
            this.btrefresh.TabIndex = 3;
            this.btrefresh.Text = "REFRESH";
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btexport
            // 
            this.btexport.BorderColor = System.Drawing.Color.Olive;
            this.btexport.BorderThickness = 2;
            this.btexport.CheckedState.Parent = this.btexport;
            this.btexport.CustomImages.Parent = this.btexport;
            this.btexport.FillColor = System.Drawing.Color.Gold;
            this.btexport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexport.ForeColor = System.Drawing.Color.DimGray;
            this.btexport.HoverState.Parent = this.btexport;
            this.btexport.Location = new System.Drawing.Point(475, 20);
            this.btexport.Margin = new System.Windows.Forms.Padding(4);
            this.btexport.Name = "btexport";
            this.btexport.ShadowDecoration.Parent = this.btexport;
            this.btexport.Size = new System.Drawing.Size(195, 48);
            this.btexport.TabIndex = 4;
            this.btexport.Text = "EXPORT";
            this.btexport.Click += new System.EventHandler(this.btexport_Click);
            // 
            // btsearch
            // 
            this.btsearch.CheckedState.Parent = this.btsearch;
            this.btsearch.CustomImages.Parent = this.btsearch;
            this.btsearch.FillColor = System.Drawing.Color.DarkGray;
            this.btsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btsearch.ForeColor = System.Drawing.Color.White;
            this.btsearch.HoverState.Parent = this.btsearch;
            this.btsearch.Location = new System.Drawing.Point(1073, 20);
            this.btsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btsearch.Name = "btsearch";
            this.btsearch.ShadowDecoration.Parent = this.btsearch;
            this.btsearch.Size = new System.Drawing.Size(195, 48);
            this.btsearch.TabIndex = 5;
            this.btsearch.Text = "SEARCH";
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsearch.DefaultText = "is, name, phone";
            this.tbsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbsearch.DisabledState.Parent = this.tbsearch;
            this.tbsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbsearch.FocusedState.Parent = this.tbsearch;
            this.tbsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbsearch.HoverState.Parent = this.tbsearch;
            this.tbsearch.Location = new System.Drawing.Point(705, 20);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(5);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.PasswordChar = '\0';
            this.tbsearch.PlaceholderText = "";
            this.tbsearch.SelectedText = "";
            this.tbsearch.SelectionStart = 15;
            this.tbsearch.ShadowDecoration.Parent = this.tbsearch;
            this.tbsearch.Size = new System.Drawing.Size(360, 44);
            this.tbsearch.TabIndex = 6;
            this.tbsearch.Enter += new System.EventHandler(this.tbsearch_Enter);
            this.tbsearch.Leave += new System.EventHandler(this.tbsearch_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tbsearch);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.btsearch);
            this.panel1.Controls.Add(this.btrefresh);
            this.panel1.Controls.Add(this.btexport);
            this.panel1.Location = new System.Drawing.Point(1, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 89);
            this.panel1.TabIndex = 0;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Blue;
            this.guna2PictureBox3.Image = global::TestFramework.Properties.Resources.pic7;
            this.guna2PictureBox3.Location = new System.Drawing.Point(1, 784);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1292, 145);
            this.panel14.TabIndex = 56;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Blue;
            this.guna2PictureBox1.Image = global::TestFramework.Properties.Resources.PIC6;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1240, 4);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.menuStrip1.Size = new System.Drawing.Size(285, 40);
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
            // diamondGroupDataSet5
            // 
            this.diamondGroupDataSet5.DataSetName = "DiamondGroupDataSet5";
            this.diamondGroupDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.diamondGroupDataSet5;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "addr";
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            this.addrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idposDataGridViewTextBoxColumn
            // 
            this.idposDataGridViewTextBoxColumn.DataPropertyName = "idpos";
            this.idposDataGridViewTextBoxColumn.HeaderText = "idpos";
            this.idposDataGridViewTextBoxColumn.Name = "idposDataGridViewTextBoxColumn";
            this.idposDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 825);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.gridNhanvien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diamondGroupDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView gridNhanvien;
        private Guna.UI2.WinForms.Guna2Button btadd;
        private Guna.UI2.WinForms.Guna2Button btrefresh;
        private Guna.UI2.WinForms.Guna2Button btexport;
        private Guna.UI2.WinForms.Guna2Button btsearch;
        private Guna.UI2.WinForms.Guna2TextBox tbsearch;
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
        private DiamondGroupDataSet5 diamondGroupDataSet5;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DiamondGroupDataSet5TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idposDataGridViewTextBoxColumn;
    }
}