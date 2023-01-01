using System;

namespace Advanced_Application_Programming
{
    public class ForSix
    {
        public static void Main(string[] args)
        {
            int k = 1, l = 0, m = 6;
            for (int i = 0; i < 6; i++)
            {
                for (; l < m; l++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < k; j++)
                {
                    Console.Write("* ");
                }
                k++;
                m--;
                l = 0;
                Console.WriteLine();
            }
        }
    }
}
