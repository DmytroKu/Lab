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
            Value = value;
        }
    }
}