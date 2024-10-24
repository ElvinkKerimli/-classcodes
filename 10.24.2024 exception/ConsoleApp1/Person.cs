using core.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get
            { return _age; }
            set
            {
                if (value < 0 || value> 125)
                {
                    throw new InvalidAgeException("yas duzgun verilmeyib");
                }
                else
                {
                    _age = value;
                }

            }


        }

    }
}
