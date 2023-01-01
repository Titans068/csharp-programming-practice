using System;
namespace Advanced_Application_Programming
{
    public class AreaCircumferenceOOP
    {
        //2)	Write a program that accepts the radius of a circle and computes both it’s area and circumference.
        private int radius;
        private double area, circumference;

        public AreaCircumferenceOOP(int radius)
        {
            this.Radius = radius;
        }
        public AreaCircumferenceOOP()
        {
            this.Radius = 1;
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
            get { return area; }
            set
            {
                area = value;
            }
        }
        public double Circumference
        {
            get
            {
                return circumference;
            }
            set
            {
                circumference = value;
            }
        }

        void Input()
        {
            Console.Write("Enter radius: ");
            Radius = Convert.ToInt32(Console.ReadLine());
        }
        void Compute()
        {
            area = Math.PI * Radius * Radius;
            circumference = Math.PI * Radius * 2;
        }
        void Output()
        {
            Console.WriteLine("Area = {0}\nCircumference = {1}", area, circumference);
        }

        public static void Main(string[] args)
        {
            AreaCircumferenceOOP areaCirc = new AreaCircumferenceOOP();
            areaCirc.Input();
            areaCirc.Compute();
            areaCirc.Output();
        }
    }
}