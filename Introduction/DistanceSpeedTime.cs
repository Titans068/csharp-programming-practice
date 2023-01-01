using System;

namespace Advanced_Application_Programming
{
    class DistanceSpeedTime
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter distance in meters: ");
            double km = Convert.ToDouble(Console.ReadLine()) / 1000;
            Console.Write("Enter time taken in minutes: ");
            double hrs = Convert.ToDouble(Console.ReadLine()) / 60;
            Console.WriteLine("Speed is {0}", km / hrs);
        }
    }
}
