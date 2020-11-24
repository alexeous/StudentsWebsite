using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories
{
    public interface IStudentTeacherRepository
    {
        Task<IEnumerable<StudentTeacher>> GetAllAsync();

        Task<StudentTeacher> GetByIdsAsync(int studentId, int teacherId);

        Task InsertAsync(StudentTeacher studentTeacher);

        Task UpdateAsync(StudentTeacher studentTeacher);

        Task RemoveByIdsAsync(int studentId, int teacherId);
    }
}
