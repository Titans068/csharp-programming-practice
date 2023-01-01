using System;

namespace Advanced_Application_Programming
{
    class Product
    {
        private int total_cost;
        private double discount, net_cost;

        public Product(int total_cost)
        {
            this.total_cost = total_cost;
        }
        public Product()
        {
            this.total_cost = 0;
        }

        public void dataIn()
        {
            Console.Write("Enter total cost:> ");
            this.total_cost = Convert.ToInt32(Console.ReadLine());
        }

        public void compute()
        {
            if (this.total_cost > 12000)
            {
                this.discount = .1;
            }
            else if (this.total_cost > 5000 && this.total_cost <= 12000)
            {
                this.discount = .05;
            }
            else if (total_cost <= 5000)
            {
                this.discount = 0;
            }
            this.net_cost = (1 - this.discount) * this.total_cost;
        }

        public void dataOut()
        {
            Console.WriteLine("With a total cost of {0:#,#.00} and a discount of {1}%, the net cost is {2:#,#.00}", this.total_cost, this.discount * 100, this.net_cost);
        }
    }

    public class ProductCalculator
    {

        public static void Main(string[] args)
        {
            Product product = new Product();
            product.dataIn();
            product.compute();
            product.dataOut();
        }
    }

}