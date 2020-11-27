using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Authorization
{
    public interface IAuthorizationService
    {
        Task<bool> AuthorizeAsync(string email, Role[] allowedRoles);
    }
}
