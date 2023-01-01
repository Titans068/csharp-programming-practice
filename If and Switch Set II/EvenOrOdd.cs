using System;

namespace Advanced_Application_Programming
{
    class EvenOrOdd
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) Console.WriteLine("The number {0} is even.", num);
            else Console.WriteLine("The number {0} is odd.", num);
        }
    }
}
