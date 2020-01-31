using System;

namespace Domain
{
    public class Musician:ITrait<CanPlay>
    {
        public Name FirstName { get; }
        public Name LastName { get; }

        public Musician(Name firstName, Name lastName)
        {

            FirstName = firstName;
            LastName = lastName;
        }

        public void Play()
        {
            Console.WriteLine("Play");
        }

       
    }
}