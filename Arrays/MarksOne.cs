using System;

namespace Advanced_Application_Programming
{
    public class MarksOne
    {
        public static void Main(string[] args)
        {
            double[] marks = new double[5];
            double sum = 0;
            for (int i = 0; i < marks.Length; ++i)
            {
                Console.Write("Enter mark {0}:> ", i + 1);
                marks[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine(string.Join(", ", marks));
            for (int i = 0; i < marks.Length; ++i)
            {
                sum += marks[i];
            }
            Console.WriteLine("Sum: {0}\nAverage: {1}", sum, sum / marks.Length);
        }
    }
}
