using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BearingMachineModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DelayTimeDistribution = new List<TimeDistribution>();
            BearingLifeDistribution = new List<TimeDistribution>();

            CurrentSimulationTable = new List<CurrentSimulationCase>();
            CurrentPerformanceMeasures = new PerformanceMeasures();

            ProposedSimulationTable = new List<ProposedSimulationCase>();
            ProposedPerformanceMeasures = new PerformanceMeasures();
        }
        
        ///////////// INPUTS /////////////
        public int DowntimeCost { get; set; }
        public int RepairPersonCost { get; set; }
        public int BearingCost { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfBearings { get; set; }
        public int RepairTimeForOneBearing { get; set; }
        public int RepairTimeForAllBearings { get; set; }
        public List<TimeDistribution> DelayTimeDistribution { get; set; }
        public List<TimeDistribution> BearingLifeDistribution { get; set; }

        ///////////// OUTPUTS /////////////
        public List<CurrentSimulationCase> CurrentSimulationTable { get; set; }
        public PerformanceMeasures CurrentPerformanceMeasures { get; set; }
        public List<ProposedSimulationCase> ProposedSimulationTable { get; set; }
        public PerformanceMeasures ProposedPerformanceMeasures { get; set; }


        ///////////// PROCESSING /////////////
        Random _bearingsRand;
        Random _delayRand;
        public const decimal Hour = 60;
        List<Bearing> _listOfRandomizedBearings;

        public List<TimeDistribution> CalculateDelayTimeDistribution(){
            _delayRand = new Random(DateTime.Now.Millisecond);
            decimal oldProb = 0;
            int maxRange = 0;

            foreach (var distribution in DelayTimeDistribution)
            {
                distribution.CummProbability = oldProb + distribution.Probability;
                oldProb = distribution.CummProbability;

                distribution.MinRange = maxRange + 1;

                maxRange = (int) (distribution.CummProbability * 100);
                distribution.MaxRange = maxRange;
            }
            return DelayTimeDistribution;
        }
        public List<TimeDistribution> CalculateBearingLifeDistribution(){
            _bearingsRand = new Random(DateTime.Now.Millisecond);
            decimal oldProb = 0;
            int maxRange = 0;

            foreach (var distribution in BearingLifeDistribution)
            {
                distribution.CummProbability = oldProb + distribution.Probability;
                oldProb = distribution.CummProbability;

                distribution.MinRange = maxRange + 1;

                maxRange = (int) (distribution.CummProbability * 100);
                distribution.MaxRange = maxRange;
            }
            return BearingLifeDistribution;
        }

        public int GetTime(int val, List<TimeDistribution> distributions)
        {
            return (from t in distributions where t.MinRange <= val && val <= t.MaxRange select t.Time).FirstOrDefault();
        }
        public int GetBearingRand(){
            return _bearingsRand.Next(1, 101);
        }
        public int GetDelayRand(){
            return _delayRand.Next(1, 101);
        }
        public void InitBearings(){
            _listOfRandomizedBearings = new List<Bearing>();
            int accumulativeTime = 0;
            while(accumulativeTime < NumberOfHours){
                int min = -1;
                for(int i = 0; i < NumberOfBearings; i++){
                    int randomHours = GetBearingRand();
                    int hours = GetTime(randomHours, BearingLifeDistribution);
                    int index = i;
                    Bearing ring = new Bearing();
                    ring.Index = index;
                    ring.RandomHours = randomHours;
                    ring.Hours = hours;
                    _listOfRandomizedBearings.Add(ring);
                    if(min == -1 || hours < min)
                        min = hours;
                }
                accumulativeTime += min;
            }
        }
        
        public List<CurrentSimulationCase> GenerateCurrentSimulationCase(){
            List<CurrentSimulationCase> ret = new List<CurrentSimulationCase>();
            for(int i = 0; i < NumberOfBearings; i++){

                int accumulateTime = 0;
                for(int j = 0; accumulateTime < NumberOfHours; j++){
                    Bearing ring = _listOfRandomizedBearings[j * NumberOfBearings + i];
                    int randomDelay = GetDelayRand();
                    int delay = GetTime(randomDelay,DelayTimeDistribution);
                    accumulateTime += ring.Hours;
                    CurrentSimulationCase cs = new CurrentSimulationCase();
                    cs.Bearing = ring;
                    cs.Delay = delay;
                    cs.RandomDelay = randomDelay;
                    cs.AccumulatedHours = accumulateTime;
                    ret.Add(cs);
                }

            }
            return ret;
        }
        public List<ProposedSimulationCase> GenerateProposedSimulationCase(){
            List<ProposedSimulationCase> ret = new List<ProposedSimulationCase>();
            int accumulativeTime = 0;
            for(int i = 0; i < _listOfRandomizedBearings.Count; i += NumberOfBearings){
                ProposedSimulationCase ps = new ProposedSimulationCase();
                int idx = 0;
                for(int j = i; j < i + NumberOfBearings; j++){
                    ps.Bearings.Add(_listOfRandomizedBearings[j]);
                    if(ps.Bearings[j-i].Hours < ps.Bearings[idx].Hours){
                        idx = j-i;
                    }
                }
                ps.FirstFailure = ps.Bearings[idx].Hours;
                accumulativeTime += ps.Bearings[idx].Hours;
                ps.AccumulatedHours = accumulativeTime;
                int randomDelay = GetDelayRand();
                int delay = GetTime(randomDelay,DelayTimeDistribution);
                ps.RandomDelay = randomDelay;
                ps.Delay = delay;
                ps.AccumulatedHours = accumulativeTime;
                ret.Add(ps);
            }
            return ret;
        }
        public PerformanceMeasures SolveCurrentSimulationCase(){
            decimal bearingReplacementCost = 0;
            decimal costOfDelayTime = 0;
            decimal costOfDownTime = 0;
            decimal costOfRepairPerson = 0;
            for(int i = 0; i < NumberOfBearings; i++){
                List<CurrentSimulationCase> thisCase = CurrentSimulationTable.FindAll(listElement => listElement.Bearing.Index == i);
                bearingReplacementCost += thisCase.Count * BearingCost;
                costOfDownTime += thisCase.Count * RepairTimeForOneBearing * DowntimeCost;
                int totalDelayTime = thisCase.Sum(listElement => listElement.Delay);
                costOfDelayTime += totalDelayTime * DowntimeCost;
                costOfRepairPerson += RepairTimeForOneBearing * thisCase.Count * RepairPersonCost / Hour;
            }

            PerformanceMeasures ret = new PerformanceMeasures
            {
                BearingCost = bearingReplacementCost,
                DelayCost = costOfDelayTime,
                DowntimeCost = costOfDownTime,
                RepairPersonCost = costOfRepairPerson
            };
            ret.TotalCost = ret.BearingCost + ret.DelayCost + ret.DowntimeCost + ret.RepairPersonCost;
            return ret;
        }
        public PerformanceMeasures SolveProposedSimulationCase(){
            decimal costOfBearingReplacement = ProposedSimulationTable.Count * BearingCost * NumberOfBearings;
            int totalDelayTime = 0;
            decimal costOfDownTime = ProposedSimulationTable.Count * RepairTimeForAllBearings * DowntimeCost;
            decimal costOfRepairPerson = ProposedSimulationTable.Count * RepairTimeForAllBearings * RepairPersonCost / Hour;
            foreach(ProposedSimulationCase listElement in ProposedSimulationTable){
                totalDelayTime += listElement.Delay;
            }
            decimal costOfDelayTime = totalDelayTime * DowntimeCost;
            PerformanceMeasures ret = new PerformanceMeasures
            {
                BearingCost = costOfBearingReplacement,
                DelayCost = costOfDelayTime,
                DowntimeCost = costOfDownTime,
                RepairPersonCost = costOfRepairPerson
            };
            ret.TotalCost = ret.BearingCost + ret.DelayCost + ret.DowntimeCost + ret.RepairPersonCost;
            return ret;
        }
    }
}
