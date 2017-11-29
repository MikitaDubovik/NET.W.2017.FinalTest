using System;
using Moq;
using NUnit.Framework;

namespace Task3.Tests
{
    [TestFixture]
    public class EventsTest
    {
        /// <summary>
        /// I've made event vitrual fo moq test
        /// </summary>
        [Test]
        public void UpdateMethodTest()
        {
            var bank = new Mock<Bank>("NextBank");
            var broker = new Mock<Broker>("OldBroker");

            var stock = new Mock<Stock>();

            stock.Raise(s => s.StocksInfo+=bank.Object.Update);
            stock.Raise(s => s.StocksInfo += broker.Object.Update);

        }
    }
}
