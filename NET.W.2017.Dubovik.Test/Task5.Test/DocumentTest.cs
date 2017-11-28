using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace Task5.Test
{
    [TestFixture]
    public class DocumentTest
    {
        [Test]
        public void TransformerTest()
        {
            var transformer = new Mock<ITransformer>();

            var parts = new List<DocumentPart>
            {
                new PlainText { Text = "Some plain text" },
                new Hyperlink { Text = "google.com", Url = "https://www.google.by/" },
                new BoldText { Text = "Some bold text" }
            };

            var document = new Document(parts);

            document.Convert(transformer.Object);

            transformer.Verify(transform=>transform.ConvertPlainText(It.IsAny<string>()), Times.Once);

            transformer.Verify(visitor => visitor.ConvertPlainText(It.IsAny<string>()), Times.Once);
            transformer.Verify(visitor => visitor.ConvertHyperlink(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
            transformer.Verify(visitor => visitor.ConvertToLaTeX(It.IsAny<string>()), Times.Once);


        }
    }
}
