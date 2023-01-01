using System;

namespace Advanced_Application_Programming
{
    public class MultiplicationTable1D
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 1, 2, 3, 4, 5, 6 },
                b = { 1, 1, 2, 3, 4 };

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i == 0 & j == 0)
                        Console.Write("*\t");
                    else
                        Console.Write("{0}\t", a[j] * b[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
