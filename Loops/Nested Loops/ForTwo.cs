using System;

namespace Advanced_Application_Programming
{
    public class ForTwo
    {
        public static void Main(string[] args)
        {
            int h, j = 0;
            string s = "\n\t";
            for (int i = 0; i <= 6; i++)
            {
                for (h = ++j; h <= 6; h++)
                {
                    Console.Write("{0}\t", h);
                }
                Console.Write(s);
                s += "\t";
            }
        }
    }
}
