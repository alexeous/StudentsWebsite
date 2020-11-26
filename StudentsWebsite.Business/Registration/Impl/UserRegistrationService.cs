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

        public UserRegistrationService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task Register(User user)
        {
            if (userRepository.GetByEmailAsync(user.Email) != null)
            {
                throw new UserExistsException();
            }
            return userRepository.InsertAsync(user);
        }
    }
}
