using System;

namespace Advanced_Application_Programming
{
    public class Marks
    {
        public static void Main(string[] args)
        {
            Console.Write("How many marks do you want to work with:> ");
            int size = Convert.ToInt32(Console.ReadLine()),
                sum = 0, fail = 0, pass = 0, highest, lowest;
            int[] marks = new int[size];

            for (int i = 0; i < marks.Length; ++i)
            {
                Console.Write("Enter mark {0}:> ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
                if (marks[i] < 50) fail++;
                else if (marks[i] >= 50) pass++;
            }
            highest = lowest = marks[0];
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > highest)
                    highest = marks[i];
                else if (marks[i] < lowest)
                    lowest = marks[i];
            }

            Console.WriteLine("\n{0} are failing\n{1} are passing\nThe highest mark is {2}\nThe lowest mark is {3}", fail, pass, highest, lowest);
        }
    }
}
