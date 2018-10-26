using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    public partial class Form2 : Form
    {
        public SimulationSystem simulationSystem;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridViewSimulationCase.DataSource = simulationSystem.SimulationTable;

            AverageWaitingTime.Text = "Average Waiting Time : " + simulationSystem.PerformanceMeasures.AverageWaitingTime;
            MaxQueueLength.Text = "Max Queue Length : " + simulationSystem.PerformanceMeasures.MaxQueueLength;
            WaitingProbability.Text = "Waiting Probability: " + simulationSystem.PerformanceMeasures.WaitingProbability;
        }
    }
}
