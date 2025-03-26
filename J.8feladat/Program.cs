using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J._8feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("adj meg egy számot:");
                int szam = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Faktorialis(szam)}");
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message );
            }
            
        }

        static int Faktorialis(int szam)
        {
            int fact = 1;
            for (int i = 1; i <= szam; i++)
            {
                fact = fact * i;
            }
            return fact;
           
        }
    }
}
