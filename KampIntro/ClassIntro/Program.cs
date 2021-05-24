using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Engin";
            int yas = 36;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Temel Egitim";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 0;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 0;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "JAVA";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 0;

            Console.WriteLine(kurs1.KursAdi);
            Console.WriteLine(kurs1.Egitmen);
            Console.WriteLine(kurs1.IzlenmeOrani);

            Console.WriteLine("---------------");

            Console.WriteLine(kurs2.KursAdi);
            Console.WriteLine(kurs2.Egitmen);
            Console.WriteLine(kurs2.IzlenmeOrani);

            Console.WriteLine("---------------");

            Console.WriteLine(kurs3.KursAdi);
            Console.WriteLine(kurs3.Egitmen);
            Console.WriteLine(kurs3.IzlenmeOrani);

            Console.WriteLine("------- foreach --------");

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var oankiKurs in kurslar)
            {
                Console.WriteLine(oankiKurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }
}
