using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_38.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            szamok = Listafeltolt(10);
            Listakiir(szamok);
            Melyikanagyobb(szamok);
            Console.ReadLine();
        }

        private static void Melyikanagyobb(List<int> szamok)
        {
            int max=szamok.Max();
            Console.Write("\nA legnagyobb szám:"+max);
        }

        static void Listakiir(List<int> lista)
        {
            Console.Write("A lista elemei:" + string.Join(" ", lista));
        }

        static List<int> Listafeltolt(int v)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < v; i++)
            {
                lista.Add(rnd.Next(200, 301));
            }
            return lista;
        }
    }
}
