using System;

namespace Advanced_Application_Programming
{
    class GToKg
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter package weight in grams: ");
            double g = Convert.ToDouble(Console.ReadLine()), kg = g / 1000;
            Console.WriteLine("The weight of the package is {0} kilograms.\n" +
                "It takes {1} such packages to form one kilogram.", kg, 1000 / g);
        }
    }
}
