using System;

namespace Advanced_Application_Programming
{
    class TaxCalculator
    {
        /*
         * Over 40,000			30%
         * >= 30,000 but below 40,000	25%
         * >=20,000 but below 30,000	15%
         * >=10,000 but below 20,000	10%
         * Below 10,000			no tax.
         */
        public static void Main(string[] args)
        {
        PROMPT:
            Console.Write("Enter gross pay: ");
            int gross = Convert.ToInt32(Console.ReadLine());
            double tax;
            if (gross >= 40000)
                tax = .3 * gross;
            else if (gross < 40000 && gross >= 30000)
                tax = .25 * gross;
            else if (gross < 30000 && gross >= 20000)
                tax = .15 * gross;
            else if (gross < 20000 && gross >= 10000)
                tax = .15 * gross;
            else if (gross < 10000)
                tax = 0 * gross;
            else
            {
                Console.WriteLine("Invalid number");
                goto PROMPT;
            }
            Console.WriteLine("Tax amount is {0:0,0.00}\nNet pay is {1:0,0.00}",
                tax, gross - tax);
        }
    }
}
