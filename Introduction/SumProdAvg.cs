using System;

namespace Advanced_Application_Programming
{
    public class SumProdAvg
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            int a = Convert.ToInt32(Console.ReadLine()),
                b = Convert.ToInt32(Console.ReadLine()),
                c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = {0}\nProduct = {1}\nAverage = {2}",
                              a + b + c,
                              a * b * c,
                              (a + b + c) / 3);
        }
    }
}