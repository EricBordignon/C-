using System;


namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get number of players from user
            int n = Environment.CheckErrors(2, 10, "How many players: ", 1);

            // Create an array of players out of the object player
            player[] players = new player[n];

            // Call functions
            get_names(players, n);

            start(players, n);
        }

        static void get_names(player[] players, int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Initialize element from players
                players[i] = new player();

                
                
                bool keep = true;
                do
                {
                    try
                    {
                        // Get name from user
                        Console.Write($"Name from player {i + 1}: ");
                        players[i].name = Console.ReadLine();
                        keep = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (keep);
            }
        }

        static void start(player[] players, int n)
        {
            for(int i = 0; i < player.categories; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    players[j].round();

                    Console.Clear();

                    Console.WriteLine();

                    players[j].printBox();

                    Console.WriteLine("Press anything to finish round");
                    try
                    {
                        string trash = Console.ReadLine();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

        }
    }
}
