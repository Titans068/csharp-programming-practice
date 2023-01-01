using System;

namespace Advanced_Application_Programming
{
    public class WhileFour
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 2, k = 0, l = 2;
            while (k < 5)
            {
                while (i < 5)
                {
                    Console.Write("{0}\t", j);
                    i++;
                    j++;
                }
                Console.WriteLine();
                k++;
                i = 0;
                j = ++l;
            }
        }
    }
}
