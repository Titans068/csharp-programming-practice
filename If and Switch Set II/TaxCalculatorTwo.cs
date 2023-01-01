using System;

namespace Advanced_Application_Programming
{
    class TaxCalculatorTwo
    {
        public static void Main(string[] args)
        {
        PROMPT:
            Console.Write("Enter gross pay: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            double tax;
            if (salary >= 20000)
                tax = .15 * salary;
            else if (salary < 20000 && salary >= 10000)
                tax = .1 * salary;
            else if (salary < 10000 && salary >= 0)
                tax = 0 * salary;
            else
            {
                Console.WriteLine("Invalid number");
                goto PROMPT;
            }
            Console.WriteLine("Your salary is {0:0,0.00}\nTax amount is {1:0,0.00}\nNet salary is {2:0,0.00}",
                salary, tax, salary - tax);
        }
    }
}
