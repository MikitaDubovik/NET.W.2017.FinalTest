using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class CalculatorWithDele
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> averagingMethod) => averagingMethod(values);
    }
}
