using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    public class KurumsalMusteri : Musteri
    {
        public String vergiNo;
        public string sirketAdi;

        public KurumsalMusteri(int musteriId, string musteriAd, string musteriTelefonNo, string vergiNo, string sirketAdi)
            : base(musteriId, musteriAd, musteriTelefonNo)
        {
            this.vergiNo = vergiNo;
            this.sirketAdi = sirketAdi;
        }
        public override string MusteriTipi()
        {
            return "Kurumsal";
        }

    }
}
