using System;

namespace Advanced_Application_Programming
{
    public class DoWhileThree
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 1, k = 0, l = 2, m = 2;
            do
            {
                do
                {
                    Console.Write("{0}\t", l);
                    i++;
                    l++;
                } while (i < j);
                Console.WriteLine();
                k++;
                j++;
                i = 0;
                l = ++m;
            } while (k < 5);
        }
    }
}
