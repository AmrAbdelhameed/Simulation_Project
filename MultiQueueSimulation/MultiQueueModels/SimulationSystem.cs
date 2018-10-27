using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }

        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }
        public int ServerPeriorty { get; set; }
        public int ToatalRun { get; set; }
        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        ///////////// OPERATIONS /////////////
        public void CalculateInterArrivalTimeDistribution()
        {
            decimal oldProb = 0;
            int maxRange = 0;

            for (int i = 0; i < InterarrivalDistribution.Count(); ++i)
            {
                InterarrivalDistribution[i].CummProbability = oldProb + InterarrivalDistribution[i].Probability;
                oldProb = InterarrivalDistribution[i].CummProbability;

                InterarrivalDistribution[i].MinRange = maxRange + 1;

                maxRange = (int)(InterarrivalDistribution[i].CummProbability * 100);
                InterarrivalDistribution[i].MaxRange = maxRange;
            }
        }

        public int randomNumberOfInterArrivalTime()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }

        public int getInterArrivalTimeByRandomRange(int randomNumber)
        {
            int arrivalTime = 0;

            for (int i = 0; i < InterarrivalDistribution.Count(); ++i)
            {
                int minRange = InterarrivalDistribution[i].MinRange, maxRange = InterarrivalDistribution[i].MaxRange;
                if (randomNumber >= minRange && randomNumber <= maxRange)
                {
                    arrivalTime = InterarrivalDistribution[i].Time;
                    break;
                }
            }
            return arrivalTime;
        }
    }
}