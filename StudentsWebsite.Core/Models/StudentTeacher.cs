using System.Collections.Generic;

namespace StudentsWebsite.Core.Models
{
    /// <summary>
    /// This class creates a many-to-many relationship with additional info
    /// between <see cref="Models.Student"/>s and <see cref="Models.Teacher"/>s.
    /// <para/>
    /// See also about many-to-many relationship with additional fields:
    /// <list type="bullet">
    /// <item><seealso cref="https://stackoverflow.com/questions/7050404/create-code-first-many-to-many-with-additional-fields-in-association-table/7053393#7053393"/></item>
    /// <item><seealso cref="https://social.msdn.microsoft.com/Forums/en-US/11df4738-437d-4c38-b3ab-8598887a0f67/how-to-map-many-to-many-relationship-with-additional-fields-?forum=adodotnetentityframework"/></item>
    /// </list>
    /// </summary>
    public class StudentTeacher
    {
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}