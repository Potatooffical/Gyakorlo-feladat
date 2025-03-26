using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace D_36.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>(10);
            szamok = Listafeltolt(10);
            Listakiir(szamok);
            HaromLegnagyobb(szamok);
            Console.ReadLine();
        }

        private static void HaromLegnagyobb(List<int> lista)
        {
            lista.Sort();
            lista.Reverse();
            Console.WriteLine();
            Console.Write($"A lista három legnagyobb száma: {lista[0]},{lista[1]},{lista[2]}");
            
        }

        private static void Listakiir(List<int> lista)
        {
            foreach (var elem in lista)
            {
                Console.Write(elem+" ");
                
            }
        }

        private static List<int> Listafeltolt(int v)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int vszam = rnd.Next(100, 200);
                lista.Add(vszam);
            }
            return lista;
        }
    }
}
