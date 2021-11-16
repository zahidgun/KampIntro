using System;

namespace React_metotlar_
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Product urun1= new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };

            //type-safe -- tip güvenliği
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }

            Console.WriteLine("-----------Metotlar-------------");
            //istance - örnek
            //encapsulation 

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //yanlış Yol izleme
            //sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 9);
            //sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 10);
            //sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);


        }
    }
}



//Dont repeat yorself. - DRY - Clean Code(temiz kod) - Best Practice(doğru uygulama teknikleri)