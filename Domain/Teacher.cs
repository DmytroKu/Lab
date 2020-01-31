using System;

namespace Domain
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

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