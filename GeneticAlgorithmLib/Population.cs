using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLib
{
    public class Population
    {
        public Population ParentPopulation { get; private set; }
        public Population ChildPopulation { get; private set; }
        public Chromosome BestSolution { get => Chromosomes.OrderBy(chromosome => chromosome.SurvivalRate).FirstOrDefault(); }
        private List<Chromosome> Chromosomes { get; set; } = new List<Chromosome>();
        private List<Chromosome> DistinguishedChromosomes { get => Chromosomes.OrderBy(chromosome => chromosome.SurvivalRate).Take(DistinguishedChromosomesCount).ToList(); } //Parametre kadar ilk en iyi kromozomlari getirir
        private static int DistinguishedChromosomesCount { get; set; } //static olanlar algoritma boyunca degismeyecek olanlar. Ayrica operator overloading islemlerinde kullanilacak ve child populasyon olustugunda bunlari set etmek icin kurucu metoda tekrar parametre olarak gondermeye gerek kalmaz.
        private static bool IsForMaximization { get; set; }
        internal static Random RandomValueGenerator { get; private set; }
        internal static int GenesCount { get; private set; }
        internal static int Size { get; private set; }
        internal static double CrossoverRate { get; private set; }
        internal static double MutationRate { get; private set; }
        public Population(int populationSize, double crossoverRate, double mutationRate, int distinguishedChromosomesCount, Random randomValueGenerator, bool isForMaximization = true)
        {
            if(distinguishedChromosomesCount >= populationSize)
                throw new InvalidOperationException("Seckinlik, populasyon buyuklugunden fazla ya da esit olamaz. Seckin kromozomlar bir sonraki nesile hicbir isleme tabi tutulmadan gececeginden dolayi seckinligin populasyon boyunu cok yakin olmasi onerilmez. Bu en iyi degeri bulmanizi zorlastiracaktir.");
            if(mutationRate < 0 || crossoverRate < 0)
                throw new InvalidOperationException("Duzgun oranlar girin. 0-1 araliginda olacak sekilde belirleyin.");
            IsForMaximization = isForMaximization;
            DistinguishedChromosomesCount = distinguishedChromosomesCount;
            RandomValueGenerator = randomValueGenerator;
            MutationRate = mutationRate;
            CrossoverRate = crossoverRate;
            Size = populationSize;
            GenesCount = 30;
            //Ilk populasyon oldugundan rastsal degerlerle cromozomlar olusacak ve gerekli degerler hesaplaniyor
            for(int i = 0; i < populationSize; i++)
                Chromosomes.Add(new Chromosome());
        }
        private Population(Population parentPopulation) //Populasyon turetildiginde cagriliyor seckin kromozomlari direk ekler
        {
            ParentPopulation = parentPopulation;
            if(DistinguishedChromosomesCount > 0)//parenti varsa child olusuyordur. Seckinlik duzeyine gore en iyileri caprazalama vs olmaksizin bir sonraki populasyonda olmasini saglar
                DistinguishedChromosomes.ForEach(chromosome=>ChildPopulation.Chromosomes.Add(new Chromosome(chromosome.Genes)));
        }
        public void CalculateSurvivalRateOfChromosomes() //Amac fonksiyonu sonuclarindan kurucu metoda gelen optimizasyon turu parametresine gore en iyisi olacak sekilde hayatta kalma oranini belirler
        {
            var totalFitnessFuntion = Chromosomes.Select(chromosome => IsForMaximization ? chromosome.FitnessFuntion : 1 / chromosome.FitnessFuntion);
            Chromosomes.ForEach(chromosome => chromosome.SurvivalRate = IsForMaximization ? chromosome.FitnessFuntion / totalFitnessFuntion.Sum() : (1 / chromosome.FitnessFuntion) / totalFitnessFuntion.Sum());
        }
        public void CalculateCumulativeRateOfChromosomes()//Rulet cemberi yontemi ile Kumulatif oranlari berirleniyor. Hayatta kalma orani yuksek olan daha buyuk bir dilime sahip olacagindan sonraki nesle aktarilma olasiligi daha yuksek olacak
        {
            double totalRate = 0;
            Chromosomes.OrderBy(chromosome => chromosome.SurvivalRate).ToList().ForEach(chromosome =>
            {
                totalRate += chromosome.SurvivalRate;
                chromosome.CumulativeRate = totalRate;
            });
        }
        private List<Chromosome> NaturalSelectChromosomesForCrossover()//Caprazlama oncesi caprazlanacak cromozomlarin caprazlama oranina gore secilerek caprazlanmak uzere gonderiliyor. Kumulatif orana gore listeye kromozomlar listeye aliniyor. Gucsuz olanlarin elendigi asama. Seckin kromozomlar dogal secilimden muhaf tutuluyor.
        {
            var toBeCrossoverChromosomes = new List<Chromosome>();
            var chromosomesWhitoutDistinguisheds = Chromosomes.Where(chromosome => !DistinguishedChromosomes.Contains(chromosome));
            for(int i = 0; i < chromosomesWhitoutDistinguisheds.Count(); i++)
                foreach(var chromosome in chromosomesWhitoutDistinguisheds.OrderBy(chromosome => chromosome.CumulativeRate))
                    if(chromosome.CumulativeRate >= RandomValueGenerator.NextDouble() && !toBeCrossoverChromosomes.Contains(chromosome))
                    {
                        toBeCrossoverChromosomes.Add(chromosome);
                        break;
                    }
            
            return toBeCrossoverChromosomes;
        }
        private List<Chromosome> ShuffleChromosomes(List<Chromosome> chromosomes) //Caprazlanacak kromozomlarin indexleri degistirilerek daha rastsal bir caprazlama yapmasini sagliyoruz.
        {
            for(int i = 0; i < chromosomes.Count; i++)
            {
                var tempChromosome = chromosomes[i];
                var randomIndex = RandomValueGenerator.Next(0, chromosomes.Count);
                chromosomes[i] = chromosomes[randomIndex];
                chromosomes[randomIndex] = tempChromosome;
            }
            return chromosomes;
        }

        public void CrossoverChildChromosomes() //Caprazalnacak listeden ikiser kromozom alarak rastgele bir caprazlama noktasi secip o noktanin sagindaki genleri degitiriyoruz. Boylece bu iki kromozom caprazlanmis oluyor. Bunlari bir sonraki populasyona ekliyoruz. 
        {
            var toBeCrossoverChromosomes = NaturalSelectChromosomesForCrossover();
            ChildPopulation = new Population(this);
            ChildPopulation.Chromosomes.AddRange(toBeCrossoverChromosomes);
            toBeCrossoverChromosomes = ShuffleChromosomes(toBeCrossoverChromosomes);

            for(int i = 0; i < toBeCrossoverChromosomes.Count-1; i = i + 2)
            {
                if(ChildPopulation.Chromosomes.Count >= Size - 1)
                    break;
                var crossoveredChromosomes = toBeCrossoverChromosomes[i] * toBeCrossoverChromosomes[i+1]; //Chromosome caprazlama icin * operatorunu overload ettim. Iki kromozomu caprazlayarak ortaya cikan yeni iki kromozomu liste olarak geri gonderiyor
                if(crossoveredChromosomes != null)
                    ChildPopulation.Chromosomes.AddRange(crossoveredChromosomes);
                else
                    ChildPopulation.Chromosomes.AddRange(new List<Chromosome> {toBeCrossoverChromosomes[i], toBeCrossoverChromosomes[i+1]});
            }
            if(ChildPopulation.Chromosomes.Count == Size - 1)//Eger caprazlanacak kromozomlarin sayisi tek ise biri disarda kalcagindan onu da rastgele secilen bir kromozomla caprazlanarak ekleniyor
            {
                var randomSelectedChromosome = toBeCrossoverChromosomes[RandomValueGenerator.Next(0, toBeCrossoverChromosomes.Count - 1)];
                var lastChromosome = toBeCrossoverChromosomes.LastOrDefault();
                var crossoverPoint = RandomValueGenerator.Next(0, GenesCount - 1);
                for(int j = crossoverPoint; j < GenesCount; j++)
                    lastChromosome.Genes[j] = randomSelectedChromosome.Genes[j];
                ChildPopulation.Chromosomes.Add(lastChromosome);
            }
        }

        public void MutationChildChromosomes() => ChildPopulation.Chromosomes.ForEach(chromosome => chromosome = ~chromosome);//Chromosome mutasyonu icin de ~ operatorunu overload ettim
        //Mutasyon oranina gore secilen kromozomun genleri -1,1 araliginda rastgele secilen bir sayi eklenerek degeri degistiriliyor.

    }
}
