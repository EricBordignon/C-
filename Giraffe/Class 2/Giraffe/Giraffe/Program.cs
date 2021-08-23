using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Girafe Academy";
            string phrase2 = " is cool";

            int n = phrase.Length;
            
            Console.WriteLine(n);

            Console.WriteLine(phrase.ToUpper());

            Console.WriteLine(phrase.Contains("Academy")); // Return true or false if phrase contains the string "Academy"

            Console.WriteLine(phrase[8]);

            Console.WriteLine(phrase.IndexOf("Academy")); // Return which index Academy start in - retrun -1 if Academy is not at the string

            Console.WriteLine(phrase.Substring(7, 3)); // Print substring of string starting in the index given and printing the amount given


        }
    }
}
