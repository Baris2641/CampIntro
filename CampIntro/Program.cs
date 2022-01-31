using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself
            //Type Safety tip güvenliği c# da veri türünü yazmak zorundayız
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 11.55;
            double dolarBugun = 11.56;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }
            
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            
        }
    }
}
