using System;

namespace Advanced_Application_Programming
{
    public class EmployeeThree
    {
        protected string Names { get; set; }
        protected char Gender { get; set; }
        protected int PersonnelNo { get; set; }
        protected string Department { get; set; }
        protected decimal Salary { get; set; }
        protected decimal Total { get; set; }

        public EmployeeThree(string names, char gender, int personnelNo, string department, decimal basicSalary, decimal total)
        {
            this.Names = names;
            this.Gender = gender;
            this.PersonnelNo = personnelNo;
            this.Department = department;
            this.Salary = basicSalary;
            this.Total = total;
        }

        public EmployeeThree()
        {
        }

        public virtual void Input()
        {
            Console.Write("Enter names:>");
            this.Names = Console.ReadLine();
            Console.Write("Enter gender:>");
            this.Gender = Console.ReadLine()[0];
            Console.Write("Enter personnel number:>");
            this.PersonnelNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter department:>");
            this.Department = Console.ReadLine();
            Console.Write("Enter basic salary:>");
            this.Salary = Convert.ToDecimal(Console.ReadLine());
        }
        public virtual void Compute()
        {
            this.Total = this.Salary;
        }

        public virtual void Output()
        {
            Console.WriteLine("\nEmployee name: {0}\nEmployee Gender: {1}\nPersonnel Number: {2}\nDepartment: {3}\nBasic Salary: {4}\nTotal Salary: {5}",
                this.Names, this.Gender, this.PersonnelNo, this.Department, this.Salary, this.Total);
        }
    }

    public class Manager : EmployeeThree
    {
        private decimal CarLoan { get; set; }
        private decimal House { get; set; }
        private string TripCountry { get; set; }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter car loan:> ");
            this.CarLoan = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter house allowance:> ");
            this.House = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter country of choice:> ");
            this.TripCountry = Console.ReadLine();
        }

        public override void Compute()
        {
            base.Compute();
            this.Total += (this.CarLoan + this.House);
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Car loan: {0}\nHouse Allowance: {1}\nCountry of choice: {2}", this.CarLoan, this.House, this.TripCountry);
        }
    }

    public class EmployeeThreeProgram
    {
        public static void Main(string[] args)
        {
            EmployeeThree employee = new();
            employee.Input();
            employee.Compute();
            employee.Output();

            Manager manager = new();
            manager.Input();
            manager.Compute();
            manager.Output();
        }
    }
}
