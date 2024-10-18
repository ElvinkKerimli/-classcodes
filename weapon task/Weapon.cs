using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Weapon
    {
        public int _bulletcapacity = 12;
        public int _bulletcount = 12;
        public bool _shootingmode;


        public void Shooting()
        {
            if (_shootingmode )
            {

                _bulletcount -= 1;

            }
            else
            {
                _bulletcount = 0;
            }

        }

        //public void Shoot()
        //{
        //    _bulletcount -= 1;
        //}




        //public void Shooot()
        //{


        //    _bulletcount = 0;
        //    Console.WriteLine("Sarjoru deyisin");
            
        //}
        public void GetRemainBullet()
        {
            Console.WriteLine(_bulletcount);
        }
        public void Reload()
        {
            _bulletcount =12;
            Console.WriteLine(_bulletcount);
            

        }
        public void ChangeFireMode(bool _shootingmode)
        {
            Console.WriteLine(Shooting);
        }


    }
}
