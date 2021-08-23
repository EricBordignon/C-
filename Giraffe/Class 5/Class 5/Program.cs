using System;

namespace Class_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first number
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Get second number
            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Print out the result
            Console.WriteLine(num1 + num2);
        }
    }
}
