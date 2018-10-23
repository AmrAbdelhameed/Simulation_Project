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
using MultiQueueTesting;
using System.IO;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem simulationSystem;
        List<string> fileLines;
        List<TimeDistribution> timeDistributions;
        TimeDistribution timeDistribution;
        Server server;
        int CounterOfServers = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            // for test getInterArrivalTimeByRandomRange function is correct
            /*int rndNumber = simulationSystem.randomNumberOfInterArrivalTime();
            int arrTime = simulationSystem.getInterArrivalTimeByRandomRange(rndNumber);
            MessageBox.Show(rndNumber + " " + arrTime);*/

            // elmfrod hena te3ml calling le form gdeda w ykon feha DataGridView 3bara 3n List<SimulationCase>
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simulationSystem = new SimulationSystem();
            fileLines = new List<string>();
            StreamReader sr = new StreamReader(@"D:\_FCIS\Sna 4\Semester 1\Modeling _ simulation\Template\MultiQueueSimulation\MultiQueueSimulation\TestCases\TestCase1.txt");
            while (!sr.EndOfStream)
            {
                fileLines.Add(sr.ReadLine());
            }
            sr.Close();

            ///////////////////////////////////////////////////////

            int idx_NumberOfServers = fileLines.IndexOf("NumberOfServers");
            simulationSystem.NumberOfServers = Convert.ToInt32(fileLines[idx_NumberOfServers + 1]);
            txtNumberOfServers.Text = simulationSystem.NumberOfServers.ToString();

            int idx_StoppingNumber = fileLines.IndexOf("StoppingNumber");
            simulationSystem.StoppingNumber = Convert.ToInt32(fileLines[idx_StoppingNumber + 1]);
            txtStoppingNumber.Text = simulationSystem.StoppingNumber.ToString();

            int idx_StoppingCriteria = fileLines.IndexOf("StoppingCriteria");
            simulationSystem.StoppingCriteria = (Enums.StoppingCriteria)Convert.ToInt32(fileLines[idx_StoppingCriteria + 1]);
            txtStoppingCriteria.Text = simulationSystem.StoppingCriteria.ToString();

            int idx_SelectionMethod = fileLines.IndexOf("SelectionMethod");
            simulationSystem.SelectionMethod = (Enums.SelectionMethod)Convert.ToInt32(fileLines[idx_SelectionMethod + 1]);
            txtSelectionMethod.Text = simulationSystem.SelectionMethod.ToString();

            ///////////////////////////////////////////////////////

            int idx_InterarrivalDistribution = fileLines.IndexOf("InterarrivalDistribution");
            timeDistributions = new List<TimeDistribution>();
            for (int i = idx_InterarrivalDistribution + 1; i < fileLines.Count(); ++i)
            {
                if (string.IsNullOrEmpty(fileLines[i]))
                    break;

                timeDistribution = new TimeDistribution();
                string[] numbers = fileLines[i].Split(new string[] {", "}, StringSplitOptions.None);
                timeDistribution.Time = Convert.ToInt32(numbers[0]);
                timeDistribution.Probability = Convert.ToDecimal(numbers[1]);
                timeDistributions.Add(timeDistribution);
            }

            simulationSystem.InterarrivalDistribution = timeDistributions;
            simulationSystem.CalculateInterArrivalTimeDistribution();

            dataGridViewInterarrival.DataSource = simulationSystem.InterarrivalDistribution;

            ///////////////////////////////////////////////////////

            int idx_ServiceDistribution_Server1 = fileLines.IndexOf("ServiceDistribution_Server1") + 1, counter = 0;
            
            for (int a = 0; a < simulationSystem.NumberOfServers; ++a)
            {
                timeDistributions = new List<TimeDistribution>();
                idx_ServiceDistribution_Server1 += counter;
                for (int i = idx_ServiceDistribution_Server1; i < fileLines.Count(); ++i)
                {
                    if (string.IsNullOrEmpty(fileLines[i]))
                    {
                        counter += 2;
                        break;
                    }

                    counter++;
                    timeDistribution = new TimeDistribution();
                    string[] numbers = fileLines[i].Split(new string[] { ", " }, StringSplitOptions.None);
                    timeDistribution.Time = Convert.ToInt32(numbers[0]);
                    timeDistribution.Probability = Convert.ToDecimal(numbers[1]);
                    timeDistributions.Add(timeDistribution);
                }

                server = new Server();
                server.ID = a + 1;
                server.TimeDistribution = timeDistributions;
                server.CalculateServiceTimeDistribution();

                simulationSystem.Servers.Add(server);
            }

            dataGridViewServers.DataSource = simulationSystem.Servers[CounterOfServers].TimeDistribution;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            CounterOfServers--;
            if (CounterOfServers >= 0)
                dataGridViewServers.DataSource = simulationSystem.Servers[CounterOfServers].TimeDistribution;
            else
                CounterOfServers++;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            CounterOfServers++;
            if (CounterOfServers < simulationSystem.Servers.Count())
                dataGridViewServers.DataSource = simulationSystem.Servers[CounterOfServers].TimeDistribution;
            else
                CounterOfServers--;
        }
    }
}
