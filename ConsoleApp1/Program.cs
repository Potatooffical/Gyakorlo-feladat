using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Add meg a négyzet oldalait én meg kiszámolom:");
            int n = int.Parse(Console.ReadLine());
            /*Feladat: Írj egy NegyzetTerulet metódust, amely egy számot kap paraméterként (az oldal hosszát), és visszaadja a négyzet területét!*/
            //int terulet = NegyzetTerulet(n) a metodus kiiraása egy valtozoban
            Console.WriteLine($"A négyzet területe: {NegyzetTerulet(n)}");
            Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private static int NegyzetTerulet(int n)
        {
            return n * n;
        }
    }
}
