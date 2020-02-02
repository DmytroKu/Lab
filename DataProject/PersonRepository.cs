using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Domain;
using Newtonsoft.Json;

namespace Data
{
    public class PersonRepository
    {
        List<IPerson> Read()
        {
            var data = new string[0];
            try
            {
                data = File.ReadAllLines("data.txt");
            }
            catch (FileNotFoundException e)
            {
                return new List<IPerson>();
            }

            var list = new List<IPerson>(data.Length / 2);
            for (int i = 0; i < data.Length - 1; i++)
            {
                var description = data[i];
                var json = data[i + 1];
                var type = new string(description.TakeWhile(x => x != ' ').ToArray());

                var personModel = JsonConvert.DeserializeObject<PersonModel>(json);
                var firstName = new Name(personModel.firstName);
                var lastName = new Name(personModel.lastName);
                switch (type)
                {
                    case "Student":
                    {
                        var student = new Student(firstName, lastName, new StudentTicket(personModel.studentId));
                        list.Add(student);
                        break;
                    }
                    default: throw new ArgumentException("Unknown person type");
                }
            }

            return list;
        }

        void Write(List<IPerson> list)
        {
            var data = new List<string>(list.Count * 2);
            foreach (var person in list)
            {
                var personModel = new PersonModel()
                {
                    firstName = person.FirstName.Value,
                    lastName = person.LastName.Value,
                };

                switch (person)
                {
                    case Musician musician:
                    {
                        break;
                    }
                    case Pupil pupil:
                    {
                        break;
                    }
                    case Student student:
                    {
                        data.Add($"Student {student.FirstName}{student.LastName}");
                        personModel.studentId = student.StudentId.StudentId;
                        break;
                    }
                    case TaxiDriver taxiDriver:
                    {
                        break;
                    }
                    case Teacher teacher:
                    {
                        break;
                    }
                    default: throw new ArgumentException("Unknown person type");
                }

                data.Add(JsonConvert.SerializeObject(personModel));
            }

            File.WriteAllLines("data.txt", data);
        }
    }
}