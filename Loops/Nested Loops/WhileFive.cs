using System;

namespace Advanced_Application_Programming
{
    public class WhileFive
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 1, k = 0;
            while (k < 6)
            {
                while (i < j)
                {
                    Console.Write("*\t");
                    i++;
                }
                Console.WriteLine();
                k++;
                j++;
                i = 0;
            }
        }
    }
}
