using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention n 
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi : "+ urun.Adi + " " + urun.Fiyati);
        }

        public void Ekle2(string UrunAdi, double UrunFiyati, string Aciklama, int StokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + UrunAdi +"  "+ Aciklama +"  "+ UrunFiyati + " TL ");
        }
    }
}
