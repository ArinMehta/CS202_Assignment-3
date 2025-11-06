using System;

namespace STT
{
    class Program1
    {
        static void Main()
        {
            Console.WriteLine("Enter the First Number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            double quotient;
            if (num2 != 0)
            {
                quotient = num1 / num2;
            }
            else
            {
                quotient = double.NaN;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            
            if (sum % 2 == 0)
            {
                Console.WriteLine("The sum is even.");
            }
            else
            {
                Console.WriteLine("The sum is odd.");
            }
        }
    }
}