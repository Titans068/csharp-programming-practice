using System;

namespace Advanced_Application_Programming
{
    /*
     * Consider class Employee that has name, EmployeeID, basicSalary and allowance as its fields.
     * i.)	Define a parameterized constructor that initializes the fields with specified values. [3 marks]
     * ii.)	Define a default constructor that sets default values (decide on the values) for the fields. [2 marks]
     * iii.)	Define a property that accesses basicSalary and ensures the value passed to field basicSalary is not less than 3000. 
     * In such a case an error message should be given and the value be set to 3000.
    */
    class Employee
    {
        private string name;
        private int basicSalary, employeeId, allowance;

        public Employee(string name, int basicSalary, int employeeId, int allowance)
        {
            this.name = name;
            this.BasicSalary = basicSalary;
            this.employeeId = employeeId;
            this.allowance = allowance;
            Console.WriteLine("Name: {0}\nBasic Salary = {1}\nEmployee ID = {2}\nAllowance = {3}",
                this.name, this.BasicSalary, this.employeeId, this.allowance);
        }
        public Employee()
        {
            this.name = "James";
            this.BasicSalary = 2000;
            this.employeeId = 200;
            this.allowance = 1500;
        }

        public int BasicSalary
        {
            get
            {
                return this.basicSalary;
            }
            set
            {
                if (value < 3000)
                {
                    this.basicSalary = 3000;
                    throw new ArgumentException(string.Format("Value {0} cannot be less than {1}", value, this.BasicSalary));
                }
                this.basicSalary = value;
            }
        }
    }

    public class EmployeeDetails
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Jane", 12_000, 200, 4_000);
            try
            {
                Employee employee1 = new Employee();
            }
            catch (ArgumentException e)
            {

                Console.WriteLine("\n" + e.ToString());
            }
        }
    }
}