using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J._7feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Irj be egy szöveget:");
                string szoveg = Console.ReadLine();
                
                Console.WriteLine(szovegvisszafele(szoveg));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        private static string szovegvisszafele(string szoveg)
        {
            /*
            char[] tombvisszair = szoveg.ToCharArray();
            Array.Reverse(tombvisszair);
            string visszafeleSzoveg = new string(tombvisszair);
            Console.WriteLine(visszafeleSzoveg);
            */
            return new string(szoveg.Reverse().ToArray());
        }
    }
}
