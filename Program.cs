using System;

namespace classmetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kisi1 = new Musteri();
            kisi1.Adi = "Ahmet";
            kisi1.SoyAdi = "Cetin";
            kisi1.Yasi = 51;
            kisi1.Cinsiyeti = "Bey";

            Musteri kisi2 = new Musteri();
            kisi2.Adi = "Hasan";
            kisi2.SoyAdi = "Cetin";
            kisi2.Yasi = 18;
            kisi2.Cinsiyeti = "Bey";



            Musteri kisi3 = new Musteri();
            kisi3.Adi = "Ebru";
            kisi3.SoyAdi = "Mumcular";
            kisi3.Yasi = 48;
            kisi3.Cinsiyeti = "Hanım";


            Musterimanager musterimanager = new Musterimanager();
            musterimanager.Ekle(kisi1);
            musterimanager.Ekle(kisi2);
            musterimanager.Ekle(kisi3);
            musterimanager.Delete(kisi3);

            Musteri[] customers = new Musteri[] {kisi1, kisi2 , kisi3 };

            foreach (var kisi in customers)
            {
                Console.WriteLine(kisi.Adi);
                Console.WriteLine(kisi.SoyAdi);
                Console.WriteLine(kisi.Cinsiyeti);
                Console.WriteLine(kisi.Yasi);

            }

            



        }
    }
}
