namespace BearingMachineSimulation
{
    partial class MainForm
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
            this.DTD_textbox = new System.Windows.Forms.TextBox();
            this.BLD_textbox = new System.Windows.Forms.TextBox();
            this.Simulate = new System.Windows.Forms.Button();
            this.DC_numeric = new System.Windows.Forms.NumericUpDown();
            this.DTD_label = new System.Windows.Forms.Label();
            this.BLD_label = new System.Windows.Forms.Label();
            this.DC_label = new System.Windows.Forms.Label();
            this.RPC_label = new System.Windows.Forms.Label();
            this.RPC_numeric = new System.Windows.Forms.NumericUpDown();
            this.NH_label = new System.Windows.Forms.Label();
            this.NH_numeric = new System.Windows.Forms.NumericUpDown();
            this.BC_label = new System.Windows.Forms.Label();
            this.BC_numeric = new System.Windows.Forms.NumericUpDown();
            this.RT1B_label = new System.Windows.Forms.Label();
            this.RT1B_numeric = new System.Windows.Forms.NumericUpDown();
            this.NB_label = new System.Windows.Forms.Label();
            this.NB_numeric = new System.Windows.Forms.NumericUpDown();
            this.RTAB_label = new System.Windows.Forms.Label();
            this.RTAB_numeric = new System.Windows.Forms.NumericUpDown();
            this.TCN_label = new System.Windows.Forms.Label();
            this.TC_list = new System.Windows.Forms.ComboBox();
            this.TCN_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NH_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RT1B_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NB_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTAB_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DTD_textbox
            // 
            this.DTD_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTD_textbox.Location = new System.Drawing.Point(391, 44);
            this.DTD_textbox.Multiline = true;
            this.DTD_textbox.Name = "DTD_textbox";
            this.DTD_textbox.Size = new System.Drawing.Size(202, 145);
            this.DTD_textbox.TabIndex = 7;
            // 
            // BLD_textbox
            // 
            this.BLD_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BLD_textbox.Location = new System.Drawing.Point(391, 222);
            this.BLD_textbox.Multiline = true;
            this.BLD_textbox.Name = "BLD_textbox";
            this.BLD_textbox.Size = new System.Drawing.Size(202, 151);
            this.BLD_textbox.TabIndex = 8;
            // 
            // Simulate
            // 
            this.Simulate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Simulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Simulate.Location = new System.Drawing.Point(152, 458);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(276, 70);
            this.Simulate.TabIndex = 9;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // DC_numeric
            // 
            this.DC_numeric.Location = new System.Drawing.Point(12, 45);
            this.DC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.DC_numeric.Name = "DC_numeric";
            this.DC_numeric.Size = new System.Drawing.Size(120, 20);
            this.DC_numeric.TabIndex = 10;
            // 
            // DTD_label
            // 
            this.DTD_label.AutoSize = true;
            this.DTD_label.Location = new System.Drawing.Point(388, 18);
            this.DTD_label.Name = "DTD_label";
            this.DTD_label.Size = new System.Drawing.Size(115, 13);
            this.DTD_label.TabIndex = 11;
            this.DTD_label.Text = "Delay Time Distribution";
            // 
            // BLD_label
            // 
            this.BLD_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BLD_label.AutoSize = true;
            this.BLD_label.Location = new System.Drawing.Point(388, 202);
            this.BLD_label.Name = "BLD_label";
            this.BLD_label.Size = new System.Drawing.Size(118, 13);
            this.BLD_label.TabIndex = 12;
            this.BLD_label.Text = "Bearing Life Distribution";
            // 
            // DC_label
            // 
            this.DC_label.AutoSize = true;
            this.DC_label.Location = new System.Drawing.Point(9, 18);
            this.DC_label.Name = "DC_label";
            this.DC_label.Size = new System.Drawing.Size(78, 13);
            this.DC_label.TabIndex = 13;
            this.DC_label.Text = "Downtime Cost";
            // 
            // RPC_label
            // 
            this.RPC_label.AutoSize = true;
            this.RPC_label.Location = new System.Drawing.Point(9, 78);
            this.RPC_label.Name = "RPC_label";
            this.RPC_label.Size = new System.Drawing.Size(98, 13);
            this.RPC_label.TabIndex = 15;
            this.RPC_label.Text = "Repair Person Cost";
            // 
            // RPC_numeric
            // 
            this.RPC_numeric.Location = new System.Drawing.Point(12, 105);
            this.RPC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.RPC_numeric.Name = "RPC_numeric";
            this.RPC_numeric.Size = new System.Drawing.Size(120, 20);
            this.RPC_numeric.TabIndex = 14;
            // 
            // NH_label
            // 
            this.NH_label.AutoSize = true;
            this.NH_label.Location = new System.Drawing.Point(9, 202);
            this.NH_label.Name = "NH_label";
            this.NH_label.Size = new System.Drawing.Size(89, 13);
            this.NH_label.TabIndex = 19;
            this.NH_label.Text = "Number Of Hours";
            // 
            // NH_numeric
            // 
            this.NH_numeric.Location = new System.Drawing.Point(12, 229);
            this.NH_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NH_numeric.Name = "NH_numeric";
            this.NH_numeric.Size = new System.Drawing.Size(120, 20);
            this.NH_numeric.TabIndex = 18;
            // 
            // BC_label
            // 
            this.BC_label.AutoSize = true;
            this.BC_label.Location = new System.Drawing.Point(9, 142);
            this.BC_label.Name = "BC_label";
            this.BC_label.Size = new System.Drawing.Size(67, 13);
            this.BC_label.TabIndex = 17;
            this.BC_label.Text = "Bearing Cost";
            // 
            // BC_numeric
            // 
            this.BC_numeric.Location = new System.Drawing.Point(12, 169);
            this.BC_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.BC_numeric.Name = "BC_numeric";
            this.BC_numeric.Size = new System.Drawing.Size(120, 20);
            this.BC_numeric.TabIndex = 16;
            // 
            // RT1B_label
            // 
            this.RT1B_label.AutoSize = true;
            this.RT1B_label.Location = new System.Drawing.Point(9, 326);
            this.RT1B_label.Name = "RT1B_label";
            this.RT1B_label.Size = new System.Drawing.Size(144, 13);
            this.RT1B_label.TabIndex = 23;
            this.RT1B_label.Text = "Repair Time For One Bearing";
            // 
            // RT1B_numeric
            // 
            this.RT1B_numeric.Location = new System.Drawing.Point(12, 353);
            this.RT1B_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.RT1B_numeric.Name = "RT1B_numeric";
            this.RT1B_numeric.Size = new System.Drawing.Size(120, 20);
            this.RT1B_numeric.TabIndex = 22;
            // 
            // NB_label
            // 
            this.NB_label.AutoSize = true;
            this.NB_label.Location = new System.Drawing.Point(9, 266);
            this.NB_label.Name = "NB_label";
            this.NB_label.Size = new System.Drawing.Size(102, 13);
            this.NB_label.TabIndex = 21;
            this.NB_label.Text = "Number Of Bearings";
            // 
            // NB_numeric
            // 
            this.NB_numeric.Location = new System.Drawing.Point(12, 293);
            this.NB_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NB_numeric.Name = "NB_numeric";
            this.NB_numeric.Size = new System.Drawing.Size(120, 20);
            this.NB_numeric.TabIndex = 20;
            // 
            // RTAB_label
            // 
            this.RTAB_label.AutoSize = true;
            this.RTAB_label.Location = new System.Drawing.Point(9, 387);
            this.RTAB_label.Name = "RTAB_label";
            this.RTAB_label.Size = new System.Drawing.Size(140, 13);
            this.RTAB_label.TabIndex = 25;
            this.RTAB_label.Text = "Repair Time For All Bearings";
            // 
            // RTAB_numeric
            // 
            this.RTAB_numeric.Location = new System.Drawing.Point(12, 414);
            this.RTAB_numeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.RTAB_numeric.Name = "RTAB_numeric";
            this.RTAB_numeric.Size = new System.Drawing.Size(120, 20);
            this.RTAB_numeric.TabIndex = 24;
            // 
            // TCN_label
            // 
            this.TCN_label.AutoSize = true;
            this.TCN_label.Location = new System.Drawing.Point(388, 387);
            this.TCN_label.Name = "TCN_label";
            this.TCN_label.Size = new System.Drawing.Size(95, 13);
            this.TCN_label.TabIndex = 26;
            this.TCN_label.Text = "Test Case Number";
            // 
            // TC_list
            // 
            this.TC_list.FormattingEnabled = true;
            this.TC_list.Location = new System.Drawing.Point(391, 411);
            this.TC_list.Name = "TC_list";
            this.TC_list.Size = new System.Drawing.Size(115, 21);
            this.TC_list.TabIndex = 27;
            this.TC_list.SelectedIndexChanged += new System.EventHandler(this.TC_list_SelectedIndexChanged);
            // 
            // TCN_btn
            // 
            this.TCN_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TCN_btn.Location = new System.Drawing.Point(518, 411);
            this.TCN_btn.Name = "TCN_btn";
            this.TCN_btn.Size = new System.Drawing.Size(75, 23);
            this.TCN_btn.TabIndex = 28;
            this.TCN_btn.Text = "Browse";
            this.TCN_btn.UseVisualStyleBackColor = true;
            this.TCN_btn.Click += new System.EventHandler(this.TCN_btn_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(605, 540);
            this.Controls.Add(this.TCN_btn);
            this.Controls.Add(this.TC_list);
            this.Controls.Add(this.TCN_label);
            this.Controls.Add(this.RTAB_label);
            this.Controls.Add(this.RTAB_numeric);
            this.Controls.Add(this.RT1B_label);
            this.Controls.Add(this.RT1B_numeric);
            this.Controls.Add(this.NB_label);
            this.Controls.Add(this.NB_numeric);
            this.Controls.Add(this.NH_label);
            this.Controls.Add(this.NH_numeric);
            this.Controls.Add(this.BC_label);
            this.Controls.Add(this.BC_numeric);
            this.Controls.Add(this.RPC_label);
            this.Controls.Add(this.RPC_numeric);
            this.Controls.Add(this.DC_label);
            this.Controls.Add(this.BLD_label);
            this.Controls.Add(this.DTD_label);
            this.Controls.Add(this.DC_numeric);
            this.Controls.Add(this.Simulate);
            this.Controls.Add(this.BLD_textbox);
            this.Controls.Add(this.DTD_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NH_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BC_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RT1B_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NB_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTAB_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DTD_textbox;
        private System.Windows.Forms.TextBox BLD_textbox;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.NumericUpDown DC_numeric;
        private System.Windows.Forms.Label DTD_label;
        private System.Windows.Forms.Label BLD_label;
        private System.Windows.Forms.Label DC_label;
        private System.Windows.Forms.Label RPC_label;
        private System.Windows.Forms.NumericUpDown RPC_numeric;
        private System.Windows.Forms.Label NH_label;
        private System.Windows.Forms.NumericUpDown NH_numeric;
        private System.Windows.Forms.Label BC_label;
        private System.Windows.Forms.NumericUpDown BC_numeric;
        private System.Windows.Forms.Label RT1B_label;
        private System.Windows.Forms.NumericUpDown RT1B_numeric;
        private System.Windows.Forms.Label NB_label;
        private System.Windows.Forms.NumericUpDown NB_numeric;
        private System.Windows.Forms.Label RTAB_label;
        private System.Windows.Forms.NumericUpDown RTAB_numeric;
        private System.Windows.Forms.Label TCN_label;
        private System.Windows.Forms.ComboBox TC_list;
        private System.Windows.Forms.Button TCN_btn;
    }
}