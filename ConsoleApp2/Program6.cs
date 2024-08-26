using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program6
  
    {
        static void Main()
        {
            Console.WriteLine("Odd numbers from 1 to 100 using do while loop:");
            int i = 1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 100);

            Console.WriteLine("\nOdd numbers from 1 to 100 using while loop:");
            int j = 1;
            while (j <= 100)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            Console.WriteLine("\nOdd numbers from 1 to 100 using for loop:");
            for (int k = 1; k <= 100; k++)
            {
                if (k % 2 != 0)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }

}

