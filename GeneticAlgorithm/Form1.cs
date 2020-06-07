using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneticAlgorithmLib;

namespace GeneticAlgorithm
{
    public partial class Form1 :Form
    {
        public int Iteration { get; set; }
        public double SuitabilityValue { get; set; }
        public Chromosome BestCromosome { get; set; }
        public Population LastPopulation { get; set; }
        public Population FirstPopulation { get; set; }

        public Random RandomValueGenerator { get; set; } = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(numBoyut.Value <= 0)
                    return;
                FirstPopulation = new Population((int)numBoyut.Value, (double)numCaprazlama.Value, (double)numMutasyon.Value, (int)numSeckinlik.Value, RandomValueGenerator, rdMaximization.Checked);
                LastPopulation = FirstPopulation;
                if(rdIterasyon.Checked)
                {
                    Iteration = (int)numJenerasyon.Value;
                    RunWithIteration();
                }
                else
                {
                    SuitabilityValue = (double)numJenerasyon.Value;
                    RunWithSuitabilityValue();
                }
                MessageBox.Show($"En iyi deger olarak {BestCromosome.FitnessFuntion.ToString("0.##")} bulundu. En iyi deger ve parametreler siralanacak.");
                FillChart();
                ShowFunctionParameters();
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Hata var: {exception.Message}");
            }
        }

        public Chromosome Run() //Genetik algoritmanin akis diyagramina gore adimlari sirayla uygular
        {
            LastPopulation.CalculateSurvivalRateOfChromosomes(); //Hayatta kalacaklari belirler. Amac fonksiyonu degerleri burda belirlenir.
            LastPopulation.CalculateCumulativeRateOfChromosomes();//Hayatta kalacak ya da olecek kromozomlari belirlemek icin her bir kromozoma hayatta kalma oranina gore kumulatif oran ver
            LastPopulation.CrossoverChildChromosomes();//Elenenlerin yerini doldurmak icin hayatta kalan kromozomlar arasinda caprazlama yapar
            LastPopulation.MutationChildChromosomes();//Mutasyona ugratir
            LastPopulation = LastPopulation.ChildPopulation;//Soyun devamliligini saglamak icin child populasyonu son populasyon olarak degistir.
            return LastPopulation.ParentPopulation.BestSolution; //Az once islem yapilan populasyondaki kromomlar arasinda amac fonksiyon degeri en iyi olanin degerini parametre olarak gonder. Uygunluk degeri kosulunda kazim amaca ulasildi mi ulasilmadi mi onu kontrol etmek icin lazim.
        }
        void RunWithIteration()//optimzasyon turune gore iterasyon sayısı kadar hesaplar.
        {
            BestCromosome = Run();
            while(--Iteration > 0)
            {
                var lastChromosome = Run();
                BestCromosome = (rdMaximization.Checked && lastChromosome.FitnessFuntion > BestCromosome.FitnessFuntion) || (rdMinimization.Checked && lastChromosome.FitnessFuntion < BestCromosome.FitnessFuntion) ? lastChromosome : BestCromosome;
            }
        }
        void RunWithSuitabilityValue()//optimzasyon turune gore uygunluk degerine ulasana kadar hesaplamaya devam eder.
        {
            var condition = rdMaximization.Checked ? (BestCromosome = Run()).FitnessFuntion < (double)numJenerasyon.Value : (BestCromosome = Run()).FitnessFuntion > (double)numJenerasyon.Value;
            while(condition)
                ;
        }

        void ShowFunctionParameters()//en iyi fonksiyonun parametrelerini gosterir.
        {
            if(BestCromosome == null)
                return;
            flwPnlParameters.Controls.Clear();

            for(int i = 0; i < BestCromosome.Genes.Count; i++)
            {
                var lblParameter = new Label { Text = $"x{i+1} = {BestCromosome.Genes[i].Value.ToString("0.##")}" };
                flwPnlParameters.Controls.Add(lblParameter);
            }
            lblEnIyiSonuc.Text = BestCromosome.FitnessFuntion.ToString("0.##");
        }

        void FillChart() //Son Populasyon uzerinden ilk populasyona kadar giderek butun amac fonksiyonu sonuclarini grafige doker
        {
            foreach(var series in chart1.Series)
                series.Points.Clear();
            var iteratorPopulation = FirstPopulation;
            var index = 0;
            do
            {
                chart1.Series[0].Points.AddXY(++index, iteratorPopulation.BestSolution.FitnessFuntion);
                chart1.Series[0].Points[index - 1].ToolTip = iteratorPopulation.BestSolution.FitnessFuntion.ToString("0.##");
                iteratorPopulation = iteratorPopulation.ChildPopulation;
            }
            while(iteratorPopulation.ChildPopulation != null);
        }

        private void rdIterasyon_CheckedChanged(object sender, EventArgs e)
        {
            if(rdIterasyon.Checked)
            {
                numJenerasyon.DecimalPlaces = 0;
                lblJenerasyon.Text = "Jenerasyon Sayısı";
            }
            else
            {
                numJenerasyon.DecimalPlaces = 2;
                lblJenerasyon.Text = "Uygunluk Değeri";
            }
        }
    }
}
