using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Journal : Product
    {
        
        public string Company;

        public Journal(string name, int price ,string company) : base(name,price)
        {
            
                Company = company;
            

           
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Price} {Company}");

        }
    }
}
