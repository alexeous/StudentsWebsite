using System.Collections.Generic;

namespace StudentsWebsite.Core.Models
{
    public class Teacher : User
    {
        public User User { get; set; }

        /// <summary>
        /// The students visiting this teacher and also marks
        /// </summary>
        public virtual ICollection<Student> Students { get; set; }

        public string Subject { get; set; }
    }
}