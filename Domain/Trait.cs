using System;
using System.Xml.Serialization;

namespace Domain
{
    public abstract class Trait
    {
    }

    interface ITrait<T> where T : Trait
    {
    }

    class CanStudy : Trait
    {
    }

    class CanTeach : Trait
    {
    }

    class CanDrive : Trait
    {
    }

    class CanPlay : Trait
    {
    }

    static class PersonTraits
    {
        public static void Teach(this ITrait<CanTeach> trait)
        {
            Console.WriteLine("Teach");
        }

        public static void Study(this ITrait<CanStudy> trait)
        {
            Console.WriteLine("Study");
        }

        public static void Drive(this ITrait<CanDrive> trait)
        {
            Console.WriteLine("Drive");
        }

        public static void Play(this ITrait<CanPlay> trait)
        {
            Console.WriteLine("Play");
        }
    }
}