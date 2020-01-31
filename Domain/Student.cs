﻿using System;

namespace Domain
{
    public class Student 
    {
        public string FirstName { get; }
        public string LastName { get; }

        public long StudentID { get; }

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