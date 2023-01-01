using System;

namespace Advanced_Application_Programming
{
    public class Person
    {
        protected string firstName, lastName;

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Speak();
        }

        public virtual string ClassName => this.GetType().Name;

        protected virtual string BaseClassName => this.GetType().Name;

        public virtual string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public virtual string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        protected virtual void Speak()
        {
            Console.Write("I am {0} {1} and I am a {2}", this.FirstName, this.LastName, this.ClassName);
        }
    }

    public class NewPerson : Person
    {
        public NewPerson(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        protected override string BaseClassName
        {
            get
            {
                return base.GetType().BaseType?.Name;
            }
        }

        protected override void Speak()
        {
            Console.WriteLine("\n");
            base.Speak();
            Console.WriteLine(". My base class is {0}.", this.BaseClassName);
        }
    }

    public class PersonProgram
    {
        public static void Main(string[] args)
        {
            new Person("John", "Doe");
            new NewPerson("Jane", "Doe");
        }
    }
}
