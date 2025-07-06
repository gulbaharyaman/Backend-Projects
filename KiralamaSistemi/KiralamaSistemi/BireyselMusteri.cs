using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    public class BireyselMusteri: Musteri
    {
        public string tcNo;

        public BireyselMusteri(int musteriId, string musteriAd, string musteriTelefonNo, string tcNo) : base(musteriId,musteriAd,musteriTelefonNo) {
            this.tcNo = tcNo;
        }
        public override string MusteriTipi()
        {
            return "Bireysel";
        }
    }
}
