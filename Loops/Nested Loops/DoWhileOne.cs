using System;

namespace Advanced_Application_Programming
{
    public class DoWhileOne
    {
        public static void Main(string[] args)
        {
            int h = 1, i = 1, j = 0;
            do
            {
                i++;
                do
                {
                    Console.Write(h);
                    h++;
                } while (h < i);
                Console.WriteLine();
                j++;
                h = 1;
            } while (j<5);
        }
    }
}
