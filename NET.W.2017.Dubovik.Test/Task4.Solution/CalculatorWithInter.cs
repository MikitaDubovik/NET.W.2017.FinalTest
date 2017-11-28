using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class CalculatorWithInter
    {
        public double CalculateAverage(List<double> values, IDoubleCalculator averagingMethod)
        {
            return averagingMethod.Computing(values);
        }
    }
}
