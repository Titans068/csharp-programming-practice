using System;

namespace Advanced_Application_Programming
{
    public class ForOne
    {
        public static void Main(string[] args)
        {
            int h = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < h; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
                h++;
            }
        }
    }
}
