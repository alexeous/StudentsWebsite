namespace StudentsWebsite.Core.Models
{
    public class Mark : BaseEntity
    {
        public Student Student { get; set; }

        public Teacher Teacher { get; set; }

        public int MarkValue { get; set; }
    }
}