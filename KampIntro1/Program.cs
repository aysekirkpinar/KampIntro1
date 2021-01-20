using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 3200 ;
            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = false;

            double dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
