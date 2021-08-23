using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get number from user
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Get operator from user
            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            // Get the other number
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Figure out what operator were typed
            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Error. Invalid operator"); 
            }
        }
    }
}
