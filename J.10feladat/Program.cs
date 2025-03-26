using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J._10feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feladat: Írj egy Legnagyobb metódust,
            //amely egy int[] tömböt kap paraméterként, és visszaadja a legnagyobb számot!
            Random rnd = new Random();
            Console.Write("Adj meg egy számot:");
            int n = int.Parse(Console.ReadLine());
            int[] tomb = new int[n];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 100);
            }
            int legnagyobb = Legnagyobbszam(tomb);
            Console.WriteLine($"A legnagyobb szám: {legnagyobb}");
            Console.ReadKey();
        }

        private static int Legnagyobbszam(int[] szamok)
        {
            int legnagyobb = szamok[0];
            foreach (int szam in szamok)
            {
                if (szam > legnagyobb)
                {
                    legnagyobb = szam;
                }
            }
            return legnagyobb;
        }
    }
}
