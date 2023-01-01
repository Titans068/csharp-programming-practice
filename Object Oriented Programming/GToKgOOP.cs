using System;

namespace Advanced_Application_Programming
{
    class GToKgRedone
    {
        private double grams;

        public GToKgRedone()
        {
            this.Grams = 1;
        }

        public GToKgRedone(double grams)
        {
            this.Grams = grams;
        }

        public double Grams
        {
            get { return grams; }
            set
            {
                grams = value;
            }
        }
        public double Kilograms
        {
            get { return grams / 1e3; }
        }
        public double Packages
        {
            get { return 1e3 / grams; }
        }
    }
    class GToKgOOP
    {
        GToKgRedone redone = new GToKgRedone();
        void Input()
        {
            Console.Write("Enter package weight in grams: ");
            redone.Grams = Convert.ToDouble(Console.ReadLine());
        }
        void Output()
        {
            Console.WriteLine("The weight of the package is {0} kilograms.\n" +
                "It takes {1} such packages to form one kilogram.", redone.Kilograms, redone.Packages);
        }
        public static void Main(string[] args)
        {
            GToKgOOP g = new GToKgOOP();
            g.Input();
            g.Output();
        }
    }
}
