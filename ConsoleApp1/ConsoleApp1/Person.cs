using ConsoleApp2.enums
using ConsoleApp2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public int No { get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }
        private int _price;
        public int Price
        {
            get
            { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new PriceMustBeGreaterThanZeroException("qiymet 0 dan kicik ola bilmez");
                }
                else
                {
                    _price = value;
                }

            }
        }
        




    }
}

