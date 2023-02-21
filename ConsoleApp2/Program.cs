using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jüri sayısını giriniz:");
            int JüriSayisi=Convert.ToInt32(Console.ReadLine());
            int hakim1 = 2500, hakim2 = 3300, ÖdenecekRüşvet;
            ÖdenecekRüşvet = hakim1;
            if (hakim1 < hakim2)
            {
                Console.WriteLine("Bizim hakim1'e rüşvet vermemiz her zaman daha uygun olur.");
            }
            int JüriToplam = JüriSayisi * 50;//Jürilere verilecek toplam ücrettir.
            int ÖdemeÇeşidi1 = (hakim1 / 2) + (JüriToplam / 2);//jürilerin 50% ve hakimin yarısı ücreti.
            if (ÖdenecekRüşvet>JüriToplam)
            {
                ÖdenecekRüşvet = JüriToplam;
                Console.WriteLine("Jürilere rüşvet verip beraat ettik.");
            }
            else if (ÖdenecekRüşvet > ÖdemeÇeşidi1){
                ÖdenecekRüşvet = ÖdemeÇeşidi1;
                Console.WriteLine("Hakim1'e ve jürilerin yarısına rüşvet verip beraat ettik.");
            }
            else if (ÖdenecekRüşvet == ÖdemeÇeşidi1)
            {
                Console.WriteLine("Her rüşvet şekli ile beraat edebiliriz.");
            }
            else
            {
                Console.WriteLine("Hakim1'e rüşvet verip beraat ettik.");
            }
            Console.Read();

        }
    }
}
