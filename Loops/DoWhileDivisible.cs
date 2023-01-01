using System;

namespace Advanced_Application_Programming
{
    public class DoWhileDivisible
    {
        public static void Main(string[] args)
        {
            int i = 0;
            do
            {
                if (i % 8 == 0)
                    Console.WriteLine(i);
                i++;
            } while (i < 200);
        }
    }
}