using System;

namespace Advanced_Application_Programming
{
    public class WhileTen
    {
        public static void Main(string[] args)
        {
            int i = 1, j = 10, k = 1, l = j, m = 0,n=10;
            Console.Write(" +\t");
            while (m < 7)
            {
                Console.Write("{0}\t", i);
                i++;
                m++;
            }
            Console.WriteLine();
            m = 0;
            while (m < 5)
            {
                Console.Write("{0}\t", j);
                while (k < 8)
                {
                    Console.Write("{0}\t", j);
                    j += n;
                    k++;
                }
                Console.WriteLine();
                j = l += 10;
                n += 10;
                m++;
                k = 1;
            }
        }
    }
}
