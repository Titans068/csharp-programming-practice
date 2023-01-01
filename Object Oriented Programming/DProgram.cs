using System;

namespace Advanced_Application_Programming
{
    public class B
    {
        //protected void b1() { }
        //protected void b2() { }
        public void b1() { }
        public void b2() { }
    }

    public class D : B
    {
        public void d1() { }
        public void d2() { }
    }

    public class DProgram
    {
        public static void Main(string[] args)
        {
            D d = new();
            d.b1();
            d.b2();
        }
    }
}
