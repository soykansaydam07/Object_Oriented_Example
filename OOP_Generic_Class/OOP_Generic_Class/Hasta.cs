using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Generic_Class
{
    //olusturulan class isminin yanına tag acıp icine suan belli olmayan gecici degisken ismi yazılıp
    //sınıf  olusturulurken tipin sonradan secilmesini saglar

    class Hasta<hold,/*hold2,hold3*/>
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TC_No { get; set; }
        public hold Hasta_Ozellikleri { get; set; }
        //public hold2 Raporlar{ get; set; }
        //public hold3 Tahliller { get; set; }
    }
    class Gribal_Enfeksiyon
    {
        public string Adi { get; set; }
        public string Tur { get; set; }
        public float LD { get; set; }
        public string Antidot { get; set; }
    }
}
