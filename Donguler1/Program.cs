using System;

namespace Donguler1
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "c++";

            //array = dizi

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Proglamaya Başlangıç için Temel Kurs","Java","c++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");

            for (int i = 1; i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
