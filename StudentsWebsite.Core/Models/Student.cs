using System.Collections.Generic;

namespace StudentsWebsite.Core.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        /// <summary>
        /// The info about the teachers being visited by this student and also marks
        /// </summary>
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}