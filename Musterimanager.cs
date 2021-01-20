using System;
using System.Collections.Generic;
using System.Text;

namespace classmetotDemo
{
    class Musterimanager
    {






        public void Ekle(Musteri kisiler) 
        {
            Console.WriteLine("Kayıt Başarılı" + "   " + "Hoşgeldiniz:" + " " +  kisiler.Adi + " " + kisiler.SoyAdi + " " + kisiler.Cinsiyeti);
        
        
        
        
        
        
        }

        public void Delete(Musteri kisiler) 
        {
            Console.WriteLine( "KAYDINIZ SİLİNMİŞTİR" + " " + kisiler.Adi + " " + kisiler.Cinsiyeti );
        
        
        
        }

            
        
        
        
        
        
        
         

        
        
        
        
        
        

    }
}
