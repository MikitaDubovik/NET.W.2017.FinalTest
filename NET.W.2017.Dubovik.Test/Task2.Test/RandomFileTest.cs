using System;
using Moq;
using NUnit.Framework;
using Task2.Solution;
using Task_2.Solution;

namespace Task2.Test
{
    [TestFixture]
    public class RandomFileTest
    { 

        [Test]
        public void RandomBytesFileGeneratorTest()
        {
            var generatorChars = new Mock<RandomCharsFileGenerator>();

            generatorChars.Object.GenerateFileContent(It.IsAny<int>());

            generatorChars.Verify(gener => gener.GenerateFileContent(It.IsAny<int>()), Times.Once());

            var generatorBytes = new Mock<RandomBytesFileGenerator>();

            generatorBytes.Object.GenerateFileContent(It.IsAny<int>());

            generatorBytes.Verify(gener => gener.GenerateFileContent(It.IsAny<int>()), Times.Once());
        }
    }
}
