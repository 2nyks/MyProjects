using System;

namespace IkinciGunOdevAlti
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Telefon";
            urun1.UrunFiyati = 5000;
            urun1.UrunStok = 7;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Bilgisayar";
            urun2.UrunFiyati = 8000;
            urun2.UrunStok = 5;

            Urun urun3 = new Urun();
            urun2.UrunAdi = "Kulaklık";
            urun2.UrunFiyati = 3000;
            urun2.UrunStok = 4;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

             //for
            for (int i=0; i<urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + "ürününden" + urunler[i].UrunStok + "kadar vardır."); 
            }

             //foreach
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + "ürününden" + urun.UrunStok + "kadar vardır.");

            }
             //while
            int j = 0;
            while(j<urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunAdi + "ürününden" + urunler[j].UrunStok + "kadar vardır.");
                j++;

            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public double UrunStok { get; set; }

    }
}

