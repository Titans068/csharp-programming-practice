using System;

namespace Advanced_Application_Programming
{
    public class DoWhileEight
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 0, k = 0, l = 1, m = 5;
            do
            {
                Console.Write("& ");
                i++;
            } while (i < 6);
            Console.WriteLine();
            do
            {
                do
                {
                    Console.Write("* ");
                    j++;
                } while (j < l);
                Console.Write("&");
                j = --m;
                do
                {
                    Console.Write(" *");
                    j--;
                } while (j > 0);
                k++;
                l++;
                j = 0;
                Console.WriteLine();
            } while (k < 4);
            i = 0;
            do
            {
                Console.Write("& ");
                i++;
            } while (i < 6);
        }
    }
}
