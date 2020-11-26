using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Password.Impl
{
    public class NoHashingPasswordService : IPasswordService
    {
        public string HashPassword(string rawPassword)
        {
            return rawPassword;
        }

        public bool VerifyPassword(string raw, string hashed)
        {
            return String.Equals(raw, hashed, StringComparison.Ordinal);
        }
    }
}
