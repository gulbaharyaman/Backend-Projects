using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiralamaSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri bireysel=new BireyselMusteri(1,"Aslı","0535 242 34 48","12345678901");
            Arac arac=new Araba("Renault","Clio");
            Kiralama kiralama = new Kiralama(bireysel,arac,DateTime.Today,DateTime.Today.AddDays(5));
            Console.WriteLine($"Kiralama tutarı: {kiralama.toplamUcret} TL");
            double ceza=kiralama.GecikmeUcreti(DateTime.Today.AddDays(7));
            if( ceza > 0 ) Console.WriteLine($"Ceza: {ceza}");
        }
    }
}
