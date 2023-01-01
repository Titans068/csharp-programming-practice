using System;

namespace Advanced_Application_Programming
{
    public class WhileSumSquares
    {
        public static void Main(string[] args)
        {
            int i = 0, sum = 0;
            while (i < 15)
            {
                sum += i * i;
                i++;
            }
            Console.WriteLine("The sum of the squares of the first 15 positive integers is {0}", sum);
        }
    }
}