using System;

namespace Advanced_Application_Programming
{
    public class ForEightRedone
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                        Console.Write("& ");
                    else
                        Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}