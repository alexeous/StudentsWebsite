using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Registration
{
    public interface IUserRegistrationService
    {
        Task Register(User user);
    }
}
