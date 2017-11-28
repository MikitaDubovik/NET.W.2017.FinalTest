using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public class Generator
    {
        public static IEnumerable<T> Generate<T>(T a, T b, int count, Func<T, T, T> calculator)
        {
            if (count == 0)
                yield break;
            if (count >= 1)
            {
                yield return a;
            }
            if (count >= 2)
            {
                yield return b;
            }

            for (int i = 3; i < count; i++)
            {
                var temp = b;
                b = calculator(b, a);
                yield return b;
                a = temp;
            }
        }


        public static IEnumerable<T> Generate<T>( T a, T b, int count, ICalculator<T> calculator) =>
            Generate(a, b, count, calculator.Calculate);

    }
}
