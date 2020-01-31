using System;

namespace Domain
{
    public class TaxiDriver
    {
        public Name FirstName { get; }
        public Name LastName { get; }
        public DriverLicense DriverLicense { get; }

        public TaxiDriver(Name firstName, Name lastName, DriverLicense driverLicense)
        {
            FirstName = firstName;
            LastName = lastName;
            DriverLicense = driverLicense;
        }

        public void Drive()
        {
            Console.WriteLine("Drive");
        }
    }
}

