using System;

class DoMineSevenRedoneOOP
{
    private int terms;

    public DoMineSevenRedoneOOP(int terms)
    {
        Terms = terms;
    }

    public DoMineSevenRedoneOOP()
    {
        Terms = 1;
    }

    public int Terms
    {
        get { return terms; }
        set
        {
            terms = value;
        }
    }

    void Input()
    {
        Console.Write("Enter no of terms:> ");
        Terms = Convert.ToInt32(Console.ReadLine());
    }

    void Output()
    {
        int h = 1, i = 0, j = 1, k = 0;
        Console.Write("{0} ", k);
        for (; k < Terms - 1; k++)
        {
            Console.Write("{0} ", h);
            h = i + j;
            i = j;
            j = h;
        }
    }

    public static void Main(string[] args)
    {
        DoMineSevenRedoneOOP redone = new DoMineSevenRedoneOOP();
        redone.Input();
        redone.Output();
    }
}
