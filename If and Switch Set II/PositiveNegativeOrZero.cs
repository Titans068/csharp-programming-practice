using System;

namespace Advanced_Application_Programming
{
    //7)	Write a program that accepts an integer and checks whether it is positive,
    //negative or zero and then prints an appropriate message.
    class PositiveNegativeOrZero
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) Console.WriteLine("{0} is POSITIVE", num);
            else if (num == 0) Console.WriteLine("{0} is ZERO", num);
            else Console.WriteLine("{0} is NEGATIVE", num);
        }
    }
}
