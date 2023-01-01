using System;

namespace Advanced_Application_Programming
{
    class SortHelper
    {
        private int size;
        int[] nums;

        public int Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }

        public void Input()
        {
            Console.Write("How many numbers do you want?:> ");
            Size = Convert.ToInt32(Console.ReadLine());
            nums = new int[Size];
            Console.WriteLine();
            for (int i = 0; i < Size; i++)
            {
                Console.Write("Enter number {0}:> ", i + 1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Sort()
        {
            int temp;
            for (int i = 0; i < Size; i++)
            {
                for (int j = i + 1; j < Size; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }

        public void Output()
        {
            foreach (int i in nums)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
    }
    public class SortArrays
    {
        public static void Main(string[] args)
        {
            SortHelper helper = new SortHelper();
            helper.Input();
            Console.WriteLine("Before sorting the array:");
            helper.Output();
            helper.Sort();
            Console.WriteLine("After sorting the array:");
            helper.Output();
        }
    }
}
