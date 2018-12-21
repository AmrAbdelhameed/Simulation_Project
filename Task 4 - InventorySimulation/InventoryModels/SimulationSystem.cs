using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryModels
{
    public class SimulationSystem
    {
        Random random;
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        ///////////// My Methods /////////////

        public void ReadFromFile(string path)
        {
            Distribution distribution;
            List<string> fileLines = new List<string>();
            StreamReader sr = new StreamReader(path);
            
            while (!sr.EndOfStream)
            {
                fileLines.Add(sr.ReadLine());
            }
            sr.Close();

            int idx0 = fileLines.IndexOf("OrderUpTo");
            OrderUpTo = Convert.ToInt32(fileLines[idx0 + 1]);

            int idx1 = fileLines.IndexOf("ReviewPeriod");
            ReviewPeriod = Convert.ToInt32(fileLines[idx1 + 1]);

            int idx2 = fileLines.IndexOf("StartInventoryQuantity");
            StartInventoryQuantity = Convert.ToInt32(fileLines[idx2 + 1]);

            int idx3 = fileLines.IndexOf("StartLeadDays");
            StartLeadDays = Convert.ToInt32(fileLines[idx3 + 1]);

            int idx4 = fileLines.IndexOf("StartOrderQuantity");
            StartOrderQuantity = Convert.ToInt32(fileLines[idx4 + 1]);

            int idx5 = fileLines.IndexOf("NumberOfDays");
            NumberOfDays = Convert.ToInt32(fileLines[idx5 + 1]);

            int idx6 = fileLines.IndexOf("DemandDistribution");
            for (int i = idx6 + 1; i < fileLines.Count(); ++i)
            {
                if (string.IsNullOrEmpty(fileLines[i]))
                    break;

                distribution = new Distribution();
                string[] numbers = fileLines[i].Split(new string[] { ", " }, StringSplitOptions.None);
                distribution.Value = Convert.ToInt32(numbers[0]);
                distribution.Probability = Convert.ToDecimal(numbers[1]);
                DemandDistribution.Add(distribution);
            }

            int idx7 = fileLines.IndexOf("LeadDaysDistribution");
            for (int i = idx7 + 1; i < fileLines.Count(); ++i)
            {
                if (string.IsNullOrEmpty(fileLines[i]))
                    break;

                distribution = new Distribution();
                string[] numbers = fileLines[i].Split(new string[] { ", " }, StringSplitOptions.None);
                distribution.Value = Convert.ToInt32(numbers[0]);
                distribution.Probability = Convert.ToDecimal(numbers[1]);
                LeadDaysDistribution.Add(distribution);
            }
        }
        public void CompleteDemandAndLeadDaysDistribution(List<Distribution> distributions)
        {
            decimal oldProb = 0;
            int maxRange = 0;

            for (int i = 0; i < distributions.Count(); ++i)
            {
                distributions[i].CummProbability = oldProb + distributions[i].Probability;
                oldProb = distributions[i].CummProbability;

                distributions[i].MinRange = maxRange + 1;

                maxRange = (int)(distributions[i].CummProbability * 100);
                distributions[i].MaxRange = maxRange;
            }
        }
        public int getDistributionValueByRandomNumber(List<Distribution> distributions, int randomNumber)
        {
            int arrivalTime = 0;

            for (int i = 0; i < distributions.Count(); ++i)
            {
                int minRange = distributions[i].MinRange, maxRange = distributions[i].MaxRange;
                if (randomNumber >= minRange && randomNumber <= maxRange)
                {
                    arrivalTime = distributions[i].Value;
                    break;
                }
            }
            return arrivalTime;
        }
        public void Run(string path)
        {
            random = new Random();
            int cycle = 1, counter_day_in_cycle = 1, days_until_order_arrives = -10, next_order = 0;
            
            ReadFromFile(path);
            CompleteDemandAndLeadDaysDistribution(DemandDistribution);
            CompleteDemandAndLeadDaysDistribution(LeadDaysDistribution);
            
            SimulationCase simulationCase;
            for (int i = 0; i < NumberOfDays; ++i)
            {
                simulationCase = new SimulationCase();
                simulationCase.Day = i + 1;
                simulationCase.Cycle = cycle;
                simulationCase.DayWithinCycle = counter_day_in_cycle;

                if (i==0)
                {
                    simulationCase.BeginningInventory = StartInventoryQuantity;
                }
                else
                {
                    simulationCase.BeginningInventory = SimulationTable[i - 1].EndingInventory;
                }

                if (i == StartLeadDays)
                {
                    simulationCase.BeginningInventory += StartOrderQuantity;
                }

                if (days_until_order_arrives == -1)
                {
                    simulationCase.BeginningInventory += next_order;
                }

                simulationCase.RandomDemand = random.Next(1, 100);
                simulationCase.Demand = getDistributionValueByRandomNumber(DemandDistribution, simulationCase.RandomDemand);

                int last_sortage = 0;
                if (i > 0)
                {
                    last_sortage = SimulationTable[i - 1].ShortageQuantity;
                }

                if (simulationCase.BeginningInventory >= simulationCase.Demand + last_sortage)
                {
                    simulationCase.EndingInventory = simulationCase.BeginningInventory - (simulationCase.Demand + last_sortage);
                    simulationCase.ShortageQuantity = 0;
                }
                else
                {
                    simulationCase.EndingInventory = 0;
                    simulationCase.ShortageQuantity = (simulationCase.Demand + last_sortage) - simulationCase.BeginningInventory;
                }

                if (ReviewPeriod == counter_day_in_cycle)
                {
                    cycle++;
                    counter_day_in_cycle = 0;
                    simulationCase.OrderQuantity = OrderUpTo - simulationCase.EndingInventory + simulationCase.ShortageQuantity;
                    next_order = simulationCase.OrderQuantity;
                    simulationCase.RandomLeadDays = random.Next(1, 100);
                    simulationCase.LeadDays = getDistributionValueByRandomNumber(LeadDaysDistribution, simulationCase.RandomLeadDays);
                    days_until_order_arrives = simulationCase.LeadDays;
                }
                else
                {
                    simulationCase.OrderQuantity = 0;
                    simulationCase.RandomLeadDays = 0;
                    simulationCase.LeadDays = 0;
                }
                counter_day_in_cycle++;
                days_until_order_arrives--;

                SimulationTable.Add(simulationCase);
            }

            decimal count_end = 0, count_shortage = 0;
            for (int i = 0; i < SimulationTable.Count(); ++i)
            {
                count_end += SimulationTable[i].EndingInventory;
                count_shortage += SimulationTable[i].ShortageQuantity;
            }

            PerformanceMeasures.EndingInventoryAverage = count_end / NumberOfDays;
            PerformanceMeasures.ShortageQuantityAverage = count_shortage / NumberOfDays;
        }
    }
}
