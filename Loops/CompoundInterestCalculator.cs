using System;

namespace Advanced_Application_Programming
{
    public class CompoundInterestCalculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter deposit");
            double deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter interest rate");
            int interest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter duration in years");
            int yrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year\tInterest\tBalance");
            double inter = (interest / 100d) * deposit,
                bal = inter + deposit;
            int i = 1;
            do
            {
                Console.WriteLine("{0}\t{1:0,0.00}\t\t{2:0,0.00}", i, inter, bal);
                if (i == yrs) break;
                inter *= 1 + (interest / 100d);
                bal += inter;
                i++;
            } while (i < yrs);
            Console.WriteLine("The compounded interest for 10 years is Kshs. {0:0,0.00}", bal - deposit);
            Console.WriteLine("The balance in the account after 10 years at 10.00 percent interest is Kshs. {0:0,0.00}", bal);
        }
    }
}