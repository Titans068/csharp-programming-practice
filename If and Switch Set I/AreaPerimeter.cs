using System;

namespace Advanced_Application_Programming
{
    //7)	Write a program that computes the area & perimeter of either a rectangle, a circle or a right-angled triangle.
    //The program should display a menu that enables the user to select the type of figure whose area & perimeter he/she wants to compute.
    //Depending on the users choice, the program should prompt for the dimensions and perform the computations.
    //The output should be: - The type of figure, the dimensions, the area and the perimeter.
    //(NB:The calculation should be for only one figure at any one time.)
    class AreaPerimeter
    {
        public static void Main(string[] args)
        {
        PROMPT:
            Console.Write("Pick a shape:\n\t1) Rectangle\n\t2) Circle\n\t" +
                "3) Right angled triangle\nEnter your choice: ");
            int dim1, dim2;
            double dim3;
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter length and width: ");
                    dim1 = Convert.ToInt32(Console.ReadLine());
                    dim2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("For a Rectangle with length of {0} and width of {1} its area is {2} and perimeter is {3}.",
                                      dim1, dim2, dim1 * dim2, 2 * (dim1 + dim2));
                    break;
                case 2:
                    Console.Write("Enter radius: ");
                    dim1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("For a Circle with radius of {0} its area is {1} and perimeter is {2}.",
                                      dim1, Math.PI * dim1 * dim1, Math.PI * dim1 * 2);
                    break;
                case 3:
                    Console.Write("Enter length and height: ");
                    dim1 = Convert.ToInt32(Console.ReadLine());
                    dim2 = Convert.ToInt32(Console.ReadLine());
                    dim3 = Math.Sqrt((dim1 * dim1) + (dim2 * dim2));
                    Console.WriteLine("For a Right angled triangle with length of {0}, height of {1} and a "
                                      + "hypotenuse of {2} its area is {3} and perimeter is {4}.",
                                      dim1, dim2, dim3, .5 * dim1 * dim2, dim1 + dim2 + dim3);
                    break;
                default:
                    Console.WriteLine("Invalid input(s) provided.");
                    goto PROMPT;
            }
        }
    }
}
