using System;

namespace Advanced_Application_Programming
{
    public class CostCalculatorArrays
    {
        public static void Main(string[] args)
        {
            int items, total, totalPayable = 0;
            Console.Write("How many items do you want to work with:> ");
            items = Convert.ToInt32(Console.ReadLine());
            int[] price = new int[items], quantity = new int[items], totalCost = new int[items],
                discount = new int[items], net = new int[items], code = new int[items];
            Console.WriteLine();

            for (int i = 0; i < items; i++)
            {
                Console.Write("Enter item code:> ");
                code[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter item price:> ");
                price[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter item quantity:> ");
                quantity[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                total = price[i] * quantity[i];
                if (total > 20000)
                    discount[i] = (int)(0.14 * total);
                else if (total >= 10000 && total <= 20000)
                    discount[i] = (int)(0.1 * total);
                else
                    discount[i] = 0;
                totalCost[i] = total;
                net[i] = total - discount[i];
                totalPayable += net[i];
            }

            Console.WriteLine("Item Code\tPrice\tQuantity\tTotal Cost\tDiscount\tNet ");
            for (int i = 0; i < items; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    code[i], price[i], quantity[i], totalCost[i], discount[i], net[i]);
            }
            Console.WriteLine("The total amount payable is {0}", totalPayable);
        }
    }
}
