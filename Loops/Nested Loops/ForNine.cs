using System;

namespace Advanced_Application_Programming
{
    public class ForNine
    {
        public static void Main(string[] args)
        {
            int i, j = 60, k = j, l;
            Console.Write(" +\t");
            for (i = 10; i < 60; i += 10)
                Console.Write("{0}\t", i);

            Console.WriteLine();
            for (i = 0; i < 7; i++)
            {
                for (l = 0; l < 6; l++)
                {
                    Console.Write("{0}\t", j);
                    j += 10;
                }
                j = k -= 5;
                Console.WriteLine();
            }
        }
    }
}
