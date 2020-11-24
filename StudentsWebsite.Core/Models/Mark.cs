namespace StudentsWebsite.Core.Models
{
    public class Mark : BaseEntity
    {
        public StudentVisitingTeacher StudentVisitingTeacher { get; set; }

        public int MarkValue { get; set; }
    }
}