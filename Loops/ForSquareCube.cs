using System;

namespace Advanced_Application_Programming
{
    class ForSquareCube
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number\tSquare\tCube");

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
            }
        }
    }
}
