using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock
    {
        public event EventHandler<StockInfoArgs> StocksInfo;

        public void Market()
        {
            var rnd = new Random();
            OnEvent(this, new StockInfoArgs(rnd.Next(0, 30), rnd.Next(40, 100)));
        }


        protected virtual void OnEvent(Stock stock, StockInfoArgs arg)
        {
            EventHandler<StockInfoArgs> temp = StocksInfo;
            temp?.Invoke(this, arg);
        }
    }
}
