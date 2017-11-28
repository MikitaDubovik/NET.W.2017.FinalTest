using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public class FormulaOne : ICalculator<int>
    {
        public int Calculate(int current, int previous) => current + previous;

    }
}
