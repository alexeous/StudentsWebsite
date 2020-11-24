using System.Collections.Generic;

namespace StudentsWebsite.Core.Models
{
    public class Teacher : BaseEntity
    {        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        /// <summary>
        /// The info about the students visiting this teacher and also marks
        /// </summary>
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }

        public string Subject { get; set; }
    }
}