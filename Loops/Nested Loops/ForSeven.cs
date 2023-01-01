using System;

namespace Advanced_Application_Programming
{
    public class ForSeven
    {
        public static void Main(string[] args)
        {
            int i, j, k = 4;
            for (i = 0; i < 6; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            for (int h = 0; h < 4; h++)
            {
                for (j = k; j > 0; j--)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("*");
                k--;
            }
            for (i = 0; i < 6; i++)
            {
                Console.Write("* ");
            }
        }
    }
}
