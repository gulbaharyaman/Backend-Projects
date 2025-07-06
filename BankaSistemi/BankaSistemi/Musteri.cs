using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSistemi
{
    class Musteri
    {
        private string ad;
        private string soyad;
        private string musteriNo;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string MusteriNo
        {
            get { return musteriNo; }
            set { musteriNo = value; }
        }
        public Musteri(string ad, string soyad, string musteriNo)
        {
            Ad = ad;
            Soyad = soyad;
            MusteriNo = musteriNo;
        }
    }
   
}
