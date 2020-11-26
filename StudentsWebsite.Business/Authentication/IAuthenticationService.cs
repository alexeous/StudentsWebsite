using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Authentication
{
    public interface IAuthenticationService
    {
        Task<User> Authenticate(string email, string password);
    }
}
