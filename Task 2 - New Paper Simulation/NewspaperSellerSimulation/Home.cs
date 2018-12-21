using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NewspaperSellerTesting;
using NewspaperSellerModels;
using System.Text.RegularExpressions;

namespace NewspaperSellerSimulation
{
    public partial class Home : Form
    {

        Dictionary<string, TextBox> TextBoxes = new Dictionary<string, TextBox>();
        List<List<TextBox>> DemandDistrubutions = new List<List<TextBox>>();

        string DirCase="";

        bool Imported = false;
        public SimulationSystem ReadTestCase(string CaseFileName)
        {
            SimulationSystem SS = new SimulationSystem();

            List<string> Keys = new List<string>()
            {
                "NumOfNewspapers","NumOfRecords","PurchasePrice","ScrapPrice","SellingPrice","DayTypeDistributions","DemandDistributions"
            };

            Hashtable Refrence = new Hashtable()
            {
                {"NumOfNewspapers",SS.InputDemandDistrubution  },
                {"NumOfRecords",SS.NumOfRecords },
                {"PurchasePrice",SS.PurchasePrice },
                {"ScrapPrice",SS.ScrapPrice },
                {"SellingPrice",SS.SellingPrice },
                {"DayTypeDistributions",SS.InputDayDistrubution },
                {"DemandDistributions",SS.InputDemandDistrubution }
            };

            string Redirect = Environment.CurrentDirectory;
            Environment.CurrentDirectory = Environment.CurrentDirectory.Replace(@"\bin\Debug", @"\TestCases");
            string Input = File.ReadAllText(CaseFileName);
            Environment.CurrentDirectory = Redirect;

            string[] Pairs = Input.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string S in Pairs)
            {
                string[] pairData = S.Split(new string[] { "\r\n" },2,StringSplitOptions.RemoveEmptyEntries);
                Refrence[pairData[0]] = Convert.ChangeType((pairData[1]), Refrence[pairData[0]].GetType());
            }

            SS.NumOfNewspapers = Convert.ToInt32(Refrence[Keys[0]]);
            SS.NumOfRecords = Convert.ToInt32(Refrence[Keys[1]]);
            SS.PurchasePrice = Convert.ToDecimal(Refrence[Keys[2]]);
            SS.ScrapPrice = Convert.ToDecimal(Refrence[Keys[3]]);
            SS.SellingPrice = Convert.ToDecimal(Refrence[Keys[4]]);
            SS.InputDayDistrubution = Convert.ToString(Refrence[Keys[5]]);
            SS.InputDemandDistrubution = Convert.ToString(Refrence[Keys[6]]);

            return SS;

        }

        public Home(string Args)
        {
            InitializeComponent();
            

        }

        public Home()
        {
            InitializeComponent();



        }


