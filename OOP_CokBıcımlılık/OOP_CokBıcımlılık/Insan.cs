using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CokBıcımlılık
{
    class Insan
    {
        public string TC_No { get; set; }
        public string Adi{ get; set; }
        public string Soyadi{ get; set; }


        //Olusturdugumuz metod kullanımında metodu diger classlarda override edilebilecek sekilde kullanmak istiyorsak 
        //Yazdıgımız metodu virtual sekilde yazmak gerekir ki diger classlarda degisime ugrayabilsin 

        public virtual void Yemek_Ye()
        {
            //Yedim
        }
    }
}
