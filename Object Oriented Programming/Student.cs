using System;

namespace Advanced_Application_Programming
{
    public class Student
    {
        private char[] Name, Reg_No;
        private int Mark;
        private char Grade;

        public Student(char[] name, char[] reg_no, int mark, char grade)
        {
            this.Name = name;
            this.Reg_No = reg_no;
            this.Mark = mark;
            this.Grade = grade;
        }

        public Student() { }

        public void Input()
        {
            bool isNull = true;
            string? input;

            Console.Write("Enter name:> ");
            while (isNull)
            {
                input = Console.ReadLine();
                if (input == null)
                    ;
                else
                {
                    this.Name = input.ToCharArray();
                    isNull = false;
                }
            }

            isNull = true;
            Console.Write("Enter registration:> ");
            while (isNull)
            {
                input = Console.ReadLine();
                if (input == null)
                    ;
                else
                {
                    this.Reg_No = input.ToCharArray();
                    isNull = false;
                }
            }

            isNull = true;
            Console.Write("Enter mark:> ");
            while (isNull)
            {
                input = Console.ReadLine();
                if (input == null)
                    ;
                else
                {
                    this.Mark = Convert.ToInt32(input);
                    isNull = false;
                }
            }

            isNull = true;
            Console.Write("Enter grade:> ");
            while (isNull)
            {
                input = Console.ReadLine();
                if (input == null)
                    ;
                else
                {
                    this.Grade = Convert.ToChar(input);
                    isNull = false;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}\nRegistration: {1}\nMark: {2}\nGrade: {3}", this.Name, this.Reg_No, this.Mark, this.Grade);
        }

        public static void Main(string[] args)
        {
            Student student = new();
            student.Input();
            student.Display();
        }
    }
}
