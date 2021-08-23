using System;

namespace Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;

            int cubed = cube(n);

            Console.WriteLine(cubed);
        }

        static int cube(int n)
        {
            return n * n * n;
        }
    }
}
