namespace Domain
{
    public class StudentTicket
    {
        public string StudentId { get; }

        public StudentTicket(string studentId)
        {
            StudentId = studentId;
        }
    }
}