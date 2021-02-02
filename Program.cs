using System;

namespace CampProject
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("---------Metotlar------");
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            
            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 12 ,9);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);

            Console.ReadLine();


        }
    }
}
