using System;

namespace Advanced_Application_Programming
{
    public class ForFour
    {
        public static void Main(string[] args)
        {
            int k = 2, l = 2;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 2; j < 7; j++)
                {
                    Console.Write("{0}\t", k++);
                }
                Console.WriteLine();
                k = ++l;
            }
        }
    }
}
