using System;

namespace Advanced_Application_Programming
{
    public class DoWhileNine
    {
        public static void Main(params string[] args)
        {
            int i = 10, j = 60, k = 1, l = j, m = 0;
            Console.Write(" +\t");
            do
            {
                Console.Write("{0}\t",i);
                i += 10;
                m++;
            } while (m < 5);
            Console.WriteLine();
            m = 0;
            do
            {
                do
                {
                    Console.Write("{0}\t", j);
                    j += 10;
                    k++;
                } while (k < 7);
                Console.WriteLine();
                j = l -= 5;
                m++;
                k = 1;
            } while (m < 7);
        }
    }
}
