﻿using System;

namespace Domain
{
    public class Student 
    {
        public Name FirstName { get; }
        public Name LastName { get; }

        public long StudentID { get; }

        public Student(Name firstName, Name lastName, long studentId)
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