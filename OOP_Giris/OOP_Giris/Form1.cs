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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Personeller frame_personel = new Personeller();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();

            personel.Adi = textBox1.Text;
            personel.SoyAdi = textBox2.Text;
            personel.Sicil_No = textBox3.Text;
            personel.Maas = numericUpDown1.Value;
            frame_personel.Personel_Ekle(personel);
            
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            numericUpDown1.Value = 0;
            textBox1.Focus();
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frame_personel.Show();
        }
        
    }
}
