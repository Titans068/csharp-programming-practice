using System;

namespace Advanced_Application_Programming
{
    public class ForSumSquares
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 15; i++)
            {
                sum += i * i;
            }
            Console.WriteLine("The sum of the squares of the first 15 positive integers is {0}", sum);
        }
    }
}