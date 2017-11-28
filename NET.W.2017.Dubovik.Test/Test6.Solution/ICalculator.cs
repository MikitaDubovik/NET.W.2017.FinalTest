using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public interface ICalculator<T>
    {
        T Calculate(T current, T previous);
    }
}
