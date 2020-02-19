using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naval_Cadets
{
    class Class234 : Class231
    {
        public new string Fam;
        public new string Im;
        public new string Ot;
        public new int Klas;
        public Class234(string fam1, string im1, string ot1, int klas1) : base(fam1, im1, ot1, klas1)
        {
            Fam = fam1;
            Im = im1;
            Ot = ot1;
            Klas = klas1;
        }
    }
}
