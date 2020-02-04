using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Data
{
    

    public class PersonRepository : IRepository
    {
        public List<IPerson> Read()
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
                    case "Teacher":
                    {
                        var teacher = new Teacher(firstName, lastName);
                        list.Add(teacher);
                        break;
                    }
                    case "TaxiDriver":
                    {
                        var taxiDriver = new TaxiDriver(firstName, lastName,
                            new DriverLicense(personModel.driverLicenseCode));
                        list.Add(taxiDriver);
                        break;
                    }
                    case "Pupil":
                    {
                        var pupil = new Pupil(firstName, lastName);
                        list.Add(pupil);
                        break;
                    }
                    case "Musician":
                    {
                        var musician = new Musician(firstName, lastName);
                        list.Add(musician);
                        break;
                    }

                    default: throw new ArgumentException("Unknown person type");
                }
            }

            return list;
        }

        public void Write(List<IPerson> list)
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
                        data.Add($"Musician {musician.FirstName.Value}{musician.LastName.Value}");
                        break;
                    }
                    case Pupil pupil:
                    {
                        data.Add($"Pupil {pupil.FirstName.Value}{pupil.LastName.Value}");
                            break;
                    }
                    case Student student:
                    {
                        data.Add($"Student {student.FirstName.Value}{student.LastName.Value}");
                        personModel.studentId = student.StudentId.StudentId;
                        break;
                    }
                    case TaxiDriver taxiDriver:
                    {
                        data.Add($"Student {taxiDriver.FirstName.Value}{taxiDriver.LastName.Value}");
                        personModel.driverLicenseCode = taxiDriver.DriverLicense.Code;
                        break;
                    }
                    case Teacher teacher:
                    {
                        data.Add($"Teacher {teacher.FirstName.Value}{teacher.LastName.Value}");
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