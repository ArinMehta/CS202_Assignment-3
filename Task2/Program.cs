using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            // For loop from 1 to 10
            Console.WriteLine("For loop (1 to 10):");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            // Foreach loop from 1 to 10
            Console.WriteLine("\n\nForeach loop (1 to 10):");
            int[] numbers = { 1,2,3,4,5,6,7,8,9,10 };
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            // Do-while loop for user input
            string input;
            do
            {
                Console.Write("\n\nEnter a number to find its factorial (or type 'exit' to quit): ");
                input = Console.ReadLine() ?? "";

                if (input.ToLower() != "exit")
                {
                    if (int.TryParse(input, out int n))
                    {
                        long fact = Factorial(n);
                        Console.WriteLine($"Factorial of {n} = {fact}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number or 'exit'.");
                    }
                }

            } while (input.ToLower() != "exit");

            Console.WriteLine("\nProgram ended!");
        }

        // Function to calculate factorial
        static long Factorial(int num)
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}