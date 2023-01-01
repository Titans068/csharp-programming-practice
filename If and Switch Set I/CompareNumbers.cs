using System;

namespace Advanced_Application_Programming
{
    //6)	Write a program that accepts two numbers and divides the bigger number
    //by the smaller number and displays the results.
    //The program should display an error message (and not perform the calculation) if the smaller number is zero.
    class CompareNumbers
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 2 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine()),
                num2 = Convert.ToInt32(Console.ReadLine()), res, big, small;
            if (num1 > num2)
            {
                big = num1;
                small = num2;
            }
            else
            {
                small = num1;
                big = num2;
            }
            if (small == 0) Console.WriteLine("0 not accepted as input.");
            else
            {
                res = big / small;
                Console.WriteLine("{0} / {1} = {2}", big, small, res);
            }
        }
    }
}
