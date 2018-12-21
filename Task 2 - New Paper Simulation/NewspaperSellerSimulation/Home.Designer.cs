namespace NewspaperSellerSimulation
{
    partial class Home
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
            this.AlphaText1 = new System.Windows.Forms.Label();
            this.Decoy1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Import = new System.Windows.Forms.Button();
            this.Simulate = new System.Windows.Forms.Button();
            this.webPanel = new System.Windows.Forms.Panel();
            this.DemandGridView = new System.Windows.Forms.DataGridView();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decoy1.SuspendLayout();
            this.webPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemandGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AlphaText1
            // 
            this.AlphaText1.AutoSize = true;
            this.AlphaText1.Location = new System.Drawing.Point(5, 5);
            this.AlphaText1.Name = "AlphaText1";
            this.AlphaText1.Size = new System.Drawing.Size(436, 26);
            this.AlphaText1.TabIndex = 0;
            this.AlphaText1.Text = "Welcome to Newspaper Problem Simulation Center, to begin kindly input the followi" +
    "ng data \r\nand press simulate or press import to choose a test case file.";
            this.AlphaText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Decoy1
            // 
            this.Decoy1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Decoy1.Controls.Add(this.label1);
            this.Decoy1.Controls.Add(this.Import);
            this.Decoy1.Controls.Add(this.Simulate);
            this.Decoy1.Location = new System.Drawing.Point(0, 288);
            this.Decoy1.Name = "Decoy1";
            this.Decoy1.Size = new System.Drawing.Size(538, 52);
            this.Decoy1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team CS_06";
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(352, 12);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(444, 12);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(75, 23);
            this.Simulate.TabIndex = 0;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // webPanel
            // 
            this.webPanel.AutoScroll = true;
            this.webPanel.Controls.Add(this.DemandGridView);
            this.webPanel.Controls.Add(this.AlphaText1);
            this.webPanel.Location = new System.Drawing.Point(12, 12);
            this.webPanel.Name = "webPanel";
            this.webPanel.Size = new System.Drawing.Size(507, 270);
            this.webPanel.TabIndex = 2;
            // 
            // DemandGridView
            // 
            this.DemandGridView.BackgroundColor = System.Drawing.Color.White;
            this.DemandGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DemandGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DemandGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DemandGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.Good,
            this.Fair,
            this.Poor});
            this.DemandGridView.Location = new System.Drawing.Point(276, 52);
            this.DemandGridView.Name = "DemandGridView";
            this.DemandGridView.RowHeadersVisible = false;
            this.DemandGridView.Size = new System.Drawing.Size(204, 449);
            this.DemandGridView.TabIndex = 1;
            // 
            // Demand
            // 
            this.Demand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            // 
            // Good
            // 
            this.Good.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Good.HeaderText = "Good";
            this.Good.Name = "Good";
            // 
            // Fair
            // 
            this.Fair.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fair.HeaderText = "Fair";
            this.Fair.Name = "Fair";
            // 
            // Poor
            // 
            this.Poor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Poor.HeaderText = "Poor";
            this.Poor.Name = "Poor";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 335);
            this.Controls.Add(this.webPanel);
            this.Controls.Add(this.Decoy1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.Text = "News Paper Problem - Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Decoy1.ResumeLayout(false);
            this.Decoy1.PerformLayout();
            this.webPanel.ResumeLayout(false);
            this.webPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemandGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AlphaText1;
        private System.Windows.Forms.Panel Decoy1;
        private System.Windows.Forms.Panel webPanel;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DemandGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poor;
    }
}