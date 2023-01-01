using System;

namespace Advanced_Application_Programming
{
    public class WhileEight
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 0, k = 0, l = 1, m = 5;
            while (i < 6)
            {
                Console.Write("& ");
                i++;
            }
            Console.WriteLine();
            while (k < 4)
            {
                while (j < l)
                {
                    Console.Write("* ");
                    j++;
                }
                Console.Write("&");
                j = --m;
                while (j > 0)
                {
                    Console.Write(" *");
                    j--;
                }
                k++;
                l++;
                j = 0;
                Console.WriteLine();
            }
            i = 0;
            while (i < 6)
            {
                Console.Write("& ");
                i++;
            }
        }
    }
}
