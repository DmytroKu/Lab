using System;

namespace Domain
{
    public class Teacher:ITrait<CanTeach>
    {
        public Name FirstName { get; }
        public Name LastName { get; }

        public Teacher(Name firstName, Name lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}