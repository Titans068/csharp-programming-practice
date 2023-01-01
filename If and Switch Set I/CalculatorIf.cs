using System;

namespace Advanced_Application_Programming
{
    class CalculatorIf
    {
        //+, - , * , / or %
        public static void Main(string[] args)
        {
        PROMPT:
            Console.Write("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine()),
                num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an operator: ");
            char operator_ = Convert.ToChar(Console.ReadKey().KeyChar);
            if (operator_ == '+')
                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            else if (operator_ == '-')
                Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            else if (operator_ == '*')
                Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            else if (operator_ == '/')
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            else if (operator_ == '%')
                Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);
            else
            {
                Console.WriteLine("Invalid operator");
                goto PROMPT;
            }
        }
    }
}
