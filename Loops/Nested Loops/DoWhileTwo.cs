using System;

namespace Advanced_Application_Programming
{
    public class DoWhileTwo
    {
        public static void Main(string[] args)
        {
            int h = 1, i = 1, j = 1;
            string s = "\n\t";
            do
            {
                do
                {
                    Console.Write("{0}\t", h);
                    h++;
                } while (h <= 6);
                Console.Write(s);
                s += "\t";
                i++;
                h = ++j;
            } while (i <= 6);
        }
    }
}
