using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya Elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Adana";
            urun2.Fiyati = 12;


            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (var oankiUrun in urunler)
            {
                Console.WriteLine(oankiUrun.Id);
                Console.WriteLine(oankiUrun.Adi);
                Console.WriteLine(oankiUrun.Aciklama);
                Console.WriteLine(oankiUrun.Fiyati);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("---------------  Metotlar ---------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);

            Console.WriteLine("---------------------");

            sepetManager.Ekle2("Armut", "Deveci", 6, 3);
            sepetManager.Ekle2("Erik", "Papaz", 6, 7);
            sepetManager.Ekle2("Kiraz", "Kiraz", 6, 12);


        }
    }
}
