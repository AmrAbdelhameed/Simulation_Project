namespace InventorySimulation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EndingInventoryAverage = new System.Windows.Forms.Label();
            this.ShortageQuantityAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Performance Measures";
            // 
            // EndingInventoryAverage
            // 
            this.EndingInventoryAverage.AutoSize = true;
            this.EndingInventoryAverage.Location = new System.Drawing.Point(24, 349);
            this.EndingInventoryAverage.Name = "EndingInventoryAverage";
            this.EndingInventoryAverage.Size = new System.Drawing.Size(130, 13);
            this.EndingInventoryAverage.TabIndex = 2;
            this.EndingInventoryAverage.Text = "Ending Inventory Average";
            // 
            // ShortageQuantityAverage
            // 
            this.ShortageQuantityAverage.AutoSize = true;
            this.ShortageQuantityAverage.Location = new System.Drawing.Point(24, 369);
            this.ShortageQuantityAverage.Name = "ShortageQuantityAverage";
            this.ShortageQuantityAverage.Size = new System.Drawing.Size(135, 13);
            this.ShortageQuantityAverage.TabIndex = 3;
            this.ShortageQuantityAverage.Text = "Shortage Quantity Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 391);
            this.Controls.Add(this.ShortageQuantityAverage);
            this.Controls.Add(this.EndingInventoryAverage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EndingInventoryAverage;
        private System.Windows.Forms.Label ShortageQuantityAverage;
    }
}