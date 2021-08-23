using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            SayHi(name, age);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello "+ name + " you're " + age + " years old");
        }
    }
}
