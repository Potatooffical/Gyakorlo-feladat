using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_43.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.Write("Adj meg egy számot a lista hosszára:");
                int n = int.Parse(Console.ReadLine());
                List<int> szamok = Listafeltolt(n);
                Listakiir(szamok);
                Parosszamkivalasztkiir(szamok);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
           
            Console.ReadLine();
        }

       

        private static void Parosszamkivalasztkiir(List<int> lista)
        {   
            Console.Write("\nSzámok a listában amik párossak: ");
            foreach (int i in lista)
            {             
                if (i % 2 == 0)
                {
                    int szamkiir= i ;
                    Console.Write(szamkiir + " ");
                }  
            }
        }

        static void Listakiir(List<int> lista)
        {
            Console.Write("A lista ki generálta ezzeket a számokat 1-100ig:");
            foreach (var elem in lista)
            {
                Console.Write($" {elem},");
            }
        }

        static List<int> Listafeltolt(int n)
        {
            List<int> lista = new List<int>(n);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int vszam = rnd.Next(1, 101);
                lista.Add(vszam);
            }
            return lista;
        }
    }
}
