using System;

namespace Advanced_Application_Programming
{
    public class WhileTwo
    {
        public static void Main(string[] args)
        {
            int h = 1, i = 1, j = 1;
            string s = "\n\t";
            while (i <= 6)
            {
                while (h <= 6)
                {
                    Console.Write("{0}\t", h);
                    h++;
                }
                Console.Write(s);
                s += "\t";
                i++;
                h = ++j;
            }
        }
    }
}
