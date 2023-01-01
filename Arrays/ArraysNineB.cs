using System;
using System.Linq;

namespace Advanced_Application_Programming
{
    public class ArraysNineB
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5] { 20, 20, 20, 20, 20 };
            Console.WriteLine(string.Join(", ", numbers));

            int[] values = Enumerable.Range(1, 30).ToArray();
            for (int i = 0; i < values.Length; ++i)
                values[i] += 5;
            Console.WriteLine(string.Join(", ", values));

            int[] marks = Enumerable.Range(1, 20).ToArray();
            for (int i = 0; i < marks.Length; ++i)
            {
                if (i % 5 == 0)
                    Console.WriteLine();
                Console.Write("{0}, ", marks[i]);
            }

            Random random = new(42);
            float[] scores = Enumerable.Range(1, 20).Select(x => random.NextSingle() * 100).ToArray();
            Console.WriteLine("\n\n{0}", string.Join(", ", scores));
        }
    }
}
