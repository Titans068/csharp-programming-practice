using System;

namespace Advanced_Application_Programming
{
    public class Increment
    {
        public static void Main(string[] args)
        {
            Random random = new(42);
            double[] test = new double[] { 50.73, 20.93, 51.98, 35.51, 21.48 };
            Console.WriteLine(string.Join(", ", test) + "\n");

            for (int i = 0; i < test.Length; i++)
            {
                test[i] += 2.0;
                Console.Write("{0:#.00}, ", test[i]);
            }
            Console.Write("\b\b");
        }
    }
}
