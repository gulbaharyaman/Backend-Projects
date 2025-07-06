using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    public class Araba: Arac
    {

        public Araba(string marka, string model):base(marka, model) { }

        public override double GunlukUcret()
        {
            return 998.9;
        }
    }
}
