using System;

namespace Domain
{
    public class Pupil
    {
        public string FirstName { get; }
        public string LastName { get; }

       

        public Pupil(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public void Study()
        {
            Console.WriteLine("Study");
        }
    }
}