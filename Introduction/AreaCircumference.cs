using System;
namespace Advanced_Application_Programming
{
    public class AreaCircumference
    {
        //2)	Write a program that accepts the radius of a circle and computes both it’s area and circumference.
        public static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area = {0}\nCircumference = {1}",
                              Math.PI * rad * rad,
                              Math.PI * rad * 2);
        }
    }
}