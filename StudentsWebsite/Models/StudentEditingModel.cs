using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsWebsite.Models
{
    public class StudentEditingModel
    {
        public struct TeacherInfo
        {
            public int Id { get; set; }

            public string FirstName { get; set; }
            
            public string LastName { get; set; }

            public string Subject { get; set; }
        }

        public int StudentId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        public ICollection<TeacherInfo> AllTeachers { get; set; }

        public ICollection<int> VisitedTeacherIds { get; set; }
    }
}