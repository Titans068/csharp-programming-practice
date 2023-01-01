using System;

namespace Advanced_Application_Programming
{
    class TaxCalculatorThree
    {
        /*
         * Female earning < 15000	12%
        * Female earning >= 15000	14%
        * Male earning < 14000	13%
        * Male earning >= 14000	15%
        */
        public static void Main(string[] args)
        {
        PROMPT:
            Console.Write("1) Male\n2)Female\nEnter gender: ");
            int gender = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter gross pay: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            double tax;
            if (gender == 2 && salary < 15000)
                tax = .12 * salary;
            else if (gender == 2 && salary >= 15000)
                tax = .14 * salary;
            else if (gender == 1 && salary < 14000)
                tax = .13 * salary;
            else if (gender == 1 && salary >= 14000)
                tax = .15 * salary;
            else
            {
                Console.WriteLine("Invalid inputs provided.");
                goto PROMPT;
            }
            Console.WriteLine("Tax amount is {0:0,0.00}\nNet pay is {1:0,0.00}",
                tax, salary - tax);
        }
    }
}
