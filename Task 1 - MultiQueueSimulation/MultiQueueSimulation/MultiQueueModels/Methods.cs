using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Methods
    {
        public int GetServerPriorityMethod(SimulationSystem simulationSystem, int ArrivalTime)
        {
            if (simulationSystem.Servers[0].FinishTime <= ArrivalTime)
                return  0;
            int min = 1000000000, idx = -1;
            for (int i = 0; i < simulationSystem.Servers.Count; i++)
            {
                if (simulationSystem.Servers[i].FinishTime <= ArrivalTime)
                    return i;
                if (simulationSystem.Servers[i].FinishTime < min)
                {
                    min = simulationSystem.Servers[i].FinishTime;
                    idx = i;
                }
            }
            return idx;
        }

        public int GetServerRandomMethod(SimulationSystem simulationSystem, int ArrivalTime)
        {
            List<int> idleServers = new List<int>();
            for (int i = 0; i < simulationSystem.Servers.Count; i++)
            {
                if (simulationSystem.Servers[i].FinishTime <= ArrivalTime)
                    idleServers.Add(i);
            }
            if (idleServers.Count != 0)
            {
                Random rand = new Random();
                return idleServers[rand.Next(0, idleServers.Count)];
            }

            int min = 1000000000;
            for (int i = 0; i < simulationSystem.Servers.Count; i++)
            {
                if (simulationSystem.Servers[i].FinishTime < min)
                {
                    min = simulationSystem.Servers[i].FinishTime;
                }
            }
            idleServers.Clear();
            
            for (int i = 0; i < simulationSystem.Servers.Count; i++)
            {
                if (simulationSystem.Servers[i].FinishTime == min)
                {
                    idleServers.Add(i);
                }
            }
            Random rand1 = new Random();
            return idleServers[rand1.Next(0, idleServers.Count)];
        }

        public int GetServerUtilizationMethod(SimulationSystem simulationSystem)
        {
            List<Tuple<decimal,int>> list = new List<Tuple<decimal,int>>();
            for (int i = 0; i < simulationSystem.Servers.Count; i++)
            {
                var tuple = new Tuple<decimal,int>(simulationSystem.Servers[i].TotalWorkingTime,i);
                list.Add(tuple);
            }
            list.Sort();
            int idx = list[0].Item2,mn=100000000;
            for (int i = 0; i < simulationSystem.Servers.Count; i++)
            {
                if(simulationSystem.Servers[i].TotalWorkingTime== list[0].Item1)
                {
                    if(simulationSystem.Servers[i].Customer<mn)
                    {
                        mn =(int) simulationSystem.Servers[i].Customer;
                        idx = i;
                    }
                }
            }
           // return idx;
            return list[0].Item2;
        }

        public List<SimulationCase> CalculateMethod(SimulationSystem simulationSystem)
        {
            List<SimulationCase> Output = new List<SimulationCase>();
            SimulationCase simulationCase = new SimulationCase();
            int NumberOfCustomer = simulationSystem.StoppingNumber;
            int number = 1;
            Random rand = new Random();
            Queue<int> q = new Queue<int>();
            while (true)
            {
                simulationCase = new SimulationCase();
                simulationCase.CustomerNumber = number;
                if (simulationCase.CustomerNumber == 1)
                {
                    simulationCase.RandomInterArrival = rand.Next(1, 101);
                    simulationCase.InterArrival = 0;
                    simulationCase.ArrivalTime = 0;
                }
                else
                {
                    simulationCase.RandomInterArrival = rand.Next(1, 101);
                    simulationCase.InterArrival = simulationSystem.getInterArrivalTimeByRandomRange(simulationCase.RandomInterArrival);
                    simulationCase.ArrivalTime = simulationCase.InterArrival + Output[Output.Count - 1].ArrivalTime;
                }
                int idx;
                if (simulationSystem.SelectionMethod == Enums.SelectionMethod.HighestPriority)
                {
                    idx = GetServerPriorityMethod(simulationSystem, simulationCase.ArrivalTime);
                }
                else if (simulationSystem.SelectionMethod == Enums.SelectionMethod.Random)
                {
                    idx = GetServerRandomMethod(simulationSystem, simulationCase.ArrivalTime);
                }
                else
                {
                    idx = GetServerUtilizationMethod(simulationSystem);
                }
                simulationSystem.PerformanceMeasures.MaxQueueLength = Math.Max(simulationSystem.PerformanceMeasures.MaxQueueLength, q.Count());
                while (q.Count > 0)
                {
                    if (q.Peek() <= simulationCase.ArrivalTime)
                        q.Dequeue();
                    else
                        break;
                }
                if (simulationSystem.Servers[idx].FinishTime == 0)
                    simulationCase.StartTime = simulationCase.ArrivalTime;
                else
                    simulationCase.StartTime = Math.Max(simulationSystem.Servers[idx].FinishTime, simulationCase.ArrivalTime);
                simulationCase.RandomService = rand.Next(1, 101);
                simulationCase.ServiceTime = simulationSystem.Servers[idx].getServiceTimeByRandomRange(simulationCase.RandomService);
                simulationCase.EndTime = simulationCase.StartTime + simulationCase.ServiceTime;
                simulationCase.AssignedServer = simulationSystem.Servers[idx];

                if (simulationSystem.StoppingCriteria == Enums.StoppingCriteria.SimulationEndTime)
                {
                    if (simulationCase.ArrivalTime >= simulationSystem.StoppingNumber)
                        break;
                }
                simulationSystem.Servers[idx].FinishTime = simulationCase.EndTime;
                simulationSystem.Servers[idx].TotalWorkingTime += simulationCase.ServiceTime;
                simulationSystem.Servers[idx].Customer++;
                simulationCase.TimeInQueue = Math.Abs(simulationCase.StartTime - simulationCase.ArrivalTime);
                simulationSystem.Servers[idx].BusyTime.Add(new Tuple<int, int>(simulationCase.StartTime, simulationCase.EndTime));
                if (simulationCase.TimeInQueue > 0)
                    q.Enqueue(simulationCase.StartTime);
                if (number == NumberOfCustomer)
                {
                    Output.Add(simulationCase);
                    break;
                }
                number++;
                Output.Add(simulationCase);
            }
            return Output;
        }
    }
}
