using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    class Kiralama
    {
        public Musteri musteri;
        public Arac arac;
        public DateTime startDate;
        public DateTime endDate;
        public double toplamUcret;
        public bool ispaid;

        public Kiralama(Musteri musteri, Arac arac, DateTime startDate, DateTime endDate)
        {
            this.musteri = musteri;
            this.arac = arac;
            this.startDate = startDate;
            this.endDate = endDate;
            toplamUcret = getToplamUcret();
            ispaid = false;
            arac.isAvailable = false;
        }

        public double getToplamUcret() { 
            int gunSayisi=(endDate-startDate).Days;
            int toplamGun=Math.Max(1, gunSayisi);
            return toplamGun * arac.GunlukUcret();
        }

        public void Odendi()
        {
            ispaid=true;
        }

        public double GecikmeUcreti(DateTime asilEndDate)
        {
            if (asilEndDate > endDate) { 
                int gecikenGun=(asilEndDate - startDate).Days;
                double ceza = gecikenGun * 162;
                toplamUcret += ceza;
                return ceza;
            }
            return 0;
        }
    }
}
