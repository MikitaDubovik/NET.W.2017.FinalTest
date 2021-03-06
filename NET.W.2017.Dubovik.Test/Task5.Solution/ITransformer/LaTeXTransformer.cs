﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LaTeXTransformer : ITransformer
    {
        public string ConvertHyperlink(string text, string url) => "\\href{" + url + "}{" + text + "}";

        public string ConvertPlainText(string text) => text;

        public string ConvertToLaTeX( string text) => "\\textbf{" + text + "}";
    }
}
