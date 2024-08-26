using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program2
    {
        static void Main()
        {
            
            double num1, num2;

            
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            
            double addition = num1 + num2;

            
            double subtraction = num1 - num2;

            
            double multiplication = num1 * num2;

           
            double division = 0;
            if (num2 != 0)
            {
                division = num1 / num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

           
            Console.WriteLine("\nResults:");
            Console.WriteLine("Addition: " + addition);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Multiplication: " + multiplication);

            
            if (num2 != 0)
            {
                Console.WriteLine("Division: " + division);
            }
        }
    }

}

