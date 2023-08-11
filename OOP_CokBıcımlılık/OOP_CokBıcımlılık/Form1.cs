using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CokBıcımlılık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = textBox1.Text;
            ogrenci.Soyadi = textBox2.Text;
            ogrenci.Vize = numericUpDown1.Value;
            ogrenci.Final = numericUpDown2.Value;

            listBox1.Items.Add(ogrenci);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Herhangi Bir Secimde Bulunamassınız");
                return;
            }

            Ogrenci ogr = (Ogrenci) listBox1.SelectedItem;
            
            textBox1.Text = ogr.Adi;
            textBox2.Text = ogr.Soyadi;
            numericUpDown1.Value = ogr.Vize;
            numericUpDown2.Value = ogr.Final;
        }
        

        
    }
}
