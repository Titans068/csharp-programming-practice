using System;

namespace Advanced_Application_Programming
{
    /*
     * A program is required that accepts the basic salary, allowance and tax rate and computes the
     * tax amount and net salary of an employee. The computations are done as follows: –
     * tax amount = tax rate / 100 * (basic salary + allowance)
     * net salary = basic salary – tax amount
     * Write a complete program that uses a class called Salary(object orientation) to implement the
     * above requirements. The class should have the following specifications.
     * Fields: –
     * ➢ basic_salary
     * ➢ allowance
     * ➢ tax_rate
     * ➢ tax_amount
     * ➢ net_salary
     * 
     * Methods: –
     * ➢ input – for data input
     * ➢ output – for data output
     * ➢ compute – for computing the tax amount and the net salary.
     * In addition, the class should have a constructor that initializes basic salary, allowance and tax
     * amount to specified values or 0 if no value is provided. 
     */
    public class Salary
    {
        private int basic_salary, allowance;
        private double tax_rate, tax_amount, net_salary;

        public Salary(int basic_salary, int allowance, double tax_rate)
        {
            this.basic_salary = basic_salary;
            this.allowance = allowance;
            this.tax_rate = tax_rate;
        }

        public Salary()
        {
            this.basic_salary = 0;
            this.allowance = 0;
            this.tax_rate = 0;
        }

        public void input()
        {
            Console.Write("Enter basic salary>: ");
            this.basic_salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter allowance>: ");
            this.allowance = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter tax rate>: ");
            this.tax_rate = Convert.ToDouble(Console.ReadLine());
        }

        public void compute()
        {
            this.tax_amount = this.tax_rate / 100 * (this.basic_salary + this.allowance);
            this.net_salary = this.basic_salary - this.tax_amount;
        }

        public void output()
        {
            Console.WriteLine("\nTax amount is {0:#,#.00}.\nNet salary is {1:#,#.00}", this.tax_amount, this.net_salary);
        }
    }

    public class TaxCalculatorFour
    {
        public static void Main(string[] args)
        {
            Salary salary = new Salary();
            salary.input();
            salary.compute();
            salary.output();
        }
    }
}
