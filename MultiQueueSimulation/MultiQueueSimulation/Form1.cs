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
        List<string> fileLines;
        List<TimeDistribution> timeDistributions;
        TimeDistribution timeDistribution;
        SimulationSystem simulationSystem;
        Server server;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            int rndNumber = simulationSystem.randomNumberOfInterArrivalTime();
            int arrTime = simulationSystem.getInterArrivalTimeByRandomRange(rndNumber);

            MessageBox.Show(rndNumber + " " + arrTime);
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

            //for (int a = 0; a < fileLines.Count(); ++a)
                //MessageBox.Show(fileLines[a]);

            ///////////////////////////////////////////////////////

            int idx_NumberOfServers = fileLines.IndexOf("NumberOfServers");
            simulationSystem.NumberOfServers = Convert.ToInt32(fileLines[idx_NumberOfServers + 1]);

            int idx_StoppingNumber = fileLines.IndexOf("StoppingNumber");
            simulationSystem.StoppingNumber = Convert.ToInt32(fileLines[idx_StoppingNumber + 1]);

            int idx_StoppingCriteria = fileLines.IndexOf("StoppingCriteria");
            simulationSystem.StoppingCriteria = (Enums.StoppingCriteria)Convert.ToInt32(fileLines[idx_StoppingCriteria + 1]);

            int idx_SelectionMethod = fileLines.IndexOf("SelectionMethod");
            simulationSystem.SelectionMethod = (Enums.SelectionMethod)Convert.ToInt32(fileLines[idx_SelectionMethod + 1]);

            //MessageBox.Show(simulationSystem.NumberOfServers + " " + simulationSystem.StoppingNumber + " " + simulationSystem.StoppingCriteria + " " + simulationSystem.SelectionMethod);

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

            /*for (int i = 0; i < simulationSystem.InterarrivalDistribution.Count(); ++i)
            {
                MessageBox.Show(simulationSystem.InterarrivalDistribution[i].Time + " " + simulationSystem.InterarrivalDistribution[i].Probability + " " + simulationSystem.InterarrivalDistribution[i].CummProbability + " " + simulationSystem.InterarrivalDistribution[i].MinRange + " " + simulationSystem.InterarrivalDistribution[i].MaxRange);
            }*/

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
                server.TimeDistribution = timeDistributions;
                server.CalculateServiceTimeDistribution();

                /*int rndNumber = server.randomNumberOfServiceTime();
                int serviceTime = server.getServiceTimeByRandomRange(rndNumber);

                MessageBox.Show(rndNumber + " " + serviceTime);*/

                simulationSystem.Servers.Add(server);
            }

            /*for (int b = 0; b < simulationSystem.NumberOfServers; ++b)
            {
                for (int i = 0; i < simulationSystem.Servers[b].TimeDistribution.Count(); ++i)
                {
                    MessageBox.Show(simulationSystem.Servers[b].TimeDistribution[i].Time + " " + simulationSystem.Servers[b].TimeDistribution[i].Probability + " " + simulationSystem.Servers[b].TimeDistribution[i].CummProbability + " " + simulationSystem.Servers[b].TimeDistribution[i].MinRange + " " + simulationSystem.Servers[b].TimeDistribution[i].MaxRange);
                }
            }*/

            ///////////////////////////////////////////////////////
        }      
    }
}
