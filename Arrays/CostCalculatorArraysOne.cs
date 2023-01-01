using System;

namespace Advanced_Application_Programming
{
    public class CostCalculatorArraysOne
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of items:> ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[,] items = new int[len, 4];

            for (int i = 0; i < items.GetLength(0); i++)
            {
                Console.Write("\nEnter item code:> ");
                items[i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter item price:> ");
                items[i, 1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter item quantity:> ");
                items[i, 2] = Convert.ToInt32(Console.ReadLine());
                items[i, 3] = items[i, 1] * items[i, 2];
            }
            Console.WriteLine("\nItem Code\tPrice\tQuantity\tTotal Cost");
            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    if (j == 0 | j == 2)
                        Console.Write("{0}\t\t", items[i, j]);
                    else
                        Console.Write("{0}\t", items[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
