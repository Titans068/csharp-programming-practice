using System;

namespace Advanced_Application_Programming
{
    class CelsiusToFahrenheit
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter temperature in degrees celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} degrees celsius = {1} degrees fahrenheit", celsius, (celsius * 1.8) + 32);
        }
    }
}
