using System;
namespace Advanced_Application_Programming
{
    //3)	Write a program that accepts the width and length of a rectangle and computes both it’s area and perimeter.
    public class Area
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter length ");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area = {0}\nPerimeter = {1}", len * width, 2 * (len + width));
        }
    }
}