using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Giris
{
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        Personel[] personeller = new Personel[100];
        int sayac = 0;
        internal void  Personel_Ekle(Personel y_personel)
        {
            personeller[sayac] = y_personel;
            listBox1.Items.Add(y_personel.Adi + " " + y_personel.SoyAdi);
            sayac++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel Is_Cıkar = personeller[listBox1.SelectedIndex];
            Is_Cıkar.Isten_Cıkar();
        }
    }
}
