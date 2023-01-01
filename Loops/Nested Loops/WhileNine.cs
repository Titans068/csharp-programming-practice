using System;

namespace Advanced_Application_Programming
{
    public class WhileNine
    {
        public static void Main(string[] args)
        {
            int i = 10, j = 60, k = 1, l = j, m = 0;
            Console.Write(" +\t");
            while (m < 5)
            {
                Console.Write("{0}\t", i);
                i += 10;
                m++;
            };
            Console.WriteLine();
            m = 0;
            while (m < 7)
            {
                while (k < 7)
                {
                    Console.Write("{0}\t", j);
                    j += 10;
                    k++;
                }
                Console.WriteLine();
                j = l -= 5;
                m++;
                k = 1;
            }
        }
    }
}
