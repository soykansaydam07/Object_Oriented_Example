using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sut_Cekme forvet;
        Oyun_Kurma ortasaha;

        private void button1_Click(object sender, EventArgs e)
        {
            // Bunu yapabilirim cunku arda implementinde sut_cekme kısmı vardır boylece  sut_cekme turunden bi degiskene atama yapabilir
            // ama oyun kurma implement etmedigi icin bu classdan uretilmis degiskene degeri(nesnesi) atılamaz
            Arda arda = new Arda();
            forvet = arda;


            // Bu kısımda Arda classı Sut_Cekme interfaceini implement ettigi icin ne olursa olsun icinde Sut_Cek tanımlı olucak
            // Aynısı Sabri classı icinde gecerlidir

            Sabri sabri = new Sabri();
            Vole_Vur(arda);
            Artistik_Calım_At(sabri);

            // Instance olusumu kullanılamaz Zaten erisebilecek field degisken bulunmamaktadırAyrıca interfacelerin constracterları yoktur
        }

        void Vole_Vur(Sut_Cekme oyuncu)
        {
            oyuncu.Sut_Cek( 405.6f , 90.0f );
        }

        void Artistik_Calım_At(Oyun_Kurma oyuncu)
        {
            oyuncu.Calım_At(407.3f, 22.0f);
        }
    }
}
