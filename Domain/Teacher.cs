namespace Domain
{
    public class Teacher : ITeacher
    {
        public IAction TeachAction { get; }
        public Name FirstName { get; }
        public Name LastName { get; }

        public Teacher(Name firstName, Name lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            TeachAction = new Teach();
        }

        public void Teach()
        {
            TeachAction.DoAction();
        }
    }
}