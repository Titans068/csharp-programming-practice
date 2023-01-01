using System;

namespace Advanced_Application_Programming
{
    class DoWhileSquareCube
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number\tSquare\tCube");
            int i = 2;
            do
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
                i++;
            } while (i <= 10);
        }
    }
}
