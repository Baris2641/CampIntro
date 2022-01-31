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
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();
            Kurs kurs4 = new Kurs();

            kurs1.KursAdi = "C#";
                 kurs1.Egitmeni = "Engin Demiroğ";
                 kurs1.IzlenmeOrani = 68;

            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "kerem Varıs";
            kurs2.IzlenmeOrani = 64;

            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 58;

            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Murrat Kurtboğa";
            kurs4.IzlenmeOrani = 75;

            //Console.WriteLine(kurs1.kursadi  + " : " + kurs1.egitmeni );

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmeni);
            }
        }
    }


    public class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }

}
