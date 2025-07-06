using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSistemi
{
    class BankaHesabi
    {
        public string HesapNo;
        public double Bakiye;
        public Musteri HesapSahibi;

        public BankaHesabi(string hesapNo, double bakiye, Musteri hesapSahibi)
        {
            HesapNo = hesapNo;
            Bakiye = bakiye;
            HesapSahibi = hesapSahibi;
        }

        public void ParaYatir(double miktar)
        {
            if (miktar > 0)
            {
                Bakiye += miktar;
                Console.WriteLine($"{miktar} TL para yatırma işlemi gerçekleştirdiniz. Toplam bakiyeniz: {Bakiye} TL");
            }
            else
            {
                Console.WriteLine("Geçersiz miktar girdiniz. Tekrar deneyiniz.");
            }
        }

        public void ParaCek(double miktar)
        {
            if (miktar > 0)
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar} TL para çekme işlemi gerçekleştirdiniz. Kalan bakiyeniz: {Bakiye} TL");
            }
            else
            {
                Console.WriteLine("Geçersiz miktar girdiniz. Tekrar deneyiniz.");
            }
        }

        public void BakiyeGoster()
        {
            Console.WriteLine($"HesapNo: {HesapNo}, Bakiye: {Bakiye}");
        }
    }
}
