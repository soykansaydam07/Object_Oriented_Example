using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Delegates
{   
    //delgate yapısı kullanımı genel anlamda metod tutan bir yapıdır
        
    public delegate void Say();
    
    public delegate void Mesaj_Ver(string mesaj);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void Sayici()
        {
            for(int i = 0 ; i < 10000 ; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        void Takipci(IAsyncResult sonuc)
        {
            Say saydirici = (Say)sonuc.AsyncState;
            saydirici.EndInvoke(sonuc);
        }

        void Kutuda_Mesaj_Ver(string msg)
        {
            MessageBox.Show(msg);
        }

        void Label_Mesaj_Ver(string msg)
        {
            label1.Text = msg;
        }

        void Text_Mesaj_Ver(string msg)
        {
            textBox1.Text = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mesaj_Ver mesaj = new Mesaj_Ver(Kutuda_Mesaj_Ver);

            //mesaj += Label_Mesaj_Ver;
            //mesaj += Text_Mesaj_Ver;
            //mesaj.Invoke("Merhaba Dunya");    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Say saydirici = new Say(Sayici);
            AsyncCallback callback = new AsyncCallback(Takipci);
            saydirici.BeginInvoke(callback, saydirici);
        }
        void sayici2()
        {
            for (int i = 0; i < 100000; i++)
            {
                listBox2.Items.Add(i);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Say saydirici2 = sayici2;
            saydirici2.BeginInvoke(Takipci , saydirici2);

        }

     }
}
