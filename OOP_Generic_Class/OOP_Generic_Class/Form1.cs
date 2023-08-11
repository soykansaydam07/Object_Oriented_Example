using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OOP_Generic_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ArrayList Obje olarak dinamik dizi olusturmaya yarar avantajı her degisken yapısını obje oldugu icin tutabilir 
            //ama dezavantajı her kayıtta boxing be unboxıing yapmak zorunda kalır
            //using System.Collection kullanılarak ulasılabilir
            ArrayList array = new ArrayList();
            array.Add("Soykan");
            array.Add(1);

            //GenericList obje modda degisken tutmayıp
            List<String> array2 = new List<string>();

            array2.Add("Soykan");
            array2.Add("Nehir");

            //Hasta<string, string, string> hasta = new Hasta<string, string, string>();

            Hasta<Gribal_Enfeksiyon> hasta = new Hasta<Gribal_Enfeksiyon>();

            Gribal_Enfeksiyon enfeksiyon = new Gribal_Enfeksiyon();

            enfeksiyon.Adi = "Fungi";
            enfeksiyon.Tur = "Asalaklar";
            enfeksiyon.LD = 0.05f;
            enfeksiyon.Antidot = "Profen";


        }
    }
}
