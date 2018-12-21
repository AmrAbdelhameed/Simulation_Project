using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewspaperSellerModels;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class PeroformancePreview : Form
    {
        PerformanceMeasures PMi;
        public PeroformancePreview(PerformanceMeasures PRM)
        {
            PMi = PRM;
            InitializeComponent();
        }

        private void PeroformancePreview_Load(object sender, EventArgs e)
        {

            DataGridViewRow DGR = new DataGridViewRow();
            DGR.CreateCells(PerformanceGrid);
            DGR.Cells[0].Value = "Days With More Demand";
            DGR.Cells[1].Value = PMi.DaysWithMoreDemand;
            PerformanceGrid.Rows.Add(DGR);

            DGR = new DataGridViewRow();
            DGR = new DataGridViewRow();
            DGR.CreateCells(PerformanceGrid);
            DGR.Cells[0].Value = "Days With Unsold Papers";
            DGR.Cells[1].Value = PMi.DaysWithUnsoldPapers;
            PerformanceGrid.Rows.Add(DGR);


            DGR = new DataGridViewRow();
            DGR.CreateCells(PerformanceGrid);
            DGR.Cells[0].Value = "Total Cost";
            DGR.Cells[1].Value = PMi.TotalCost;
            PerformanceGrid.Rows.Add(DGR);

            DGR = new DataGridViewRow();
            DGR.CreateCells(PerformanceGrid);
            DGR.Cells[0].Value = "Total Lost Profit";
            DGR.Cells[1].Value = PMi.TotalLostProfit;
            PerformanceGrid.Rows.Add(DGR);

            DGR = new DataGridViewRow();
            DGR.CreateCells(PerformanceGrid);
            DGR.Cells[0].Value = "Total Net Profit";
            DGR.Cells[1].Value = PMi.TotalNetProfit;
            PerformanceGrid.Rows.Add(DGR);

            DGR = new DataGridViewRow();
            DGR.CreateCells(PerformanceGrid);
            DGR.Cells[0].Value = "Total Sales Profit";
            DGR.Cells[1].Value = PMi.TotalSalesProfit;
            PerformanceGrid.Rows.Add(DGR);

            DGR = new DataGridViewRow();
            DGR.CreateCells(PerformanceGrid);
            DGR.Cells[0].Value = "Total Scrap Profit";
            DGR.Cells[1].Value = PMi.TotalScrapProfit;
            PerformanceGrid.Rows.Add(DGR);
        }
    }
}
