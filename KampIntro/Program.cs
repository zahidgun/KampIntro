using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //(ŞART BLOKLARI...);

            //alias : Değeri tutucu demektir.
            //Do not repeat yourself: Kendini tekrarlama.
            //type safety: Tip güvenliği.
            //Temel veri tipler...
            
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmişmi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

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
                Console.WriteLine("Deüişmedi Butonu");
            }
            if (sistemeGirişYapmişmi == true)
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
