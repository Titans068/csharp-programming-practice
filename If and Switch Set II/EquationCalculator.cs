using System;

namespace Advanced_Application_Programming
{
    class EquationCalculator
    {
        public static void Main(string[] args)
        {
            /*
             * y = 4x3 + 2x – 6 when x > 5
             * y = 3x2 – 4y + 12 when x < 5
             * y = 6x – 5 when x = 5
            */
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine()), y;
            if (x > 5)
            {
                y = 4 * x * x * x + (2 * x) - 6;
                Console.WriteLine("y = {0}", y);
            }
            else if (x < 5)
            {
                y = 3 * x * x - (4 * x) + 12;
                Console.WriteLine("y = {0}", y);
            }
            else if (x == 5)
            {
                y = (6 * x) - 5;
                Console.WriteLine("y = {0}", y);
            }
        }
    }
}
