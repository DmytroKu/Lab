using System;

namespace Domain
{
    public class TaxiDriver
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int DriverLicense { get; }

        public TaxiDriver(string firstName, string lastName, int driverLicense)
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

