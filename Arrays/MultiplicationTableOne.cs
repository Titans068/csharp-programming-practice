using System;

namespace Advanced_Application_Programming
{
    public class MultiplicationTableOne
    {
        public static void Main(string[] args)
        {
            int[,] table = new int[10, 11];
            int i, j, k = 1, l = 0;

            for (i = 0; i < table.GetLength(0); i++)
            {
                table[i, 0] = l;
                for (j = 1; j < table.GetLength(1); j++)
                {
                    table[i, j] = k++ * (l == 0 ? 1 : l);
                }
                l++;
                k = 1;
            }

            for (i = 0; i < table.GetLength(0); ++i)
            {
                for (j = 0; j < table.GetLength(1); ++j)
                    Console.Write("{0}\t", table[i, j]);
                Console.WriteLine();
            }
        }
    }
}
