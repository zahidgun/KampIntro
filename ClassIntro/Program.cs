using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Zahid";
            int yaş = 26;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "java";
            kurs1.Egitmeni = "Ali";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmeni = "İrem";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmeni = "Zahid";
            kurs3.IzlenmeOrani = 68;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni + " : " +
                    kurs.IzlenmeOrani);
            }


        }


    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }     
 


}   

