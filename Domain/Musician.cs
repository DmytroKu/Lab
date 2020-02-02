namespace Domain
{
    public class Musician : IPlayer, IPerson
    {
        public IAction PlayAction { get; }
        public Name FirstName { get; }
        public Name LastName { get; }

        public Musician(Name firstName, Name lastName)
        {
            PlayAction = new PlayMusician();
            FirstName = firstName;
            LastName = lastName;
        }

        public void Play()
        {
            PlayAction.DoAction();
        }
    }
}