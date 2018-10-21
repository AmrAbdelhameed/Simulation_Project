using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
        }

        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }

        ///////////// OPERATIONS /////////////
        public void CalculateServiceTimeDistribution()
        {
            decimal oldProb = 0;
            int maxRange = 0;

            for (int i = 0; i < TimeDistribution.Count(); ++i)
            {
                TimeDistribution[i].CummProbability = oldProb + TimeDistribution[i].Probability;
                oldProb = TimeDistribution[i].CummProbability;

                TimeDistribution[i].MinRange = maxRange + 1;

                maxRange = (int)(TimeDistribution[i].CummProbability * 100);
                TimeDistribution[i].MaxRange = maxRange;
            }
        }

        public int getServiceTimeByRandomRange()
        {
            int arrivalTime = 0;
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            for (int i = 0; i < TimeDistribution.Count(); ++i)
            {
                int minRange = TimeDistribution[i].MinRange, maxRange = TimeDistribution[i].MaxRange;
                if (randomNumber >= minRange && randomNumber <= maxRange)
                {
                    arrivalTime = TimeDistribution[i].Time;
                    break;
                }
            }
            return arrivalTime;
        }
    }
}
