using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    public abstract class Arac
    {
        public string marka;
        public string model;
        public bool isAvailable;

        public Arac(string marka, string model)
        {
            this.marka = marka;
            this.model = model;
            isAvailable = true;
        }
        public abstract double GunlukUcret();
    }

    
}
