using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories.Impl
{
    class StudentTeacherRepository : IStudentTeacherRepository
    {
        private UniversityDbContext dbContext;

        public StudentTeacherRepository(UniversityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task InsertAsync(StudentTeacher studentTeacher)
        {
            dbContext.StudentTeachers.Add(studentTeacher);
            return dbContext.SaveChangesAsync();
        }
    }
}
