using System;

namespace Advanced_Application_Programming
{
    class CmToM
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Measurement in cm ");
            int cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} cm = {1} metres", cm, cm / 100);
        }
    }
}
