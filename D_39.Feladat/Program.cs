using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_39.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            szamok = Listafeltolt(10);
            Listakiir(szamok);
            
            Legkisebb(szamok);
            Legnagyobb(szamok);
            Console.ReadLine();
        }

        private static void Legnagyobb(List<int> lista)
        {
            int max = lista.Max();
            Console.Write("\nA lista legnagyobb eleme:"+max);
        }

        private static void Legkisebb(List<int> lista)
        {
           int min=lista.Min();
            Console.Write("\nA lista legkisebb elem:"+min);
        }

        static void Listakiir(List<int> lista)
        {
            Console.Write("A lista elemi:"+string.Join(" ",lista));
        }

        static List<int> Listafeltolt(int v)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < v; i++)
            {
                lista.Add(rnd.Next(20, 61));
            }
            return lista;
        }
    }
}
