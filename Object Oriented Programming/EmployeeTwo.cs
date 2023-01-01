using System;

namespace Advanced_Application_Programming
{
    public class EmployeeTwo
    {
        private string Names { get; set; }
        private int BoxNumber { get; set; }
        private string Town { get; set; }
        private int PersonnelNo { get; set; }
        private string Department { get; set; }
        private decimal BasicSalary { get; set; }
        private decimal Consolidated { get; set; }
        private decimal Total { get; set; }

        public EmployeeTwo(string names, int boxNumber, string town, int personnelNo, string department, decimal basicSalary, decimal consolidated, decimal total)
        {
            this.Names = names;
            this.BoxNumber = boxNumber;
            this.Town = town;
            this.PersonnelNo = personnelNo;
            this.Department = department;
            this.BasicSalary = basicSalary;
            this.Consolidated = consolidated;
            this.Total = total;
        }

        public EmployeeTwo()
        {
        }

        public void Input()
        {
            Console.Write("Enter names:>");
            this.Names = Console.ReadLine();
            Console.Write("Enter box number:>");
            this.BoxNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter town:>");
            this.Town = Console.ReadLine();
            Console.Write("Enter personnel number:>");
            this.PersonnelNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter department:>");
            this.Department = Console.ReadLine();
            Console.Write("Enter basic salary:>");
            this.BasicSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter consolidated allowances :>");
            this.Consolidated = Convert.ToDecimal(Console.ReadLine());
        }
        public void Compute()
        {
            this.Total = this.BasicSalary + this.Consolidated;
        }

        public void Output()
        {
            Console.WriteLine("Employee name: {0}\nBox Number: {1}\nTown: {2}\nPersonnel Number: {3}\nDepartment: {4}\nBasic Salary: {5}\nConsolidated Allowances: {6}\nTotal Salary: {7}",
                this.Names, this.BoxNumber, this.Town, this.PersonnelNo, this.Department, this.BasicSalary, this.Consolidated, this.Total);
        }


    }

    public class EmployeeTwoProgram
    {
        public static void Main(string[] args)
        {
            EmployeeTwo employee = new();
            employee.Input();
            employee.Compute();
            employee.Output();
        }

    }

}
