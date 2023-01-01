using System;

namespace Advanced_Application_Programming
{
    public class Credit
    {
        private int account;
        private decimal balance, charges, credit, limit;

        public void Input()
        {
            Console.Write("Enter account number:> ");
            this.account = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Balance at the beginning of the month:> ");
            this.balance = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Total of all items charged by this customer this month:> ");
            this.charges = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Total of all credits applied to this customer account this month:> ");
            this.credit = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter credit limit:> ");
            this.limit = Convert.ToDecimal(Console.ReadLine());
        }

        public void Compute()
        {
            this.balance = this.balance + this.charges - this.credit;
        }

        public void Output()
        {
            if (this.balance > this.limit)
                Console.WriteLine("Credit Limit Exceeded");
            else Console.WriteLine("Within the Credit Limit");
        }

        public static void Main(string[] args)
        {
            Credit credit = new();
            int add = 1;
            while (add == 1)
            {
                credit.Input();
                credit.Compute();
                credit.Output();
                Console.Write("Add another customer\n1. Yes\n2. No:> ");
                add = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
