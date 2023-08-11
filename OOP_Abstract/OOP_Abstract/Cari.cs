using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstract
{
    public abstract class Cari
    {
        public abstract string Carikodu { get; set; }
        public string Unvan { get; set; }

        public abstract string[] getBanks();

        public decimal getKDV()
        {
            return 0.18m;
        }
    }
    public class CariMusteri : Cari
    {
        private string cariKod;
        public override string Carikodu
        {
            get
            {
                return cariKod;
            }
            set
            {
                cariKod = value;
                
            }
        }

        public override string[] getBanks()
        {
            return new string[] { "İsBankası", "ZiraatBankası" };
        }
    }
}
