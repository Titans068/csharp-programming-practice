using System;

namespace Advanced_Application_Programming
{
    public class ForTen
    {
        public static void Main(string[] args)
        {
            int i, j = 10, k = j, l, n = 10;
            Console.Write(" +\t");
            for (i = 1; i < 8; i++)
                Console.Write("{0}\t", i);

            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}\t", j);
                for (l = 0; l < 7; l++)
                {
                    Console.Write("{0}\t", j);
                    j += n;
                }
                j = k += 10;
                n += 10;
                Console.WriteLine();
            }
        }
    }
}
