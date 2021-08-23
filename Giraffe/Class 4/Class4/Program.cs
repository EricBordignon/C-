using System;

namespace Class4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.Write("What's your age: ");

            string age = Console.ReadLine();

            Console.WriteLine("You are " + age + " years old");
        }
    }
}
