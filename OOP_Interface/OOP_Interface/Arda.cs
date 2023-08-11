using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    class Arda :Futbolcu_Base , Sut_Cekme
    {

        public bool Sut_Cek(float guc, float acı)
        {
            return true;
        }

        public float Mesafe
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
