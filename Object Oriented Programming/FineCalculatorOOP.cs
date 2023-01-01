using System;

namespace Advanced_Application_Programming
{
    //8)	Write a program that can be used by a policeman to determine if a vehicle has exceeded
    // the speed limit and to levy a fine. The policeman should enter the vehicles speed and the speed limit.
    // If the speed limit is exceeded by less than 30kph a fine of Kshs. 2500 should be charged.
    // Otherwise a fine of Kshs 4000 is charged. Your program should then output (in a suitable format)
    // the vehicle speed, the speed limit, the excess speed and the fine levied.
    class FineCalculatorOOP
    {
        private int speed, limit, excess;

        public FineCalculatorOOP()
        {
            this.Speed = 1;
            this.Limit = 1;
        }

        public FineCalculatorOOP(int speed, int limit)
        {
            this.Speed = speed;
            this.Limit = limit;
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public int Limit
        {
            get
            {
                return limit;
            }
            set
            {
                limit = value;
            }
        }
        public int Excess
        {
            get
            {
                return excess;
            }
            set
            {
                excess = value;
            }
        }

        void Input()
        {
            Console.Write("Enter speed: ");
            Speed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter speed limit: ");
            Limit = Convert.ToInt32(Console.ReadLine());
        }
        void Compute()
        {
            if (Speed > Limit)
            {
                Excess = Speed - Limit;
            }
        }
        void Output()
        {
            if (Speed > Limit)
            {
                if (Excess < 30)
                    Console.WriteLine("Speed:\t\t{0} kph\nSpeed limit:\t{1} kph\nExcess speed:\t{2} kph\nFine levied:\tKshs. 2500", Speed, Limit, Excess);
                else
                    Console.WriteLine("Speed:\t\t{0} kph\nSpeed limit:\t{1} kph\nExcess speed:\t{2} kph\nFine levied:\tKshs. 4000", Speed, Limit, Excess);
            }

        }
        public static void Main(string[] args)
        {
            FineCalculatorOOP fine = new FineCalculatorOOP();
            fine.Input();
            fine.Compute();
            fine.Output();
        }
    }
}
