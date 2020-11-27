using StudentsWebsite.Business.Password;
using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Registration.Impl
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private IUserRepository userRepository;
        private IPasswordService passwordService;

        public UserRegistrationService(IUserRepository userRepository, IPasswordService passwordService)
        {
            this.userRepository = userRepository;
            this.passwordService = passwordService;
        }

        public async Task RegisterAsync(User user)
        {
            if (await userRepository.GetByEmailAsync(user.Email) != null)
            {
                throw new UserExistsException();
            }
            user.Password = passwordService.HashPassword(user.Password);
            await userRepository.InsertAsync(user);
        }
    }
}
