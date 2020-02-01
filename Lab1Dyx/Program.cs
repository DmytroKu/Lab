using Domain;

namespace Lab1Dyx
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(new Name("Dima"), new Name("Kushch"), new StudentTicket("KB13413252"));
            student.Study();
            student.Play();
        }
    }
}