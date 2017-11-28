using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class ComputingDoubleMean : IDoubleCalculator
    {
        public double Computing(List<double> values) => values.Sum() / values.Count;
    }
}
