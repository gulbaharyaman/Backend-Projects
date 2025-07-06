using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    public class Otobüs: Arac
    {
        public Otobüs(string marka, string model) : base(marka, model)
        {
        }
        public override double GunlukUcret()
        {
            return 1476.0;
        }
    }
}
