using System;

namespace Advanced_Application_Programming
{
    public class SumList
    {
        public static void Main(string[] args)
        {
            int sum = 0, j;
            string input;
            Console.WriteLine("Enter a list of numbers");
            input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            for (int i = 0; i < inputs.Length; i++)
            {
                j = Convert.ToInt32(inputs[i].Trim());
                if (j == 0)
                    break;
                else sum += j;
            }
            Console.WriteLine("The sum of the list is {0}", sum);
        }
    }
}