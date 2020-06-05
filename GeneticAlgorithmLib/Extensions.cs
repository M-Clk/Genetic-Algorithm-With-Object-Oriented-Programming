using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmLib
{
    public static class Extensions
    {
        public static double GetDouble(this Random rdm, double min, double max) => rdm.NextDouble() * (max - min) + min; //Random sinifinda olmayan metot ekledik.
    }
}
