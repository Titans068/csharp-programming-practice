using System;

namespace Advanced_Application_Programming
{
    public class FibonacciArrays
    {
        public static void Main(string[] args)
        {
            Console.Write("How many Fibonacci terms:> ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int[] fibonacci = new int[terms];
            int sum = fibonacci[1] = 1;

            for (int i = 2; i < terms; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                sum += fibonacci[i];
            }

            Console.WriteLine("{0}\nSum: {1}", string.Join(", ", fibonacci), sum);
        }
    }
}
