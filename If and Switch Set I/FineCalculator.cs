using System;

namespace Advanced_Application_Programming
{
    //8)	Write a program that can be used by a policeman to determine if a vehicle has exceeded
    // the speed limit and to levy a fine. The policeman should enter the vehicles speed and the speed limit.
    // If the speed limit is exceeded by less than 30kph a fine of Kshs. 2500 should be charged.
    // Otherwise a fine of Kshs 4000 is charged. Your program should then output (in a suitable format)
    // the vehicle speed, the speed limit, the excess speed and the fine levied.
    class FineCalculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter speed limit: ");
            int limit = Convert.ToInt32(Console.ReadLine()), excess;
            if (speed > limit)
            {
                excess = speed - limit;
                if (excess < 30)
                    Console.WriteLine("Speed:\t\t{0} kph\nSpeed limit:\t{1} kph\nExcess speed:\t{2} kph\nFine levied:\tKshs. 2500", speed, limit, excess);
                else 
                    Console.WriteLine("Speed:\t\t{0} kph\nSpeed limit:\t{1} kph\nExcess speed:\t{2} kph\nFine levied:\tKshs. 4000", speed, limit, excess);
            }
        }
    }
}
