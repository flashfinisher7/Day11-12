using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProblem
{
    public class Stock
    {
        public int totalshare = 0;
        public int totalvalue = 0;
        public void Stockvalue(int a, int b, string c)
        {
            int stockvalue = a * b;
            Console.WriteLine("the value of the stock for" + c + " shares is :  " + stockvalue);
            totalvalue += (a * b);
            Console.WriteLine("the total value of the stock is  " + totalvalue);


        }
    }
}
