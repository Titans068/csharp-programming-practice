using System;

namespace Advanced_Application_Programming
{
    //7)	Write a program that computes the area & perimeter of either a rectangle, a circle or a right-angled triangle.
    //The program should display a menu that enables the user to select the type of figure whose area & perimeter he/she wants to compute.
    //Depending on the users choice, the program should prompt for the dimensions and perform the computations.
    //The output should be: - The type of figure, the dimensions, the area and the perimeter.
    //(NB:The calculation should be for only one figure at any one time.)
    class Rectangle
    {
        private int width, length;

        public Rectangle()
        {
            this.Width = 1;
            this.Length = 1;
        }

        public Rectangle(int width, int length)
        {
            this.Width = width;
            this.Length = length;
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
            }
        }
        public int Length
        {
            get { return length; }
            set
            {
                length = value;
            }
        }
        public int Area
        {
            get
            {
                return Length * Width;
            }
        }
        public int Perimeter
        {
            get
            {
                return 2 * (Length + Width);
            }
        }
    }
    class Circle
    {
        private int radius;

        public Circle()
        {
            this.Radius = 1;
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
            }
        }
        public double Area
        {
            get
            {
                return 22.0 / 7 * radius * radius;
            }
        }
        public double Perimeter
        {
            get
            {
                return 22.0 / 7 * Radius * 2;
            }
        }
    }
    class RightAngledTriangle
    {
        private int base_, height;

        public RightAngledTriangle()
        {
            this.Base = 1;
            this.Height = 1;
        }

        public RightAngledTriangle(int @base, int height)
        {
            this.Base = @base;
            this.Height = height;
        }

        public int Base
        {
            get { return base_; }
            set
            {
                base_ = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        public double Hypotenuse
        {
            get
            {
                return Math.Sqrt((Base * Base) + (Height * Height));
            }
        }
        public double Perimeter
        {
            get
            {
                return Base + Height + Hypotenuse;
            }
        }
        public double Area
        {
            get
            {
                return .5 * Base * height;
            }
        }

    }
    class AreaPerimeterOOP
    {
        private int choice;
        Rectangle rect = new Rectangle();
        Circle circle = new Circle();
        RightAngledTriangle triangle = new RightAngledTriangle();

        void Input()
        {
            Console.Write("Pick a shape:\n\t1) Rectangle\n\t2) Circle\n\t" +
                            "3) Right angled triangle\nEnter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter length:> ");
                    rect.Length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter width:> ");
                    rect.Width = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Enter radius:> ");
                    circle.Radius = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Enter base:> ");
                    triangle.Base = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter height:> ");
                    triangle.Height = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid input(s) provided.");
                    Input();
                    break;
            }
        }
        void Output()
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("For a Rectangle with length of {0} and width of {1}, its area is {2} and perimeter is {3}.",
                                      rect.Length, rect.Width, rect.Area, rect.Perimeter);
                    break;
                case 2:
                    Console.WriteLine("For a Circle with radius of {0}, its area is {1} and perimeter is {2}.",
                                      circle.Radius, circle.Area, circle.Perimeter);
                    break;
                case 3:
                    Console.WriteLine("For a Right angled triangle with base of {0}, height of {1} and a "
                                      + "hypotenuse of {2}, its area is {3} and perimeter is {4}.",
                                      triangle.Base, triangle.Height, triangle.Hypotenuse, triangle.Area, triangle.Perimeter);
                    break;
            }
        }
        public static void Main(string[] args)
        {
            AreaPerimeterOOP a = new AreaPerimeterOOP();
            a.Input();
            a.Output();
        }
    }
}
