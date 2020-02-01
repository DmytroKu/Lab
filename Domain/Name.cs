using System;

namespace Domain
{
    public class Name
    {
        public string Value { get; }

        public Name(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(value));
            Value = value;
        }
    }
}