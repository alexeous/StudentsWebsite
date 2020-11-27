using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Registration.Impl
{
    public class TeacherRegistrationService : ITeacherRegistrationService
    {
        private const string SecretWord = "кодовоеслово";

        private IUserRegistrationService userRegistration;
        private ITeacherRepository teacherRepository;

        public TeacherRegistrationService(IUserRegistrationService userRegistration, ITeacherRepository teacherRepository)
        {
            this.userRegistration = userRegistration;
            this.teacherRepository = teacherRepository;
        }

        public async Task RegisterAsync(Teacher teacher, string secretWord)
        {
            if (secretWord != SecretWord)
            {
                throw new InvalidSecretWordException();
            }

            await userRegistration.RegisterAsync(teacher.User);
            await teacherRepository.InsertAsync(teacher);
        }
    }
}
