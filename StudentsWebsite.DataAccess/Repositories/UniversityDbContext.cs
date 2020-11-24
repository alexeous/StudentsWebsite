using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories
{
    class UniversityDbContext : DbContext
    {
        private const string ConnectionStringName = "DbConnection";

        public UniversityDbContext() 
            : base(ConnectionStringName)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<StudentTeacher> StudentTeachers { get; set; }

        public DbSet<Mark> Marks { get; set; }
    }
}
