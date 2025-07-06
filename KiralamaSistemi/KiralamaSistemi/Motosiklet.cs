using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    public class Motosiklet:Arac
    {
        Motosiklet(string marka, string model) : base(marka, model) { }

        public override double GunlukUcret()
        {
            return 745.5;
        }
    }
}
