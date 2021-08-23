using System;

namespace Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string color, pluralNoun, celebrity;

            // Prompt information from user
            Console.WriteLine("Enter:\n1.Color\n2.Plural Noun\n3. Celebrity name");

            // Get those infomrations
            color = Console.ReadLine();
            pluralNoun = Console.ReadLine(); ;
            celebrity =  Console.ReadLine();

            // Print out
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
        }
    }
}
