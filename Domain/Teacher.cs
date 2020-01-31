using System;

namespace Domain
{
    public class Teacher
    {
        public Name FirstName { get; }
        public Name LastName { get; }

        public Teacher(Name firstName, Name lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Teach()
        {
            Console.WriteLine("Teach");
        }
    }
}