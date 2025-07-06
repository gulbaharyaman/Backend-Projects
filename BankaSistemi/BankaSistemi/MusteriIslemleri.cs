using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankaSistemi
{
    class MusteriIslemleri
    {
        public void Islemler(BankaHesabi hesap)
        {
            Console.WriteLine("---------------işlemler---------------");
            Console.WriteLine("1- Bakiye Kontrol");
            Console.WriteLine("2- Para Yatır");
            Console.WriteLine("3- Para Çek");

            Console.WriteLine("İşlem numarasını giriniz: ");
            int islemNo=Convert.ToInt32(Console.ReadLine());

            switch (islemNo) { 
                case 1:
                    hesap.BakiyeGoster();
                    break;
                case 2:
                    Console.WriteLine("Yatırılacak miktarı giriniz: ");
                    double yatir = Convert.ToDouble(Console.ReadLine());
                    hesap.ParaYatir(yatir);
                    break;
                case 3:
                    Console.WriteLine("Çekilecek para miktarı giriniz: ");
                    double cek = Convert.ToDouble(Console.ReadLine());
                    hesap.ParaCek(cek);
                    break;
                default: 
                    Console.WriteLine("Geçersiz işlem numarası girdiniz");
                    break;
            }
        }
    }
}
