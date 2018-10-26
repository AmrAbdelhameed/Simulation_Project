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
            Methods methods = new Methods();
            simulationSystem.ServerPeriorty = 1;
            simulationSystem.SimulationTable = methods.CalculateMethod(simulationSystem);
            int totalwait = 0, numberwait = 0,count=0,maxinQueue=0;
            for(int i=0;i<simulationSystem.SimulationTable.Count;i++)
            {
                numberwait += (simulationSystem.SimulationTable[i].TimeInQueue != 0 ? 1 : 0);
                totalwait += simulationSystem.SimulationTable[i].TimeInQueue;
                if (simulationSystem.SimulationTable[i].TimeInQueue != 0)
                    count++;
                else
                    count = 0;
                maxinQueue = Math.Max(maxinQueue, count);
            }

            simulationSystem.PerformanceMeasures.AverageWaitingTime =(decimal) totalwait / simulationSystem.SimulationTable.Count;
            simulationSystem.PerformanceMeasures.WaitingProbability= (decimal)numberwait /simulationSystem.SimulationTable.Count;
            simulationSystem.PerformanceMeasures.MaxQueueLength = maxinQueue;
            for(int i=0;i<simulationSystem.Servers.Count;i++)
            {
                simulationSystem.Servers[i].IdleProbability = (decimal) simulationSystem.Servers[i].Idle / simulationSystem.ToatalRun;
                if (simulationSystem.Servers[i].Customer == 0)
                    simulationSystem.Servers[i].AverageServiceTime = 0;
                else
                simulationSystem.Servers[i].AverageServiceTime = (decimal)simulationSystem.Servers[i].TotalWorkingTime / simulationSystem.Servers[i].Customer;
                //ask a question
                simulationSystem.Servers[i].Utilization = (decimal) simulationSystem.Servers[i].TotalWorkingTime / simulationSystem.ToatalRun;

            }
            //SimulationCase simulationCase = new SimulationCase();
            // count = 0;
            //for (int i = 0; i < simulationSystem.SimulationTable.Count; i++)
            //{
            //    simulationCase = simulationSystem.SimulationTable[i];
            //    if (simulationCase.RandomInterArrival > 100 || simulationCase.RandomService > 100)
            //        count++;
            //  //      MessageBox.Show(simulationCase.CustomerNumber + " " + simulationCase.RandomInterArrival + " " + simulationCase.InterArrival + " " + simulationCase.ArrivalTime
            //    //       +" "+simulationCase.RandomService+ " " + simulationCase.StartTime + " " + simulationCase.ServiceTime + " " + simulationCase.EndTime + " " + simulationCase.TimeInQueue);
            //}

            string testingResult = TestingManager.Test(simulationSystem, Constants.FileNames.TestCase2);
            MessageBox.Show(testingResult);

            Form2 f = new Form2();
            f.simulationSystem = simulationSystem;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simulationSystem = new SimulationSystem();
            fileLines = new List<string>();
            StreamReader sr = new StreamReader(@"E:\Simulation_Final\Simulation_Project\MultiQueueSimulation\MultiQueueSimulation\TestCases\TestCase2.txt");
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

            int idx_ServiceDistribution_Server = fileLines.IndexOf("ServiceDistribution_Server1") + 1, counter = 0;
            
            for (int a = 0; a < simulationSystem.NumberOfServers; ++a)
            {
                timeDistributions = new List<TimeDistribution>();
                idx_ServiceDistribution_Server += counter;
                counter = 0;
                for (int i = idx_ServiceDistribution_Server; i < fileLines.Count(); ++i)
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

            txtServiceDistribution.Text = "Service Distribution (Server ID: " + simulationSystem.Servers[CounterOfServers].ID+ ")";
            dataGridViewServers.DataSource = simulationSystem.Servers[CounterOfServers].TimeDistribution;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            CounterOfServers--;
            if (CounterOfServers >= 0)
            {
                txtServiceDistribution.Text = "Service Distribution (Server ID: " + simulationSystem.Servers[CounterOfServers].ID + ")";
                dataGridViewServers.DataSource = simulationSystem.Servers[CounterOfServers].TimeDistribution;
            }
            else
                CounterOfServers++;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            CounterOfServers++;
            if (CounterOfServers < simulationSystem.Servers.Count())
            {
                txtServiceDistribution.Text = "Service Distribution (Server ID: " + simulationSystem.Servers[CounterOfServers].ID + ")";
                dataGridViewServers.DataSource = simulationSystem.Servers[CounterOfServers].TimeDistribution;
            }
            else
                CounterOfServers--;
        }
    }
}
