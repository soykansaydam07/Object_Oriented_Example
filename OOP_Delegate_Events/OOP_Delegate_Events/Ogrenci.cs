using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Delegate_Events
{
     delegate void IfEventHandler(Object sender, IfEventArgs e);

    class IfEventArgs : EventArgs
    {
        public string AdSoyad { get; set; }
        public double Ortalama { get; set; }
    }
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        private double vize;

        public double Vize
        {
            get { return vize; }
            set { vize = value; Durum_Kontrol(); }
        }

        private double final;

        public double Final
        {
            get { return final; }
            set { final = value; Durum_Kontrol(); }
        }

        void Durum_Kontrol()
        {
            if (Ortalama >= 70)
            {
                if (Gecti != null)
                {
                    Gecti(this, new IfEventArgs { AdSoyad = Adi + " " + Soyadi, Ortalama = Ortalama });
                }

            }
            else
            {
                if (Kaldı != null)
                {
                    Kaldı(this, new IfEventArgs { AdSoyad = Adi + " " + Soyadi, Ortalama = Ortalama });
                }

            }
        }
        public double Ortalama
        {
            get
            {
                return Vize * 0.4d + Final * 0.6d;
            }

        }
        public event IfEventHandler Gecti;
        public event IfEventHandler Kaldı;

        public override string ToString()
        {
            return Adi + " " + Soyadi + " " + Ortalama;
        }
    }
}
