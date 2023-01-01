using System;

namespace Advanced_Application_Programming
{
    class TaxCalculatorOOP
    {
        /*
         * Over 40,000			30%
         * >= 30,000 but below 40,000	25%
         * >=20,000 but below 30,000	15%
         * >=10,000 but below 20,000	10%
         * Below 10,000			no tax.
         */
        private int gross;
        private double tax, net;

        public TaxCalculatorOOP()
        {
            this.Gross = 1;
        }

        public TaxCalculatorOOP(int gross)
        {
            this.Gross = gross;
        }

        public int Gross
        {
            get
            {
                return gross;
            }
            set
            {
                gross = value;
            }
        }
        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }
        public double Net
        {
            get
            {
                return net;
            }
            set
            {
                net = value;
            }
        }

        void Input()
        {
            Console.Write("Enter gross pay: ");
            Gross = Convert.ToInt32(Console.ReadLine());
        }
        void Compute()
        {
            if (Gross >= 40000)
                Tax = .3 * Gross;
            else if (Gross < 40000 && Gross >= 30000)
                Tax = .25 * Gross;
            else if (Gross < 30000 && Gross >= 20000)
                Tax = .15 * Gross;
            else if (Gross < 20000 && Gross >= 10000)
                Tax = .15 * Gross;
            else if (Gross < 10000)
                Tax = 0 * Gross;
            else
            {
                Console.WriteLine("Invalid number\n");
                Input();
                Compute();
            }
            Net = Gross - Tax;
        }
        void Output()
        {
            Console.WriteLine("Tax amount is {0:0,0.00}\nNet pay is {1:0,0.00}", Tax, Net);
        }
        public static void Main(string[] args)
        {
            TaxCalculatorOOP tax = new TaxCalculatorOOP();
            tax.Input();
            tax.Compute();
            tax.Output();
        }
    }
}
