using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    public abstract class Musteri
    {
        private int musteriId;
        private string musteriAd;
        private string musteriTelefonNo;

        public int MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }
        public string MusteriAd
        {
            get { return musteriAd; }
            set { musteriAd = value; }
        }
        public string MusteriTelefonNo
        {
            get { return musteriTelefonNo; }
            set { musteriTelefonNo = value; }
        }
        public Musteri(int musteriId,string musteriAd,string musteriTelefonNo) { 
            MusteriId = musteriId;
            MusteriAd = musteriAd;
            MusteriTelefonNo=musteriTelefonNo;
        }

        public abstract string MusteriTipi();
    }
}
