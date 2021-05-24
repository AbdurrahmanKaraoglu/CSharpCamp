using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string>();

            isimler2.Add("Engin");
            isimler2.Add("Murat");
            isimler2.Add("Kerem");
            isimler2.Add("Halil");

            foreach (var oankiIsim in isimler2)
            {
                Console.WriteLine(oankiIsim);
            }
            Console.WriteLine("---------");

            isimler2.Add("Ahmet");
            foreach (var oankiIsim in isimler2)
            {
                Console.WriteLine(oankiIsim);
            }
        }
    }
}
