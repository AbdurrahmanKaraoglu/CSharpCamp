using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler." + urun.Adi + " Sepete Eklendi!" + " Stok : " + urun.StokAdedi);
        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stok)
        {
            Console.WriteLine("Tebrikler." + urunAdi + " Sepete Eklendi! " +"Açıklama : " +aciklama +" Fiyat : "+ fiyat + " Stok : " + stok);

        }

    }
}
