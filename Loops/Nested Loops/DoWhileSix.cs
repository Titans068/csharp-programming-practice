using System;

namespace Advanced_Application_Programming
{
    public class DoWhileSix
    {
        public static void Main(string[] args)
        {
            int i = 6, j = 0, k = 1, l = 6, m = 6;
            do
            {
                do
                {
                    Console.Write(" ");
                    l--;
                } while (l > 0);
                do
                {
                    Console.Write("* ");
                    j++;
                } while (j < k);
                Console.WriteLine();
                i--;
                k++;
                j = 0;
                l = --m;
            } while (i > 0);
        }
    }
}
