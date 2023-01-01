using System;

namespace Advanced_Application_Programming
{
    public class NoonTemperature
    {
        public static void Main(string[] args)
        {
            int[] temp = new int[7];
            int max, min, total = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write("Enter day {0} noon temperature:> ",
                    i + 1);
                temp[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = min = temp[0];

            for (int i = 0; i < temp.Length; ++i)
            {
                if (temp[i] > max)
                    max = temp[i];
                else if (temp[i] < min)
                    min = temp[i];
                total += temp[i];
            }

            Console.WriteLine("Average temperature: {0}\nHottest day: on day {1} with {2}\nCoolest day: on day {3} with {4}", total / temp.Length, Array.IndexOf(temp, max) + 1, max, Array.IndexOf(temp, min) + 1, min);
        }
    }
}
