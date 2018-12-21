using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BearingMachineModels;
using BearingMachineTesting;

namespace BearingMachineSimulation
{  
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            SimulationSystem ss = new SimulationSystem
            {
                DowntimeCost = (int) DC_numeric.Value,
                RepairPersonCost = (int) RPC_numeric.Value,
                BearingCost = (int) BC_numeric.Value,
                NumberOfHours = (int) NH_numeric.Value,
                NumberOfBearings = (int) NB_numeric.Value,
                RepairTimeForOneBearing = (int) RT1B_numeric.Value,
                RepairTimeForAllBearings = (int) RTAB_numeric.Value
            };
            int convertedTime;
            decimal convertedProbability;
            var DTD = DTD_textbox.Text.Split('\n');
            var BTD = BLD_textbox.Text.Split('\n');
            foreach (var dtd in DTD)
            {
                string[] spliced = dtd.Split(',');
                if (spliced.Length == 2 && int.TryParse(spliced[0], out convertedTime) &&  decimal.TryParse(spliced[1], out convertedProbability))
                {
                    ss.DelayTimeDistribution.Add( new TimeDistribution
                        {
                            Time = convertedTime, Probability = convertedProbability
                        });
                }
            }
            foreach (var btd in BTD)
            {
                var spliced = btd.Split(',');
                if (spliced.Length == 2 && int.TryParse(spliced[0], out convertedTime) &&  decimal.TryParse(spliced[1], out convertedProbability))
                {
                    ss.BearingLifeDistribution.Add( new TimeDistribution
                    {
                        Time = convertedTime, Probability = convertedProbability
                    });
                }
            }
            ss.CalculateBearingLifeDistribution();
            ss.CalculateDelayTimeDistribution();
            ss.InitBearings();
            ss.CurrentSimulationTable = ss.GenerateCurrentSimulationCase();
            ss.ProposedSimulationTable = ss.GenerateProposedSimulationCase();
            ss.CurrentPerformanceMeasures = ss.SolveCurrentSimulationCase();
            ss.ProposedPerformanceMeasures = ss.SolveProposedSimulationCase();
            if (File.Exists("TestCases\\" + TC_list.Text))
            {
                var testingResult = TestingManager.Test(ss, TC_list.Text);
                MessageBox.Show(testingResult);
                ResultsForm resultsForm = new ResultsForm(ss);
                resultsForm.ShowDialog(this);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TC_list.Items.Add(Constants.FileNames.TestCase1);
            TC_list.Items.Add(Constants.FileNames.TestCase2);
            TC_list.Items.Add(Constants.FileNames.TestCase3);
            TC_list.Items.Add(Constants.FileNames.TestCase4);
            TC_list.Items.Add(Constants.FileNames.TestCase5);
            TC_list.Items.Add(Constants.FileNames.TestCase6);
            TC_list.Items.Add(Constants.FileNames.TestCase7);
            TC_list.Items.Add(Constants.FileNames.TestCase8);
            TC_list.Items.Add(Constants.FileNames.TestCase9);
            TC_list.Items.Add(Constants.FileNames.TestCase10);
            TC_list.SelectedIndex = 0;
        }

        private void TC_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filename = "TestCases\\" + TC_list.Text;
            if (!File.Exists(filename)) return;
            var lines = File.ReadAllLines(filename).ToList();
            int conversionResult = 0;
            int.TryParse(lines[lines.IndexOf("DowntimeCost") + 1], out conversionResult);
            DC_numeric.Value = conversionResult;
            int.TryParse(lines[lines.IndexOf("RepairPersonCost") + 1], out conversionResult);
            RPC_numeric.Value = conversionResult;
            int.TryParse(lines[lines.IndexOf("BearingCost") + 1], out conversionResult);
            BC_numeric.Value = conversionResult;
            int.TryParse(lines[lines.IndexOf("NumberOfHours") + 1], out conversionResult);
            NH_numeric.Value = conversionResult;
            int.TryParse(lines[lines.IndexOf("NumberOfBearings") + 1], out conversionResult);
            NB_numeric.Value = conversionResult;
            int.TryParse(lines[lines.IndexOf("RepairTimeForOneBearing") + 1], out conversionResult);
            RT1B_numeric.Value = conversionResult;
            int.TryParse(lines[lines.IndexOf("RepairTimeForAllBearings") + 1], out conversionResult);
            RTAB_numeric.Value = conversionResult;
            { // DelayTimeDistribution
                var startIndex = lines.IndexOf("DelayTimeDistribution") + 1;
                DTD_textbox.Text = "";
                while (startIndex < lines.Count && !string.IsNullOrWhiteSpace(lines[startIndex]))
                {
                    DTD_textbox.Text += lines[startIndex] + Environment.NewLine;
                    startIndex++;
                }
            }
            { // BearingLifeDistribution
                var startIndex = lines.IndexOf("BearingLifeDistribution") + 1;
                BLD_textbox.Text = "";
                while (startIndex < lines.Count && !string.IsNullOrWhiteSpace(lines[startIndex]))
                {
                    BLD_textbox.Text += lines[startIndex] + Environment.NewLine;
                    startIndex++;
                }
            }
        }

        private void TCN_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory() + "\\TestCases\\"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK && fileDialog.SafeFileName != null)
            {
                TC_list.Items.Add(fileDialog.SafeFileName);
                TC_list.SelectedIndex = TC_list.Items.Count - 1;
            }
        }
    }
}
