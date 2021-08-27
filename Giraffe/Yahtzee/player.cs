using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class player
    {
        public const int categories = 13;
        public const int nDices = 5;
        public const int totalAttempts = 3;

        int[] DICES;

        int quit;

        public string name;
        private int[] score;
        private int[,] boxes;
        private bool[] boxFilled;
        private int totalScore = 0;
        private int[] roundDices;
        private bool[] roundDicesFreezed;
        
        public player()
        {
            score = new int[categories];
            boxes = new int[categories, nDices];
            boxFilled = new bool[categories];

            for(int i = 0; i < categories; i++)
            {
                score[i] = 0;
                boxFilled[i] = false;

                for(int j = 0; j < nDices; j++)
                {
                    boxes[i, j] = 0;
                }
            }

            DICES = new int[nDices];
            roundDices = new int[nDices];
            roundDicesFreezed = new bool[nDices];

            for(int i = 0; i < nDices; i++)
            {
                DICES[i] = i + 1;
            }

            Environment.setBoolTo(roundDicesFreezed, nDices, false);
        }

        

        public void round()
        {   
            Console.Clear();

            Console.WriteLine();

            Random rnd = new Random();

            int attempts = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Turn: " + name);

                attempts++;

                // Randomly get values for dices
                for (int i = 0; i < nDices; i++)
                {
                    if(!(roundDicesFreezed[i]))
                    {
                        roundDices[i] = rnd.Next(1, 6);
                    }

                    Console.WriteLine($"Dado {i + 1}: {roundDices[i]}");
                }

                Environment.setBoolTo(roundDicesFreezed, nDices, false);

                Console.WriteLine();

                

                Console.WriteLine("What do you want to do: ");
                Console.WriteLine("0. Close round");
                Console.WriteLine("1. Roll again");

                // User can roll again or quit
                bool keep;

                quit = Environment.CheckErrors(0, 1);

                /*do
                {
                    try
                    {
                        quit = Convert.ToInt32(Console.ReadLine());

                        if (quit == 0 || quit == 1)
                        {
                            keep = false;
                        }
                        else
                        {
                            keep = true;
                            Console.WriteLine("Wrong value. Only accepted 0 (quit) or 1 (roll again)");
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message + " Only accepted 0 (quit) or 1 (roll again)");
                        keep = true;
                    }
                    

                }
                while (keep);*/
                

                Console.WriteLine();

                // User decided to roll again
                if(quit == 1)
                {
                    
                    if (attempts == totalAttempts)
                    {
                        Console.WriteLine("Last round!");
                        Console.WriteLine();
                    }

                    // Get dices freezed
                    keep = true;

                    int nDicesFreezed = Environment.CheckErrors(1, 6, "How many dices do you want to freeze (press zero if don't want to freeze any dice)");

                    // Freezed dices marked to be freezed
                    if (nDicesFreezed == 0)
                    {
                        continue;
                    }
                    else if(nDicesFreezed == nDices)
                    {
                        Environment.setBoolTo(roundDicesFreezed, nDices, true);
                        continue;
                    }

                    Console.WriteLine("Enter the position of the dice you want to freeze");
                    for(int i = 0; i < nDicesFreezed; i++)
                    {
                        int indice = Environment.CheckErrors(1, 6,"", 1); 

                        indice--;

                        roundDicesFreezed[indice] = true;
                    }
                }  
            }
            while (quit == 1 && attempts < totalAttempts);

            Console.Clear();

            for (int i = 0; i < nDices; i++)
            {
                Console.WriteLine($"Dado {i + 1}: {roundDices[i]}");
            }

            Console.WriteLine();

            printBox();

            populateBoxes();

        }

        private void populateBoxes()
        {
            // TODO: Populate variable boxes and adjust boxFilled
            int nBox;
            bool keep;

            do
            {
                keep = false;
                nBox = Environment.CheckErrors(1, 13, "Which box do you want to fill in the new set");
                if(boxFilled[nBox - 1])
                {
                    Console.WriteLine("Box already filled. Choose another one");
                    keep = true;
                }

            }
            while (keep);
            
            boxFilled[nBox - 1] = true;

            for(int i = 0; i < nDices; i++)
            {
                boxes[nBox - 1, i] = roundDices[i];
            }


        }

        public void printBox()
        {
            // TODO
            Console.WriteLine("Turn: " + name);

            for (int i = 0; i < categories; i++)
            {
                Console.Write($"Box {i + 1}: " );
                for (int j = 0; j < nDices; j++)
                {
                    Console.Write($"{boxes[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        public void calculateScore()
        {
            // TODO

        }

    }


}
