using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D41_.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            szamok = Listafeltolt(10);
            Listakiir(szamok);
            int osszeg = Osszeg(szamok);
            Szorzat(szamok);
            Atlag(szamok, osszeg);
            Console.ReadLine();
        }

        private static void Atlag(List<int> lista, int osszeg)
        {
            double atlag = (double)osszeg / lista.Count;
            Console.Write("\nA lista átlaga: " + atlag);
        }

        private static void Szorzat(List<int> lista)
        {
            int szorzat = 1;
            foreach (int szam in lista)
            {
                szorzat *= szam;
            }
            Console.Write("\nA lista szorzatai: " + szorzat);
        }

        private static int Osszeg(List<int> lista)
        {
            int osszeg = 0;
            foreach (int szam in lista)
            {
                osszeg += szam;
            }
            Console.Write("\nA lista összege: " + osszeg);
            return osszeg;
        }

        private static void Listakiir(List<int> lista)
        {
            Console.Write("A lista elemei: " + string.Join(" ", lista));
        }

        private static List<int> Listafeltolt(int v)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < v; i++)
            {
                lista.Add(rnd.Next(100, 200));
            }
            return lista;
        }
    }
}
