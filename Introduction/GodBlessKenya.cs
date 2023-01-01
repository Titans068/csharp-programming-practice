using System;

namespace Advanced_Application_Programming
{
    class GodBlessKenya
    {
        public static void Main(string[] args)
        {
            int i = 0;
            string s = "God Bless Kenya";
            do
            {
                Console.WriteLine(s);
                i++;
            } while (i < 25);

            i = 0;
            Console.WriteLine();
            while (i < 25)
            {
                Console.WriteLine(s);
                i++;
            }

            Console.WriteLine();
            for (i = 0; i < 25; i++) Console.WriteLine(s);
        }
    }
}
