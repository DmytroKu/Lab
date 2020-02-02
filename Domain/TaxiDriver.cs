namespace Domain
{
    public class TaxiDriver : IDriver, IPerson
    {
        public IAction DriveAction { get; }
        public Name FirstName { get; }
        public Name LastName { get; }
        public DriverLicense DriverLicense { get; }

        public TaxiDriver(Name firstName, Name lastName, DriverLicense driverLicense)
        {
            FirstName = firstName;
            LastName = lastName;
            DriverLicense = driverLicense;
            DriveAction = new Drive();
        }

        public void Drive()
        {
            DriveAction.DoAction();
        }
    }
}