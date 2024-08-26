using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program5
   
    {
        static void Main()
        {
            int i = 1; 
            Console.WriteLine("Even numbers using do-while loop:");

            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 20);

        }


    }
}



