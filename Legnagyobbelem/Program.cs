using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legnagyobbelem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Add meg a tömb méretét:");
                int n=int.Parse(Console.ReadLine());
                int[] szamok = Tombfeltolt(n);
                Console.WriteLine($"A legnagyobb szám: {Legnagyobb(szamok)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("A pogram elszált egy hiba miatt :( ......");
                Console.ReadKey();
            }       
        }
        static int[] Tombfeltolt(int n)
        {
            int[] szamok = new int[n];
            Console.WriteLine("Add meg a tömb elemeit!");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. elem: ");
                szamok[i] = int.Parse(Console.ReadLine());
            }
            return szamok;
        }
        static int Legnagyobb(int[] tomb)
        {
            int maximum=tomb[0];
            for (int i = 1;i < tomb.Length; i++) {
                if (tomb[i]>maximum)
                {
                    maximum = tomb[i];
                }
            }
            return maximum;
        }
    }
}
