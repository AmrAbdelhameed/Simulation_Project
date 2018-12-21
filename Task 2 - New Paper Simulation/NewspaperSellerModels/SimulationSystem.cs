using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }




        //OPERATION

        Enums.DayType GetDayType(int Entry)
        {
            Enums.DayType Out=new Enums.DayType();
            foreach (DayTypeDistribution DTD in DayTypeDistributions)
            {
                if (Entry<=DTD.MaxRange && Entry >= DTD.MinRange)
                {
                    Out = DTD.DayType;
                }
            }
            return Out;
        }

        List<DayTypeDistribution> GenerateDayTypeList(decimal a, decimal b, decimal c)
        {
            List<DayTypeDistribution> Out = new List<DayTypeDistribution>();

            string aStr = a.ToString().Replace("0.", "");
            string bStr = b.ToString().Replace("0.", "");
            string cStr = c.ToString().Replace("0.", "");

            decimal CurrentAccum = 0;

            decimal[] DeciVals = { a, b, c,1 };
            int[] Ranges = { 0, int.Parse(aStr), int.Parse(bStr), int.Parse(cStr) };
            int CurrentAccumInt = 0;

            for (int i = 0; i < 3; i++)
            {
                DayTypeDistribution DT = new DayTypeDistribution();
                DT.MinRange = CurrentAccumInt + 1;
                DT.MaxRange = CurrentAccumInt + Ranges[i + 1];
                CurrentAccumInt = DT.MaxRange;
                DT.DayType = (Enums.DayType)i;
                DT.Probability = DeciVals[i];
                CurrentAccum += DeciVals[i];
                DT.CummProbability = CurrentAccum;
                Out.Add(DT);
            }

            return Out;
        }

        public void FillDayTypeDistrubutions(string Entry)
        {
            string[] Values = Entry.Split(',');
            decimal a = Convert.ToDecimal(Values[0]);
            decimal b = Convert.ToDecimal(Values[1]);
            decimal c = Convert.ToDecimal(Values[2]);

            List<DayTypeDistribution> inList = GenerateDayTypeList(a, b, c);
            DayTypeDistributions = inList;
        }



        int GetDemand(int Entry,Enums.DayType DTE)
        {
            int Out = -1;
            foreach (DemandDistribution DD in DemandDistributions)
            {
                if (DD.DayTypeDistributions[(int)DTE].MaxRange>=Entry && DD.DayTypeDistributions[(int)DTE].MinRange<=Entry)
                {
                    Out = DD.Demand;
                    break;
                }
            }
            if (Out==-1)
            {
                throw new Exception("Warning demand distrubution didn't match any of the known ranges!");
            }
            return Out;
        }

        public string InputDayDistrubution
        {
            get
            {
                return "";
            }
            set
            {
                FillDayTypeDistrubutions(value);
            }
        }

        public string InputDemandDistrubution
        {
            get
            {
                return "";
            }
            set
            {
                FillDemandDistrubution(value);
            }
        }

        public void FillDemandDistrubution(string Entry)
        {
            List<int> DemandValues = new List<int>();
            List<List<int>> TableValues = new List<List<int>>();

            string[] Entries = Entry.Split(new string[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in Entries)
            {
                string curDemand = s.Split(',')[0];
                DemandValues.Add(Convert.ToInt32(curDemand));
                string Values = s.Replace(curDemand + ',', "");
                TableValues.Add(new List<int>()
                {
                    int.Parse(Values.Split(',')[0].Replace("0.","")),
                    int.Parse(Values.Split(',')[1].Replace("0.","")),
                    int.Parse(Values.Split(',')[2].Replace("0.","")),
                });
            }

            int[] Accumaltions = { 0, 0, 0 };

            for (int i=0;i<DemandValues.Count;i++)
            {
                DemandDistribution DDi = new DemandDistribution();
                DDi.Demand = DemandValues[i];

                for (int j=0;j<3;j++)
                {
                    DDi.DayTypeDistributions.Add(new DayTypeDistribution());
                    DDi.DayTypeDistributions.Last().MinRange = Accumaltions[j]+1;
                    if (DDi.DayTypeDistributions.Last().MinRange>100)
                    {
                        DDi.DayTypeDistributions.Last().MinRange = 100;
                    }
                    DDi.DayTypeDistributions.Last().DayType = (Enums.DayType)j;
                    Accumaltions[j] += TableValues[i][j];
                    DDi.DayTypeDistributions.Last().Probability = Convert.ToDecimal("0."+TableValues[i][j].ToString());
                    DDi.DayTypeDistributions.Last().MaxRange = Accumaltions[j];
                }
                DemandDistributions.Add(DDi);
            }
        }

        public void BeginSimulation()
        {
            Random R = new Random();
            for (int i=0;i<NumOfRecords;i++)
            {
                SimulationCase SC = new SimulationCase();
                SC.DayNo = i + 1;
                SC.RandomNewsDayType = R.Next(1, 100);
                SC.NewsDayType = GetDayType(SC.RandomNewsDayType);
                SC.RandomDemand = R.Next(1, 100);
                SC.Demand = GetDemand(SC.RandomDemand,SC.NewsDayType);


                SC.DailyCost = NumOfNewspapers * PurchasePrice;
                SC.SalesProfit = NumOfNewspapers * SellingPrice;
                decimal ProfitPerPiece = SellingPrice - PurchasePrice;

                if (SC.Demand>NumOfNewspapers)
                {
                    SC.LostProfit = (SC.Demand - NumOfNewspapers) * ProfitPerPiece;
                    SC.ScrapProfit = 0;
                }
                else if (SC.Demand<NumOfNewspapers)
                {
                    SC.ScrapProfit = (NumOfNewspapers - SC.Demand) * ScrapPrice;
                    SC.SalesProfit -= (NumOfNewspapers - SC.Demand) * SellingPrice;
                    SC.DailyNetProfit += SC.ScrapProfit;
                    SC.LostProfit = 0;
                }
                else
                {
                    SC.ScrapProfit = 0;
                    SC.LostProfit = 0;
                }
                SC.DailyNetProfit = SC.SalesProfit - SC.DailyCost - SC.LostProfit + SC.ScrapProfit;
                SimulationTable.Add(SC);
            }
            Resas();
        }

        void Resas()
        {
            PerformanceMeasures.DaysWithMoreDemand = 0;
            PerformanceMeasures.DaysWithUnsoldPapers = 0;
            PerformanceMeasures.TotalCost = 0;
            PerformanceMeasures.TotalLostProfit = 0;
            PerformanceMeasures.TotalSalesProfit = 0;
            PerformanceMeasures.TotalScrapProfit = 0;

            foreach (SimulationCase SCa in SimulationTable)
            {
                if (SCa.Demand > NumOfNewspapers)
                {
                    PerformanceMeasures.DaysWithMoreDemand++;
                }
                else if (SCa.Demand < NumOfNewspapers)
                {
                    PerformanceMeasures.DaysWithUnsoldPapers++;
                }
                
                PerformanceMeasures.TotalCost +=SCa.DailyCost;
                PerformanceMeasures.TotalLostProfit += SCa.LostProfit;
                PerformanceMeasures.TotalSalesProfit += SCa.SalesProfit;
                PerformanceMeasures.TotalScrapProfit += SCa.ScrapProfit;
                PerformanceMeasures.TotalNetProfit += SCa.DailyNetProfit;
            }
        }
    }
}
