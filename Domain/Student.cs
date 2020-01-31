using System;

namespace Domain
{
    public class Student :ILearner
    {
        public IAction Action { get; set; }
        public Name FirstName { get; }
        public Name LastName { get; }

        public StudentTicket StudentID { get; }

        public Student(Name firstName, Name lastName, StudentTicket studentId)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentId;
            Action=new StudyInUniversity();
        }


        public  void Study()
        {
            Action.DoAction();
        }
    }
}