        void FormulateFormView(SimulationSystem SS)
        {
            TextBoxes["Number of NewsPapers"].Text = SS.NumOfNewspapers.ToString();
            TextBoxes["Number Of Records"].Text = SS.NumOfRecords.ToString();
            TextBoxes["Purchase Price"].Text = SS.PurchasePrice.ToString();
            TextBoxes["Scrap Price"].Text = SS.ScrapPrice.ToString();
            TextBoxes["SellingPrice"].Text = SS.SellingPrice.ToString();
            TextBoxes["Good Distrubtion"].Text = SS.DayTypeDistributions[0].Probability.ToString();
            TextBoxes["Fair Distrubtion"].Text = SS.DayTypeDistributions[1].Probability.ToString();
            TextBoxes["Poor Distrubtion"].Text = SS.DayTypeDistributions[2].Probability.ToString();

            DemandGridView.DataSource = null;

            foreach (DemandDistribution DD in SS.DemandDistributions)
            {
                DataGridViewRow DVR = new DataGridViewRow();

                DVR.CreateCells(DemandGridView);

                DVR.Cells[0].Value = DD.Demand;
                DVR.Cells[1].Value = DD.DayTypeDistributions[0].Probability;
                DVR.Cells[2].Value = DD.DayTypeDistributions[1].Probability;
                DVR.Cells[3].Value = DD.DayTypeDistributions[2].Probability;
                DemandGridView.Rows.Add(DVR);
            }
            DemandGridView.Refresh();
        }
        SimulationSystem FormulateSimulattor()
        {
            SimulationSystem SS = new SimulationSystem();
            SS.NumOfNewspapers = int.Parse(TextBoxes["Number of NewsPapers"].Text);
            SS.NumOfRecords = int.Parse(Text = TextBoxes["Number Of Records"].Text);
            SS.PurchasePrice = Convert.ToDecimal(TextBoxes["Purchase Price"].Text);
            SS.ScrapPrice = Convert.ToDecimal(TextBoxes["Scrap Price"].Text);
            SS.SellingPrice = Convert.ToDecimal(TextBoxes["SellingPrice"].Text);
            SS.InputDayDistrubution = TextBoxes["Good Distrubtion"].Text + ", "
                                    + TextBoxes["Fair Distrubtion"].Text + ", "
                                    + TextBoxes["Poor Distrubtion"].Text;

            string Accu = "";

            foreach (DataGridViewRow DC in DemandGridView.Rows)
            {
                if (DC.Cells[0].Value==null)
                {
                    break;
                }
                Accu += DC.Cells[0].Value + ", ";
                Accu += DC.Cells[1].Value + ", ";
                Accu += DC.Cells[2].Value + ", ";
                Accu += DC.Cells[3].Value + "\r\n";
            }

            SS.InputDemandDistrubution=Accu;
            return SS;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            TextBoxes.Add("Number of NewsPapers", new TextBox());
            TextBoxes.Add("Number Of Records", new TextBox());
            TextBoxes.Add("Purchase Price", new TextBox());
            TextBoxes.Add("Scrap Price", new TextBox());
            TextBoxes.Add("SellingPrice", new TextBox());

            int currentHeight = 74;

            foreach (KeyValuePair<string,TextBox> KVP in TextBoxes)
            {
                Label temp = new Label();
                temp.Width = 240;
                temp.Text = KVP.Key;
                temp.Location = new Point(8, currentHeight);
                currentHeight += 23;
                KVP.Value.Width = 240;
                webPanel.Controls.Add(temp);
                temp.Show();
                KVP.Value.Location = new Point(8, currentHeight);
                webPanel.Controls.Add(KVP.Value);
                KVP.Value.Show();
                currentHeight += 36;
            }

            TextBoxes.Add("Good Distrubtion",new TextBox());
            TextBoxes.Add("Fair Distrubtion", new TextBox());
            TextBoxes.Add("Poor Distrubtion", new TextBox());

            Label Dayslbl = new Label();
            Dayslbl.Text = "Day type Distrubution\n\n                        Good                   Fair                    Poor";
            Dayslbl.Location = new Point(8, currentHeight);
            Dayslbl.Size = new Size(280, 40);
            webPanel.Controls.Add(Dayslbl);
            Dayslbl.Show();

            currentHeight += 23;
            currentHeight += 23;

            TextBoxes["Good Distrubtion"].Width = 30;
            TextBoxes["Fair Distrubtion"].Width = 30;
            TextBoxes["Poor Distrubtion"].Width = 30;

            TextBoxes["Good Distrubtion"].Location = new Point(80, currentHeight);
            TextBoxes["Fair Distrubtion"].Location = new Point(160, currentHeight);
            TextBoxes["Poor Distrubtion"].Location = new Point(240, currentHeight);

            webPanel.Controls.Add(TextBoxes["Good Distrubtion"]);
            webPanel.Controls.Add(TextBoxes["Fair Distrubtion"]);
            webPanel.Controls.Add(TextBoxes["Poor Distrubtion"]);

            currentHeight += 56;

            DemandDistrubutions = new List<List<TextBox>>();

            Label Demandlbl = new Label();
            Demandlbl.Text = "";
            Demandlbl.Location = new Point(8, currentHeight);
            Demandlbl.Size = new Size(280, 40);
            webPanel.Controls.Add(Demandlbl);
            Dayslbl.Show();
            

            Label GridTitle = new Label();
            DataGridView DGV = new DataGridView();
            DGV.BackgroundColor = Color.White;


        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            SimulationSystem SS=new SimulationSystem();

            if (!Imported)
               SS = FormulateSimulattor();
            else
               SS = ReadTestCase(DirCase);


            SS.BeginSimulation();


            //string TestRes = TestingManager.Test(SS, Constants.FileNames.TestCase1);
            //MessageBox.Show(TestRes);

            this.Text = "News Paper Problem - Home";
            SimulationTable ST = new SimulationTable(SS);
            ST.Show();

        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = Environment.CurrentDirectory;
            OFD.Multiselect = false;
            OFD.Filter = "Text Files|*.txt";
            if (OFD.ShowDialog()==DialogResult.OK)
            {
                //Imported = true;
                DirCase = OFD.FileName;
                SimulationSystem SS = ReadTestCase(DirCase);
                FormulateFormView(SS);
            }
            
        }
    }
}
