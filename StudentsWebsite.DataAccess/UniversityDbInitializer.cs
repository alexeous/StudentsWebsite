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
                new Student { User = new User { FirstName = "Freddy", LastName = "Howard", Email = "fd@gmail.com" } },
                new Student { User = new User { FirstName = "Mark", LastName = "Jackson", Email = "mj@gmail.com" } },
                new Student { User = new User { FirstName = "Lucy", LastName = "Persson", Email = "lp@gmail.com" } },
                new Student { User = new User { FirstName = "Anna", LastName = "Golubeva", Email = "ag@gmail.com" } },
                new Student { User = new User { FirstName = "Bill", LastName = "Gates", Email = "bg@gmail.com" } }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
