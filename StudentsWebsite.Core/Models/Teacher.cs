using StudentsWebsite.Core.Models;

namespace StudentsWebsite.Data.Models
{
    public class Teacher : BaseEntity
    {        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Subject { get; set; }
    }
}