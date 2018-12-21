using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTesting;
using InventoryModels;

namespace InventorySimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"D:\_FCIS\Sna 4\Semester 1\Modeling _ simulation\Simulation_Project\Task 4 - InventorySimulation\InventorySimulation\TestCases\TestCase1.txt";
            SimulationSystem simulationSystem = new SimulationSystem();
            simulationSystem.Run(path);
            dataGridView1.DataSource = simulationSystem.SimulationTable;
            EndingInventoryAverage.Text = "Ending Inventory Average: " + simulationSystem.PerformanceMeasures.EndingInventoryAverage.ToString();
            ShortageQuantityAverage.Text = "Shortage Quantity Average: " + simulationSystem.PerformanceMeasures.ShortageQuantityAverage.ToString();

            string testingResult = TestingManager.Test(simulationSystem, Constants.FileNames.TestCase1);
            MessageBox.Show(testingResult);
        }
    }
}
