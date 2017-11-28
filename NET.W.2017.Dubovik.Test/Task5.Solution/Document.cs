using System;
using System.Collections.Generic;

namespace Task5
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        private string ToNewFormat( Func<string> func)
        {
            return $"{func.Invoke()}\n";
        }

        public string ToHtml()
        {
            

            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += ToNewFormat(part.ToHtml);
            }

            return output;
        }

        public string ToPlainText()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += ToNewFormat(part.ToPlainText);
            }

            return output;
        }

        public string ToLaTeX()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += ToNewFormat(part.ToLaTeX);
            }

            return output;
        }
    }
}
