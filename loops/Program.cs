using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C#";

            //array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , 
                "Programlamaya Başlangıç İçin Temel Kurs" ,"java", "Pyhton", "C#"};

            
            

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("Sayfa Sonu - footer");


        }
    }
}
