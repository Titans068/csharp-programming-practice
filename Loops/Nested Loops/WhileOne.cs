using System;

namespace Advanced_Application_Programming
{
    public class WhileOne
    {
        public static void Main(string[] args)
        {
            int h = 1, i = 1, j = 0;
            while (j < 5)
            {
                i++;
                while (h < i)
                {
                    Console.Write(h);
                    h++;
                }
                Console.WriteLine();
                j++;
                h = 1;
            }
        }
    }
}
