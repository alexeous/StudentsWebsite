using System.Collections.Generic;

namespace StudentsWebsite.Core.Models
{
    public class Student : BaseEntity
    {
        public User User { get; set; }

        /// <summary>
        /// The teachers being visited by this student
        /// </summary>
        public ICollection<Teacher> Teachers { get; set; }

        public ICollection<Mark> Marks { get; set; }
    }
}