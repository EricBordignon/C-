using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user the day number
            Console.WriteLine("Enter the day number: ");

            // Get the number, call method and print result
            Console.WriteLine(GetDay(Convert.ToInt32(Console.ReadLine())));
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            // Assign a number to a day of week
            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}
