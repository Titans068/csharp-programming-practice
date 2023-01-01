using System;
using System.Linq;

namespace Advanced_Application_Programming
{
    public class UsedCar
    {
        public int Registration { get; set; }
        public string Make { get; set; }
        public int Distance { get; set; }
        public decimal Buying { get; set; }
        public decimal Selling { get; set; }
        public string Previous { get; set; }

        public UsedCar(int registration, string make, int distance, decimal buying, decimal selling, string previous)
        {
            this.Registration = registration;
            this.Make = make;
            this.Distance = distance;
            this.Buying = buying;
            this.Selling = selling;
            this.Previous = previous;
        }

        public void Input()
        {
            Console.Write("Enter registration number:> ");
            this.Registration = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter make:>");
            this.Make = Console.ReadLine();
            Console.Write("Enter distance travelled in km:>");
            this.Distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter buying price:>");
            this.Buying = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter selling price:>");
            this.Selling = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter name of previous owner:>");
            this.Previous = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("Registration number: {0}\nMake: {1}\nDistance travelled in km: {2:#,#}\nBuying Price (in Kshs): {3:#,#.00}\nSelling Price (in Kshs): {4:#,#.00}\nName of the previous owner: {5}\n\n", this.Registration, this.Make, this.Distance, this.Buying, this.Selling, this.Previous);
        }
    }
    public class UsedCarProgram
    {
        public static void Main(string[] args)
        {
            Random random = new();
            string[] make = { "Abarth", "Acura", "Aston Martin", "BMW", "Buick", "Chevrolet", "Citroen", "Dacia", "Dodge", "Fiat", "Ford", "GMC", "Honda", "Hyundai", "Infiniti", "Isuzu", "Jeep", "Kia", "Lexus", "Lincoln", "Mazda", "Mercedes-Benz", "Mercury", "Mini", "Mitsubishi", "Nissan", "Opel", "Peugeot", "Pontiac", "Ram", "Renault", "Saab", "Saturn", "Scion", "Seat", "Skoda", "Smart", "SsangYong", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo", "Wiesmann" };
            string[] names = { "Liam", "Noah", "Oliver", "Elijah", "James", "William", "Benjamin", "Lucas", "Henry", "Theodore", "Jack", "Levi", "Alexander", "Jackson", "Mateo", "Daniel", "Michael", "Mason", "Sebastian", "Ethan", "Logan", "Owen", "Samuel", "Jacob", "Asher", "Aiden", "John", "Joseph", "Wyatt", "David" };

            UsedCar[] usedCars = new UsedCar[30].Select((UsedCar u) => new UsedCar(random.Next(2_000), make[random.Next(make.Length)], random.Next(100_000), random.Next(300_000, 3_000_000), random.Next(300_000, 3_000_000), names[random.Next(names.Length)])).ToArray();

            Array.ForEach(usedCars.Where((UsedCar u) => u.Selling > 4E5M && u.Selling < 1E6M).ToArray(), (UsedCar u) => u.Output());

            //OR
            /* foreach(UsedCar u in usedCars)
            {
                if (u.Selling > 4E5M && u.Selling < 1E6M)
                    u.Output();
            } */
        }
    }
}
