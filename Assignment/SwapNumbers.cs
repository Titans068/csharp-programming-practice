using System;

namespace Advanced_Application_Programming
{
    public class SwapNumbers
    {
        private void swapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args)
        {
            int a, b;
            SwapNumbers swap = new SwapNumbers();
            Console.Write("Enter first number:> ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter first number:> ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore swapping:\na is {0}\nb is {1}", a, b);

            swap.swapNumbers(ref a, ref b);

            Console.WriteLine("\nAfter swapping:\na is {0}\nb is {1}", a, b);
        }
    }
}
