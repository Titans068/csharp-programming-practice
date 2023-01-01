using System;
using System.Linq;

namespace Advanced_Application_Programming
{
    public record AccountTwo
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public decimal Owed { get; set; }
        public int DaysOverdue { get; set; }

        public AccountTwo(string name, int accountNumber, decimal owed, int daysOverdue)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
            this.Owed = owed;
            this.DaysOverdue = daysOverdue;
        }
        public AccountTwo()
        {
        }

        public void Input()
        {
            Console.Write("\nEnter customer name:> ");
            this.Name = Console.ReadLine();
            Console.Write("Enter account number:> ");
            this.AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount owed:> ");
            this.Owed = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter days overdue:> ");
            this.DaysOverdue = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("\nCustomer name: {0}\nCustomer account number: {1}\nAmount Owed: {2:#,#.00}\nDays Overdue: {3}\n", this.Name, this.AccountNumber, this.Owed, this.DaysOverdue);
        }
    }
    public class AccountProgram
    {
        public static void Main(string[] args)
        {
            AccountTwo account;

            Console.Write("Enter how many customers you want to work with:> ");
            int customers = Convert.ToInt32(Console.ReadLine());
            AccountTwo[] accounts = new AccountTwo[customers];

            for (int i = 0; i < customers; i++)
            {
                account = new();
                account.Input();
                accounts[i] = account;
            }
            foreach (AccountTwo acc in accounts.Where((AccountTwo a) => a.Owed > 2e4m || a.DaysOverdue > 30))
                acc.Output();

            //OR
            /* foreach (AccountTwo acc in accounts)
                if (acc.Owed > 2e4m || acc.DaysOverdue > 30)
                    acc.Output();
            */
        }
    }
}
