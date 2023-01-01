using System;

namespace Advanced_Application_Programming
{
    public class NestedLoopOne
    {
        public static void Main(string[] args)
        {
            int h = 7;
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= h; j++)
                {
                    Console.Write("{0} ", j + 1);
                }
                Console.WriteLine();
                h--;
            }
        }
    }
}
