using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsWebsite.Models
{
    public class StudentVisitingTeacher
    {
        public int Id { get; set; }

        public Student Student { get; set; }

        public Teacher Teacher { get; set; }
    }
}