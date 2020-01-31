using System;
using System.Diagnostics;
using static System.String;

namespace Domain
{
    public class Name
    {
        public string Value { get; }

        public Name(string value)
        {
            if (IsNullOrEmpty(value)) throw new ArgumentException("Value cannot be null or empty.", nameof(value));

            Value = value;
        }
    }
}