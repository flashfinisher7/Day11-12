using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonInventor
{
    class Inventor
    {
        public string name { get; set; }
        public double weight { get; set; }
        public double price { get; set; }
        public Inventor(string name, double weight, double price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }
    }
}
