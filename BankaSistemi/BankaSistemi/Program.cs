using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Banka.BankaBilgisiGoster();

            Musteri musteri1 = new Musteri("Ferhunde", "Tekin", "7476");
            Musteri musteri2 = new Musteri("Şevket", "Tekin", "8490");
            Musteri musteri3 = new Musteri("Ali Rıza", "Tekin", "6543");

            BankaHesabi hesap1 = new BankaHesabi("001", 20000, musteri1);
            BankaHesabi hesap2 = new BankaHesabi("002",0, musteri2);
            BankaHesabi hesap3 = new BankaHesabi("003",500, musteri3);


            Console.WriteLine("Lütfen işlem yapmak istediğiniz hesap numarasını giriniz: ");
            string secilenHesapNo=Console.ReadLine();
            BankaHesabi aktifHesap;

            if (secilenHesapNo == hesap1.HesapNo)
            {
                aktifHesap = hesap1;
            }
            else if (secilenHesapNo == hesap2.HesapNo)
            {
                aktifHesap = hesap2;
            }
            else if (secilenHesapNo == hesap3.HesapNo)
            {
                aktifHesap = hesap3;
            }
            else { Console.WriteLine("Yanlış hesap numarası girdiniz");
                aktifHesap = null;
            }

            MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
            if (musteriIslemleri != null)
            {
                Console.WriteLine($"\nHoş geldiniz, {aktifHesap.HesapSahibi.Ad} {aktifHesap.HesapSahibi.Soyad}");
                musteriIslemleri.Islemler(aktifHesap);
            }


        }
    }
}
