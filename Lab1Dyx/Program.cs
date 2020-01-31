using System;
using Domain;

namespace Lab1Dyx
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(new Name("Dima"),new Name("Kushch"),new StudentTicket("fddfs")  );
            student.Study();
        }
    }
}
