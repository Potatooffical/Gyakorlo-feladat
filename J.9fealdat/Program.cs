using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace J._9fealdat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot:");
            int szam = int.Parse(Console.ReadLine());
            /*if (PrimE(szam))
            {
                Console.WriteLine("Primszám");
            }
            else
                Console.WriteLine("Nem primszam");*/
            //Console.WriteLine($"Prim-e?:{PrimE(szam)}");
            Console.WriteLine(PrimE(szam)?"Primszám":"Nem primszám");
            Console.ReadKey();
        }
        static bool PrimE(int szam)
        {
            int osztokszam = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0) osztokszam++;
            }
            if (osztokszam == 2) return true;
            else return false;
        }
    }
}
