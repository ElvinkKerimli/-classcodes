using core.exceptions;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();


            try
            {
                Console.WriteLine("ad daxil edin");
                string b = Console.ReadLine();
                Console.WriteLine("yas daxil edin");
                person.Age = int.Parse(Console.ReadLine());
                b = person.Name;
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
