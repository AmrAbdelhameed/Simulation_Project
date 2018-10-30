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
        private List<SimulationCaseOutput> simulationCasesOutput;
        private SimulationCaseOutput simulationCaseobj;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            simulationCasesOutput = new List<SimulationCaseOutput>();

            for (int i = 0; i < simulationSystem.SimulationTable.Count; ++i)
            {
                simulationCaseobj = new SimulationCaseOutput(simulationSystem.SimulationTable[i]);
                simulationCasesOutput.Add(simulationCaseobj);
            }
            dataGridViewSimulationCase.DataSource = simulationCasesOutput;

            AverageWaitingTime.Text = "Average Waiting Time : " + simulationSystem.PerformanceMeasures.AverageWaitingTime;
            MaxQueueLength.Text = "Max Queue Length : " + simulationSystem.PerformanceMeasures.MaxQueueLength;
            WaitingProbability.Text = "Waiting Probability: " + simulationSystem.PerformanceMeasures.WaitingProbability;
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.simulationSystem = simulationSystem;
            f.Show();
        }
    }
}
