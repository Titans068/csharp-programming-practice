using System;

namespace Advanced_Application_Programming
{
    public abstract class BankAccount
    {
        private int account_number;
        private string account_holder;
        protected float balance;
        protected static int holders = 0;

        protected int get_account_number()
        {
            return this.account_number;
        }

        protected void set_account_number(int account_number)
        {
            this.account_number = account_number;
        }

        protected string get_account_holder()
        {
            return this.account_holder;
        }

        protected void set_account_holder(string account_holder)
        {
            if (holders <= 4)
            {
                this.account_holder = account_holder;
                ++holders;
            }
            else throw new Exception($"Max of 4 account holders allowed. You have {holders}.");
        }

        protected float get_balance()
        {
            return this.balance;
        }

        protected void Deposit(float amount)
        {
            this.balance += amount;
        }

        protected void Withdraw(float amount)
        {
            this.balance -= amount;
        }
    }
    public class Account : BankAccount
    {
        private int Account_number
        {
            get => this.get_account_number();
            set => this.set_account_number(value);
        }
        private string Account_holder
        {
            get => this.get_account_holder();
            set
            {
                if (holders <= 4)
                {
                    this.set_account_holder(value);
                    ++holders;
                }
                else throw new Exception($"Max of 4 account holders allowed. You have {holders}.");
            }
        }
        private float Balance
        {
            get => this.get_balance();
            init
            {
                this.balance = value;
            }
        }

        private void Display()
        {
            Console.WriteLine("Account holder: {0}\nAccount number: {1}\nAccount balance: {2:#,#.00}\n", 
                this.Account_holder, this.Account_number, this.Balance);
        }

        public static void Main(string[] args)
        {
            Account account = new()
            {
                Balance = 0.00f,
                Account_number = 101,
                Account_holder = "John"
            };
            account.Deposit(2e3f);
            account.Display();

            Account account2 = new()
            {
                Balance = 0.00f,
                Account_number = 102,
                Account_holder = "Jane"
            };
            account2.Deposit(1750.00f);
            account2.Display();

            Account account3 = new()
            {
                Balance = 2e3f,
                Account_number = 103,
                Account_holder = "Chad"
            };
            account3.Withdraw(1250.00f);
            account3.Display();
        }
    }
}
