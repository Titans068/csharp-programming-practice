using System;

namespace Advanced_Application_Programming
{
    public class ForThree
    {
        public static void Main(string[] args)
        {
            int j = 1, k = 2, l = 2;
            for (int h = 0; h < 5; h++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write("{0}\t", k++);
                }
                Console.WriteLine();
                j++;
                k = ++l;
            }
        }
    }
}
