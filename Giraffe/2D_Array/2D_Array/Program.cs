using System;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hard code populating
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            Console.WriteLine(numberGrid[0, 0]); // 1

            Console.WriteLine(numberGrid[2, 1]); // 5

            // Soft code populating
            int[,] myArray = new int[2, 3];

            int num = 1;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    myArray[i, j] = num;
                    num++;
                }
            }
        }
    }
}
