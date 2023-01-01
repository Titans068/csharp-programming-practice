using System;

namespace Advanced_Application_Programming
{
    public class DoWhileTen
    {
        public static void Main(params string[] args)
        {
            int i = 1, j = 10, k = 1, l = j, m = 0,n=10;
            Console.Write(" +\t");
            do
            {
                Console.Write("{0}\t", i);
                i++;
                m++;
            } while (m < 7);
            Console.WriteLine();
            m = 0;
            do
            {
                Console.Write("{0}\t", j);
                do
                {
                    Console.Write("{0}\t", j);
                    j += n;
                    k++;
                } while (k < 8);
                Console.WriteLine();
                j = l += 10;
                n += 10;
                m++;
                k = 1;
            } while (m < 5);
        }
    }
}
