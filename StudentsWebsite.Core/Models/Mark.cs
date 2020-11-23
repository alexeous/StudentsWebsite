using StudentsWebsite.Core.Models;

namespace StudentsWebsite.Data.Models
{
    public class Mark : BaseEntity
    {
        public StudentVisitingTeacher StudentVisitingTeacher { get; set; }

        public int MarkValue { get; set; }
    }
}