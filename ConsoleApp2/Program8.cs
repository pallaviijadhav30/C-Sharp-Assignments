using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program8
    
    {
       
        static void Main()
        {
            Console.WriteLine("Numbers from 100 to 5 with a gap of 3 using do while loop:");
            int i = 100;
            do
            {
                Console.WriteLine(i);
                i -= 3;
            } while (i >= 5);

            Console.WriteLine("\nNumbers from 100 to 5 with a gap of 3 using while loop:");
            int j = 100;
            while (j >= 5)
            {
                Console.WriteLine(j);
                j -= 3;
            }

            Console.WriteLine("\nNumbers from 100 to 5 with a gap of 3 using for loop:");
            for (int k = 100; k >= 5; k -= 3)
            {
                Console.WriteLine(k);
            }
        }
    }

}


