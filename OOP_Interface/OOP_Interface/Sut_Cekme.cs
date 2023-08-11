using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    // Ability anlamında kullanılırbundan dolayı field ve degisken almak yerine sadece abilitylerden olusur
    // Bunun anlamı sadece metodlar (ici doldurulmamıs) ve proportilerden olusabilri
    // Birden fazla  interface implement edilebilir herhangi bir sorun olusmamaktadır

    // abstract tan farkı abstracta normal degiskenler ve metodlar kullanılabilir ama interfacede sadece proporties ve metodlar kullanılır
    // abstrackta icini sizin doldurmanız gerekirken interfacede otomatik olarak metodları olusturur


    interface Sut_Cekme
    {
        bool Sut_Cek(float guc , float acı);
        float  Mesafe { get; set; }

    }
}
