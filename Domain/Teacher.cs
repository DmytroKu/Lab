using System;

namespace Domain
{
    public class Teacher
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Teacher(string firstName, string lastName)
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