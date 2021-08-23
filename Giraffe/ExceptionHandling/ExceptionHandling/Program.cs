using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // If whatever code in this box go wrong...
            try
            {
                Console.WriteLine("Enter a number: ");

                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a number: ");

                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }

            // ... the program will come to here and execute these lines
            catch(Exception e)
            {
                Console.WriteLine("Error. " + e.Message);
            }
            // But these codes below are going to be execute no metter what
            finally
            {
                Console.WriteLine("End of operation"); // Of course, the code here can be something more complex.
            }
            

        }
    }
}
