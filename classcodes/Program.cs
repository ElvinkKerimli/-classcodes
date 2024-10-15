using System.Drawing;
using System.IO;
using System.Xml;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Elvin", "kerimli", "AB107", 87, true);

            student.GetInfo("Elvin", "kerimli", "AB107", 87, true);

        }

        
    }

    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool Isgraduated;


        public Student(string name, string surname, string group, int point, bool isgraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            Isgraduated = isgraduated;
        }
        public void GetInfo(string name, string surname, string group, int point, bool isgraduated)
        {
            Console.WriteLine(name + " " + surname + " " + group + " " + point + " " + isgraduated);

        }
        public void CheckGraduation()
        {
            if (Isgraduated)
            {
                Console.WriteLine("Telebe mezun olub ");

            }
            else {

                Console.WriteLine("telebe mezun olmayib");
            }
        }
        public void GetDiplomDegree(int point)
        {
            if (point < 65)
            {
                Console.WriteLine("telebenin diblomu yoxdur");
            }
            else if (point < 80)
            {
                Console.WriteLine("Telebe adi diplom alib");
            }
            else if (point < 90)
            {
                Console.WriteLine("telebe seref diplomu alib");
            }
            else 
            {
                Console.WriteLine("telebe yuksek seref alib");
            
            }
        }

    }
}
