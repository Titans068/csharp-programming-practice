using System;

namespace Advanced_Application_Programming
{
    class CheckVoter
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("You can vote.");
            else Console.WriteLine("You are too young to vote.");
        }
    }
}
