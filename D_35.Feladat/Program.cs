using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_35.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            szamok = Listafeltolt(10);
            Listakiir(szamok);
            //AtlagNagyobb(szamok);
            Console.ReadKey();
            double avg=Atlag(szamok);
            Console.Write($"a lista átlaga:{avg}");
            Nagyobbintatlag(szamok,avg);
            Console.ReadKey();
        }

        private static void Nagyobbintatlag(List<int> lista, double atlag)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > atlag)
                {
                    Console.Write(lista[i] + " ");
                }
            }
        }

        private static double Atlag(List<int> lista)
        {
            return lista.Average();
        }

        /*private static void AtlagNagyobb(List<int> lista)
        {
            Double osszeg=0;
            for (int i = 0; i < lista.Count; i++)
            {
                osszeg += lista[i];
            }
            Double atlag = osszeg / lista.Count();
            Console.WriteLine($"\nÁtlag:{atlag}");
            Console.Write("A lista átlag feletti értékei: ");
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i]>atlag)
                {
                    Console.Write( lista[i]+" ");
                }
            }

        }*/

        private static void Listakiir(List<int> lista)
        {
            foreach (var elem in lista)
            {
                Console.Write(elem+"  ");
            }
        }

        private static List<int> Listafeltolt(int v)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int vszam=rnd.Next(1,101);
                lista.Add(vszam);
            }
            return lista;
        }
    }
}
