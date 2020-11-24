namespace StudentsWebsite.Core.Models
{
    public class Mark : BaseEntity
    {
        public StudentTeacher StudentTeacher { get; set; }

        public int MarkValue { get; set; }
    }
}