using StudentsWebsite.Business.Password;
using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Authentication.Impl
{
    public class AuthenticationService : IAuthenticationService
    {
        private IUserRepository userRepository;
        private IPasswordService passwordService;

        public AuthenticationService(IUserRepository userRepository, IPasswordService passwordService)
        {
            this.userRepository = userRepository;
            this.passwordService = passwordService;
        }

        public async Task<User> Authenticate(string email, string password)
        {
            User user = await userRepository.GetByEmailAsync(email);
            if (passwordService.VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }
    }
}
