using System;

namespace Advanced_Application_Programming
{
    public class ForEight
    {
        public static void Main(string[] args)
        {
            int i, j = 1, k = 3;
            for (i = 0; i < 5; i++)
            {
                Console.Write("& ");
            }
            Console.WriteLine();
            for (int l = 0; l < 4; l++)
            {
                for (i = 0; i < j; i++)
                {
                    Console.Write("* ");
                }
                Console.Write("& ");
                for (i = 0; i < k; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                j++;
                k--;
            }
            for (i = 0; i < 5; i++)
            {
                Console.Write("& ");
            }

        }
    }
}
