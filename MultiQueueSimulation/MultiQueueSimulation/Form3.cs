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
    public partial class Form3 : Form
    {
        public SimulationSystem simulationSystem;
        private int CounterOfServers = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CounterOfServers--;
            if (CounterOfServers >= 0)
            {
                serverID.Text = "Server ID: " + simulationSystem.Servers[CounterOfServers].ID;
                fillChart(CounterOfServers);
                AverageWaitingTime.Text = "IdleProbability : " + simulationSystem.Servers[CounterOfServers].IdleProbability;
                MaxQueueLength.Text = "AverageServiceTime : " + simulationSystem.Servers[CounterOfServers].AverageServiceTime;
                WaitingProbability.Text = "Utilization: " + simulationSystem.Servers[CounterOfServers].Utilization;
            }
            else
                CounterOfServers++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CounterOfServers++;
            if (CounterOfServers < simulationSystem.Servers.Count())
            {
                serverID.Text = "Server ID: " + simulationSystem.Servers[CounterOfServers].ID;
                fillChart(CounterOfServers);
                AverageWaitingTime.Text = "IdleProbability : " + simulationSystem.Servers[CounterOfServers].IdleProbability;
                MaxQueueLength.Text = "AverageServiceTime : " + simulationSystem.Servers[CounterOfServers].AverageServiceTime;
                WaitingProbability.Text = "Utilization: " + simulationSystem.Servers[CounterOfServers].Utilization;
            }
            else
                CounterOfServers--;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            serverID.Text = "Server ID: " + simulationSystem.Servers[CounterOfServers].ID;
            fillChart(CounterOfServers);

            AverageWaitingTime.Text = "IdleProbability : " + simulationSystem.Servers[CounterOfServers].IdleProbability;
            MaxQueueLength.Text = "AverageServiceTime : " + simulationSystem.Servers[CounterOfServers].AverageServiceTime;
            WaitingProbability.Text = "Utilization: " + simulationSystem.Servers[CounterOfServers].Utilization;
        }
        private void fillChart(int pos)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.ChartAreas[0].AxisX.Maximum = simulationSystem.Servers[pos].FinishTime;
            chart1.ChartAreas[0].AxisY.Maximum = 1;

            for (int j = 0; j < simulationSystem.Servers[pos].BusyTime.Count; ++j)
                for (int k = simulationSystem.Servers[pos].BusyTime[j].Item1;
                    k < simulationSystem.Servers[pos].BusyTime[j].Item2; ++k)
                    chart1.Series["BusyTime"].Points.AddXY(k, 1);
        }
    }
}
