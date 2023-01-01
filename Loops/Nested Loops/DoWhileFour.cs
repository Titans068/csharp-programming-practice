using System;

namespace Advanced_Application_Programming
{
    public class DoWhileFour
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 2, k = 0, l = 2;
            do
            {
                do
                {
                    Console.Write("{0}\t", j);
                    i++;
                    j++;
                } while (i < 5);
                Console.WriteLine();
                k++;
                i = 0;
                j = ++l;
            } while (k < 5);
        }
    }
}
