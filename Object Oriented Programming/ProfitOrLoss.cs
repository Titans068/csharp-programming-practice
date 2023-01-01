using System;
namespace Advanced_Application_Programming
{
    class Commodity
    {
        /*
         * Making use of object oriented concepts, write a complete C# program that accepts the buying price, transport cost and selling price of a commodity and
         * then calculates the profit or loss (the programs output should be specific on this) earned by selling the commodity. Your program must make use of a
         * class called Commodity with the following members: –                [12 marks]
         * Fields: -
         * buying_price, transport_cost, selling_price, profit
         * Methods: -
         * ◦ get_data( ) – For data input.
         * ◦ give_output( ) – For data output
         * ◦ calculate( ) – To perform calculations.
         * In addition, your class should have the following: –
         * • A copy constructor that initializes the fields.
         * • Set profit to read only.
         */
        private int buying_price, transport, selling_price, profit;
        public Commodity(int buying_price, int transport, int selling_price)
        {
            this.Buying_Price = buying_price;
            this.Transport = transport;
            this.Selling_Price = selling_price;
        }
        public Commodity()
        {
            this.Buying_Price = 1;
            this.Transport = 1;
            this.Selling_Price = 2;
        }
        public int Buying_Price
        {
            get
            {
                return this.buying_price;
            }
            set
            {
                this.buying_price = value;
            }
        }
        public int Transport
        {
            get
            {
                return this.transport;
            }
            set
            {
                this.transport = value;
            }
        }
        public int Selling_Price
        {
            get
            {
                return this.selling_price;
            }
            set
            {
                this.selling_price = value;
            }
        }
        public int Profit
        {
            get
            {
                return this.profit;
            }
        }

        public void get_data()
        {
            Console.Write("Enter buying price:> ");
            this.Buying_Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter transport:> ");
            this.Transport = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter selling price:> ");
            this.Selling_Price = Convert.ToInt32(Console.ReadLine());
        }
        public void give_output()
        {
            if (this.Profit > 0)
                Console.WriteLine("The profit is {0:#,#.00}", this.Profit);
            else if (this.Profit < 0)
                Console.WriteLine("The loss is {0:#,#.00}", this.Profit * -1);
            else if (this.Profit == 0)
                Console.WriteLine("You have broken even");
        }
        public void calculate()
        {
            this.profit = this.Selling_Price - (this.Buying_Price + this.Transport);
        }
    }
    public class ProfitOrLoss
    {
        public static void Main(string[] args)
        {
            Commodity commodity = new Commodity();
            commodity.get_data();
            commodity.calculate();
            commodity.give_output();
        }
    }
}