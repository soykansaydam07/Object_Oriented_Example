using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface2
{
    enum OyunTur
    {
        Pelus ,
        Tabanca ,
        Araba , 
        Ucak ,
        Tren , 
        Barbie ,
        Gemi
    }

    struct OyuncakEbat
    {
        public float Yukseklik { get; set; }
        public float Genislik { get; set; }
        public float Derinlik { get; set; }
    }

    class Oyuncak_Base
    {
        public string Kodu { get; set; }
        public string Adı { get; set; }
        public decimal Fiyat { get; set; }
        public string Barkod { get; set; }
        public OyunTur Tur { get; set; }
        public OyuncakEbat Boyut { get; set; }
        public float Agirlik{ get; set; }
    }
}
