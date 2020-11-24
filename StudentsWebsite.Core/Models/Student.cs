using System.Collections.Generic;

namespace StudentsWebsite.Core.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}