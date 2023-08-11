using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        // İlk olarak abstarct bir sınıftan instance uretilmez ama bu sınıfı extend eden sınıflardan instance uretebilirsiniz
        // Abstract olusturmus classlarda abstract olmayan metodlar bulunurken ayrıca abstract metod ve degiskenlerde bulunabilir bu metodların
        // ic kısımları bostur ve diger extend edilen classlarda olusturulup kullanılması gerekmektedir
        // her class kendi icinde abstract yapılar icin tanımlama yapılmak zorumludur
        private void button1_Click(object sender, EventArgs e)
        {
            CariMusteri musteri = new CariMusteri();
            musteri.Carikodu = "AB343";
            HaveleYap(musteri);
        }

        void HaveleYap(Cari c)
        {
            string[] bankalar = c.getBanks();
        }
    }
}
