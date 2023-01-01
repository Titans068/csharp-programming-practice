using System;

namespace Advanced_Application_Programming
{
    public class DoWhileSeven
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 4, k = 0, l = 4;
            do
            {
                Console.Write("* ");
                i++;
            } while (i < 6);
            Console.WriteLine();
            do
            {
                do
                {
                    Console.Write("  ");
                    j--;
                } while (j > 0);
                Console.Write("*");
                Console.WriteLine();
                k++;
                j = --l;
            } while (k < 4);
            i = 0;
            do
            {
                Console.Write("* ");
                i++;
            } while (i < 6);
        }
    }
}
