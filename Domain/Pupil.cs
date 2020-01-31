using System;

namespace Domain
{
    public class Pupil:ITrait<CanStudy>
    {
        public Name FirstName { get; }
        public Name LastName { get; }


        public Pupil(Name firstName, Name lastName)
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