using System;

namespace Advanced_Application_Programming
{
    public class ArraysNineA
    {
        public static void Main(string[] args)
        {
            int[,] n = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int sum = 0;
            for (int i = 0; i < n.GetLength(0); ++i)
            {
                for (int j = 0; j < n.GetLength(1); ++j)
                    sum += n[i, j];
            }
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Last element: {0}", n[2, 3]);
        }
    }
}
