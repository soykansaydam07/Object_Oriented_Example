using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CokBıcımlılık
{
    class Ogrenci :Insan
    {
        public decimal Vize { get; set; }
        public decimal Final { get; set; }
        /*
        // Suanda yaptıgımız olay object clasında olusturulmus virtual metodların kendimiz olusturdugumuz classlarda 
        // override yaparak kökten yada yüzeysel degisiklikler yapılarak kullanılabilir 
         */

        /*
        // Virtual  : Bir sınıfın miras alınan sınıflarda ezilebilmesini saglayan key dir virtual ise degistirlebilirligini saglamk 
        // Override : Miras alınan metodun yenilenmesini saglar  override icerigi degistirmek 
         */

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
        public override void Yemek_Ye()
        {
            // Yemek yiyorum hala
        }
    }
}
