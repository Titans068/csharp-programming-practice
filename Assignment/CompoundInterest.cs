using System;

namespace Advanced_Application_Programming
{
    class InterestCalculator
    {
        private int deposit, target, duration;
        private double j, k, rate;

        public void Input()
        {
            Console.Write("Enter amount of deposited money:> ");
            deposit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter interest rate:> ");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter targeted amount:> ");
            target = Convert.ToInt32(Console.ReadLine());
        }
        public void Compute()
        {
            rate /= 100;
            j = deposit * rate;
            k = deposit + j;
            duration++;

            while (k < target)
            {
                j += (rate * j);
                k += j;
                duration++;
            }
        }

        public void Output()
        {
            Console.WriteLine("\nIt will take {0} years for your money to reach your target.", duration);
            Console.WriteLine("By the end of this period, the amount in your account will be {0:#.##}", k);
        }
    }
    public class CompoundInterest
    {
        public static void Main(string[] args)
        {
            InterestCalculator interest = new InterestCalculator();
            interest.Input();
            interest.Compute();
            interest.Output();
        }
    }
}
