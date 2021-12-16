using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public interface IRandomGenerator
    {
        double GenerateDouble(double lowerBound, double upperBound);
    }
}
