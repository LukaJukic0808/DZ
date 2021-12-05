using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public class UniformGenerator:IRandomGenerator
    {
        private Random generator;

        public UniformGenerator(Random generator)
        {
            this.generator = generator;
        }
        public double GenerateDouble(double lowerBound,double upperBound)
        {
            return generator.NextDouble() * (upperBound - lowerBound) + lowerBound; 
        }
    }
}
