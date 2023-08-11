using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Delegate_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();

            o.Adi = textBox1.Text;
            o.Soyadi = textBox2.Text;

            o.Gecti += new IfEventHandler(o_Gecti);
            o.Kaldı += new IfEventHandler(o_Kaldı);

            o.Vize = Convert.ToDouble(textBox3.Text);
            o.Final = Convert.ToDouble(textBox4.Text);

            listBox1.Items.Add(o);
        }

        void o_Kaldı(object sender, IfEventArgs e)
        {
            listBox3.Items.Remove(e.AdSoyad);
            listBox2.Items.Remove(e.AdSoyad);
            listBox3.Items.Add(e.AdSoyad);
        }       

        void o_Gecti(object sender, IfEventArgs e)
        {
            listBox2.Items.Remove(e.AdSoyad);
            listBox3.Items.Remove(e.AdSoyad);
            listBox2.Items.Add(e.AdSoyad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogrenci secili = (Ogrenci)textBox1.Tag;
            secili.Adi = textBox1.Text;
            secili.Soyadi = textBox2.Text;
            secili.Vize = Convert.ToDouble (textBox3.Text);
            secili.Final =Convert.ToDouble (textBox4.Text);

            listBox1.Items.Remove(secili);
            listBox1.Items.Add(secili);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Ogrenci secili = (Ogrenci)listBox1.SelectedItem;
            textBox1.Text = secili.Adi;
            textBox2.Text = secili.Soyadi;
            textBox3.Text = secili.Vize.ToString();
            textBox4.Text = secili.Final.ToString();
            textBox1.Tag = secili;
        }
    }
}
