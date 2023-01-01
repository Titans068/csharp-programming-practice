using System;

namespace Advanced_Application_Programming
{
    public class ForFive
    {
        public static void Main(string[] args)
        {
            int k = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*\t");
                }
                k++;
                Console.WriteLine();
            }
        }
    }
}
