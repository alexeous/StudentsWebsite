namespace StudentsWebsite.Data.Models
{
    public class StudentVisitingTeacher
    {
        public int Id { get; set; }

        public Student Student { get; set; }

        public Teacher Teacher { get; set; }
    }
}