namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(3, "MERCEDES", "sclass", 120000);

            Car car1 = new Car(3, "MERCDES", "sclss", 110000);
            
            Car car2 = new Car(3, "MERCES", "sclas", 10000);
        }
       
    }
}
