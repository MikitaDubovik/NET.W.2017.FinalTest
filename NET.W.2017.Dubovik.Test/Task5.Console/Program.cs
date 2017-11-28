namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5;

    class Program
    {
        static void Main(string[] args)
        {
            var hyperlinkTransformer = new HyperlinkTransformer();
            var laTeXTransformer = new LaTeXTransformer();
            var plainTextTransformer = new PlainTextTransformer();

            var parts = new List<DocumentPart>
            {
                new PlainText {Text = "Some plain text"},
                new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                new BoldText {Text = "Some bold text"}
            };

            var document = new Document(parts);

            Console.WriteLine(document.Convert(hyperlinkTransformer));

            Console.WriteLine(document.Convert(plainTextTransformer));

            Console.WriteLine(document.Convert(laTeXTransformer));

            Console.ReadLine();
        }
    }
}
