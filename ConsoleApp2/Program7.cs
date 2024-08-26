using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program7
    
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Using do while loop
            Console.WriteLine("\nMultiplication table using do while loop:");
            int i = 1;
            do
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
                i++;
            } while (i <= 10);

            // Using while loop
            Console.WriteLine("\nMultiplication table using while loop:");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine($"{number} x {j} = {number * j}");
                j++;
            }

            // Using for loop
            Console.WriteLine("\nMultiplication table using for loop:");
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine($"{number} x {k} = {number * k}");
            }
        }
    }

}
