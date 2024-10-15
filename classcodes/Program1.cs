

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("mercedes", "sclass", 70, 2, 125000);
      
            car.Drive(30);
        }
    }
    class Car
    {
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1km;
        public int Millage;
        public int km;
      

        public Car(string brand, string model, int currentFuel, int fuelFor1km, int millage)
        {
            Brand = brand;
            Model = model;
            CurrentFuel = currentFuel;
            FuelFor1km = fuelFor1km;
            Millage = millage;
        }

        public void Drive( int km)
        {

            if (km * FuelFor1km > CurrentFuel)
            {
                Console.WriteLine("xəta");
            }
            else 
            {
                CurrentFuel= CurrentFuel - km*FuelFor1km;
                Millage=Millage + km;
                Console.WriteLine(CurrentFuel+" "+Millage);
                
            }

        }

        
    }
}
