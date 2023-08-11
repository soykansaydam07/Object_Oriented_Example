using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Miras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            Insan insan = new Insan();
            Mudur mudur = new Mudur();
            Ogretmen ogretmen = new Ogretmen();
            Memur memur= new Memur();            
            Insan ins = ogr;

            memur.AccountStatus = AccountStatus.NotApproved;
            int status = (int)memur.AccountStatus;
            string stringStatus = memur.AccountStatus.ToString();


            switch (memur.AccountStatus)
            {
                case AccountStatus.Approved:
                    //
                    break;
                case AccountStatus.NotApproved:
                    //
                    break;
                case AccountStatus.Pending:

                    ///
                    break;
                default:
                    break;
            }

            
            
            //Kullanımda  göruldugu gibi olusturulan ogr insan classındaki metodlara erisim yapabilir
            //ayrıca her ogrenci suoer classı olan yapıya donusebilirken tam tersi mumkun degildir
            

            TC_No_Sorgula(insan); // Bu kısımda sıkıntı olmucaktır cunku normal istenen nesnede donme saglanmıstır
            TC_No_Sorgula(ogr);   // Burdada sub class old icin miras alma olayı gerceklesir ve herhangi bir
            TC_No_Sorgula(mudur); //sıkıntı yasamadan özelliklerini miras aldıgı icin kod sorunsuz calsır
            TC_No_Sorgula(memur);
            /*
            // Bu kısımda ise olusturulmus anaclass ve subclass ın access modifiersı  belli kurallara göredir
            // kural olarak olusturulmus sub class public ise superclassda public olmalıdır diger belirtecler olmamaktadır
            // miras almanın kurallarından biridir
             */
        
        }
        void TC_No_Sorgula(Insan num)
        {

        }
    }
}
