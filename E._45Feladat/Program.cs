using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._45Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a mátrix első elemét:");
            int v=int.Parse(Console.ReadLine());
            Console.Write("Add meg a mátrix második elemét:");
            int w=int.Parse(Console.ReadLine());
            int[,] matrix = new int[v,w];
            matrix = Matrixtombfeltolt(v,w);
            //Matrixmetodkiir(matrix[]);
            Console.ReadKey();
        }

        private static void Matrixmetodkiir(int[,] matrix)
        {
           
        }

        private static int[,] Matrixtombfeltolt(int v ,int w)
        {
            int[,] metodusmatrix = new int[v, w];
            Random rnd= new Random();
            for (int i = 0; i < v; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    metodusmatrix[i, j] = rnd.Next(1, 101);
                }
            }
            return metodusmatrix;
        }
    }
}
