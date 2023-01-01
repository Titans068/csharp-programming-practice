using System;

namespace Advanced_Application_Programming
{
    public class MultiplicationTableRedone
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 0, k = 1, l = 1;
            do
            {
                j = 0;
                Console.Write("{0}\t", l == 1 ? "*" : l);
                do
                {
                    Console.Write("{0}\t", k++ * l);
                    j++;
                } while (j < 10);
                Console.WriteLine();
                k = 1;
                l++;
                i++;
            } while (i <= 10);
        }
    }
}
