using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Editing.Impl
{
    public class StudentEditingService : IStudentEditingService
    {
        private IStudentRepository studentRepository;
        private ITeacherRepository teacherRepository;

        public StudentEditingService(IStudentRepository studentRepository, ITeacherRepository teacherRepository)
        {
            this.studentRepository = studentRepository;
            this.teacherRepository = teacherRepository;
        }

        public async Task Edit(int studentId, string firstName, string lastName, ICollection<int> teacherIds)
        {
            Student student = await studentRepository.GetByIdAsync(studentId);
            if (student == null)
            {
                throw new NotFoundException();
            }

            student.User.FirstName = firstName;
            student.User.LastName = lastName;

            IEnumerable<Teacher> allTeachers = await teacherRepository.GetAllAsync();
            student.Teachers = allTeachers.Where(teacher => teacherIds.Contains(teacher.Id)).ToList();
            
            await studentRepository.UpdateAsync(student);
        }
    }
}
