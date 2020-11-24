using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess
{
    class UniversityDbInitializer : DropCreateDatabaseIfModelChanges<UniversityDbContext>
    {
        protected override void Seed(UniversityDbContext context)
        {
            Student[] students =
            {
                new Student { FirstName = "Freddy", LastName = "Howard" },
                new Student { FirstName = "Mark", LastName = "Jackson" },
                new Student { FirstName = "Lucy", LastName = "Persson" },
                new Student { FirstName = "Anna", LastName = "Golubeva" },
                new Student { FirstName = "Bill", LastName = "Gates" }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
