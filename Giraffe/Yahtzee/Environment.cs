using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Environment
    {
        public static void setBoolTo(bool[] bol, int n, bool b)
        {
            for (int i = 0; i < n; i++)
            {
                bol[i] = b;
            }
        }

        public static int CheckErrors(int less, int larger, string str = "", int which = 0)
        {
            bool keep = true;
            int n = -1;

            do
            {
                try
                {
                    if (str == "")
                    {
                        
                    }
                    else if (which == 0)
                    {
                        Console.WriteLine(str);
                    }
                    else 
                    {
                        Console.Write(str);
                    }
                    
                    
                    n = Convert.ToInt32(Console.ReadLine());
                    
                    

                    keep = false;

                    if (!(n <= larger && n >= less))
                    {
                        Console.WriteLine("Error. Incorrect number");
                        keep = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            while (keep);
            return n;
        }
    }
}
