using System;

namespace InverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get word from user
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            for(int i = word.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }

        }
    }
}
