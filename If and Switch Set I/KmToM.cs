using System;

namespace Advanced_Application_Programming
{
    class KmToM
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter distance in kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} kilometers = {1} metres", km, km * 1000);
        }
    }
}
