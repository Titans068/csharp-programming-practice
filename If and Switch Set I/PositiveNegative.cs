using System;

namespace Advanced_Application_Programming
{
    //5)	Write a program to read a value from the keyboard and output the phrase NEGATIVE if the number is negative,
    //POSITIVE if the number is positive or ZERO otherwise
    class PositiveNegative
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0) Console.WriteLine("POSITIVE");
            else Console.WriteLine("NEGATIVE");
        }
    }
}
