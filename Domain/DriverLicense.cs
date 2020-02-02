using System;

namespace Domain
{
    public class DriverLicense
    {
        public string Code { get; }

        public DriverLicense(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(code));
            Code = code;
        }
    }
}