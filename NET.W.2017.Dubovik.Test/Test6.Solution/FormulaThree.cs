using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public class FormulaThree : ICalculator<double>
    {
        public double Calculate(double current, double previous)
        {
            return current + previous / current;
        }
    }
}
