using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    class SimulationCaseOutput
    {
        public SimulationCaseOutput(SimulationCase simulationCase)
        {
            this.CustomerNumber = simulationCase.CustomerNumber;
            this.RandomInterArrival = simulationCase.RandomInterArrival;
            this.InterArrival = simulationCase.InterArrival;
            this.ArrivalTime = simulationCase.ArrivalTime;
            this.RandomService = simulationCase.RandomService;
            this.ServerID = simulationCase.AssignedServer.ID;
            this.StartTime = simulationCase.StartTime;
            this.ServiceTime = simulationCase.ServiceTime;
            this.EndTime = simulationCase.EndTime;
            this.TimeInQueue = simulationCase.TimeInQueue;
        }

        public int CustomerNumber { get; set; }
        public int RandomInterArrival { get; set; }
        public int InterArrival { get; set; }
        public int ArrivalTime { get; set; }
        public int RandomService { get; set; }
        public int ServerID { get; set; }
        public int StartTime { get; set; }
        public int ServiceTime { get; set; }
        public int EndTime { get; set; }
        public int TimeInQueue { get; set; }
    }
}
