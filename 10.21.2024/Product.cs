using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal abstract class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        

        protected Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{Name} {Price}");
        }
    }
}
