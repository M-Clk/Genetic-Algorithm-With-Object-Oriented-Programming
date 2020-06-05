using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLib
{
    public class Gene
    {
        public double Value { get; private set; }
        public int LowerLimit { get; private set; } = -30;
        public int UpperLimit { get; private set; } = 30;
        public Gene()
        {
            Value = Population.RandomValueGenerator.GetDouble(LowerLimit, UpperLimit);
        }
        public Gene(double value)
        {
            Value = value > UpperLimit ? UpperLimit : value < LowerLimit ? LowerLimit : value;
        }
    }
}
