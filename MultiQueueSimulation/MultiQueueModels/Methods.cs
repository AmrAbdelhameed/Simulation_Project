using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Methods
    {
        public int GetServerPriorityMethod(SimulationSystem simulationSystem, int ArrivalTime, int serverPeriorty)
        {
            if (simulationSystem.Servers[serverPeriorty - 1].FinishTime <= ArrivalTime)
                return serverPeriorty - 1;
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
            Random rand1 = new Random();
            return rand1.Next(0, simulationSystem.Servers.Count);
        }

        public int GetServerNumberUtilizationMethod(SimulationSystem simulationSystem)
        {
            List<Tuple<int, decimal>> list = new List<Tuple<int, decimal>>();
            for (int i = 0; i < simulationSystem.Servers.Count; i++)
            {
                var tuple = new Tuple<int, decimal>(i, simulationSystem.Servers[i].TotalWorkingTime);
                list.Add(tuple);
            }
            list.Sort();
            return list[0].Item1;
        }

        public List<SimulationCase> CalculateMethod(SimulationSystem simulationSystem)
        {
            List<SimulationCase> Output = new List<SimulationCase>();
            SimulationCase simulationCase = new SimulationCase();
            int NumberOfCustomer = simulationSystem.StoppingNumber;
            int number = 1;
            Output.Add(simulationCase);

            Random rand = new Random();
            while (true)
            {
                simulationCase = new SimulationCase();
                simulationCase.CustomerNumber = number;
                if (simulationCase.CustomerNumber == 1)
                {
                    simulationCase.ArrivalTime = 0;
                }
                else
                {
                    simulationCase.RandomInterArrival = rand.Next(1, 101);
                    simulationCase.InterArrival = simulationSystem.getInterArrivalTimeByRandomRange(simulationCase.RandomInterArrival);
                    simulationCase.ArrivalTime = simulationCase.InterArrival + Output[Output.Count - 2].ArrivalTime;
                }
                int idx;
                if (simulationSystem.SelectionMethod == Enums.SelectionMethod.HighestPriority)
                {
                    idx = GetServerPriorityMethod(simulationSystem, simulationCase.ArrivalTime, simulationSystem.ServerPeriorty);
                }
                else if (simulationSystem.SelectionMethod == Enums.SelectionMethod.Random)
                {
                    idx = GetServerRandomMethod(simulationSystem, simulationCase.ArrivalTime);
                }
                else
                {
                    idx = GetServerNumberUtilizationMethod(simulationSystem);
                }
                simulationCase.RandomService = rand.Next(1, 101);
                simulationCase.StartTime = Math.Max(simulationSystem.Servers[idx].FinishTime, simulationCase.ArrivalTime);
                simulationCase.ServiceTime = simulationSystem.Servers[idx].getServiceTimeByRandomRange(simulationCase.RandomService);
                simulationCase.EndTime = simulationCase.StartTime + simulationCase.ServiceTime;
                simulationCase.AssignedServer = simulationSystem.Servers[idx];
                simulationSystem.Servers[idx].FinishTime = simulationCase.EndTime;
                simulationSystem.Servers[idx].TotalWorkingTime += simulationCase.ServiceTime;
                simulationSystem.Servers[idx].Idle += Math.Abs(simulationSystem.Servers[idx].FinishTime-simulationCase.ArrivalTime);
                simulationSystem.Servers[idx].Customer ++;
                simulationSystem.ToatalRun += simulationCase.ServiceTime;
                simulationCase.TimeInQueue = simulationCase.StartTime - simulationCase.ArrivalTime;
                if (simulationSystem.StoppingCriteria == Enums.StoppingCriteria.SimulationEndTime)
                {
                    if (simulationSystem.Servers[idx].FinishTime > simulationSystem.StoppingNumber)
                        break;
                    if (number == NumberOfCustomer)
                        break;
                }
                else
                {
                    if (number == NumberOfCustomer)
                        break;
                }
                number++;
                Output.Add(simulationCase);
            }
            return Output;
        }
    }
}
