using System;

namespace Advanced_Application_Programming
{
    public class WhileSix
    {
        public static void Main(string[] args)
        {
            int i = 6, j = 0, k = 1, l = 6, m = 6;
            while (i > 0)
            {
                while (l > 0)
                {
                    Console.Write(" ");
                    l--;
                }
                while (j < k)
                {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine();
                i--;
                k++;
                j = 0;
                l = --m;
            }
        }
    }
}
