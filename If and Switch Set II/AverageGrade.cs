using System;

namespace Advanced_Application_Programming
{
    class AverageGrade
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
            if (avg >= 75 && avg <= 100)
                Console.WriteLine("{0} is Distinction", avg);
            else if (avg >= 65 && avg < 75)
                Console.WriteLine("{0} is Credit", avg);
            else if (avg >= 50 && avg < 65)
                Console.WriteLine("{0} is Pass", avg);
            else if (avg >= 0 && avg < 50)
                Console.WriteLine("{0} is Fail", avg);
        }

    }
}
