using System;

namespace Advanced_Application_Programming
{
    class SquareCubeSqrt
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square = {0}\nCube = {1}\nCube Root = {2}",
                              Math.Pow(num, 2),
                              Math.Pow(num, 3),
                              Math.Pow(num, (double)1 / 3));
        }
    }
}
