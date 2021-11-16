namespace React_metotlar_
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax - yazım şekilleri
        public void Ekle(Product urun)
        {
            System.Console.WriteLine("Tbrikler. Sepete eklendi! : " + urun.Adi);

        }


        // yanlış yol izleme Kendini Tekrar edersin böyle yaparsan, Class'a gidip ekleme yapmalısın...
        //public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi) 
        //{
        //    System.Console.WriteLine("Tebrikler. Sepete Eklemdi : " + urunAdi);
        //}


    }
}
