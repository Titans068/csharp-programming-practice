using System;

namespace Advanced_Application_Programming
{
    public class WhileThree
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 1, k = 0, l = 2, m = 2;
            while (k < 5)
            {
                while (i < j)
                {
                    Console.Write("{0}\t", l);
                    i++;
                    l++;
                }
                Console.WriteLine();
                k++;
                j++;
                i = 0;
                l = ++m;
            }
        }
    }
}
