using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_37.Feladat
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            szamok = Listafeltolt(30);
            Listakiir(szamok);
            Negativelemek(szamok);
            Pozitivszámok(szamok);
            Nullasszamok(szamok);
            Console.ReadLine();
        }

        private static void Pozitivszámok(List<int> lista)
        {
            int dbpozitiv = 0;
            foreach (var elem in lista)
            {
                if (elem>0)
                {
                    dbpozitiv++;
                }
            }
            Console.Write("\nPozitivszámok száma:" + dbpozitiv + ";");
        }

        private static void Nullasszamok(List<int> lista)
        {
            int dbnulla = 0;
            foreach (var elem in lista)
            {
                if (elem == 0)
                {
                    dbnulla++;
                }
            }
            Console.Write("\nNullásszámok száma:" + dbnulla + ";");
        }

        static void Negativelemek(List<int> lista)
        {
            int dbnagtiv = 0;
            foreach (var elem in lista)
            {
                if (elem<0)
                {
                    dbnagtiv++;
                }
            }
            Console.Write("Negaivszámok száma:" +dbnagtiv+";");
        }

        static void Listakiir(List<int> lista)
        {
            Console.WriteLine("A lista elemei:"+string.Join(" ", lista));
        }

        static List<int> Listafeltolt(int n)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < n; i++)
            {
                lista.Add(rnd.Next(-50, 50));
            }
            return lista;
        }
    }
}
