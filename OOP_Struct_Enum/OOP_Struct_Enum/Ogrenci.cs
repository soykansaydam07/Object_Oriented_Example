using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Struct_Enum
{
    class Ogrenci
    {
        /*                              STATIC METHODS AND VALUE
        // Static class ismi yazılarak erisilebilen yapılara static türden eleman ve metodlar denir.
        // İnstance a göre zaman ve bellek harcamasını azaltmaya yaramaktadır
        // Static metodlarda static degiskenler kullanılmak zorundadır cunku static yapı program acıldıgında ilk olusturulan yapıdır metodun
        //icinde  normal degisken varsa static metod olustuktan sonra degiskenler daha olusmadıgı icin bunları kullanamayabilir.
         */


        public Ogrenci()
        {
            Dersler = new List<Ders>();
        }

        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public List<Ders> Dersler { get; set; }

        public decimal Ortalama 
        {
            get
            {
                decimal toplam = 0;
                foreach (Ders not  in Dersler)
                {
                    toplam = toplam + not.Ortalama;
                }
                return toplam / Dersler.Count();
            }
        }
    }

    struct Ders
    {
        public string  Adi  { get; set; }
        public decimal Vize { get; set; }
        public decimal Final { get; set; }

        public decimal  Ortalama 
        {
            get
            {
                return Vize * 0.4m + Final * 0.6m;
            }
        }
        public OgrenciDurum Durum
        {
            get
            {
                if (Ortalama >= 70)
                    return OgrenciDurum.Gecti;
                
                else if (Ortalama >= 50 && Ortalama <= 70)
                    return OgrenciDurum.SartlıGecti;
                
                else return OgrenciDurum.Kaldı;

            }
        }
    }

    enum OgrenciDurum
    {
        Gecti ,
        SartlıGecti ,
        Devamsız ,
        Kaldı , 
        SinifTekrari
    }
}
