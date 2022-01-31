using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması ";

            Product urun1 = new Product();

            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklamasi = "Amasya elması";


            Product urun2 = new Product();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklamasi = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1,urun2 };

            //Type-safe -- Tip güvenliği
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklamasi);
                Console.WriteLine("---------");

            }

            Console.WriteLine("-------Metotlar----------");
            //instance-Örnek
           //encapsulation kapsülleme ayrı ayrı yazacağın yapıyı bir düzene sokmaktır.
           
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12,22);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 12,21);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,15);
        }
    }
}


//Dont repeat yourself -- DRY -- Clean Code -- Best Practice