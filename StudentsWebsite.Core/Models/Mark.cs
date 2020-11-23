namespace StudentsWebsite.Data.Models
{
    public class Mark
    {
        public int Id { get; set; }

        public StudentVisitingTeacher StudentVisitingTeacher { get; set; }

        public int MarkValue { get; set; }
    }
}