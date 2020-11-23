using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsWebsite.Models
{
    public class Mark
    {
        public int Id { get; set; }

        public StudentVisitingTeacher StudentVisitingTeacher { get; set; }

        public int MarkValue { get; set; }
    }
}