namespace Day01
{
    partial class StacticsForm
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
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.pnlMale = new System.Windows.Forms.Panel();
            this.lblmale = new System.Windows.Forms.Label();
            this.pnlFemale = new System.Windows.Forms.Panel();
            this.lblfemale = new System.Windows.Forms.Label();
            this.pnlTotal.SuspendLayout();
            this.pnlMale.SuspendLayout();
            this.pnlFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTotal.Controls.Add(this.lbltotal);
            this.pnlTotal.Location = new System.Drawing.Point(-2, 0);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(457, 157);
            this.pnlTotal.TabIndex = 0;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(3, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(454, 157);
            this.lbltotal.TabIndex = 0;
            this.lbltotal.Text = "Total Students: 100%";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltotal.MouseEnter += new System.EventHandler(this.lbltotal_MouseEnter);
            this.lbltotal.MouseLeave += new System.EventHandler(this.lbltotal_MouseLeave);
            // 
            // pnlMale
            // 
            this.pnlMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlMale.Controls.Add(this.lblmale);
            this.pnlMale.Location = new System.Drawing.Point(-2, 161);
            this.pnlMale.Name = "pnlMale";
            this.pnlMale.Size = new System.Drawing.Size(229, 184);
            this.pnlMale.TabIndex = 1;
            // 
            // lblmale
            // 
            this.lblmale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmale.Location = new System.Drawing.Point(0, 0);
            this.lblmale.Name = "lblmale";
            this.lblmale.Size = new System.Drawing.Size(229, 184);
            this.lblmale.TabIndex = 0;
            this.lblmale.Text = "Male: 50%";
            this.lblmale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmale.MouseEnter += new System.EventHandler(this.lblmale_MouseEnter_1);
            this.lblmale.MouseLeave += new System.EventHandler(this.lblmale_MouseLeave_1);
            // 
            // pnlFemale
            // 
            this.pnlFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlFemale.Controls.Add(this.lblfemale);
            this.pnlFemale.Location = new System.Drawing.Point(233, 161);
            this.pnlFemale.Name = "pnlFemale";
            this.pnlFemale.Size = new System.Drawing.Size(222, 184);
            this.pnlFemale.TabIndex = 2;
            // 
            // lblfemale
            // 
            this.lblfemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfemale.Location = new System.Drawing.Point(0, 0);
            this.lblfemale.Name = "lblfemale";
            this.lblfemale.Size = new System.Drawing.Size(222, 184);
            this.lblfemale.TabIndex = 0;
            this.lblfemale.Text = "Female: 50%";
            this.lblfemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblfemale.MouseEnter += new System.EventHandler(this.lblfemale_MouseEnter);
            this.lblfemale.MouseLeave += new System.EventHandler(this.lblfemale_MouseLeave);
            // 
            // StacticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 347);
            this.Controls.Add(this.pnlFemale);
            this.Controls.Add(this.pnlMale);
            this.Controls.Add(this.pnlTotal);
            this.Name = "StacticsForm";
            this.Text = "StacticsForm";
            this.Load += new System.EventHandler(this.StacticsForm_Load);
            this.pnlTotal.ResumeLayout(false);
            this.pnlMale.ResumeLayout(false);
            this.pnlFemale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Panel pnlMale;
        private System.Windows.Forms.Label lblmale;
        private System.Windows.Forms.Panel pnlFemale;
        private System.Windows.Forms.Label lblfemale;
    }
}