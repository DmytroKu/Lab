using System;

namespace Domain
{
    public interface IAction
    {
        void DoAction();
    }

    public interface ITeacher
    {
        void Teach();
    }

    public interface IDriver
    {
        void Drive();
    }

    public interface IPlayer
    {
        void Play();
    }

    public interface ILearner
    {
        void Study();
    }

    class StudyInUniversity : IAction
    {
       
        public void DoAction()
        {
            Console.WriteLine("Study in university");
        }
    }

    class SelfStudy : IAction
    {
        public void DoAction()
        {
            Console.WriteLine("Study for yourself");
        }
    }

}