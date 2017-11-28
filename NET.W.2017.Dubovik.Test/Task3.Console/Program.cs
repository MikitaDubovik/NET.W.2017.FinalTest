using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank("NextBank");
            var broker = new Broker("OldBroker");

            var stock = new Stock();

            stock.StocksInfo += bank.Update;
            stock.StocksInfo += broker.Update;

            stock.Market();

            System.Console.ReadLine();
        }
    }
}
