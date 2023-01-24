using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._17_Cevrimler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 10;
            while (sayac >0)
            {
                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac*sayac); //yanyana yazılması için write
                //boşluk atmak için "  " kullanılır vya "{0,5}" kullanılır. bu 0 sayac 5 boşluktur.
                //alt alta yazılması için writeline
                //{1,-3} ise sayının karesini veriyor yeni bir sayı ve sayac anlamına geliyor. yeni
                //sayıyı atamak için sayac*sayac ifadesini kullanıyoruz.
                sayac = sayac - 1;
                //sayac++; sayac = sayac+1
                //sayac +=1; sayac = sayac +1;
            }
            Console.ReadKey();
        }
    }
}