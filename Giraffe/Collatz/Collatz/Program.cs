using System;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 27;

            while (n != 1)
            {
                Console.WriteLine(n);

                if (n % 2 == 1)
                {
                    n *= 3;
                    n++;
                }

                else
                {
                    n /= 2;
                }
            }

            Console.WriteLine(n);

        }
    }
}
