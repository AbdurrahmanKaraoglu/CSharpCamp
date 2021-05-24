using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";

            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = false;

            sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Sisteme Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapılmamış");
            }

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            
        }
    }
}
