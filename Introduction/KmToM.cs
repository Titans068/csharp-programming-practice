using System;

namespace Advanced_Application_Programming.Introduction
{
    class KmToM
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter distance in km:> ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} kilometres = {1} metres", km, km * 1e3);
        }
    }
}
