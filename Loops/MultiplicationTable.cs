using System;

namespace Advanced_Application_Programming
{
    public class MultiplicationTable
    {
        public static void Main(string[] args)
        {
            /*
             * *    1    2    3    4    5    6
             * 1    1    2    3    4    5    6
             * 2    2    4    6    8   10   12
             * 3    3    6    9   12   15   18
             * 4    4    8    12  16   20   24
             * 5    5   10    15  20   25   30
            */
            int i = 0, j = 1, k = 1;

            Console.Write("\t");
            for (int l = 1; l <= 6; l++)
            {
                Console.Write(l + "\t");
            }
            Console.WriteLine();

            do
            {
                Console.Write(j + "\t");
                do
                {
                    Console.Write(j + "\t");
                    j += k;
                } while (j <= 6 * k);
                i++;
                Console.WriteLine();
                j = ++k;
            } while (i < 5);
        }
    }
}