namespace MultiQueueSimulation
{
    partial class Form2
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
            this.dataGridViewSimulationCase = new System.Windows.Forms.DataGridView();
            this.btn_output = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AverageWaitingTime = new System.Windows.Forms.Label();
            this.MaxQueueLength = new System.Windows.Forms.Label();
            this.WaitingProbability = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulationCase)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSimulationCase
            // 
            this.dataGridViewSimulationCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSimulationCase.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSimulationCase.Name = "dataGridViewSimulationCase";
            this.dataGridViewSimulationCase.Size = new System.Drawing.Size(779, 381);
            this.dataGridViewSimulationCase.TabIndex = 0;
            // 
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(538, 433);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(110, 35);
            this.btn_output.TabIndex = 3;
            this.btn_output.Text = "Graph";
            this.btn_output.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Performance Measures :-";
            // 
            // AverageWaitingTime
            // 
            this.AverageWaitingTime.AutoSize = true;
            this.AverageWaitingTime.Location = new System.Drawing.Point(124, 422);
            this.AverageWaitingTime.Name = "AverageWaitingTime";
            this.AverageWaitingTime.Size = new System.Drawing.Size(118, 13);
            this.AverageWaitingTime.TabIndex = 5;
            this.AverageWaitingTime.Text = "Average Waiting Time :";
            // 
            // MaxQueueLength
            // 
            this.MaxQueueLength.AutoSize = true;
            this.MaxQueueLength.Location = new System.Drawing.Point(124, 444);
            this.MaxQueueLength.Name = "MaxQueueLength";
            this.MaxQueueLength.Size = new System.Drawing.Size(104, 13);
            this.MaxQueueLength.TabIndex = 6;
            this.MaxQueueLength.Text = "Max Queue Length :";
            // 
            // WaitingProbability
            // 
            this.WaitingProbability.AutoSize = true;
            this.WaitingProbability.Location = new System.Drawing.Point(124, 465);
            this.WaitingProbability.Name = "WaitingProbability";
            this.WaitingProbability.Size = new System.Drawing.Size(100, 13);
            this.WaitingProbability.TabIndex = 7;
            this.WaitingProbability.Text = "Waiting Probability :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 487);
            this.Controls.Add(this.WaitingProbability);
            this.Controls.Add(this.MaxQueueLength);
            this.Controls.Add(this.AverageWaitingTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_output);
            this.Controls.Add(this.dataGridViewSimulationCase);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulationCase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSimulationCase;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AverageWaitingTime;
        private System.Windows.Forms.Label MaxQueueLength;
        private System.Windows.Forms.Label WaitingProbability;
    }
}