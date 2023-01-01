using System;

namespace Advanced_Application_Programming
{
    public class WhileSeven
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 4, k = 0, l = 4;
            while (i < 6)
            {
                Console.Write("* ");
                i++;
            }
            Console.WriteLine();
            while (k < 4)
            {
                while (j > 0)
                {
                    Console.Write("  ");
                    j--;
                }
                Console.Write("*");
                Console.WriteLine();
                k++;
                j = --l;
            }
            i = 0;
            while (i < 6)
            {
                Console.Write("* ");
                i++;
            }
        }
    }
}
