using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Authorization.Impl
{
    public class AuthorizationService : IAuthorizationService
    {
        private IUserRepository userRepository;
        private IStudentRepository studentRepository;
        private ITeacherRepository teacherRepository;

        public AuthorizationService(IUserRepository userRepository, IStudentRepository studentRepository, ITeacherRepository teacherRepository)
        {
            this.userRepository = userRepository;
            this.studentRepository = studentRepository;
            this.teacherRepository = teacherRepository;
        }

        public async Task<bool> AuthorizeAsync(string email, Role[] allowedRoles)
        {
            Role role = await GetRoleAsync(email);
            return allowedRoles.Contains(role);
        }

        private async Task<Role> GetRoleAsync(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                return Role.Anonymous;
            }

            User user = await userRepository.GetByEmailAsync(email);
            if (user == null)
            {
                return Role.Anonymous;
            }
            if (await studentRepository.GetByUserIdAsync(user.Id) != null)
            {
                return Role.Student;
            }
            if (await teacherRepository.GetByUserIdAsync(user.Id) != null)
            {
                return Role.Teacher;
            }

            throw new InvalidOperationException(
                $"Could not determine the role of the user with email '{email}'." +
                $"He is in the User repo but neither in Student nor Teacher."
                );
        }
    }
}
