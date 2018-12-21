using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    public partial class SimulationTable : Form
    {
        SimulationSystem SSi;
        public SimulationTable(SimulationSystem SST)
        {
            SSi = SST;
            InitializeComponent();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            DataGridViewRow DGR = new DataGridViewRow();
            for (int i=0;i<SSi.NumOfRecords;i++)
            {
                DGR = new DataGridViewRow();
                DGR.CreateCells(TableSimulationView);
                DGR.Cells[0].Value = SSi.SimulationTable[i].DayNo;
                DGR.Cells[1].Value = SSi.SimulationTable[i].RandomNewsDayType;
                DGR.Cells[2].Value = SSi.SimulationTable[i].NewsDayType;
                DGR.Cells[3].Value = SSi.SimulationTable[i].RandomDemand;
                DGR.Cells[4].Value = SSi.SimulationTable[i].Demand;
                DGR.Cells[5].Value = SSi.SimulationTable[i].DailyCost;
                DGR.Cells[6].Value = SSi.SimulationTable[i].SalesProfit;
                DGR.Cells[7].Value = SSi.SimulationTable[i].LostProfit;
                DGR.Cells[8].Value = SSi.SimulationTable[i].ScrapProfit;
                DGR.Cells[9].Value = SSi.SimulationTable[i].DailyNetProfit;
                TableSimulationView.Rows.Add(DGR);
            }
        }

        private void shwMeasures_Click(object sender, EventArgs e)
        {
            PeroformancePreview Pr = new PeroformancePreview(SSi.PerformanceMeasures);
            Pr.Show();
        }
    }
}
