using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D44_.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
//          Generáljon ötös lottószám tippeket!Biztosítsa, hogy nem lehet 2 azonos szám a kihúzottak között!

            List<int> szamok=new List<int>();
            szamok = Gamblingfeltolt(5);
            Listakiir(szamok);
            Console.ReadLine();
        }

        private static void Listakiir(List<int> lista)
        {
            Console.Write("A lista kisorsolt elemeket:"+ string.Join(" ",lista));
        }

        private static List<int> Gamblingfeltolt(int v)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < v; i++)
            {
                lista.Add(rnd.Next(1,50));
            }
            return lista;
        }
    }
}
