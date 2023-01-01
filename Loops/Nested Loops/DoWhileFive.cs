using System;

namespace Advanced_Application_Programming
{
    public class DoWhileFive
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 1, k = 0;
            do
            {
                do
                {
                    Console.Write("*\t");
                    i++;
                } while (i < j);
                Console.WriteLine();
                k++;
                j++;
                i = 0;
            } while (k < 6);
        }
    }
}
