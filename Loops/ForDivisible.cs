using System;

namespace Advanced_Application_Programming
{
    public class ForDivisible
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 200; i++)
                if (i % 8 == 0)
                    Console.WriteLine(i);
        }
    }
}