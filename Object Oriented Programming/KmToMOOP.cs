using System;

namespace Advanced_Application_Programming.Introduction
{
    class KmToMRedone
    {
        private double km;

        public KmToMRedone(double km)
        {
            this.Km = km;
        }
        public KmToMRedone()
        {
            this.Km = 1;
        }
        public double Km
        {
            get { return km; }
            set
            {
                km = value;
            }
        }
        public double M
        {
            get { return Km / 1e3; }
        }
    }
    class KmToMOOP
    {
        private KmToMRedone redone = new KmToMRedone();
        void Input()
        {
            Console.Write("Enter distance in km:> ");
            redone.Km = Convert.ToDouble(Console.ReadLine());
        }
        void Output()
        {
            Console.WriteLine("{0} kilometres = {1} metres", redone.Km, redone.M);
        }
        public static void Main(string[] args)
        {
            KmToMOOP k = new KmToMOOP();
            k.Input();
            k.Output();
        }
    }
}
