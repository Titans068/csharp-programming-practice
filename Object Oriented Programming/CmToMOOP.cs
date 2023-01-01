using System;

namespace Advanced_Application_Programming
{
    class CmToMRedone
    {
        private int cm;

        public CmToMRedone()
        {
            this.Cm = 1;
        }

        public CmToMRedone(int cm)
        {
            this.Cm = cm;
        }

        public int Cm
        {
            get { return cm; }
            set
            {
                cm = value;
            }
        }
        public double M
        {
            get { return this.Cm / 100d; }
        }
    }
    class CmToMOOP
    {
        private CmToMRedone redone = new CmToMRedone();
        void Input()
        {
            Console.Write("Enter Measurement in cm:> ");
            redone.Cm = Convert.ToInt32(Console.ReadLine());
        }
        void Output()
        {
            Console.WriteLine("{0} cm = {1} metres", redone.M, redone.Cm);
        }
        public static void Main(string[] args)
        {
            CmToMOOP cmToMOOP = new CmToMOOP();
            cmToMOOP.Input();
            cmToMOOP.Output();
        }
    }
}
