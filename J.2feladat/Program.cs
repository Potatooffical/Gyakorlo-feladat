using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J._2feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Feladat: Készíts egy Maximum metódust, amely két egész számot kap paraméterként, ésvisszaadja a nagyobbat!we*/
                Console.Write("Add meg az első számot:");
                int szam1 = int.Parse(Console.ReadLine());
                Console.Write("Add meg az második számot:");
                int szam2 = int.Parse(Console.ReadLine());
                if (szam1 == szam2)
                {
                    Console.WriteLine("Mindkét szám azonos");
                }
                else
                {
                    Console.WriteLine($"A maximális érték: {Maximumkeres(szam1, szam2)} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sajnos hiba történt :( " +ex.Message);
                
            }
            Console.WriteLine("Legyen szép napod <3 ");
            Console.ReadKey();
        }

        

        private static int Maximumkeres(int szam1,int szam2)
        {
            /*egyik megoldás max fügvénnyel de már nem feladat :/
             * return Math.Max(szam1, szam2);*/

            if (szam1 > szam2)
            {
                Console.WriteLine("Az első szam a nagyobb");
                return szam1;
            }
            else
            {
                Console.WriteLine("A második a nagyobb");
                return szam2;
            }
            
        }
    }
}
