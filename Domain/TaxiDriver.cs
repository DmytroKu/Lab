using System;

namespace Domain
{
    public class TaxiDriver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DriverLicense { get; set; }

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

