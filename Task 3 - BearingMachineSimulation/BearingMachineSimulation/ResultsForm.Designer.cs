namespace BearingMachineSimulation
{
    partial class ResultsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CS_data = new System.Windows.Forms.DataGridView();
            this.BH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PS_view = new System.Windows.Forms.TreeView();
            this.CS_group = new System.Windows.Forms.GroupBox();
            this.CS_TC_label = new System.Windows.Forms.Label();
            this.CS_DC_label = new System.Windows.Forms.Label();
            this.CS_DTC_label = new System.Windows.Forms.Label();
            this.CS_RPC_label = new System.Windows.Forms.Label();
            this.CS_BC_label = new System.Windows.Forms.Label();
            this.CS_BC_numeric = new System.Windows.Forms.NumericUpDown();
            this.CS_DTC_numeric = new System.Windows.Forms.NumericUpDown();
            this.CS_DC_numeric = new System.Windows.Forms.NumericUpDown();
            this.CS_RPC_numeric = new System.Windows.Forms.NumericUpDown();
            this.CS_TC_numeric = new System.Windows.Forms.NumericUpDown();
            this.PS_group = new System.Windows.Forms.GroupBox();
            this.PS_TC_numeric = new System.Windows.Forms.NumericUpDown();
            this.PS_RPC_numeric = new System.Windows.Forms.NumericUpDown();
            this.PS_DC_numeric = new System.Windows.Forms.NumericUpDown();
            this.PS_BC_numeric = new System.Windows.Forms.NumericUpDown();
            this.PS_DTC_numeric = new System.Windows.Forms.NumericUpDown();
            this.PS_TC_label = new System.Windows.Forms.Label();
            this.PS_DC_label = new System.Windows.Forms.Label();
            this.PS_DTC_label = new System.Windows.Forms.Label();
            this.PS_RPC_label = new System.Windows.Forms.Label();
            this.PS_BC_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CS_data)).BeginInit();
            this.CS_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CS_BC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_DTC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_DC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_RPC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_TC_numeric)).BeginInit();
            this.PS_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PS_TC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_RPC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_DC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_BC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_DTC_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PS_group, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CS_data, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PS_view, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CS_group, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.64726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.35275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CS_data
            // 
            this.CS_data.AllowUserToAddRows = false;
            this.CS_data.AllowUserToDeleteRows = false;
            this.CS_data.AllowUserToOrderColumns = true;
            this.CS_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CS_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BH,
            this.BRH,
            this.BHrs,
            this.AH,
            this.RD,
            this.D});
            this.CS_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CS_data.Location = new System.Drawing.Point(3, 75);
            this.CS_data.Name = "CS_data";
            this.CS_data.ReadOnly = true;
            this.CS_data.Size = new System.Drawing.Size(457, 546);
            this.CS_data.TabIndex = 2;
            // 
            // BH
            // 
            this.BH.Frozen = true;
            this.BH.HeaderText = "Bearing Index";
            this.BH.Name = "BH";
            this.BH.ReadOnly = true;
            // 
            // BRH
            // 
            this.BRH.HeaderText = "Bearing Random Hours";
            this.BRH.Name = "BRH";
            this.BRH.ReadOnly = true;
            // 
            // BHrs
            // 
            this.BHrs.HeaderText = "Bearing Hours";
            this.BHrs.Name = "BHrs";
            this.BHrs.ReadOnly = true;
            // 
            // AH
            // 
            this.AH.HeaderText = "Accumulated Hours";
            this.AH.Name = "AH";
            this.AH.ReadOnly = true;
            // 
            // RD
            // 
            this.RD.HeaderText = "RandomDelay";
            this.RD.Name = "RD";
            this.RD.ReadOnly = true;
            // 
            // D
            // 
            this.D.HeaderText = "Delay";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // PS_view
            // 
            this.PS_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PS_view.Location = new System.Drawing.Point(466, 75);
            this.PS_view.Name = "PS_view";
            this.PS_view.Size = new System.Drawing.Size(458, 546);
            this.PS_view.TabIndex = 3;
            // 
            // CS_group
            // 
            this.CS_group.Controls.Add(this.CS_TC_numeric);
            this.CS_group.Controls.Add(this.CS_RPC_numeric);
            this.CS_group.Controls.Add(this.CS_DC_numeric);
            this.CS_group.Controls.Add(this.CS_BC_numeric);
            this.CS_group.Controls.Add(this.CS_DTC_numeric);
            this.CS_group.Controls.Add(this.CS_TC_label);
            this.CS_group.Controls.Add(this.CS_DC_label);
            this.CS_group.Controls.Add(this.CS_DTC_label);
            this.CS_group.Controls.Add(this.CS_RPC_label);
            this.CS_group.Controls.Add(this.CS_BC_label);
            this.CS_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CS_group.Location = new System.Drawing.Point(3, 3);
            this.CS_group.Name = "CS_group";
            this.CS_group.Size = new System.Drawing.Size(457, 66);
            this.CS_group.TabIndex = 4;
            this.CS_group.TabStop = false;
            this.CS_group.Text = "Current System";
            // 
            // CS_TC_label
            // 
            this.CS_TC_label.AutoSize = true;
            this.CS_TC_label.Location = new System.Drawing.Point(321, 26);
            this.CS_TC_label.Name = "CS_TC_label";
            this.CS_TC_label.Size = new System.Drawing.Size(55, 13);
            this.CS_TC_label.TabIndex = 4;
            this.CS_TC_label.Text = "Total Cost";
            // 
            // CS_DC_label
            // 
            this.CS_DC_label.AutoSize = true;
            this.CS_DC_label.Location = new System.Drawing.Point(3, 35);
            this.CS_DC_label.Name = "CS_DC_label";
            this.CS_DC_label.Size = new System.Drawing.Size(58, 13);
            this.CS_DC_label.TabIndex = 3;
            this.CS_DC_label.Text = "Delay Cost";
            // 
            // CS_DTC_label
            // 
            this.CS_DTC_label.AutoSize = true;
            this.CS_DTC_label.Location = new System.Drawing.Point(164, 16);
            this.CS_DTC_label.Name = "CS_DTC_label";
            this.CS_DTC_label.Size = new System.Drawing.Size(78, 13);
            this.CS_DTC_label.TabIndex = 2;
            this.CS_DTC_label.Text = "Downtime Cost";
            // 
            // CS_RPC_label
            // 
            this.CS_RPC_label.AutoSize = true;
            this.CS_RPC_label.Location = new System.Drawing.Point(164, 35);
            this.CS_RPC_label.Name = "CS_RPC_label";
            this.CS_RPC_label.Size = new System.Drawing.Size(98, 13);
            this.CS_RPC_label.TabIndex = 1;
            this.CS_RPC_label.Text = "Repair Person Cost";
            // 
            // CS_BC_label
            // 
            this.CS_BC_label.AutoSize = true;
            this.CS_BC_label.Location = new System.Drawing.Point(3, 16);
            this.CS_BC_label.Name = "CS_BC_label";
            this.CS_BC_label.Size = new System.Drawing.Size(67, 13);
            this.CS_BC_label.TabIndex = 0;
            this.CS_BC_label.Text = "Bearing Cost";
            // 
            // CS_BC_numeric
            // 
            this.CS_BC_numeric.Enabled = false;
            this.CS_BC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CS_BC_numeric.Location = new System.Drawing.Point(76, 14);
            this.CS_BC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CS_BC_numeric.Name = "CS_BC_numeric";
            this.CS_BC_numeric.Size = new System.Drawing.Size(45, 20);
            this.CS_BC_numeric.TabIndex = 1;
            // 
            // CS_DTC_numeric
            // 
            this.CS_DTC_numeric.Enabled = false;
            this.CS_DTC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CS_DTC_numeric.Location = new System.Drawing.Point(270, 14);
            this.CS_DTC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CS_DTC_numeric.Name = "CS_DTC_numeric";
            this.CS_DTC_numeric.Size = new System.Drawing.Size(45, 20);
            this.CS_DTC_numeric.TabIndex = 5;
            // 
            // CS_DC_numeric
            // 
            this.CS_DC_numeric.Enabled = false;
            this.CS_DC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CS_DC_numeric.Location = new System.Drawing.Point(76, 33);
            this.CS_DC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CS_DC_numeric.Name = "CS_DC_numeric";
            this.CS_DC_numeric.Size = new System.Drawing.Size(45, 20);
            this.CS_DC_numeric.TabIndex = 6;
            // 
            // CS_RPC_numeric
            // 
            this.CS_RPC_numeric.Enabled = false;
            this.CS_RPC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CS_RPC_numeric.Location = new System.Drawing.Point(270, 33);
            this.CS_RPC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CS_RPC_numeric.Name = "CS_RPC_numeric";
            this.CS_RPC_numeric.Size = new System.Drawing.Size(45, 20);
            this.CS_RPC_numeric.TabIndex = 7;
            // 
            // CS_TC_numeric
            // 
            this.CS_TC_numeric.Enabled = false;
            this.CS_TC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CS_TC_numeric.Location = new System.Drawing.Point(382, 24);
            this.CS_TC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CS_TC_numeric.Name = "CS_TC_numeric";
            this.CS_TC_numeric.Size = new System.Drawing.Size(45, 20);
            this.CS_TC_numeric.TabIndex = 8;
            // 
            // PS_group
            // 
            this.PS_group.Controls.Add(this.PS_TC_numeric);
            this.PS_group.Controls.Add(this.PS_RPC_numeric);
            this.PS_group.Controls.Add(this.PS_DC_numeric);
            this.PS_group.Controls.Add(this.PS_BC_numeric);
            this.PS_group.Controls.Add(this.PS_DTC_numeric);
            this.PS_group.Controls.Add(this.PS_TC_label);
            this.PS_group.Controls.Add(this.PS_DC_label);
            this.PS_group.Controls.Add(this.PS_DTC_label);
            this.PS_group.Controls.Add(this.PS_RPC_label);
            this.PS_group.Controls.Add(this.PS_BC_label);
            this.PS_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PS_group.Location = new System.Drawing.Point(466, 3);
            this.PS_group.Name = "PS_group";
            this.PS_group.Size = new System.Drawing.Size(458, 66);
            this.PS_group.TabIndex = 1;
            this.PS_group.TabStop = false;
            this.PS_group.Text = "Proposed System";
            // 
            // PS_TC_numeric
            // 
            this.PS_TC_numeric.Enabled = false;
            this.PS_TC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PS_TC_numeric.Location = new System.Drawing.Point(399, 24);
            this.PS_TC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PS_TC_numeric.Name = "PS_TC_numeric";
            this.PS_TC_numeric.Size = new System.Drawing.Size(45, 20);
            this.PS_TC_numeric.TabIndex = 18;
            // 
            // PS_RPC_numeric
            // 
            this.PS_RPC_numeric.Enabled = false;
            this.PS_RPC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PS_RPC_numeric.Location = new System.Drawing.Point(287, 33);
            this.PS_RPC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PS_RPC_numeric.Name = "PS_RPC_numeric";
            this.PS_RPC_numeric.Size = new System.Drawing.Size(45, 20);
            this.PS_RPC_numeric.TabIndex = 17;
            // 
            // PS_DC_numeric
            // 
            this.PS_DC_numeric.Enabled = false;
            this.PS_DC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PS_DC_numeric.Location = new System.Drawing.Point(93, 33);
            this.PS_DC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PS_DC_numeric.Name = "PS_DC_numeric";
            this.PS_DC_numeric.Size = new System.Drawing.Size(45, 20);
            this.PS_DC_numeric.TabIndex = 16;
            // 
            // PS_BC_numeric
            // 
            this.PS_BC_numeric.Enabled = false;
            this.PS_BC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PS_BC_numeric.Location = new System.Drawing.Point(93, 14);
            this.PS_BC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PS_BC_numeric.Name = "PS_BC_numeric";
            this.PS_BC_numeric.Size = new System.Drawing.Size(45, 20);
            this.PS_BC_numeric.TabIndex = 10;
            // 
            // PS_DTC_numeric
            // 
            this.PS_DTC_numeric.Enabled = false;
            this.PS_DTC_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PS_DTC_numeric.Location = new System.Drawing.Point(287, 14);
            this.PS_DTC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PS_DTC_numeric.Name = "PS_DTC_numeric";
            this.PS_DTC_numeric.Size = new System.Drawing.Size(45, 20);
            this.PS_DTC_numeric.TabIndex = 15;
            // 
            // PS_TC_label
            // 
            this.PS_TC_label.AutoSize = true;
            this.PS_TC_label.Location = new System.Drawing.Point(338, 26);
            this.PS_TC_label.Name = "PS_TC_label";
            this.PS_TC_label.Size = new System.Drawing.Size(55, 13);
            this.PS_TC_label.TabIndex = 14;
            this.PS_TC_label.Text = "Total Cost";
            // 
            // PS_DC_label
            // 
            this.PS_DC_label.AutoSize = true;
            this.PS_DC_label.Location = new System.Drawing.Point(20, 35);
            this.PS_DC_label.Name = "PS_DC_label";
            this.PS_DC_label.Size = new System.Drawing.Size(58, 13);
            this.PS_DC_label.TabIndex = 13;
            this.PS_DC_label.Text = "Delay Cost";
            // 
            // PS_DTC_label
            // 
            this.PS_DTC_label.AutoSize = true;
            this.PS_DTC_label.Location = new System.Drawing.Point(181, 16);
            this.PS_DTC_label.Name = "PS_DTC_label";
            this.PS_DTC_label.Size = new System.Drawing.Size(78, 13);
            this.PS_DTC_label.TabIndex = 12;
            this.PS_DTC_label.Text = "Downtime Cost";
            // 
            // PS_RPC_label
            // 
            this.PS_RPC_label.AutoSize = true;
            this.PS_RPC_label.Location = new System.Drawing.Point(181, 35);
            this.PS_RPC_label.Name = "PS_RPC_label";
            this.PS_RPC_label.Size = new System.Drawing.Size(98, 13);
            this.PS_RPC_label.TabIndex = 11;
            this.PS_RPC_label.Text = "Repair Person Cost";
            // 
            // PS_BC_label
            // 
            this.PS_BC_label.AutoSize = true;
            this.PS_BC_label.Location = new System.Drawing.Point(20, 16);
            this.PS_BC_label.Name = "PS_BC_label";
            this.PS_BC_label.Size = new System.Drawing.Size(67, 13);
            this.PS_BC_label.TabIndex = 9;
            this.PS_BC_label.Text = "Bearing Cost";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 624);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ResultsForm";
            this.Text = "Results Form";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CS_data)).EndInit();
            this.CS_group.ResumeLayout(false);
            this.CS_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CS_BC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_DTC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_DC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_RPC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CS_TC_numeric)).EndInit();
            this.PS_group.ResumeLayout(false);
            this.PS_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PS_TC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_RPC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_DC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_BC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_DTC_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView CS_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn BH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn AH;
        private System.Windows.Forms.DataGridViewTextBoxColumn RD;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.TreeView PS_view;
        private System.Windows.Forms.GroupBox CS_group;
        private System.Windows.Forms.Label CS_BC_label;
        private System.Windows.Forms.Label CS_TC_label;
        private System.Windows.Forms.Label CS_DC_label;
        private System.Windows.Forms.Label CS_DTC_label;
        private System.Windows.Forms.Label CS_RPC_label;
        private System.Windows.Forms.NumericUpDown CS_TC_numeric;
        private System.Windows.Forms.NumericUpDown CS_RPC_numeric;
        private System.Windows.Forms.NumericUpDown CS_DC_numeric;
        private System.Windows.Forms.NumericUpDown CS_BC_numeric;
        private System.Windows.Forms.NumericUpDown CS_DTC_numeric;
        private System.Windows.Forms.GroupBox PS_group;
        private System.Windows.Forms.NumericUpDown PS_TC_numeric;
        private System.Windows.Forms.NumericUpDown PS_RPC_numeric;
        private System.Windows.Forms.NumericUpDown PS_DC_numeric;
        private System.Windows.Forms.NumericUpDown PS_BC_numeric;
        private System.Windows.Forms.NumericUpDown PS_DTC_numeric;
        private System.Windows.Forms.Label PS_TC_label;
        private System.Windows.Forms.Label PS_DC_label;
        private System.Windows.Forms.Label PS_DTC_label;
        private System.Windows.Forms.Label PS_RPC_label;
        private System.Windows.Forms.Label PS_BC_label;
    }
}