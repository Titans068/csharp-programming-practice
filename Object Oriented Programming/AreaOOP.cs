using System;
namespace Advanced_Application_Programming
{
    //3)	Write a program that accepts the width and length of a rectangle and computes both it’s area and perimeter.
    public class AreaRedone
    {
        private int length, width;
        public AreaRedone(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }
        public AreaRedone()
        {
            this.Length = 1;
            this.Width = 1;
        }
        public int Length
        {
            get { return length; }
            set
            {
                length = value;
            }
        }
        public int Width
        {
            get { return width; }
            set
            {
                width = value;
            }
        }
    }
    public class AreaOOP
    {
        private int area, perimeter;
        private AreaRedone redone = new AreaRedone();
        void Input()
        {
            Console.Write("Enter length:> ");
            redone.Length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width:> ");
            redone.Width = Convert.ToInt32(Console.ReadLine());
        }
        void Compute()
        {
            area = redone.Length * redone.Width;
            perimeter = 2 * (redone.Length + redone.Width);
        }
        void Output()
        {
            Console.WriteLine("Area = {0}\nPerimeter = {1}", area, perimeter);
        }
        public static void Main(string[] args)
        {
            AreaOOP area = new AreaOOP();
            area.Input();
            area.Compute();
            area.Output();
        }
    }
}