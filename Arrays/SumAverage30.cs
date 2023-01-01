using System;

namespace Advanced_Application_Programming
{
    public class SumAverage30
    {
        public static void Main(string[] args)
        {
            double[] arr = new double[30];
            double sum = 0, average;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter number {0}", i + 1);
                arr[i] = Convert.ToDouble(Console.ReadLine());
                sum += arr[i];
            }
            average = sum / arr.Length;
            Console.WriteLine("The sum is {0} and the average is {1}", sum, average);
        }
    }
}
