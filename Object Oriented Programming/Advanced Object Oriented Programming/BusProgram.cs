using System;
using System.Linq;

namespace Advanced_Application_Programming
{
    public class Buses
    {
        public int RegNo { get; set; }
        public int FuelCapacity { get; set; }
        public int AxleWeight { get; set; }
        public Buses[] Express = new Buses[67];

        public Buses(int regNo, int fuelCapacity, int axleWeight)
        {
            this.RegNo = regNo;
            this.FuelCapacity = fuelCapacity;
            this.AxleWeight = axleWeight;
        }

        public Buses()
        {
        }

        public void Input()
        {
            Buses bus;
            for (int i = 0; i < this.Express.Length; i++)
            {
                bus = new();
                Console.Write("\nEnter registration number:> ");
                bus.RegNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter fuel capacity:> ");
                bus.FuelCapacity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter axle weight:> ");
                bus.AxleWeight = Convert.ToInt32(Console.ReadLine());
                this.Express[i] = bus;
            }
        }

        public void Output()
        {
            foreach (Buses bus in this.Express)
                Console.WriteLine("Registration number: {0}\nFuel Capacity: {1:#,#}\nAxle Weight: {2:#,#}\n", bus.RegNo, bus.FuelCapacity, bus.AxleWeight);
        }
    }
    public class BusProgram
    {
        public static void Main(string[] args)
        {
            Random random = new();
            Buses bus = new();
            bus.Express = bus.Express.Select((Buses b) => new Buses(random.Next(1_000), random.Next(10_000), random.Next(20_000))).ToArray();
            
            //OR
            /* for(int i = 0; i < bus.Express.Length; i++)
                bus.Express[i] = new Buses(random.Next(1_000), random.Next(10_000), random.Next(20_000)); */

            bus.Output();
        }
    }
}
