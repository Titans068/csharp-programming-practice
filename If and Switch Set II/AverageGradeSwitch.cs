using System;

namespace Advanced_Application_Programming
{
    class AverageGradeSwitch
    {
        public static void Main(string[] args)
        {
            int[] marks = new int[5];
            int total = 0, avg;
            for (int i = 0; i < marks.Length; ++i)
            {
                Console.Write("Enter marks: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total += marks[i];
            }
            avg = total / marks.Length;
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

    }
}
