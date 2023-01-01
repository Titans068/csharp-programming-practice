using System;

namespace Advanced_Application_Programming
{
    class CostCalculatorOne
    {
        private int[] code, price, quantity, totalCost, discount, net;
        private int items, totalPayable = 0;

        public int[] Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public int[] Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }

        public int[] TotalCost
        {
            get { return totalCost; }
            set
            {
                totalCost = value;
            }
        }

        public int[] Code
        {
            get { return this.code; }
        }

        public CostCalculatorOne()
        {
            this.items = 1;
            this.Price = new int[] { 1 };
            this.Quantity = new int[] { 1 };
            this.discount = new int[] { 0 };
            this.net = new int[] { 1 };
            this.code = new int[] { 1 };
        }

        public CostCalculatorOne(int items)
        {
            this.items = items;
            this.Price = new int[] { 1 };
            this.Quantity = new int[] { 1 };
            this.discount = new int[] { 0 };
            this.net = new int[] { 1 };
            this.code = new int[] { 1 };
        }

        ~CostCalculatorOne()
        {
            Console.WriteLine("The destructor was called");
        }

        public void Input()
        {
            Console.Write("How many items do you want to work with:> ");
            this.items = Convert.ToInt32(Console.ReadLine());
            this.Price = new int[items];
            this.Quantity = new int[items];
            this.TotalCost = new int[items];
            this.discount = new int[items];
            this.net = new int[items];
            this.code = new int[items];
            Console.WriteLine();
            for (int i = 0; i < items; i++)
            {
                Console.Write("Enter item code:> ");
                code[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter item price:> ");
                this.Price[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter item quantity:> ");
                this.Quantity[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }

        public void Compute()
        {
            int total;
            for (int i = 0; i < items; i++)
            {
                total = Price[i] * Quantity[i];
                if (total > 20000)
                    discount[i] = (int)(0.14 * total);
                else if (total >= 10000 && total <= 20000)
                    discount[i] = (int)(0.1 * total);
                else
                    discount[i] = 0;
                TotalCost[i] = total;
                net[i] = total - discount[i];
                totalPayable += net[i];
            }
        }

        public void Output()
        {
            Console.WriteLine("Item Code\tPrice\tQuantity\tTotal Cost\tDiscount\tNet ");
            for (int i = 0; i < items; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    Code[i], Price[i], Quantity[i], totalCost[i], discount[i], net[i]);
            }
            Console.WriteLine("The total amount payable is {0}", totalPayable);
        }
    }
    public class CostCalculatorOOP
    {
        public static void Main(string[] args)
        {
            CostCalculatorOne calculatorOne = new CostCalculatorOne();
            calculatorOne.Input();
            calculatorOne.Compute();
            calculatorOne.Output();
        }
    }
}
