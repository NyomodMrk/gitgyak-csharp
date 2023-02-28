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
            List<int> lista=new List<int>();
            int szam;
            do
            {
                Console.WriteLine("Adja meg a számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam != 0)
                {
                    lista.Add(szam);
                }
            } while (szam != 0);
            Console.WriteLine("A legnagyobb szám a felsorolásból a "+lista.Max());
        }
        static void Main(string[] args)
        {
            egesz_szam();
            Console.ReadKey();
        }
    }
}
