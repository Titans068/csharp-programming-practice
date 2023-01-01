using System;

namespace Advanced_Application_Programming
{
    class AverageGradeOOP
    {
        private int[] marks;
        private int total = 0, avg;
        public AverageGradeOOP(int[] marks)
        {
            this.Marks = marks;
        }
        public AverageGradeOOP()
        {
            Marks = new int[5];
            Array.Fill<int>(Marks, 1);
        }
        public int[] Marks
        {
            get { return marks; }
            set
            {
                marks = value;
            }
        }

        void Input()
        {
            Marks = new int[5];
            for (int i = 0; i < Marks.Length; ++i)
            {
                Console.Write("Enter marks:> ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        void Compute()
        {
            for (int i = 0; i < Marks.Length; ++i)
                total += Marks[i];

            avg = total / Marks.Length;
        }
        void Output()
        {
            if (avg >= 75 && avg <= 100)
                Console.WriteLine("{0} is Distinction", avg);
            else if (avg >= 65 && avg < 75)
                Console.WriteLine("{0} is Credit", avg);
            else if (avg >= 50 && avg < 65)
                Console.WriteLine("{0} is Pass", avg);
            else if (avg >= 0 && avg < 50)
                Console.WriteLine("{0} is Fail", avg);
        }
        public static void Main(string[] args)
        {
            AverageGradeOOP ap = new AverageGradeOOP();
            ap.Input();
            ap.Compute();
            ap.Output();
        }

    }
}
