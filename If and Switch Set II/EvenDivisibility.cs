using System;

namespace Advanced_Application_Programming
{
    class EvenDivisibility
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0 && num % 9 == 0)
                Console.WriteLine("{0} is evenly divisible by 9.", num);
            else Console.WriteLine("{0} is not evenly divisible by 9.", num);
        }
    }
}
