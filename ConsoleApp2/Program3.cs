using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program3
    {
        static void Main()
        {
            
            double num1, num2;

            
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            
            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            
            double result = 0;
            if (choice == 1)
            {
                result = num1 + num2;
                Console.WriteLine($"Addition: {num1} + {num2} = {result}");
            }
            else if (choice == 2)
            {
                result = num1 - num2;
                Console.WriteLine($"Subtraction: {num1} - {num2} = {result}");
            }
            else if (choice == 3)
            {
                result = num1 * num2;
                Console.WriteLine($"Multiplication: {num1} * {num2} = {result}");
            }
            else if (choice == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Division: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
            }
        }
    }

}

