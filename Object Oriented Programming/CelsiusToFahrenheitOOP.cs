using System;

namespace Advanced_Application_Programming
{
    class CelsiusToFahrenheitRedone
    {
        private int celsius;

        public CelsiusToFahrenheitRedone()
        {
            this.Celsius = 1;
        }

        public CelsiusToFahrenheitRedone(int celsius)
        {
            this.Celsius = celsius;
        }

        public int Celsius
        {
            get { return celsius; }
            set
            {
                celsius = value;
            }
        }
        public double Fahrenheit
        {
            get { return (this.Celsius * 1.8d) + 32; }
        }
    }
    class CelsiusToFahrenheitOOP
    {
        CelsiusToFahrenheitRedone redone = new CelsiusToFahrenheitRedone();
        void Input()
        {
            Console.Write("Enter temperature in degrees celsius: ");
            redone.Celsius = Convert.ToInt32(Console.ReadLine());
        }
        void Output()
        {
            Console.WriteLine("{0} degrees celsius = {1} degrees fahrenheit", redone.Celsius, redone.Fahrenheit);
        }
        public static void Main(string[] args)
        {
            CelsiusToFahrenheitOOP c = new CelsiusToFahrenheitOOP();
            c.Input();
            c.Output();
        }
    }
}
