
namespace ConsoleApp21
{
    internal class Program:Weapon
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            bool f=false;


            do
            {
                Console.WriteLine("0. information  1. Shoot  2. Get Remain Bullet Count  3 .Reload 4. ChangeFireMode 5. Exit ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "0":

                        Console.WriteLine("Gulle tutumu" + weapon._bulletcapacity);
                        Console.WriteLine("Gulle sayi" + weapon._bulletcount);




                        break;

                    case "1":


                        weapon.Shooting();
                        



                        break;
                    case "2":
                        Console.WriteLine("qalmis gulleler");
                        weapon.GetRemainBullet();



                        break;
                    case "3":
                        weapon.Reload();
                        Console.WriteLine("daraq dolduruldu");



                        break;
                    case "4":
                        Console.WriteLine("1. avtomatik 2. tekli");
                        string mode = Console.ReadLine();
                        switch (mode)
                        {


                            case "1":
                                weapon._shootingmode = false;
                                weapon.ChangeFireMode(false);

                                break;

                            case "2":
                                weapon._shootingmode = true;
                                weapon.ChangeFireMode(true);
                                break;

                        }
                        break;
                    case "5":

                        Console.Clear
                            ();

                     break;

                }




            }
            while (true);
             


        }

    }
}
