using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories.Impl
{
    public class StudentTeacherRepository : IStudentTeacherRepository
    {
        private UniversityDbContext dbContext;

        public StudentTeacherRepository(UniversityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<StudentTeacher>> GetAllAsync()
        {
            return await dbContext.StudentTeachers.ToListAsync();
        }

        public Task<StudentTeacher> GetByIdsAsync(int studentId, int teacherId)
        {
            return dbContext.StudentTeachers
                .FirstOrDefaultAsync(st => st.StudentId == studentId && st.TeacherId == teacherId);
        }

        public Task InsertAsync(StudentTeacher studentTeacher)
        {
            return dbContext.InsertAsync(studentTeacher);
        }

        public Task RemoveByIdsAsync(int studentId, int teacherId)
        {
            return dbContext.RemoveAsync<StudentTeacher>(st => st.StudentId == studentId && st.TeacherId == teacherId);
        }

        public Task UpdateAsync(StudentTeacher studentTeacher)
        {
            return dbContext.UpdateAsync(studentTeacher, 
                st => st.StudentId == studentTeacher.StudentId && st.TeacherId == st.TeacherId);
        }
    }
}
