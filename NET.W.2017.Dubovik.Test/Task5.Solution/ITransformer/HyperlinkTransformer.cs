using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class HyperlinkTransformer : ITransformer
    {
        public string ConvertHyperlink(string text, string url) => "<a href=\"" + url + "\">" + text + "</a>";

        public string ConvertPlainText(string text) => text;

        public string ToLaTeX(string text) => "<b>" + text + "</b>";

    }
}
