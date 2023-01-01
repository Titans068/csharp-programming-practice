using System;
//4)	Write a program that computes the area of a right-angled triangle.
namespace Advanced_Application_Programming
{
    class AreaTwoRedone
    {
        private int base_, width;

        public AreaTwoRedone()
        {
            this.Base_ = 1;
            this.Width = 1;
        }

        public AreaTwoRedone(int base_, int width)
        {
            Base_ = base_;
            Width = width;
        }

        public int Base_
        {
            get { return base_; }
            set
            {
                base_ = value;
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
    class AreaTwoOOP
    {
        private int area;
        private AreaTwoRedone redone = new AreaTwoRedone();
        void Input()
        {
            Console.Write("Enter base ");
            redone.Base_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width ");
            redone.Width = Convert.ToInt32(Console.ReadLine());
        }
        void Compute()
        {
            area = (redone.Base_ * redone.Width) / 2;
        }
        void Output()
        {
            Console.WriteLine("Area = {0}", area);
        }
        public static void Main(string[] args)
        {
            AreaTwoOOP areaTwo = new AreaTwoOOP();
            areaTwo.Input();
            areaTwo.Compute();
            areaTwo.Output();
        }
    }
}
