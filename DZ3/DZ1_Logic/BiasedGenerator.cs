using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public class BiasedGenerator:IRandomGenerator
    {
        private Random generator;

        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double GenerateDouble(double lowerBound,double upperBound)
        {
            int c = generator.Next(1, 4);
            
            if (c!=3)
                return generator.NextDouble() * ((upperBound+lowerBound) / 2 - lowerBound) + lowerBound;
            else
                return generator.NextDouble() * (upperBound - (upperBound+lowerBound) / 2) + (upperBound+lowerBound) / 2;
        }
    }
}
