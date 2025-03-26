using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot:");
            int szam = int.Parse(Console.ReadLine());
            if (parosE(szam))
            {
                Console.WriteLine("A szám páros");
            }
            else
            {
                Console.WriteLine("A szám páratlan");
            }
            Console.WriteLine(parosE(szam));

            Console.ReadKey();
        }

        private static bool parosE(int szam)
        {
            if (szam % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
