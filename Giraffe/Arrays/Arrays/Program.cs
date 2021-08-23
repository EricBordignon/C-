using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of integers
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(luckyNumbers[2]);

            Console.WriteLine();

            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            // Array of strings
            string[] friends = new string[3];
            
            for(int i = 0; i < friends.Length; i++)
            {
                Console.Write("Enter a friend name: ");
                friends[i] = Console.ReadLine();
            }

            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }

        }
    }
}
