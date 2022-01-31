using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    //Managerler bir operasyon tutuyor demek!
    public class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi! : " + urun.UrunAdi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat, int stokAdedi )
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi! : " + urunAdi);
        }
    }
}
