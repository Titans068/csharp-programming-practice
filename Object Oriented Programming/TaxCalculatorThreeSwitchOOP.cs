using System;

namespace Advanced_Application_Programming
{
    class TaxCalculatorThreeSwitchOOP
    {
        /*
         * Female earning < 15000	12%
        * Female earning >= 15000	14%
        * Male earning < 14000	13%
        * Male earning >= 14000	15%
        */
        private int gender, salary;
        private double tax;
        public TaxCalculatorThreeSwitchOOP()
        {
            this.Gender = 1;
            this.Salary = 1;
        }

        public TaxCalculatorThreeSwitchOOP(int gender, int salary)
        {
            this.Gender = gender;
            this.Salary = salary;
        }
        public int Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        void Input()
        {
            Console.Write("1) Male\n2)Female\nEnter gender: ");
            Gender = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter gross pay: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        void Compute()
        {
            switch (Gender)
            {
                case 2 when Salary < 15000:
                    Tax = .12 * Salary;
                    break;
                case 2 when Salary >= 15000:
                    Tax = .14 * Salary;
                    break;
                case 1 when Salary < 14000:
                    Tax = .13 * Salary;
                    break;
                case 1 when Salary >= 14000:
                    Tax = .15 * Salary;
                    break;
                default:
                    Console.WriteLine("Invalid inputs provided.");
                    break;
            }
        }
        void Output()
        {
            Console.WriteLine("Tax amount is {0:0,0.00}\nNet pay is {1:0,0.00}",
                Tax, Salary - Tax);
        }
        public static void Main(string[] args)
        {
            TaxCalculatorThreeSwitchOOP taxCalculator = new TaxCalculatorThreeSwitchOOP();
            taxCalculator.Input();
            taxCalculator.Compute();
            taxCalculator.Output();
        }
    }
}
