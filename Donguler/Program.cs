 using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)

        {
            //array: Diziler
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kursu",
                "Programlamaya başlangıç için temel kurs", "java", "Python" };


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
          
            
            }

            Console.WriteLine("For Bitti");

            //metin dizilerini dolaşmak için kullanılır. (For daha kapsamlı bir dögüdür.)
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("-Sayfa Sonu-");


        }
           
    }
}
