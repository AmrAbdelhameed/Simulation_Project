namespace MultiQueueSimulation
{
    partial class Form1
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
            this.btn_output = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfServers = new System.Windows.Forms.Label();
            this.txtStoppingNumber = new System.Windows.Forms.Label();
            this.txtStoppingCriteria = new System.Windows.Forms.Label();
            this.txtSelectionMethod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewInterarrival = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewServers = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterarrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(631, 278);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(110, 35);
            this.btn_output.TabIndex = 2;
            this.btn_output.Text = "Output";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number Of Servers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stopping Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stopping Criteria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selection Method";
            // 
            // txtNumberOfServers
            // 
            this.txtNumberOfServers.AutoSize = true;
            this.txtNumberOfServers.Location = new System.Drawing.Point(697, 166);
            this.txtNumberOfServers.Name = "txtNumberOfServers";
            this.txtNumberOfServers.Size = new System.Drawing.Size(102, 13);
            this.txtNumberOfServers.TabIndex = 7;
            this.txtNumberOfServers.Text = "txtNumberOfServers";
            // 
            // txtStoppingNumber
            // 
            this.txtStoppingNumber.AutoSize = true;
            this.txtStoppingNumber.Location = new System.Drawing.Point(697, 189);
            this.txtStoppingNumber.Name = "txtStoppingNumber";
            this.txtStoppingNumber.Size = new System.Drawing.Size(97, 13);
            this.txtStoppingNumber.TabIndex = 8;
            this.txtStoppingNumber.Text = "txtStoppingNumber";
            // 
            // txtStoppingCriteria
            // 
            this.txtStoppingCriteria.AutoSize = true;
            this.txtStoppingCriteria.Location = new System.Drawing.Point(697, 216);
            this.txtStoppingCriteria.Name = "txtStoppingCriteria";
            this.txtStoppingCriteria.Size = new System.Drawing.Size(92, 13);
            this.txtStoppingCriteria.TabIndex = 9;
            this.txtStoppingCriteria.Text = "txtStoppingCriteria";
            // 
            // txtSelectionMethod
            // 
            this.txtSelectionMethod.AutoSize = true;
            this.txtSelectionMethod.Location = new System.Drawing.Point(697, 241);
            this.txtSelectionMethod.Name = "txtSelectionMethod";
            this.txtSelectionMethod.Size = new System.Drawing.Size(98, 13);
            this.txtSelectionMethod.TabIndex = 10;
            this.txtSelectionMethod.Text = "txtSelectionMethod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Interarrival Distribution";
            // 
            // dataGridViewInterarrival
            // 
            this.dataGridViewInterarrival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInterarrival.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewInterarrival.Name = "dataGridViewInterarrival";
            this.dataGridViewInterarrival.Size = new System.Drawing.Size(543, 168);
            this.dataGridViewInterarrival.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Service Distribution (All Servers)";
            // 
            // dataGridViewServers
            // 
            this.dataGridViewServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServers.Location = new System.Drawing.Point(12, 268);
            this.dataGridViewServers.Name = "dataGridViewServers";
            this.dataGridViewServers.Size = new System.Drawing.Size(543, 168);
            this.dataGridViewServers.TabIndex = 14;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(208, 442);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(289, 442);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 16;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 480);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridViewServers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewInterarrival);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSelectionMethod);
            this.Controls.Add(this.txtStoppingCriteria);
            this.Controls.Add(this.txtStoppingNumber);
            this.Controls.Add(this.txtNumberOfServers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_output);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterarrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNumberOfServers;
        private System.Windows.Forms.Label txtStoppingNumber;
        private System.Windows.Forms.Label txtStoppingCriteria;
        private System.Windows.Forms.Label txtSelectionMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewInterarrival;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewServers;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_next;
    }
}

