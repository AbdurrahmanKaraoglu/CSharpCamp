using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");
            for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("******************");

            string kurs1 = "Temel Kurs";
            string kurs2 = "C#";
            string kurs3 = "Java";

            // Bu tip veriler arraylerde tutulur.

            string[] kurslar = new string[3];

            kurslar[0] = kurs1;
            kurslar[1] = kurs2;
            kurslar[2] = kurs3;

            string[] kurslar2 = new string[] { "Temel Kurs", "C#", "Java" };

            Console.WriteLine("--------- for ile ---------");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("------------------");
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("------------------");
            
            for (int i = 0; i < kurslar2.Length; i++)
            {
                Console.WriteLine(kurslar2[i]);
            }

            Console.WriteLine("--------- while İle  ---------");
            int sayac = 0;
            while (sayac < kurslar.Length)
            {
                Console.WriteLine(kurslar[sayac]);
                sayac++;
            }

            Console.WriteLine("--------- foreach ile ---------");

            foreach (var oankiKurs in kurslar)
            {
                Console.WriteLine(oankiKurs);
            }
            
            Console.WriteLine("------------------");
            
            foreach (string oankiKurs in kurslar2)
            {
                Console.WriteLine(oankiKurs);
            }

        }
    }
}
