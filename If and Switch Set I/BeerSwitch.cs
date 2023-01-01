using System;

namespace Advanced_Application_Programming
{
    class BeerSwitch
    {
        public static void Main(string[] args)
        {
        PROMPT:
            Console.Write("\n* * * * Jamal and Daughters Pub * * * *\n"
                          + "Beer Brand\t\tPrice\n1) Tusker\t\t100/=\n"
                          + "2) Pilsner\t\t120/=\n3) Smirnoff Ice\t\t140/=\n"
                          + "4) White Cap\t\t90/=\nEnter your choice: ");
            int bottles;
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Write("How many bottles of Tusker do you want? ");
                    bottles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} bottles of Tusker will cost you Kshs. {1}", bottles, 100 * bottles);
                    break;
                case 2:
                    Console.Write("How many bottles of Pilsner do you want? ");
                    bottles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} bottles of Pilsner will cost you Kshs. {1}", bottles, 120 * bottles);
                    break;
                case 3:
                    Console.Write("How many bottles of Smirnoff Ice do you want? ");
                    bottles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} bottles of Smirnoff Ice will cost you Kshs. {1}", bottles, 140 * bottles);
                    break;
                case 4:
                    Console.Write("How many bottles of White Cap do you want? ");
                    bottles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} bottles of White Cap will cost you Kshs. {1}", bottles, 90 * bottles);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    goto PROMPT;
            }
        }
    }
}
