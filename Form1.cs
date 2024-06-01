using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace test
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            geneticAlgorithm geneticAlgorithm = new geneticAlgorithm();

            int populationSize = Convert.ToInt32(textBox1.Text);
            double mutationRate = Convert.ToDouble(textBox3.Text);
            double crossoverRate = Convert.ToDouble(textBox2.Text);
            int generationCountInput = Convert.ToInt32(textBox5.Text);


            double[] result = geneticAlgorithm.start(populationSize, mutationRate, crossoverRate, generationCountInput);
            double[] listOfFitnessValues = geneticAlgorithm.fitnessedList;
            double[][] populationList = geneticAlgorithm.populationList;
            int generationCount = geneticAlgorithm.generationCountIndex;
            double bestFuncValue = geneticAlgorithm.bestFuncValue;

            label10.Text = bestFuncValue.ToString();
            label8.Text = result[0].ToString() + "," + result[1].ToString();
            label6.Text = ("Best Selection Pair in the Generation (Result of Minimization)(" + generationCount + ".)");
            label9.Text = "The Lowest Value Result of the Function";
            for (int i = 0; i < listOfFitnessValues.Length; i++)
            {
                functionResults.Items.Add(listOfFitnessValues[i]);
            }

            for (int j = 0; j < populationList.Length; j++)
            {
                this.populationList.Items.Add(populationList[j][0] + "," + populationList[j][1]);
            }

            chart1.ChartAreas.Add(new ChartArea("Convergence"));
            chart1.Series.Add(new Series("Best Fitness Value"));
            chart1.Series["Best Fitness Value"].ChartType = SeriesChartType.Line;
            for (int i = 0; i < listOfFitnessValues.Length; i++)
            {
                chart1.Series["Best Fitness Value"].Points.AddXY(i, listOfFitnessValues[i]);
            }

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();

            label10.Text = "";
            label8.Text = "";
            label6.Text = "";
            label9.Text = "";

            functionResults.Items.Clear();
            populationList.Items.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            button1.Enabled = true;
        }
    }
}