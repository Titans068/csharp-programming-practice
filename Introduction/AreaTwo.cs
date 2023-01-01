using System;
//4)	Write a program that computes the area of a right-angled triangle.
namespace Advanced_Application_Programming
{
    class AreaTwo
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter base ");
            int base_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area = {0}", (base_ * width) / 2);
        }
    }
}
