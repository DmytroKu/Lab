namespace Domain
{
    public class Pupil
    {
        public IAction StudyAction { get; }
        public Name FirstName { get; }
        public Name LastName { get; }

        public Pupil(Name firstName, Name lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            StudyAction = new SelfStudy();
        }

        public void Study()
        {
            StudyAction.DoAction();
        }
    }
}