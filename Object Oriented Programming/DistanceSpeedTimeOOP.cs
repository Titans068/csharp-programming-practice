using System;

namespace Advanced_Application_Programming
{
    class DistanceSpeedRedone
    {
        private double distance, time, speed;

        public DistanceSpeedRedone()
        {
            this.Distance = 1;
            this.Time = 1;
        }

        public DistanceSpeedRedone(double distance, double time)
        {
            this.Distance = distance;
            this.Time = time;
        }

        public double Distance
        {
            get { return distance; }
            set
            {
                distance = value;
            }
        }
        public double Time
        {
            get { return time; }
            set
            {
                time = value;
            }
        }
        public double Speed
        {
            get { return speed; }
            set
            {
                speed = value;
            }
        }
    }
    class DistanceSpeedTimeOOP
    {
        DistanceSpeedRedone redone = new DistanceSpeedRedone();
        void Input()
        {
            Console.Write("Enter distance in meters: ");
            redone.Distance = Convert.ToDouble(Console.ReadLine()) / 1000;
            Console.Write("Enter time taken in minutes: ");
            redone.Time = Convert.ToDouble(Console.ReadLine()) / 60;
        }
        void Compute()
        {
            redone.Speed = redone.Distance / redone.Time;
        }
        void Output()
        {
            Console.WriteLine("Speed is {0}", redone.Speed);
        }
        public static void Main(string[] args)
        {
            DistanceSpeedTimeOOP d = new DistanceSpeedTimeOOP();
            d.Input();
            d.Compute();
            d.Output();
        }
    }
}
