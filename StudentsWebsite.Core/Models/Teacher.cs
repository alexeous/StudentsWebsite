using System.Collections.Generic;

namespace StudentsWebsite.Core.Models
{
    public class Teacher : BaseEntity
    {        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Subject { get; set; }
    }
}