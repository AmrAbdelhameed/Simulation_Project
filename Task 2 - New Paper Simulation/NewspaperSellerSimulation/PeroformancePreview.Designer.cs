namespace NewspaperSellerSimulation
{
    partial class PeroformancePreview
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
            this.PerformanceGrid = new System.Windows.Forms.DataGridView();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PerformanceGrid
            // 
            this.PerformanceGrid.BackgroundColor = System.Drawing.Color.White;
            this.PerformanceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PerformanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property,
            this.Value});
            this.PerformanceGrid.Location = new System.Drawing.Point(11, 12);
            this.PerformanceGrid.MultiSelect = false;
            this.PerformanceGrid.Name = "PerformanceGrid";
            this.PerformanceGrid.ReadOnly = true;
            this.PerformanceGrid.RowHeadersVisible = false;
            this.PerformanceGrid.Size = new System.Drawing.Size(304, 334);
            this.PerformanceGrid.TabIndex = 0;
            // 
            // Property
            // 
            this.Property.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Property.HeaderText = "";
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            this.Property.Width = 21;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 21);
            this.panel1.TabIndex = 1;
            // 
            // PeroformancePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PerformanceGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PeroformancePreview";
            this.Text = "Peroformance Measures Preview";
            this.Load += new System.EventHandler(this.PeroformancePreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PerformanceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Panel panel1;
    }
}