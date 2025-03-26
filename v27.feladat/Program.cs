using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D27.feladat
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                List<int> szamok = new List<int>();
                szamok = listabeker(5);
                Listakiir(szamok);
                Listalegnagyobb(szamok);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }

        private static void Listalegnagyobb(List<int> lista)
        {
            int max=lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i]>max)
                {
                    max = lista[i];
                }
            }
            Console.WriteLine();
            Console.Write($"A Lista legnagyobb száma: {max}");
        }

        static void Listakiir(List<int> lista)
        {
            Console.Write("A lista elemei: ");
            foreach (var elem in lista)
            {
                Console.Write(elem+" ");
            }
        }

        static List<int> listabeker(int n)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}.szám:");
                int szam=int.Parse( Console.ReadLine() );
                lista.Add(szam);
            }
            return lista;
        }
    }
}
