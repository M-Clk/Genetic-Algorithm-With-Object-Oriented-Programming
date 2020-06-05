using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GeneticAlgorithmLib
{
    public class Chromosome
    {
        public List<Gene> Genes { get; set; } = new List<Gene>();
        public double FitnessFuntion { get; private set; } = 0;
        public double SurvivalRate { get; set; }
        public double CumulativeRate { get; set; }
        public Chromosome() //Kromozom ilk olustugunda populasyonda belirtildigi kadar genlere sahip bir sekilde olusturuluyor.
        {
            for(int i = 0; i < Population.GenesCount; i++)
                Genes.Add(new Gene());
            CalculateFittnesFuntion();
        }
        public Chromosome(List<Gene> genes) //Caprazlama yapildiginda yeni kromozom olusturmak icin sadece bu metot taraginda kullanilabilir
        {
            foreach(var gene in genes)
                Genes.Add(new Gene(gene.Value));
            CalculateFittnesFuntion();
        }
        private void CalculateFittnesFuntion() //Fonksiyonun parametre olarak gen degerlerini aldiktan sonra cikti Fitness function olarak kaydedilmektedir.
        {
            for(int i = 0; i < Genes.Count - 1; i++)
                FitnessFuntion += 100 * Math.Pow((Genes[i + 1].Value - Math.Pow(Genes[i].Value, 2)), 2) + Math.Pow((Genes[i].Value - 1), 2);
        }
        public static List<Chromosome> operator *(Chromosome firstParent, Chromosome secondParent)//Iki kromozomu caplrazlayarak yeni iki kromozom olusturur.
        {
            if(Population.CrossoverRate < Population.RandomValueGenerator.NextDouble())
                return null;
            var crossoverPoint = Population.RandomValueGenerator.Next(1, Population.GenesCount - 1);
            var genesFromFirstParent1 = firstParent.Genes.Take(crossoverPoint).ToList();
            var genesFromSecondParent1 = secondParent.Genes.Take(crossoverPoint).ToList();
            var genesFromFirstParent2 = new List<Gene>();
            var genesFromSecondParent2 = new List<Gene>();
            for(int j = crossoverPoint; j < Population.GenesCount; j++)
            {
                genesFromFirstParent2.Add(firstParent.Genes[j]);
                genesFromSecondParent2.Add(secondParent.Genes[j]);
            }
            return new List<Chromosome> { new Chromosome(genesFromFirstParent1.Concat(genesFromSecondParent2).ToList()), new Chromosome(genesFromSecondParent1.Concat(genesFromFirstParent2).ToList()) };
        }
        public static Chromosome operator ~(Chromosome chromosome) //Kromozomu mutasyona ugratir. degerini bir miktar degistirir.
        {
            for(int i = 0; i < chromosome.Genes.Count; i++)
            {
                if(Population.MutationRate < Population.RandomValueGenerator.NextDouble())
                    break;
                var rdmPlus = Population.RandomValueGenerator.GetDouble(-1, 1);
                var geneValue = chromosome.Genes[i].Value + rdmPlus * (chromosome.Genes[i].UpperLimit - chromosome.Genes[i].LowerLimit);
                chromosome.Genes[i] = new Gene(geneValue);
            }
            return chromosome;
        }
    }

}
