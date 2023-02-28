using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitgyak_csharp
{
    internal class Program
    {

        static void egesz_szam()
        {
            int nagyobb = 0;
            Console.WriteLine("Adj meg egy egész számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg egy másik egész számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            if (szam1 > szam2)
            {
                Console.WriteLine("Az első szám a nagyobb");
                nagyobb=szam1;
                Console.WriteLine(nagyobb);
            }
            if (szam2 > szam1)
            {
                Console.WriteLine("A második szám a nagyobb");
                nagyobb = szam2;
                Console.WriteLine(nagyobb);
            }
        }
        static void Main(string[] args)
        {
            egesz_szam();
            Console.ReadKey();
        }
    }
}
