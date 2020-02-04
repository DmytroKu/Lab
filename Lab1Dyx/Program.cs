using System;
using System.Collections.Generic;
using Data;
using Domain;

namespace Lab1Dyx
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(new Name("Dima"), new Name("Kushch"), new StudentTicket("KB13413252"));
            var rep = new PersonRepository();
            List<IPerson> list = new List<IPerson>();
            list.Add(student);
            rep.Write(list);
            list = rep.Read();
            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}