using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string secretWord = "giraffe";

            int guessCount = 0;

            int guessLimit = 5;

            // Loop
            while(true)
            {
                // Prompt word from user
                Console.Write("Enter a word: ");
                string guess = Console.ReadLine();

                // If user is right
                if(secretWord == guess)
                {
                    Console.WriteLine("Congratulations! You are right");
                    Console.WriteLine("Your attempts: " + guessCount);
                    break;
                }

                // If user is wrong
                Console.WriteLine("Wrong!");
                guessCount++;

                // If user run out of attempts
                if (guessCount == guessLimit)
                {
                    Console.WriteLine("You lose! Limit of guesses achieved");
                    break;
                }
            }
        }
    }
}
