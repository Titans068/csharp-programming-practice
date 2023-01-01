using System;

namespace Advanced_Application_Programming
{
    abstract class Flora
    {
        //Encapsulation
        protected bool seeds;
        //Encapsulation
        private string name;

        //Encapsulation
        //Property
        protected bool Seeds
        {
            get { return seeds; }
            set
            {
                seeds = value;
            }
        }

        //Encapsulation
        //Property
        protected string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        //Encapsulation
        public virtual void Identify(string name)
        {
            Console.WriteLine("The plant is identified as {0} plant with the following details:", name);
            Console.WriteLine("The plant produces seeds: {0}", this.Seeds);
        }
    }

    //Inheritance
    class Seeding : Flora
    {
        //Encapsulation
        private bool flowering;
        //Encapsulation
        //Default Constructor
        public Seeding()
        {
            Seeds = true;
        }
        //Encapsulation
        //Property
        protected bool Flowering
        {
            get { return flowering; }
            set
            {
                flowering = value;
            }
        }
        //Encapsulation
        //Overriding
        public override void Identify(string name)
        {
            base.Identify(name);
            Console.WriteLine("The plant produces flowers: {0}", this.Flowering);
        }
        //Destructor
        ~Seeding()
        {
            Console.WriteLine("The destructor was called from the Seeding class.");
        }
    }
    //Inheritance
    class NonSeeding : Flora
    {
        //Encapsulation
        private bool roots;
        //Encapsulation
        //Default Constructor
        public NonSeeding()
        {
            this.Seeds = false;
        }
        //Encapsulation
        //Property
        protected bool Roots
        {
            get { return roots; }
            set
            {
                roots = value;
            }
        }
        //Overriding
        public override void Identify(string name)
        {
            base.Identify(name);
            Console.WriteLine("The plant has roots: {0}", this.Roots);
        }
        //Destructor
        ~NonSeeding()
        {
            Console.WriteLine("The destructor was called from the NonSeeding class.");
        }

    }
    //Inheritance
    class Roots : NonSeeding
    {
        //Encapsulation
        //Default Constructor
        public Roots()
        {
            this.Roots = true;
            this.Name = "Fern";
            this.Identify(this.Name);
        }

        //Encapsulation
        //Overriding
        public override void Identify(string name)
        {
            base.Identify(name);
        }
        //Destructor
        ~Roots()
        {
            Console.WriteLine("The destructor was called from the Roots class.");
        }

    }
    //Inheritance
    class NoRoots : NonSeeding
    {
        //Encapsulation
        //Default Constructor
        public NoRoots()
        {
            this.Roots = false;
            this.Name = "Algae";
            this.Identify(this.Name);
        }
        //Encapsulation
        //Overriding
        public override void Identify(string name)
        {
            base.Identify(name);
        }
        //Destructor
        ~NoRoots()
        {
            Console.WriteLine("The destructor was called from the NoRoots class.");
        }
    }
    //Inheritance
    class Flowering : Seeding
    {
        //Encapsulation
        private int cotyledons;

        //Encapsulation
        //Constructor
        public Flowering(int cotyledons)
        {
            this.Cotyledons = cotyledons;
            this.Flowering = true;
        }
        //Encapsulation
        //Overloading
        //Default Constructor
        public Flowering()
        {
            this.Cotyledons = 1;
            this.Flowering = true;
        }
        //Encapsulation
        //Property
        protected int Cotyledons
        {
            get { return cotyledons; }
            set
            {
                cotyledons = value;
            }
        }

        //Encapsulation
        //Overriding
        public override void Identify(string name)
        {
            base.Identify(name);
            Console.WriteLine("The plant seed contains {0} cotyledon(s).", this.Cotyledons);
        }
        //Destructor
        ~Flowering()
        {
            Console.WriteLine("The destructor was called from the Flowering class.");
        }
    }

    //Inheritance
    class NonFlowering : Seeding
    {
        //Encapsulation
        //Default Constructor
        public NonFlowering()
        {
            this.Name = "Conifer";
            this.Identify(this.Name);
        }
        //Encapsulation
        //Overriding
        public override void Identify(string name)
        {
            base.Identify(name);
        }
        //Destructor
        ~NonFlowering()
        {
            Console.WriteLine("The destructor was called from the NonFlowering class.");
        }
    }

    //Inheritance
    class Monocot : Flowering
    {
        //Encapsulation
        //Constructor
        public Monocot(int cotyledons) : base(cotyledons)
        {
            this.Name = "Maize";
            this.Identify(this.Name);
        }
        //Encapsulation
        //Overloading
        //Default Constructor
        public Monocot()
        {
            this.Name = "Maize";
            this.Identify(this.Name);
        }

        //Encapsulation
        //Overriding
        public override void Identify(string name)
        {
            base.Identify(name);
        }
        //Destructor
        ~Monocot()
        {
            Console.WriteLine("The destructor was called from the Monocot class.");
        }
    }
    //Inheritance
    class Dicot : Flowering
    {
        //Encapsulation
        //Constructor
        public Dicot(int cotyledons) : base(cotyledons)
        {
            this.Name = "Beans";
            this.Identify(this.Name);
        }
        //Encapsulation
        //Overloading
        //Default Constructor
        public Dicot()
        {
            this.Name = "Beans";
            this.Identify(this.Name);
        }

        //Encapsulation
        //Overriding
        public override void Identify(string name)
        {
            base.Identify(name);
        }
        //Destructor
        ~Dicot()
        {
            Console.WriteLine("The destructor was called from the Dicot class.");
        }
    }
    //Encapsulation
    public class Plants
    {
        //Encapsulation
        public static void Main(string[] args)
        {
        START:
            //Error handling - try ... catch with throw
            try
            {
                int seeds, flowers, cotyledons, roots;
                Console.WriteLine("Welcome to the plant classification system");
                Console.Write("Does your plant produce seeds?\n1. Yes\n2. No\n:> ");
                seeds = Convert.ToInt32(Console.ReadLine());
                switch (seeds)
                {
                    case 1:
                        {
                            Console.WriteLine("Does your plant produce flowers?\n1. Yes\n2. No\n:> ");
                            flowers = Convert.ToInt32(Console.ReadLine());
                            switch (flowers)
                            {
                                case 1:
                                    {
                                        Console.Write("How many cotyledons are contained in your seeds?:> ");
                                        cotyledons = Convert.ToInt32(Console.ReadLine());
                                        switch (cotyledons)
                                        {
                                            case 1:
                                                Monocot monocot = new Monocot(cotyledons);
                                                break;
                                            case 2:
                                                Dicot dicot = new Dicot(cotyledons);
                                                break;
                                            default:
                                                Console.WriteLine("Only 1 or 2 cotyledons are allowed as input not {0}", cotyledons);
                                                throw new FormatException();
                                        }

                                        break;
                                    }

                                case 2:
                                    {
                                        NonFlowering non = new NonFlowering();
                                        break;
                                    }

                                default:
                                    throw new FormatException();
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Does your plant contain roots?\n1. Yes\n2. No\n:> ");
                            roots = Convert.ToInt32(Console.ReadLine());
                            switch (roots)
                            {
                                case 1:
                                    {
                                        Roots root = new Roots();
                                        break;
                                    }

                                case 2:
                                    {
                                        NoRoots noRoots = new NoRoots();
                                        break;
                                    }

                                default:
                                    throw new FormatException();
                            }
                            break;
                        }

                    default:
                        throw new FormatException();
                }
                GC.Collect();
            }
            catch (FormatException)
            {
                Console.WriteLine("Your input is invalid.\n");
                goto START;
            }
        }
    }
}
