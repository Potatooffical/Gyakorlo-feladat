using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_42.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.Write("Ird be egy számot amely meghatároza a lista méretét:");
                int n =int.Parse(Console.ReadLine());
                List<int> szamok = new List<int>();
                List<int> szamokparos = new List<int>();    
                szamok = Listafeltölt(n);
                ListaKiir(szamok);
                Parosszamok(szamok);
               
			}
			catch (Exception e)
			{
                Console.Write(e.Message);
			}
            Console.ReadLine();
        }

        

        private static void Parosszamok(List<int> szamok)
        {
            List<int> paros = new List<int>();
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok.Count%2==0)
                {
                    paros.Add(szamok.Count);
                }
            }   
        }

        private static void ListaKiir(List<int> lista)
        {
            Console.Write("A lista elemei:"+string.Join(" ",lista));
        }

        private static List<int> Listafeltölt(int n)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                lista.Add(rnd.Next(1, 101));
            }
            return lista;
        }
    }
}
