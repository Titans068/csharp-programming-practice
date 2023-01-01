using System;

namespace Advanced_Application_Programming
{
    //4)	Write a program that prompts the user for two numbers and then computes them using the following rules.
    //If the first number is greater than the second one, the second number is subtracted from the first one.
    //If the second number is greater than the first one, the first number is divided by the second one. Otherwise the two numbers are added.
    class ComputeIf
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 2 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine()),
                num2 = Convert.ToInt32(Console.ReadLine()),res;
            if (num1 > num2)
                res = num2 - num1;
            else if (num2 > num1) res = num1 / num2;
            else res = num1 + num2;
            Console.WriteLine("The result is {0}", res);
        }
    }
}
