namespace StudentsWebsite.Core.Models
{
    public class StudentVisitingTeacher : BaseEntity
    {
        public Student Student { get; set; }

        public Teacher Teacher { get; set; }
    }
}