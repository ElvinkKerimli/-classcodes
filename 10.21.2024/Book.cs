using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Book:Product
    {
        public string  Author { get; set; }
     
        
        public string Genre { get; set; }
        public Book(string name,int price , string author , string genre):base (name, price)
        {
            this.Genre = genre;
            this.Author = author;   
        }



        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Price} {Author} {Genre}");
        }
    }

}
