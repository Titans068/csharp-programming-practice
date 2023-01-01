using System;

// Fibonacci Day -> November 23 2022
namespace Advanced_Application_Programming
{
    public class FibonacciDay
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter no of terms:> ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int h = 1, i = 0, j = 1, k = 0;
            Console.Write("\n{0} ", k);
            for (; k < terms - 1; k++)
            {
                Console.Write("{0} ", h);
                h = i + j;
                i = j;
                j = h;
            }
        }
    }
}