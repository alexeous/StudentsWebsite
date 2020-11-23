using StudentsWebsite.Core.Models;

namespace StudentsWebsite.Data.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}