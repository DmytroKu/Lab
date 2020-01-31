using System;

namespace Domain
{
    public class StudentTicket
    {
        public string StudentId { get; }

        public StudentTicket(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(studentId));
            StudentId = studentId;
        }
    }
}