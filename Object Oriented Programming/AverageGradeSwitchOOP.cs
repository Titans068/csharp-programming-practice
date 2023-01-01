using System;

namespace Advanced_Application_Programming
{
    class AverageGradeSwitchOOP
    {
        private int[] marks;
        private int total = 0, avg;
        public AverageGradeSwitchOOP(int[] marks)
        {
            this.Marks = marks;
        }
        public AverageGradeSwitchOOP()
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
            switch (avg)
            {
                case >= 75 and <= 100:
                    Console.WriteLine("{0} is Distinction", avg);
                    break;
                case >= 65 and < 75:
                    Console.WriteLine("{0} is Credit", avg);
                    break;
                case >= 50 and < 65:
                    Console.WriteLine("{0} is Pass", avg);
                    break;
                case >= 0 and < 50:
                    Console.WriteLine("{0} is Fail", avg);
                    break;
            }
        }
        public static void Main(string[] args)
        {
            AverageGradeSwitchOOP ap = new AverageGradeSwitchOOP();
            ap.Input();
            ap.Compute();
            ap.Output();
        }

    }
}
