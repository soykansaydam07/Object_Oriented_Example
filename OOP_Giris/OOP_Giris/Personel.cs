    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris
{
    public class Personel
    {   
        /*
        // Yeni class Turunden olusturulmus bir classda ramdan bir alan istenmesi olayına INSTANCE olarak adlandırılır
        // Erisim Belirleyiclierine ACCESS MODIFIERS olarak adlandırılır

        //private : Sadece tanımladıgı sınıf icerisinde gecerlidir default budur
        //protected : Miras alınan sınıflarda erisebilmeyi saglar 
        //internal : Bulundugu proje icerisinde herkezin erisebilmesini saglar 
        //protected internal : Hem proje icerisindekiler hemde miras alanlar erisebilir
        //public : kitlesel olup her tarafından erisilebilir
        */
        internal string Adi { get; set; }
        internal string SoyAdi { get; set; }
        internal string Sicil_No { get; set; }
        internal string  TC_Kimlik { get; set; }
        internal decimal Maas { get; set; }
        internal DateTime Tarih_Giris { get; set; }
        /*
        //Auto Property  : FIELD(Degisken tanımlaması) icinde olan property dir faydası tekrar field olusturmaz 
        // field ını kendi icinde olusturur set ve get komutlarının ıcınde komut olmaz  olursa auto property 
        // bozulur get ve set silinemez ayrıca set get kısımları istenirse private yapılabilir
        // internal decimal Maas { get; private set; } gibi
         */

        double value;
        double vize;
        public double Vize
        {
            get { return vize; }
            set { if(value>= 0 && value>=100) vize = value;}
        }
        /*
         // Kullanım olarak set get metodu kullanımıdır private bi yapıya sadece  iki metodla ulasmayı saglar 
         // Böylece kapsülleme olusup private degiskene dısarıdan erisim saglanır
         */

        public Personel()
        {
            Tarih_Giris = DateTime.Now;
            Adi = "Girilmedi";
            SoyAdi = "Girilmedi";
            Sicil_No = "Girilmedi";
            TC_Kimlik = "Girilmedi";
        }

        public Personel(String name , String surname)
        {
            Adi = name;
            SoyAdi = surname;
        }

        /*
        //Bu yapı propertis olusturup diger classlara erisimde kullanılır public degiskenden farklı olarak 
        //olusturulan bu yapıda interface kullanımınada olanak saglar
        */
        /*
        //Constracter Ramda nesneyi üreten yapıcı metoddur geri donus tipi olmayan tek metoddur
        //Tanımlanmassa default constractr gercerlidir        
        //parametre almayan new personal metodu (default)
        //overload yapılabilir
         */
        ~Personel()
        {
            System.Windows.Forms.MessageBox.Show("Program Kapatılıyor");
        }
        
        /*
        //Destracter Tilda işareti ile kullanılır (~) Destracter da ramdan silinmeden önce yapılmasını istediginiz
        //Olay icin kullanılır sonra silinir overload yapılamaz
         */
        
        internal void Ise_Al()
        {
            //Veri tabanına ekleme işi yapar
            

        }
        internal decimal Kidem_Tazminatı_Hesabla()
        {
            //hesaplama kodları bulunacaktır
            return 0;
        }

        internal void Isten_Cıkar()
        {
            decimal tazminat = Kidem_Tazminatı_Hesabla();
            //veritabanında isten cılarma islemlerti yapılacaktır

        }

 

    }
}
