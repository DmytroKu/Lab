using System;

namespace Domain
{
    public class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long StudentID { get; set; }

        public Student(string firstName, string lastName, long studentId)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentId;
        }


        public  void Study()
        {
            Console.WriteLine("Study");
        }
    }
}