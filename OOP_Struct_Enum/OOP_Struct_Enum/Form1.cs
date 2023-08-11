using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Struct_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.Adi = "Soykan";
            ogrenci.SoyAdi = "Saydam";

            Ders ders = new Ders { Adi = "Matematik", Final = 60, Vize = 40 };
            Ders ders2 = new Ders { Adi = "Fizik", Final = 80, Vize = 60 };

            ogrenci.Dersler.Add(ders);
            ogrenci.Dersler.Add(ders2);
         
   

        }
    }
}
