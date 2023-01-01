using System;

namespace Advanced_Application_Programming
{
    public class Reciprocal
    {
        public static void Main(string[] args)
        {
            int ans;
            char val;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("\nEnter a number");
                    ans = Convert.ToInt32(Console.ReadLine());
                    if (ans != 0) break;
                }
                Console.WriteLine("The reciprocal of {0} is {1}", ans, Math.Pow(ans, -1));
                Console.WriteLine("Do you want to continue?");
                val = Console.ReadKey().KeyChar;
                if (val != 'c') break;
            }
        }
    }
}