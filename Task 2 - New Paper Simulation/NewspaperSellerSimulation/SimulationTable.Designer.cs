namespace NewspaperSellerSimulation
{
    partial class SimulationTable
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
            this.TableSimulationView = new System.Windows.Forms.DataGridView();
            this.DayN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomNewsDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewsDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyNetProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decoy2 = new System.Windows.Forms.Panel();
            this.shwMeasures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableSimulationView)).BeginInit();
            this.Decoy2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableSimulationView
            // 
            this.TableSimulationView.BackgroundColor = System.Drawing.Color.White;
            this.TableSimulationView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableSimulationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSimulationView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayN,
            this.RandomNewsDayType,
            this.NewsDayType,
            this.RandomDemand,
            this.Demand,
            this.DailyCost,
            this.SalesProfit,
            this.LostProfit,
            this.ScrapProfit,
            this.DailyNetProfit});
            this.TableSimulationView.Location = new System.Drawing.Point(-1, -3);
            this.TableSimulationView.Name = "TableSimulationView";
            this.TableSimulationView.RowHeadersVisible = false;
            this.TableSimulationView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TableSimulationView.Size = new System.Drawing.Size(885, 487);
            this.TableSimulationView.TabIndex = 0;
            // 
            // DayN
            // 
            this.DayN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DayN.HeaderText = "Day #";
            this.DayN.Name = "DayN";
            // 
            // RandomNewsDayType
            // 
            this.RandomNewsDayType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RandomNewsDayType.HeaderText = "RandomNewsDayType";
            this.RandomNewsDayType.Name = "RandomNewsDayType";
            // 
            // NewsDayType
            // 
            this.NewsDayType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NewsDayType.HeaderText = "NewsDayType";
            this.NewsDayType.Name = "NewsDayType";
            // 
            // RandomDemand
            // 
            this.RandomDemand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RandomDemand.HeaderText = "RandomDemand";
            this.RandomDemand.Name = "RandomDemand";
            // 
            // Demand
            // 
            this.Demand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            // 
            // DailyCost
            // 
            this.DailyCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DailyCost.HeaderText = "DailyCost";
            this.DailyCost.Name = "DailyCost";
            // 
            // SalesProfit
            // 
            this.SalesProfit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesProfit.HeaderText = "SalesProfit";
            this.SalesProfit.Name = "SalesProfit";
            // 
            // LostProfit
            // 
            this.LostProfit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LostProfit.HeaderText = "LostProfit";
            this.LostProfit.Name = "LostProfit";
            // 
            // ScrapProfit
            // 
            this.ScrapProfit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScrapProfit.HeaderText = "ScrapProfit";
            this.ScrapProfit.Name = "ScrapProfit";
            // 
            // DailyNetProfit
            // 
            this.DailyNetProfit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DailyNetProfit.HeaderText = "Daily Net Profit";
            this.DailyNetProfit.Name = "DailyNetProfit";
            // 
            // Decoy2
            // 
            this.Decoy2.BackColor = System.Drawing.Color.LightGray;
            this.Decoy2.Controls.Add(this.shwMeasures);
            this.Decoy2.Location = new System.Drawing.Point(-1, 490);
            this.Decoy2.Name = "Decoy2";
            this.Decoy2.Size = new System.Drawing.Size(885, 71);
            this.Decoy2.TabIndex = 1;
            // 
            // shwMeasures
            // 
            this.shwMeasures.Location = new System.Drawing.Point(778, 19);
            this.shwMeasures.Name = "shwMeasures";
            this.shwMeasures.Size = new System.Drawing.Size(75, 23);
            this.shwMeasures.TabIndex = 0;
            this.shwMeasures.Text = "Performance";
            this.shwMeasures.UseVisualStyleBackColor = true;
            this.shwMeasures.Click += new System.EventHandler(this.shwMeasures_Click);
            // 
            // SimulationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Decoy2);
            this.Controls.Add(this.TableSimulationView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SimulationTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Table";
            this.Load += new System.EventHandler(this.SimulationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableSimulationView)).EndInit();
            this.Decoy2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableSimulationView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayN;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomNewsDayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewsDayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyNetProfit;
        private System.Windows.Forms.Panel Decoy2;
        private System.Windows.Forms.Button shwMeasures;
    }
}