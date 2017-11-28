using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public interface ITransformer
    {
        string ConvertHyperlink(string text, string url);

        string ConvertPlainText(string text);

        string ConvertToLaTeX(string text);
    }
}
