using System;

namespace Advanced_Application_Programming
{
    public class GetEven
    {
        private int get_even(int num)
        {
            if (num % 2 == 0)
                return 1;
            else
                return 0;
        }
        public static void Main(string[] args)
        {
            int[] inputs;
            int nums, i, evenSum = 0, oddSum = 0, oddCount = 0, evenCount = 0;
            GetEven getEven = new GetEven();

            Console.Write("How many numbers do you want?:> ");
            nums = Convert.ToInt32(Console.ReadLine());
            inputs = new int[nums];
            for (i = 0; i < nums; i++)
            {
                Console.Write("Enter number {0}:> ", i + 1);
                inputs[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (i = 0; i < nums; i++)
            {
                if (getEven.get_even(inputs[i]) == 1)
                {
                    Console.WriteLine("{0} is an even number", inputs[i]);
                    evenSum += inputs[i];
                    evenCount++;
                }
                else
                {
                    Console.WriteLine("{0} is an odd number", inputs[i]);
                    oddSum += inputs[i];
                    oddCount++;
                }
            }
            Console.WriteLine("\nThere is a total of {0} odd numbers and their sum is {1}.", oddCount, oddSum);
            Console.WriteLine("There is a total of {0} even numbers and their sum is {1}.", evenCount, evenSum);
        }
    }
}
