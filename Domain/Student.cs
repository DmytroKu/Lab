namespace Domain
{
    public class Student : ILearner, IPlayer
    {
        public IAction StudyAction { get; }
        public IAction PlayAction { get; }
        public Name FirstName { get; }
        public Name LastName { get; }

        public StudentTicket StudentId { get; }

        public Student(Name firstName, Name lastName, StudentTicket studentId)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentId = studentId;
            StudyAction = new StudyInUniversity();
            PlayAction = new PlayStudent();
        }


        public void Study()
        {
            StudyAction.DoAction();
        }

        public void Play()
        {
            PlayAction.DoAction();
        }
    }
}