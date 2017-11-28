using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class StockInfoArgs : EventArgs
    {
        public StockInfoArgs(int usd, int euro)
        {
            USD = usd;
            Euro = euro;
        }

        public int USD { get; set; }
        public int Euro { get; set; }
    }
}
