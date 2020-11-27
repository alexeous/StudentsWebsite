using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Registration.Impl
{
    public class StudentRegistrationService : IStudentRegistrationService
    {
        private IUserRegistrationService userRegistration;
        private IStudentRepository studentRepository;

        public StudentRegistrationService(IUserRegistrationService userRegistration, IStudentRepository studentRepository)
        {
            this.userRegistration = userRegistration;
            this.studentRepository = studentRepository;
        }

        public async Task RegisterAsync(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            await userRegistration.RegisterAsync(student.User);
            await studentRepository.InsertAsync(student);
        }
    }
}
