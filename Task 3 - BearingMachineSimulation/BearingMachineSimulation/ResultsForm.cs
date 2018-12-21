using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineModels;

namespace BearingMachineSimulation
{
    public partial class ResultsForm : Form
    {
        private SimulationSystem _simulationSystem;
        public ResultsForm(SimulationSystem simulationSystem)
        {
            InitializeComponent();
            _simulationSystem = simulationSystem;
        }

        private void InitCurrentSimulationData(List<CurrentSimulationCase> currentSimulationCases)
        {
            foreach (var currentSimulationCase in currentSimulationCases)
            {
                CS_data.Rows.Add(currentSimulationCase.Bearing.Index, currentSimulationCase.Bearing.RandomHours, currentSimulationCase.Bearing.Hours, currentSimulationCase.AccumulatedHours, currentSimulationCase.RandomDelay, currentSimulationCase.Delay);
            }
        }

        private void InitProposedSimulationView(List<ProposedSimulationCase> proposedSimulationCases)
        {
            PS_view.Nodes.Clear();
            foreach (var proposedSimulationCase in proposedSimulationCases)
            {
                TreeNode caseNode = new TreeNode("Proposed Simulation Case");
                TreeNode bearingsNode = new TreeNode("Bearings");
                foreach (var bearing in proposedSimulationCase.Bearings)
                {
                    TreeNode bearingNode = new TreeNode("Bearing Index = " + bearing.Index);
                    bearingNode.Nodes.Add(new TreeNode("Random Hours = " + bearing.RandomHours));
                    bearingNode.Nodes.Add(new TreeNode("Hours = " + bearing.Hours));
                    bearingsNode.Nodes.Add(bearingNode);
                }
                caseNode.Nodes.Add(bearingsNode);
                caseNode.Nodes.Add(new TreeNode("First Failure = " + proposedSimulationCase.FirstFailure));
                caseNode.Nodes.Add(new TreeNode("Accumulated Hours = " + proposedSimulationCase.AccumulatedHours));
                caseNode.Nodes.Add(new TreeNode("Random Delay = " + proposedSimulationCase.RandomDelay));
                caseNode.Nodes.Add(new TreeNode("Delay = " + proposedSimulationCase.Delay));

                PS_view.Nodes.Add(caseNode);
            }
        }

        private void InitCurrentSystemPerformance(PerformanceMeasures csMeasures)
        {
            CS_BC_numeric.Value = csMeasures.BearingCost;
            CS_DC_numeric.Value = csMeasures.DelayCost;
            CS_DTC_numeric.Value = csMeasures.DowntimeCost;
            CS_RPC_numeric.Value = csMeasures.RepairPersonCost;
            CS_TC_numeric.Value = csMeasures.TotalCost;
        }

        private void InitProposedSystemPerformance(PerformanceMeasures psMeasures)
        {
            PS_BC_numeric.Value = psMeasures.BearingCost;
            PS_DC_numeric.Value = psMeasures.DelayCost;
            PS_DTC_numeric.Value = psMeasures.DowntimeCost;
            PS_RPC_numeric.Value = psMeasures.RepairPersonCost;
            PS_TC_numeric.Value = psMeasures.TotalCost;
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            InitCurrentSimulationData(_simulationSystem.CurrentSimulationTable);
            InitProposedSimulationView(_simulationSystem.ProposedSimulationTable);
            InitCurrentSystemPerformance(_simulationSystem.CurrentPerformanceMeasures);
            InitProposedSystemPerformance(_simulationSystem.ProposedPerformanceMeasures);
        }
    }
}
