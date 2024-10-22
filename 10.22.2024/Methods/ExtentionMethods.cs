using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Methods
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int value)
        {
            if (value % 2 == 1)
            {
                return true;
                Console.WriteLine(true);
            }
            else
            {
                return false;
                Console.WriteLine("false");
            }

        }
        public static bool IsEven(this int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine("true");
                return true;
                
            }
            else
            {
                return false;
                Console.WriteLine("false");
            }
        }
        public static string ToCapitalize(this string name)
        {
            name = name.ToUpper();

            return name;
            Console.WriteLine(name);
        }
        public static void GetValueIndex(this char i, string name)
        {
            for (int j = 0; j < name.Length; j++)
            {
                if (i == j)
                {
                    Console.WriteLine("daxil etdiyiniz char stringde var");

                }
                else
                {

                    Console.WriteLine("daxil etdiyiniz char stringde yoxdur");

                }

            }
        }
        public static bool CustomContains(this char name, string cumle)
        {
            for (int j = 0; j < cumle.Length; j++)
            {
                if (j == name)
                {
                    
                    Console.WriteLine("soz cumlede var");
                    bool x = true;
                    return x;
                }
                else
                {
                    
                    Console.WriteLine("soz cumlede yoxdur");
                    bool x= false;
                    return x;


                }
                return x;
            }
            
        }
    }
}