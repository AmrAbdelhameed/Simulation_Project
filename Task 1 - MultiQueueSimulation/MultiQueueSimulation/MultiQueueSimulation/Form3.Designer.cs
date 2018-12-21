namespace MultiQueueSimulation
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serverID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.WaitingProbability = new System.Windows.Forms.Label();
            this.MaxQueueLength = new System.Windows.Forms.Label();
            this.AverageWaitingTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "BusyTime";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1206, 368);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // serverID
            // 
            this.serverID.AutoSize = true;
            this.serverID.Location = new System.Drawing.Point(563, 414);
            this.serverID.Name = "serverID";
            this.serverID.Size = new System.Drawing.Size(35, 13);
            this.serverID.TabIndex = 1;
            this.serverID.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WaitingProbability
            // 
            this.WaitingProbability.AutoSize = true;
            this.WaitingProbability.Location = new System.Drawing.Point(144, 456);
            this.WaitingProbability.Name = "WaitingProbability";
            this.WaitingProbability.Size = new System.Drawing.Size(100, 13);
            this.WaitingProbability.TabIndex = 11;
            this.WaitingProbability.Text = "Waiting Probability :";
            // 
            // MaxQueueLength
            // 
            this.MaxQueueLength.AutoSize = true;
            this.MaxQueueLength.Location = new System.Drawing.Point(144, 435);
            this.MaxQueueLength.Name = "MaxQueueLength";
            this.MaxQueueLength.Size = new System.Drawing.Size(104, 13);
            this.MaxQueueLength.TabIndex = 10;
            this.MaxQueueLength.Text = "Max Queue Length :";
            // 
            // AverageWaitingTime
            // 
            this.AverageWaitingTime.AutoSize = true;
            this.AverageWaitingTime.Location = new System.Drawing.Point(144, 413);
            this.AverageWaitingTime.Name = "AverageWaitingTime";
            this.AverageWaitingTime.Size = new System.Drawing.Size(118, 13);
            this.AverageWaitingTime.TabIndex = 9;
            this.AverageWaitingTime.Text = "Average Waiting Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Performance Measures :-";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 478);
            this.Controls.Add(this.WaitingProbability);
            this.Controls.Add(this.MaxQueueLength);
            this.Controls.Add(this.AverageWaitingTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serverID);
            this.Controls.Add(this.chart1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label serverID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label WaitingProbability;
        private System.Windows.Forms.Label MaxQueueLength;
        private System.Windows.Forms.Label AverageWaitingTime;
        private System.Windows.Forms.Label label1;
    }
}