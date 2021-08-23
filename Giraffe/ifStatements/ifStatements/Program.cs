using System;

namespace ifStatements
{
    class Program
    {
        static int Main(string[] args)
        {
            bool isMale = true;

            if(isMale)
            {
                Console.WriteLine("Run away");
                return 1;
            }
            else
            {
                Console.WriteLine("Approach");
                return 0;
            }

        }
    }
}
