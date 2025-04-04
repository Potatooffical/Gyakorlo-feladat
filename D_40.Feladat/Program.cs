﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_40.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list = Listafeltolt(10);
            Listakiir(list);
            Parosszamesparatlan(list);
            
            Console.ReadLine();
        }

        private static void Parosszamesparatlan(List<int> list)
        {
            int parosdb = 0;
            int paratlandb = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    parosdb++;
                }
                else
                {
                    paratlandb++;
                }
            }
            Console.Write("\nPáros számok:" + parosdb);
            Console.Write("\nPáratlan számok:" + paratlandb);
        }

        private static void Listakiir(List<int> list)
        {
            Console.Write("A lista elemei:"+string.Join(" ",list));
        }

        private static List<int> Listafeltolt(int v)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < v; i++)
            {
                lista.Add(rnd.Next(1, 101));
            }
            return lista;
        }
    }
}
